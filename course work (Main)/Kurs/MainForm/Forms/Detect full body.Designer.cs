namespace MainForm.Forms
{
    partial class Detect_full_body
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
            this.buttonFullBodyDetectSave = new System.Windows.Forms.Button();
            this.buttonFullBodyDetect = new System.Windows.Forms.Button();
            this.buttonFileOpen = new System.Windows.Forms.Button();
            this.pictureBoxDetectFullBody = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetectFullBody)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearPicture
            // 
            this.btnClearPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPicture.Location = new System.Drawing.Point(36, 243);
            this.btnClearPicture.Name = "btnClearPicture";
            this.btnClearPicture.Size = new System.Drawing.Size(200, 54);
            this.btnClearPicture.TabIndex = 10;
            this.btnClearPicture.Text = "Clear working area";
            this.btnClearPicture.UseVisualStyleBackColor = true;
            this.btnClearPicture.Click += new System.EventHandler(this.btnClearPicture_Click);
            // 
            // buttonFullBodyDetectSave
            // 
            this.buttonFullBodyDetectSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFullBodyDetectSave.Location = new System.Drawing.Point(36, 181);
            this.buttonFullBodyDetectSave.Name = "buttonFullBodyDetectSave";
            this.buttonFullBodyDetectSave.Size = new System.Drawing.Size(200, 38);
            this.buttonFullBodyDetectSave.TabIndex = 9;
            this.buttonFullBodyDetectSave.Text = "Save result";
            this.buttonFullBodyDetectSave.UseVisualStyleBackColor = true;
            this.buttonFullBodyDetectSave.Click += new System.EventHandler(this.buttonFullBodyDetectSave_Click);
            // 
            // buttonFullBodyDetect
            // 
            this.buttonFullBodyDetect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFullBodyDetect.Location = new System.Drawing.Point(36, 117);
            this.buttonFullBodyDetect.Name = "buttonFullBodyDetect";
            this.buttonFullBodyDetect.Size = new System.Drawing.Size(200, 38);
            this.buttonFullBodyDetect.TabIndex = 8;
            this.buttonFullBodyDetect.Text = "Recognize";
            this.buttonFullBodyDetect.UseVisualStyleBackColor = true;
            this.buttonFullBodyDetect.Click += new System.EventHandler(this.buttonFullBodyDetect_Click);
            // 
            // buttonFileOpen
            // 
            this.buttonFileOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFileOpen.Location = new System.Drawing.Point(36, 52);
            this.buttonFileOpen.Name = "buttonFileOpen";
            this.buttonFileOpen.Size = new System.Drawing.Size(200, 38);
            this.buttonFileOpen.TabIndex = 7;
            this.buttonFileOpen.Text = "Browse";
            this.buttonFileOpen.UseVisualStyleBackColor = true;
            this.buttonFileOpen.Click += new System.EventHandler(this.buttonFileOpen_Click);
            // 
            // pictureBoxDetectFullBody
            // 
            this.pictureBoxDetectFullBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDetectFullBody.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxDetectFullBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDetectFullBody.Location = new System.Drawing.Point(267, 52);
            this.pictureBoxDetectFullBody.Name = "pictureBoxDetectFullBody";
            this.pictureBoxDetectFullBody.Size = new System.Drawing.Size(510, 371);
            this.pictureBoxDetectFullBody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDetectFullBody.TabIndex = 6;
            this.pictureBoxDetectFullBody.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG|*.jpg|PNG|*.png";
            // 
            // Detect_full_body
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearPicture);
            this.Controls.Add(this.buttonFullBodyDetectSave);
            this.Controls.Add(this.buttonFullBodyDetect);
            this.Controls.Add(this.buttonFileOpen);
            this.Controls.Add(this.pictureBoxDetectFullBody);
            this.Name = "Detect_full_body";
            this.Text = "Detect full body";
            this.Load += new System.EventHandler(this.Detect_full_body_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetectFullBody)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClearPicture;
        private System.Windows.Forms.Button buttonFullBodyDetectSave;
        private System.Windows.Forms.Button buttonFullBodyDetect;
        private System.Windows.Forms.Button buttonFileOpen;
        private System.Windows.Forms.PictureBox pictureBoxDetectFullBody;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}