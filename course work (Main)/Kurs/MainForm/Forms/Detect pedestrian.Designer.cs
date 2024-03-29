﻿namespace MainForm.Forms
{
    partial class Detect_pedestrian
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
            this.btnPauseVideo = new System.Windows.Forms.Button();
            this.buttonPedestrianDetect = new System.Windows.Forms.Button();
            this.buttonFileOpen = new System.Windows.Forms.Button();
            this.pictureBoxDetectPedestrian = new System.Windows.Forms.PictureBox();
            this.pictureBoxDetectPedestrianResult = new System.Windows.Forms.PictureBox();
            this.buttonRewindForward = new System.Windows.Forms.Button();
            this.buttonRewindBack = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelFrames = new System.Windows.Forms.Label();
            this.numericUpDownFrames = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetectPedestrian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetectPedestrianResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrames)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPauseVideo
            // 
            this.btnPauseVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPauseVideo.Location = new System.Drawing.Point(26, 214);
            this.btnPauseVideo.Name = "btnPauseVideo";
            this.btnPauseVideo.Size = new System.Drawing.Size(214, 55);
            this.btnPauseVideo.TabIndex = 19;
            this.btnPauseVideo.Text = "Пауза";
            this.btnPauseVideo.UseVisualStyleBackColor = true;
            this.btnPauseVideo.Click += new System.EventHandler(this.btnbtnPauseVideo_Click);
            // 
            // buttonPedestrianDetect
            // 
            this.buttonPedestrianDetect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPedestrianDetect.Location = new System.Drawing.Point(26, 129);
            this.buttonPedestrianDetect.Name = "buttonPedestrianDetect";
            this.buttonPedestrianDetect.Size = new System.Drawing.Size(214, 55);
            this.buttonPedestrianDetect.TabIndex = 17;
            this.buttonPedestrianDetect.Text = "Распознать / Смотреть";
            this.buttonPedestrianDetect.UseVisualStyleBackColor = true;
            this.buttonPedestrianDetect.Click += new System.EventHandler(this.buttonPedestrianDetect_Click);
            // 
            // buttonFileOpen
            // 
            this.buttonFileOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFileOpen.Location = new System.Drawing.Point(26, 42);
            this.buttonFileOpen.Name = "buttonFileOpen";
            this.buttonFileOpen.Size = new System.Drawing.Size(214, 55);
            this.buttonFileOpen.TabIndex = 16;
            this.buttonFileOpen.Text = "Обзор";
            this.buttonFileOpen.UseVisualStyleBackColor = true;
            this.buttonFileOpen.Click += new System.EventHandler(this.buttonFileOpen_Click);
            // 
            // pictureBoxDetectPedestrian
            // 
            this.pictureBoxDetectPedestrian.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxDetectPedestrian.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxDetectPedestrian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDetectPedestrian.Location = new System.Drawing.Point(265, 42);
            this.pictureBoxDetectPedestrian.Name = "pictureBoxDetectPedestrian";
            this.pictureBoxDetectPedestrian.Size = new System.Drawing.Size(543, 371);
            this.pictureBoxDetectPedestrian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDetectPedestrian.TabIndex = 15;
            this.pictureBoxDetectPedestrian.TabStop = false;
            // 
            // pictureBoxDetectPedestrianResult
            // 
            this.pictureBoxDetectPedestrianResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDetectPedestrianResult.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxDetectPedestrianResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDetectPedestrianResult.Location = new System.Drawing.Point(895, 42);
            this.pictureBoxDetectPedestrianResult.Name = "pictureBoxDetectPedestrianResult";
            this.pictureBoxDetectPedestrianResult.Size = new System.Drawing.Size(553, 371);
            this.pictureBoxDetectPedestrianResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDetectPedestrianResult.TabIndex = 24;
            this.pictureBoxDetectPedestrianResult.TabStop = false;
            // 
            // buttonRewindForward
            // 
            this.buttonRewindForward.Location = new System.Drawing.Point(133, 354);
            this.buttonRewindForward.Name = "buttonRewindForward";
            this.buttonRewindForward.Size = new System.Drawing.Size(32, 30);
            this.buttonRewindForward.TabIndex = 25;
            this.buttonRewindForward.Text = ">";
            this.buttonRewindForward.UseVisualStyleBackColor = true;
            this.buttonRewindForward.Click += new System.EventHandler(this.buttonRewindForward_Click);
            // 
            // buttonRewindBack
            // 
            this.buttonRewindBack.Location = new System.Drawing.Point(96, 354);
            this.buttonRewindBack.Name = "buttonRewindBack";
            this.buttonRewindBack.Size = new System.Drawing.Size(31, 30);
            this.buttonRewindBack.TabIndex = 26;
            this.buttonRewindBack.Text = "<";
            this.buttonRewindBack.UseVisualStyleBackColor = true;
            this.buttonRewindBack.Click += new System.EventHandler(this.buttonRewindBack_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "MP4|*.mp4|AVI|*.avi|MKV|*.mkv";
            // 
            // labelFrames
            // 
            this.labelFrames.AutoSize = true;
            this.labelFrames.Location = new System.Drawing.Point(23, 359);
            this.labelFrames.Name = "labelFrames";
            this.labelFrames.Size = new System.Drawing.Size(0, 16);
            this.labelFrames.TabIndex = 27;
            // 
            // numericUpDownFrames
            // 
            this.numericUpDownFrames.Location = new System.Drawing.Point(171, 357);
            this.numericUpDownFrames.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFrames.Name = "numericUpDownFrames";
            this.numericUpDownFrames.Size = new System.Drawing.Size(69, 22);
            this.numericUpDownFrames.TabIndex = 28;
            this.numericUpDownFrames.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(26, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 55);
            this.button1.TabIndex = 29;
            this.button1.Text = "Очистить рабочие области";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Detect_pedestrian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 455);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDownFrames);
            this.Controls.Add(this.labelFrames);
            this.Controls.Add(this.buttonRewindBack);
            this.Controls.Add(this.buttonRewindForward);
            this.Controls.Add(this.pictureBoxDetectPedestrianResult);
            this.Controls.Add(this.btnPauseVideo);
            this.Controls.Add(this.buttonPedestrianDetect);
            this.Controls.Add(this.buttonFileOpen);
            this.Controls.Add(this.pictureBoxDetectPedestrian);
            this.Name = "Detect_pedestrian";
            this.Text = "Обнаружение пешеходов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Detect_pedestrian_FormClosed);
            this.Load += new System.EventHandler(this.Detect_pedestrian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetectPedestrian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetectPedestrianResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPauseVideo;
        private System.Windows.Forms.Button buttonPedestrianDetect;
        private System.Windows.Forms.Button buttonFileOpen;
        private System.Windows.Forms.PictureBox pictureBoxDetectPedestrian;
        private System.Windows.Forms.PictureBox pictureBoxDetectPedestrianResult;
        private System.Windows.Forms.Button buttonRewindForward;
        private System.Windows.Forms.Button buttonRewindBack;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelFrames;
        private System.Windows.Forms.NumericUpDown numericUpDownFrames;
        private System.Windows.Forms.Button button1;
    }
}