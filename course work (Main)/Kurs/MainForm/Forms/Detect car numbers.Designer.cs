namespace MainForm.Forms
{
    partial class Detect_car_numbers
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
            this.btnClearPictureResult = new System.Windows.Forms.Button();
            this.btnClearPicture = new System.Windows.Forms.Button();
            this.buttonCarNumbersDetect = new System.Windows.Forms.Button();
            this.buttonFileOpen = new System.Windows.Forms.Button();
            this.pictureBoxDetectCarNumbers = new System.Windows.Forms.PictureBox();
            this.pictureBoxDetectCarNumbersResult = new System.Windows.Forms.PictureBox();
            this.buttonCarNumbersDetectSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetectCarNumbers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetectCarNumbersResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearPictureResult
            // 
            this.btnClearPictureResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPictureResult.Location = new System.Drawing.Point(33, 313);
            this.btnClearPictureResult.Name = "btnClearPictureResult";
            this.btnClearPictureResult.Size = new System.Drawing.Size(200, 54);
            this.btnClearPictureResult.TabIndex = 21;
            this.btnClearPictureResult.Text = "Clear result";
            this.btnClearPictureResult.UseVisualStyleBackColor = true;
            this.btnClearPictureResult.Click += new System.EventHandler(this.btnClearPictureResult_Click);
            // 
            // btnClearPicture
            // 
            this.btnClearPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPicture.Location = new System.Drawing.Point(33, 232);
            this.btnClearPicture.Name = "btnClearPicture";
            this.btnClearPicture.Size = new System.Drawing.Size(200, 54);
            this.btnClearPicture.TabIndex = 19;
            this.btnClearPicture.Text = "Clear picture area";
            this.btnClearPicture.UseVisualStyleBackColor = true;
            this.btnClearPicture.Click += new System.EventHandler(this.btnClearPicture_Click);
            // 
            // buttonCarNumbersDetect
            // 
            this.buttonCarNumbersDetect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCarNumbersDetect.Location = new System.Drawing.Point(33, 105);
            this.buttonCarNumbersDetect.Name = "buttonCarNumbersDetect";
            this.buttonCarNumbersDetect.Size = new System.Drawing.Size(200, 38);
            this.buttonCarNumbersDetect.TabIndex = 17;
            this.buttonCarNumbersDetect.Text = "Recognize";
            this.buttonCarNumbersDetect.UseVisualStyleBackColor = true;
            this.buttonCarNumbersDetect.Click += new System.EventHandler(this.buttonCarNumbersDetect_Click);
            // 
            // buttonFileOpen
            // 
            this.buttonFileOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFileOpen.Location = new System.Drawing.Point(33, 40);
            this.buttonFileOpen.Name = "buttonFileOpen";
            this.buttonFileOpen.Size = new System.Drawing.Size(200, 38);
            this.buttonFileOpen.TabIndex = 16;
            this.buttonFileOpen.Text = "Browse";
            this.buttonFileOpen.UseVisualStyleBackColor = true;
            this.buttonFileOpen.Click += new System.EventHandler(this.buttonFileOpen_Click);
            // 
            // pictureBoxDetectCarNumbers
            // 
            this.pictureBoxDetectCarNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDetectCarNumbers.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxDetectCarNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDetectCarNumbers.Location = new System.Drawing.Point(258, 40);
            this.pictureBoxDetectCarNumbers.Name = "pictureBoxDetectCarNumbers";
            this.pictureBoxDetectCarNumbers.Size = new System.Drawing.Size(369, 371);
            this.pictureBoxDetectCarNumbers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDetectCarNumbers.TabIndex = 15;
            this.pictureBoxDetectCarNumbers.TabStop = false;
            // 
            // pictureBoxDetectCarNumbersResult
            // 
            this.pictureBoxDetectCarNumbersResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDetectCarNumbersResult.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxDetectCarNumbersResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDetectCarNumbersResult.Location = new System.Drawing.Point(662, 40);
            this.pictureBoxDetectCarNumbersResult.Name = "pictureBoxDetectCarNumbersResult";
            this.pictureBoxDetectCarNumbersResult.Size = new System.Drawing.Size(369, 371);
            this.pictureBoxDetectCarNumbersResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDetectCarNumbersResult.TabIndex = 22;
            this.pictureBoxDetectCarNumbersResult.TabStop = false;
            // 
            // buttonCarNumbersDetectSave
            // 
            this.buttonCarNumbersDetectSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCarNumbersDetectSave.Location = new System.Drawing.Point(33, 169);
            this.buttonCarNumbersDetectSave.Name = "buttonCarNumbersDetectSave";
            this.buttonCarNumbersDetectSave.Size = new System.Drawing.Size(200, 38);
            this.buttonCarNumbersDetectSave.TabIndex = 23;
            this.buttonCarNumbersDetectSave.Text = "Save result";
            this.buttonCarNumbersDetectSave.UseVisualStyleBackColor = true;
            this.buttonCarNumbersDetectSave.Click += new System.EventHandler(this.buttonCarNumbersDetectSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Detect_car_numbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 450);
            this.Controls.Add(this.buttonCarNumbersDetectSave);
            this.Controls.Add(this.pictureBoxDetectCarNumbersResult);
            this.Controls.Add(this.btnClearPictureResult);
            this.Controls.Add(this.btnClearPicture);
            this.Controls.Add(this.buttonCarNumbersDetect);
            this.Controls.Add(this.buttonFileOpen);
            this.Controls.Add(this.pictureBoxDetectCarNumbers);
            this.Name = "Detect_car_numbers";
            this.Text = "Detect_car_numbers";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetectCarNumbers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetectCarNumbersResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClearPictureResult;
        private System.Windows.Forms.Button btnClearPicture;
        private System.Windows.Forms.Button buttonCarNumbersDetect;
        private System.Windows.Forms.Button buttonFileOpen;
        private System.Windows.Forms.PictureBox pictureBoxDetectCarNumbers;
        private System.Windows.Forms.PictureBox pictureBoxDetectCarNumbersResult;
        private System.Windows.Forms.Button buttonCarNumbersDetectSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}