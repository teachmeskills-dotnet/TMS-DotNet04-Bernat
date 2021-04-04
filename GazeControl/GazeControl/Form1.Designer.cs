
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
            this.label1 = new System.Windows.Forms.Label();
            this.brightPlus = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UseML = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rangeMinus = new System.Windows.Forms.Button();
            this.rangePlus = new System.Windows.Forms.Button();
            this.StartEmgu = new System.Windows.Forms.Button();
            this.brightMinus = new System.Windows.Forms.Button();
            this.ShowContours = new System.Windows.Forms.Button();
            this.UseMarker = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "bright: 80";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brightPlus
            // 
            this.brightPlus.Location = new System.Drawing.Point(12, 178);
            this.brightPlus.Name = "brightPlus";
            this.brightPlus.Size = new System.Drawing.Size(75, 23);
            this.brightPlus.TabIndex = 9;
            this.brightPlus.Text = "+";
            this.brightPlus.UseVisualStyleBackColor = true;
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
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(109, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // UseML
            // 
            this.UseML.Location = new System.Drawing.Point(12, 39);
            this.UseML.Name = "UseML";
            this.UseML.Size = new System.Drawing.Size(75, 23);
            this.UseML.TabIndex = 12;
            this.UseML.Text = "Use ML.Net";
            this.UseML.UseVisualStyleBackColor = true;
            this.UseML.Click += new System.EventHandler(this.UseML_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(586, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Use Emgu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.UseEmgu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(592, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "range: 1px";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rangeMinus
            // 
            this.rangeMinus.Location = new System.Drawing.Point(586, 220);
            this.rangeMinus.Name = "rangeMinus";
            this.rangeMinus.Size = new System.Drawing.Size(75, 23);
            this.rangeMinus.TabIndex = 15;
            this.rangeMinus.Text = "-";
            this.rangeMinus.UseVisualStyleBackColor = true;
            this.rangeMinus.Click += new System.EventHandler(this.rangeMinus_Click);
            // 
            // rangePlus
            // 
            this.rangePlus.Location = new System.Drawing.Point(586, 178);
            this.rangePlus.Name = "rangePlus";
            this.rangePlus.Size = new System.Drawing.Size(75, 23);
            this.rangePlus.TabIndex = 14;
            this.rangePlus.Text = "+";
            this.rangePlus.UseVisualStyleBackColor = true;
            this.rangePlus.Click += new System.EventHandler(this.rangePlus_Click);
            // 
            // StartEmgu
            // 
            this.StartEmgu.Location = new System.Drawing.Point(579, 118);
            this.StartEmgu.Name = "StartEmgu";
            this.StartEmgu.Size = new System.Drawing.Size(91, 39);
            this.StartEmgu.TabIndex = 17;
            this.StartEmgu.Text = "START/STOP";
            this.StartEmgu.UseVisualStyleBackColor = true;
            this.StartEmgu.Click += new System.EventHandler(this.StartEmgu_Click);
            // 
            // brightMinus
            // 
            this.brightMinus.Location = new System.Drawing.Point(12, 220);
            this.brightMinus.Name = "brightMinus";
            this.brightMinus.Size = new System.Drawing.Size(75, 23);
            this.brightMinus.TabIndex = 18;
            this.brightMinus.Text = "-";
            this.brightMinus.UseVisualStyleBackColor = true;
            this.brightMinus.Click += new System.EventHandler(this.brightMinus_Click);
            // 
            // ShowContours
            // 
            this.ShowContours.Location = new System.Drawing.Point(575, 345);
            this.ShowContours.Name = "ShowContours";
            this.ShowContours.Size = new System.Drawing.Size(91, 39);
            this.ShowContours.TabIndex = 19;
            this.ShowContours.Text = "Show Contours";
            this.ShowContours.UseVisualStyleBackColor = true;
            this.ShowContours.Click += new System.EventHandler(this.ShowContours_Click);
            // 
            // UseMarker
            // 
            this.UseMarker.Location = new System.Drawing.Point(12, 345);
            this.UseMarker.Name = "UseMarker";
            this.UseMarker.Size = new System.Drawing.Size(91, 39);
            this.UseMarker.TabIndex = 20;
            this.UseMarker.Text = "Use Marker";
            this.UseMarker.UseVisualStyleBackColor = true;
            this.UseMarker.Click += new System.EventHandler(this.UseMarker_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 433);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

