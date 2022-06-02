namespace MainForm.Forms
{
    partial class Detect_contours
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
            this.btnClearPicture = new System.Windows.Forms.Button();
            this.buttonContoursSave = new System.Windows.Forms.Button();
            this.buttonContoursDetect = new System.Windows.Forms.Button();
            this.buttonFileOpen = new System.Windows.Forms.Button();
            this.pictureBoxDetectContours = new System.Windows.Forms.PictureBox();
            this.checkBoxContoursBlackBackground = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetectContours)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearPicture
            // 
            this.btnClearPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPicture.Location = new System.Drawing.Point(36, 292);
            this.btnClearPicture.Name = "btnClearPicture";
            this.btnClearPicture.Size = new System.Drawing.Size(200, 54);
            this.btnClearPicture.TabIndex = 15;
            this.btnClearPicture.Text = "Clear working area";
            this.btnClearPicture.UseVisualStyleBackColor = true;
            this.btnClearPicture.Click += new System.EventHandler(this.btnClearPicture_Click);
            // 
            // buttonContoursSave
            // 
            this.buttonContoursSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContoursSave.Location = new System.Drawing.Point(36, 229);
            this.buttonContoursSave.Name = "buttonContoursSave";
            this.buttonContoursSave.Size = new System.Drawing.Size(200, 38);
            this.buttonContoursSave.TabIndex = 14;
            this.buttonContoursSave.Text = "Save result";
            this.buttonContoursSave.UseVisualStyleBackColor = true;
            this.buttonContoursSave.Click += new System.EventHandler(this.buttonContoursSave_Click);
            // 
            // buttonContoursDetect
            // 
            this.buttonContoursDetect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContoursDetect.Location = new System.Drawing.Point(36, 116);
            this.buttonContoursDetect.Name = "buttonContoursDetect";
            this.buttonContoursDetect.Size = new System.Drawing.Size(200, 38);
            this.buttonContoursDetect.TabIndex = 13;
            this.buttonContoursDetect.Text = "Recognize";
            this.buttonContoursDetect.UseVisualStyleBackColor = true;
            this.buttonContoursDetect.Click += new System.EventHandler(this.buttonContoursDetect_Click);
            // 
            // buttonFileOpen
            // 
            this.buttonFileOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFileOpen.Location = new System.Drawing.Point(36, 51);
            this.buttonFileOpen.Name = "buttonFileOpen";
            this.buttonFileOpen.Size = new System.Drawing.Size(200, 38);
            this.buttonFileOpen.TabIndex = 12;
            this.buttonFileOpen.Text = "Browse";
            this.buttonFileOpen.UseVisualStyleBackColor = true;
            this.buttonFileOpen.Click += new System.EventHandler(this.buttonFileOpen_Click);
            // 
            // pictureBoxDetectContours
            // 
            this.pictureBoxDetectContours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDetectContours.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxDetectContours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDetectContours.Location = new System.Drawing.Point(267, 51);
            this.pictureBoxDetectContours.Name = "pictureBoxDetectContours";
            this.pictureBoxDetectContours.Size = new System.Drawing.Size(510, 371);
            this.pictureBoxDetectContours.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDetectContours.TabIndex = 11;
            this.pictureBoxDetectContours.TabStop = false;
            // 
            // checkBoxContoursBlackBackground
            // 
            this.checkBoxContoursBlackBackground.AutoSize = true;
            this.checkBoxContoursBlackBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxContoursBlackBackground.Location = new System.Drawing.Point(36, 160);
            this.checkBoxContoursBlackBackground.Name = "checkBoxContoursBlackBackground";
            this.checkBoxContoursBlackBackground.Size = new System.Drawing.Size(278, 21);
            this.checkBoxContoursBlackBackground.TabIndex = 16;
            this.checkBoxContoursBlackBackground.Text = "Show contours in the black background";
            this.checkBoxContoursBlackBackground.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG|*.jpg|PNG|*.png";
            // 
            // Detect_contours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxContoursBlackBackground);
            this.Controls.Add(this.btnClearPicture);
            this.Controls.Add(this.buttonContoursSave);
            this.Controls.Add(this.buttonContoursDetect);
            this.Controls.Add(this.buttonFileOpen);
            this.Controls.Add(this.pictureBoxDetectContours);
            this.Name = "Detect_contours";
            this.Text = "Detect contours";
            this.Load += new System.EventHandler(this.Detect_contours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetectContours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearPicture;
        private System.Windows.Forms.Button buttonContoursSave;
        private System.Windows.Forms.Button buttonContoursDetect;
        private System.Windows.Forms.Button buttonFileOpen;
        private System.Windows.Forms.PictureBox pictureBoxDetectContours;
        private System.Windows.Forms.CheckBox checkBoxContoursBlackBackground;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}