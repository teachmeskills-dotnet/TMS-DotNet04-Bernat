
namespace GazeControl
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.brightPlus = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.UseML = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rangeMinus = new System.Windows.Forms.Button();
            this.rangePlus = new System.Windows.Forms.Button();
            this.StartEmgu = new System.Windows.Forms.Button();
            this.brightMinus = new System.Windows.Forms.Button();
            this.UseMarker = new System.Windows.Forms.Button();
            this.ShowContours = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.setSensevity = new System.Windows.Forms.TrackBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setSensevity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(94, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bright: 80";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // brightPlus
            // 
            this.brightPlus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.brightPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brightPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brightPlus.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.brightPlus.Location = new System.Drawing.Point(250, 453);
            this.brightPlus.Name = "brightPlus";
            this.brightPlus.Size = new System.Drawing.Size(50, 50);
            this.brightPlus.TabIndex = 9;
            this.brightPlus.Text = "+";
            this.brightPlus.UseVisualStyleBackColor = false;
            this.brightPlus.Visible = false;
            this.brightPlus.Click += new System.EventHandler(this.brightPlus_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(682, 531);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(10, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Visible = false;
            // 
            // UseML
            // 
            this.UseML.BackColor = System.Drawing.SystemColors.ControlDark;
            this.UseML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UseML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UseML.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UseML.Font = new System.Drawing.Font("Yu Gothic UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.UseML.Image = ((System.Drawing.Image)(resources.GetObject("UseML.Image")));
            this.UseML.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.UseML.Location = new System.Drawing.Point(348, 490);
            this.UseML.Name = "UseML";
            this.UseML.Size = new System.Drawing.Size(90, 80);
            this.UseML.TabIndex = 12;
            this.UseML.Text = "ML.Net";
            this.UseML.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UseML.UseVisualStyleBackColor = false;
            this.UseML.Click += new System.EventHandler(this.UseML_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(348, 398);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 80);
            this.button4.TabIndex = 13;
            this.button4.Text = "Emgu";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.UseEmgu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(81, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "Range: 1px";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // rangeMinus
            // 
            this.rangeMinus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rangeMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rangeMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rangeMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rangeMinus.Font = new System.Drawing.Font("Yu Gothic UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rangeMinus.Location = new System.Drawing.Point(25, 451);
            this.rangeMinus.Name = "rangeMinus";
            this.rangeMinus.Size = new System.Drawing.Size(50, 50);
            this.rangeMinus.TabIndex = 15;
            this.rangeMinus.Text = "-";
            this.rangeMinus.UseVisualStyleBackColor = false;
            this.rangeMinus.Visible = false;
            this.rangeMinus.Click += new System.EventHandler(this.rangeMinus_Click);
            // 
            // rangePlus
            // 
            this.rangePlus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rangePlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rangePlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rangePlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rangePlus.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangePlus.Location = new System.Drawing.Point(250, 453);
            this.rangePlus.Name = "rangePlus";
            this.rangePlus.Size = new System.Drawing.Size(50, 50);
            this.rangePlus.TabIndex = 14;
            this.rangePlus.Text = "+";
            this.rangePlus.UseVisualStyleBackColor = false;
            this.rangePlus.Visible = false;
            this.rangePlus.Click += new System.EventHandler(this.rangePlus_Click);
            // 
            // StartEmgu
            // 
            this.StartEmgu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.StartEmgu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StartEmgu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartEmgu.FlatAppearance.BorderSize = 0;
            this.StartEmgu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartEmgu.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartEmgu.Location = new System.Drawing.Point(69, 525);
            this.StartEmgu.Name = "StartEmgu";
            this.StartEmgu.Size = new System.Drawing.Size(195, 60);
            this.StartEmgu.TabIndex = 17;
            this.StartEmgu.Text = "start";
            this.StartEmgu.UseVisualStyleBackColor = false;
            this.StartEmgu.Visible = false;
            this.StartEmgu.Click += new System.EventHandler(this.StartEmgu_Click);
            // 
            // brightMinus
            // 
            this.brightMinus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.brightMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brightMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brightMinus.Font = new System.Drawing.Font("Yu Gothic UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.brightMinus.Location = new System.Drawing.Point(25, 451);
            this.brightMinus.Name = "brightMinus";
            this.brightMinus.Size = new System.Drawing.Size(50, 50);
            this.brightMinus.TabIndex = 18;
            this.brightMinus.Text = "-";
            this.brightMinus.UseVisualStyleBackColor = false;
            this.brightMinus.Visible = false;
            this.brightMinus.Click += new System.EventHandler(this.brightMinus_Click);
            // 
            // UseMarker
            // 
            this.UseMarker.BackColor = System.Drawing.SystemColors.ControlDark;
            this.UseMarker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UseMarker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UseMarker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UseMarker.Font = new System.Drawing.Font("Yu Gothic UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UseMarker.Image = ((System.Drawing.Image)(resources.GetObject("UseMarker.Image")));
            this.UseMarker.Location = new System.Drawing.Point(459, 490);
            this.UseMarker.Name = "UseMarker";
            this.UseMarker.Size = new System.Drawing.Size(90, 80);
            this.UseMarker.TabIndex = 20;
            this.UseMarker.Text = "Marker";
            this.UseMarker.UseVisualStyleBackColor = false;
            this.UseMarker.Click += new System.EventHandler(this.UseMarker_Click);
            // 
            // ShowContours
            // 
            this.ShowContours.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ShowContours.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ShowContours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowContours.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ShowContours.FlatAppearance.BorderSize = 15;
            this.ShowContours.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowContours.Font = new System.Drawing.Font("Yu Gothic UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowContours.Image = ((System.Drawing.Image)(resources.GetObject("ShowContours.Image")));
            this.ShowContours.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ShowContours.Location = new System.Drawing.Point(459, 398);
            this.ShowContours.Name = "ShowContours";
            this.ShowContours.Size = new System.Drawing.Size(90, 80);
            this.ShowContours.TabIndex = 19;
            this.ShowContours.Text = "Contours";
            this.ShowContours.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ShowContours.UseVisualStyleBackColor = false;
            this.ShowContours.Click += new System.EventHandler(this.ShowContours_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // setSensevity
            // 
            this.setSensevity.Location = new System.Drawing.Point(41, 382);
            this.setSensevity.Minimum = 1;
            this.setSensevity.Name = "setSensevity";
            this.setSensevity.Size = new System.Drawing.Size(247, 45);
            this.setSensevity.TabIndex = 21;
            this.setSensevity.Value = 1;
            this.setSensevity.Visible = false;
            this.setSensevity.Scroll += new System.EventHandler(this.setSensitivity_Scroll);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(360, 181);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 190);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(561, 596);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.setSensevity);
            this.Controls.Add(this.UseMarker);
            this.Controls.Add(this.ShowContours);
            this.Controls.Add(this.brightMinus);
            this.Controls.Add(this.StartEmgu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rangeMinus);
            this.Controls.Add(this.rangePlus);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.UseML);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brightPlus);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setSensevity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button brightPlus;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UseML;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rangeMinus;
        private System.Windows.Forms.Button rangePlus;
        private System.Windows.Forms.Button StartEmgu;
        private System.Windows.Forms.Button brightMinus;
        private System.Windows.Forms.Button ShowContours;
        private System.Windows.Forms.Button UseMarker;
        private System.Windows.Forms.TrackBar setSensevity;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

