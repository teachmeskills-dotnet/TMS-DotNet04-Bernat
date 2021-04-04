using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace GazeControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            InitializeComponent();
        }
        ModelInput sampleData = new ModelInput();
        int brightnessValue = 80;
        int sensitivity = 1;
        int range = 1;
        int startPointX;
        int endPointX;
        int endPointY;
        bool _lock;
        bool useMlNet;
        bool useEmgu;
        bool getContours;
        bool useMarkers;
        Rectangle[] foundObject;
        private static CascadeClassifier classifierEye = new CascadeClassifier("cascadeEye.xml");
        private static CascadeClassifier classifierPulp = new CascadeClassifier("lastPulp.xml");
        private static CascadeClassifier classifierMarker = new CascadeClassifier("stickWhite.xml");
        FilterInfoCollection filter;
        VideoCaptureDevice device;
        private void Form1_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in filter)
                comboBox1.Items.Add(item.Name);
            comboBox1.SelectedIndex = 0;
            device = new VideoCaptureDevice(filter[comboBox1.SelectedIndex].MonikerString);
            device.NewFrame += Device_NewFrame;
            device.Start();
        }

        private void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            var frameBitmap = (Bitmap)eventArgs.Frame.Clone();
            GC.Collect();
            if (useEmgu == true)
            {
                foundObject = FindObject(frameBitmap, classifierEye, 10);
                if (foundObject.Length != 0)
                {
                    var cutImage = ImageProccesing.CutImage(frameBitmap, foundObject.First());
                    foundObject = FindObject(cutImage, classifierPulp, 5);

                    if (foundObject.Length != 0)
                    {
                        var centerX2 = foundObject.First().X + foundObject.First().Width / 2;
                        var centerY2 = foundObject.First().Y + foundObject.First().Height / 2;
                        ImageProccesing.CircleAnObject(cutImage, foundObject.First());
                        CursorControlByEmgu(centerX2, centerY2, cutImage, sensitivity, range);
                    }
                }
            }
            else if (useMlNet == true)
            {
                foundObject = FindObject(frameBitmap, classifierEye, 8);
                foreach (var rectangle in foundObject)
                {
                    pictureBox1.Image = ImageProccesing.SaveRebiuldImage(ImageProccesing.CutImage(frameBitmap, rectangle), brightnessValue);
                    var predictionResult = GetPredictionResult(sampleData);
                    CursorControlByPrediction(predictionResult, sensitivity);
                }
            }
            else if (getContours == true)
            {
                Image<Gray, byte> grayImage = new Image<Gray, byte>(frameBitmap);
                Image<Gray, byte> output = grayImage.ThresholdBinary(new Gray(50), new Gray(255));
                VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
                Mat hierarchy = new Mat();
                CvInvoke.FindContours(output, contours, hierarchy, Emgu.CV.CvEnum.RetrType.Tree, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
                Image<Gray, byte> finalResult = new Image<Gray, byte>(grayImage.Width, grayImage.Height, new Gray(0));
                CvInvoke.DrawContours(finalResult, contours, -1, new MCvScalar(255, 0, 0));
                pictureBox1.Image = finalResult.Bitmap;
            }
            if (useMarkers == true)
            {
                foundObject = FindObject(frameBitmap, classifierMarker, 5);
                if (foundObject.Length != 0)
                {
                    using (Graphics graphics = Graphics.FromImage(frameBitmap))
                    {
                        if (foundObject.First().Width < 80)
                        {
                            using (Pen pen = new Pen(Color.Red, 5))
                            {
                                graphics.DrawEllipse(pen, foundObject.First());
                            }
                        }
                        else if (foundObject.First().Width > 80 && foundObject.First().Width < 160)
                        {
                            using (Pen pen = new Pen(Color.Black, 5))
                            {
                                graphics.DrawEllipse(pen, foundObject.First());
                            }
                        }
                        else if (foundObject.First().Width > 160)
                        {
                            using (Pen pen = new Pen(Color.Blue, 5))
                            {
                                graphics.DrawEllipse(pen, foundObject.First());
                            }
                        }
                    }
                }
                pictureBox1.Image = frameBitmap;
            }
        }

        public Rectangle[] FindObject(Bitmap frame, CascadeClassifier cascade, int Neighbors)
        {
            Image<Gray, byte> grayImage = new Image<Gray, byte>(frame);
            Rectangle[] rectangles = cascade.DetectMultiScale(grayImage, 1.1, Neighbors);
            return rectangles;
        }

        public void CursorControlByPrediction(string predictionResult, int sensitivity)
        {
            switch (predictionResult)
            {
                case "down":
                    Cursor.Position = new Point(Cursor.Position.X - 0, Cursor.Position.Y - sensitivity);
                    break;
                case "up":
                    Cursor.Position = new Point(Cursor.Position.X - 0, Cursor.Position.Y - sensitivity * -1);
                    break;
                case "left":
                    Cursor.Position = new Point(Cursor.Position.X - sensitivity, Cursor.Position.Y - 0);
                    break;
                case "right":
                    Cursor.Position = new Point(Cursor.Position.X - sensitivity * -1, Cursor.Position.Y - 0);
                    break;
            }
        }

        public void CursorControlByEmgu(int X, int Y, Bitmap image, int sensitivity, int range)
        {
            if (_lock == false) //start point
            {
                startPointX = X - range;
                endPointX = X + range;
                endPointY = Y;
            }
            if (endPointX < image.Width)
            {
                image.SetPixel(startPointX, endPointY, Color.Azure);
                image.SetPixel(endPointX, endPointY, Color.Azure);
            }
            if (X < startPointX) //right
            {
                Cursor.Position = new Point(Cursor.Position.X - sensitivity * -1, Cursor.Position.Y - 0);
            }
            else if (X > endPointX) //left
            {
                Cursor.Position = new Point(Cursor.Position.X - sensitivity, Cursor.Position.Y - 0);
            }
            pictureBox1.Image = image;
        }

        public string GetPredictionResult(ModelInput sampleData)
        {
            sampleData.ImageSource = "ProcessImg.jpg";
            var predictionResult = ConsumeModel.Predict(sampleData);
            return predictionResult.Prediction;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            device.Stop();
            Application.Exit();
        }

        private void brightPlus_Click(object sender, EventArgs e)
        {
            if (brightnessValue < 255)
            {
                brightnessValue += 5;
                label1.Text = $"bright: {brightnessValue}";
            }
        }

        private void brightMinus_Click(object sender, EventArgs e)
        {
            if (brightnessValue > 0)
            {
                brightnessValue -= 5;
                label1.Text = $"bright: {brightnessValue}";
            }
        }

        private void UseML_Click(object sender, EventArgs e)
        {
            if (useMlNet == false)
            {
                getContours = false;
                useEmgu = false;
                useMlNet = true;
            }
            else
            {
                useMlNet = false;
            }
        }

        private void UseEmgu_Click(object sender, EventArgs e)
        {
            if (useEmgu == false)
            {
                useMlNet = false;
                getContours = false;
                useEmgu = true;
            }
            else
            {
                useEmgu = false;
            }
        }

        private void rangePlus_Click(object sender, EventArgs e)
        {
            if (range < 50 && range >= 0)
            {
                if (range <= 50)
                {
                    range += 1;
                    label2.Text = $"range: {range} px";
                }
            }
        }

        private void rangeMinus_Click(object sender, EventArgs e)
        {
            if (range > 0)
            {
                if (range != 0)
                {
                    range -= 1;
                    label2.Text = $"range: {range} px";
                }
            }
        }

        private void StartEmgu_Click(object sender, EventArgs e)
        {
            if (_lock == false)
            {
                _lock = true;
            }
            else
            {
                _lock = false;
            }
        }

        private void ShowContours_Click(object sender, EventArgs e)
        {
            if (getContours == false)
            {
                useMlNet = false;
                useEmgu = false;
                getContours = true;
            }
            else
            {
                getContours = false;
            }
        }

        private void UseMarker_Click(object sender, EventArgs e)
        {
            if (useMarkers == false)
            {
                useMlNet = false;
                useEmgu = false;
                getContours = false;
                useMarkers = true;
            }
            else
            {
                useMarkers = false;
            }
        }
    }
}
