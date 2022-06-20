namespace MainForm.Forms
{
    partial class Detect_text
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
            this.buttonTextDetectSave = new System.Windows.Forms.Button();
            this.buttonTextDetect = new System.Windows.Forms.Button();
            this.buttonFileOpen = new System.Windows.Forms.Button();
            this.pictureBoxDetectText = new System.Windows.Forms.PictureBox();
            this.richTextBoxDetectText = new System.Windows.Forms.RichTextBox();
            this.btnClearText = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxDetectText = new System.Windows.Forms.ComboBox();
            this.labelLanguage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetectText)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearPicture
            // 
            this.btnClearPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPicture.Location = new System.Drawing.Point(30, 250);
            this.btnClearPicture.Name = "btnClearPicture";
            this.btnClearPicture.Size = new System.Drawing.Size(200, 54);
            this.btnClearPicture.TabIndex = 10;
            this.btnClearPicture.Text = "Очистить рабочую область";
            this.btnClearPicture.UseVisualStyleBackColor = true;
            this.btnClearPicture.Click += new System.EventHandler(this.btnClearPicture_Click);
            // 
            // buttonTextDetectSave
            // 
            this.buttonTextDetectSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTextDetectSave.Location = new System.Drawing.Point(30, 184);
            this.buttonTextDetectSave.Name = "buttonTextDetectSave";
            this.buttonTextDetectSave.Size = new System.Drawing.Size(200, 46);
            this.buttonTextDetectSave.TabIndex = 9;
            this.buttonTextDetectSave.Text = "Сохранить результат в буфер обмена";
            this.buttonTextDetectSave.UseVisualStyleBackColor = true;
            this.buttonTextDetectSave.Click += new System.EventHandler(this.buttonTextDetectSave_Click);
            // 
            // buttonTextDetect
            // 
            this.buttonTextDetect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTextDetect.Location = new System.Drawing.Point(30, 105);
            this.buttonTextDetect.Name = "buttonTextDetect";
            this.buttonTextDetect.Size = new System.Drawing.Size(200, 38);
            this.buttonTextDetect.TabIndex = 8;
            this.buttonTextDetect.Text = "Распознать";
            this.buttonTextDetect.UseVisualStyleBackColor = true;
            this.buttonTextDetect.Click += new System.EventHandler(this.buttonTextDetect_Click);
            // 
            // buttonFileOpen
            // 
            this.buttonFileOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFileOpen.Location = new System.Drawing.Point(30, 40);
            this.buttonFileOpen.Name = "buttonFileOpen";
            this.buttonFileOpen.Size = new System.Drawing.Size(200, 38);
            this.buttonFileOpen.TabIndex = 7;
            this.buttonFileOpen.Text = "Обзор";
            this.buttonFileOpen.UseVisualStyleBackColor = true;
            this.buttonFileOpen.Click += new System.EventHandler(this.buttonFileOpen_Click);
            // 
            // pictureBoxDetectText
            // 
            this.pictureBoxDetectText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDetectText.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxDetectText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDetectText.Location = new System.Drawing.Point(255, 40);
            this.pictureBoxDetectText.Name = "pictureBoxDetectText";
            this.pictureBoxDetectText.Size = new System.Drawing.Size(369, 371);
            this.pictureBoxDetectText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDetectText.TabIndex = 6;
            this.pictureBoxDetectText.TabStop = false;
            // 
            // richTextBoxDetectText
            // 
            this.richTextBoxDetectText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxDetectText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxDetectText.Location = new System.Drawing.Point(648, 40);
            this.richTextBoxDetectText.Name = "richTextBoxDetectText";
            this.richTextBoxDetectText.Size = new System.Drawing.Size(369, 371);
            this.richTextBoxDetectText.TabIndex = 11;
            this.richTextBoxDetectText.Text = "";
            // 
            // btnClearText
            // 
            this.btnClearText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearText.Location = new System.Drawing.Point(30, 325);
            this.btnClearText.Name = "btnClearText";
            this.btnClearText.Size = new System.Drawing.Size(200, 54);
            this.btnClearText.TabIndex = 12;
            this.btnClearText.Text = "Очистить текстовую область";
            this.btnClearText.UseVisualStyleBackColor = true;
            this.btnClearText.Click += new System.EventHandler(this.btnClearText_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG|*.jpg|PNG|*.png";
            // 
            // comboBoxDetectText
            // 
            this.comboBoxDetectText.FormattingEnabled = true;
            this.comboBoxDetectText.Items.AddRange(new object[] {
            "Русский",
            "Английский",
            "Немецкий"});
            this.comboBoxDetectText.Location = new System.Drawing.Point(109, 149);
            this.comboBoxDetectText.Name = "comboBoxDetectText";
            this.comboBoxDetectText.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDetectText.TabIndex = 13;
            this.comboBoxDetectText.SelectedIndexChanged += new System.EventHandler(this.comboBoxDetectText_SelectedIndexChanged);
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(31, 152);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(44, 16);
            this.labelLanguage.TabIndex = 14;
            this.labelLanguage.Text = "Язык:";
            // 
            // Detect_text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 455);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.comboBoxDetectText);
            this.Controls.Add(this.btnClearText);
            this.Controls.Add(this.richTextBoxDetectText);
            this.Controls.Add(this.btnClearPicture);
            this.Controls.Add(this.buttonTextDetectSave);
            this.Controls.Add(this.buttonTextDetect);
            this.Controls.Add(this.buttonFileOpen);
            this.Controls.Add(this.pictureBoxDetectText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Detect_text";
            this.Text = "Распознание текста";
            this.Load += new System.EventHandler(this.Detect_text_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetectText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearPicture;
        private System.Windows.Forms.Button buttonTextDetectSave;
        private System.Windows.Forms.Button buttonTextDetect;
        private System.Windows.Forms.Button buttonFileOpen;
        private System.Windows.Forms.PictureBox pictureBoxDetectText;
        private System.Windows.Forms.RichTextBox richTextBoxDetectText;
        private System.Windows.Forms.Button btnClearText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBoxDetectText;
        private System.Windows.Forms.Label labelLanguage;
    }
}