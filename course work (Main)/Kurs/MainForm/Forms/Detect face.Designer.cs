namespace MainForm.Forms
{
    partial class Detect_face
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
            this.pictureBoxDetectFace = new System.Windows.Forms.PictureBox();
            this.buttonFileOpen = new System.Windows.Forms.Button();
            this.buttonFaceDetect = new System.Windows.Forms.Button();
            this.buttonFaceDetectSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnClearPicture = new System.Windows.Forms.Button();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.comboBoxObjectDetect = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetectFace)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDetectFace
            // 
            this.pictureBoxDetectFace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDetectFace.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxDetectFace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDetectFace.Location = new System.Drawing.Point(265, 53);
            this.pictureBoxDetectFace.Name = "pictureBoxDetectFace";
            this.pictureBoxDetectFace.Size = new System.Drawing.Size(510, 371);
            this.pictureBoxDetectFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDetectFace.TabIndex = 0;
            this.pictureBoxDetectFace.TabStop = false;
            // 
            // buttonFileOpen
            // 
            this.buttonFileOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFileOpen.Location = new System.Drawing.Point(34, 53);
            this.buttonFileOpen.Name = "buttonFileOpen";
            this.buttonFileOpen.Size = new System.Drawing.Size(200, 38);
            this.buttonFileOpen.TabIndex = 2;
            this.buttonFileOpen.Text = "Browse";
            this.buttonFileOpen.UseVisualStyleBackColor = true;
            this.buttonFileOpen.Click += new System.EventHandler(this.buttonFileOpen_Click);
            // 
            // buttonFaceDetect
            // 
            this.buttonFaceDetect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFaceDetect.Location = new System.Drawing.Point(34, 163);
            this.buttonFaceDetect.Name = "buttonFaceDetect";
            this.buttonFaceDetect.Size = new System.Drawing.Size(200, 38);
            this.buttonFaceDetect.TabIndex = 3;
            this.buttonFaceDetect.Text = "Recognize";
            this.buttonFaceDetect.UseVisualStyleBackColor = true;
            this.buttonFaceDetect.Click += new System.EventHandler(this.buttonFaceDetect_Click);
            // 
            // buttonFaceDetectSave
            // 
            this.buttonFaceDetectSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFaceDetectSave.Location = new System.Drawing.Point(34, 219);
            this.buttonFaceDetectSave.Name = "buttonFaceDetectSave";
            this.buttonFaceDetectSave.Size = new System.Drawing.Size(200, 38);
            this.buttonFaceDetectSave.TabIndex = 4;
            this.buttonFaceDetectSave.Text = "Save result";
            this.buttonFaceDetectSave.UseVisualStyleBackColor = true;
            this.buttonFaceDetectSave.Click += new System.EventHandler(this.buttonFaceDetectSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG|*.jpg|PNG|*.png";
            // 
            // btnClearPicture
            // 
            this.btnClearPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPicture.Location = new System.Drawing.Point(34, 285);
            this.btnClearPicture.Name = "btnClearPicture";
            this.btnClearPicture.Size = new System.Drawing.Size(200, 54);
            this.btnClearPicture.TabIndex = 5;
            this.btnClearPicture.Text = "Clear working area";
            this.btnClearPicture.UseVisualStyleBackColor = true;
            this.btnClearPicture.Click += new System.EventHandler(this.btnClearPicture_Click);
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(31, 100);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(78, 16);
            this.labelLanguage.TabIndex = 16;
            this.labelLanguage.Text = "Object type:";
            // 
            // comboBoxObjectDetect
            // 
            this.comboBoxObjectDetect.FormattingEnabled = true;
            this.comboBoxObjectDetect.Items.AddRange(new object[] {
            "Face",
            "Full body",
            "Glasses"});
            this.comboBoxObjectDetect.Location = new System.Drawing.Point(113, 97);
            this.comboBoxObjectDetect.Name = "comboBoxObjectDetect";
            this.comboBoxObjectDetect.Size = new System.Drawing.Size(121, 24);
            this.comboBoxObjectDetect.TabIndex = 15;
            this.comboBoxObjectDetect.SelectedIndexChanged += new System.EventHandler(this.comboBoxObjectDetect_SelectedIndexChanged);
            // 
            // Detect_face
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.comboBoxObjectDetect);
            this.Controls.Add(this.btnClearPicture);
            this.Controls.Add(this.buttonFaceDetectSave);
            this.Controls.Add(this.buttonFaceDetect);
            this.Controls.Add(this.buttonFileOpen);
            this.Controls.Add(this.pictureBoxDetectFace);
            this.Name = "Detect_face";
            this.Text = "Detect face";
            this.Load += new System.EventHandler(this.Detect_Face_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetectFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDetectFace;
        private System.Windows.Forms.Button buttonFileOpen;
        private System.Windows.Forms.Button buttonFaceDetect;
        private System.Windows.Forms.Button buttonFaceDetectSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnClearPicture;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.ComboBox comboBoxObjectDetect;
    }
}