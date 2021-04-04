using System;
using System.Drawing;

namespace GazeControl
{
    public static class ImageProccesing
    {
        public static Image SaveRebiuldImage(Bitmap bmp, int brightnessValue)
        {
            var bmpByte = ImageToByteByBrightness(bmp, brightnessValue);
            var postImg = ByteToBlackWhiteImage(bmpByte);
            postImg.Save("ProcessImg.jpg");
            return postImg;
        }
        public static Image CircleAnObject (Bitmap bmp, Rectangle rectangle, Color color, int widht)
        {
            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                using (Pen pen = new Pen(color, widht))
                {
                    graphics.DrawEllipse(pen, rectangle);
                }
            }
            return bmp;
        }
        public static Bitmap CutImage(Bitmap src, Rectangle rect)
        {
            Bitmap bmp = new Bitmap(rect.Width, rect.Height);
            Graphics.FromImage(bmp).DrawImage(src, 0, 0, rect, GraphicsUnit.Pixel);
            return bmp;
        }
        public static int[,] ImageToByteByBrightness(Bitmap bmp, int brightnessValue)
        {
            int[,] mass = new int[bmp.Width, bmp.Height];
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    var oldColor = bmp.GetPixel(x, y);
                    var red = oldColor.R + brightnessValue;
                    var green = oldColor.G + brightnessValue;
                    var blue = oldColor.B + brightnessValue;
                    if (red > 255) red = 255;
                    if (red < 0) red = 0;
                    if (green > 255) green = 255;
                    if (green < 0) green = 0;
                    if (blue > 255) blue = 255;
                    if (blue < 0) blue = 0;
                    var newColor = Color.FromArgb(oldColor.A, red, green, blue);
                    bmp.SetPixel(x, y, newColor);
                    var bright = bmp.GetPixel(x, y).R * 0.2126 + bmp.GetPixel(x, y).G * 0.7152 + bmp.GetPixel(x, y).B * 0.0722;
                    mass[x, y] = bright < 160 ? 1 : 0;
                }
            }
            return mass;
        }
        public static Bitmap SetBrightness(Bitmap bmp, int b)
        {
            var lockedBitmap = new Bitmap(bmp);

            var contrast = Math.Pow((100.0 + b) / 100.0, 2);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    var oldColor = bmp.GetPixel(x, y);
                    var red = oldColor.R + b;
                    var green = oldColor.G + b;
                    var blue = oldColor.B + b;
                    if (red > 255) red = 255;
                    if (red < 0) red = 0;
                    if (green > 255) green = 255;
                    if (green < 0) green = 0;
                    if (blue > 255) blue = 255;
                    if (blue < 0) blue = 0;
                    var newColor = Color.FromArgb(oldColor.A, (int)red, (int)green, (int)blue);
                    lockedBitmap.SetPixel(x, y, newColor);
                }
            }
            return lockedBitmap;
        }
        public static Bitmap ByteToBlackWhiteImage(int[,] bmpByte)
        {
            var bmp = new Bitmap(bmpByte.GetLength(0), bmpByte.GetLength(1));
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    bmp.SetPixel(x, y, bmpByte[x, y] == 1 ? Color.Black : Color.White);
                }
            }
            return bmp;
        }
    }
}
