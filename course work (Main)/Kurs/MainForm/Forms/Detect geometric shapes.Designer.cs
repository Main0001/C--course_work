namespace MainForm.Forms
{
    partial class Detect_geometric_shapes
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
            this.buttonGeometricShapesDetectSave = new System.Windows.Forms.Button();
            this.buttonGeometricShapesDetect = new System.Windows.Forms.Button();
            this.buttonFileOpen = new System.Windows.Forms.Button();
            this.pictureBoxDetectGeometricShapes = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetectGeometricShapes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearPicture
            // 
            this.btnClearPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPicture.Location = new System.Drawing.Point(35, 247);
            this.btnClearPicture.Name = "btnClearPicture";
            this.btnClearPicture.Size = new System.Drawing.Size(200, 54);
            this.btnClearPicture.TabIndex = 10;
            this.btnClearPicture.Text = "Очистить рабочую область";
            this.btnClearPicture.UseVisualStyleBackColor = true;
            this.btnClearPicture.Click += new System.EventHandler(this.btnClearPicture_Click);
            // 
            // buttonGeometricShapesDetectSave
            // 
            this.buttonGeometricShapesDetectSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGeometricShapesDetectSave.Location = new System.Drawing.Point(35, 182);
            this.buttonGeometricShapesDetectSave.Name = "buttonGeometricShapesDetectSave";
            this.buttonGeometricShapesDetectSave.Size = new System.Drawing.Size(200, 38);
            this.buttonGeometricShapesDetectSave.TabIndex = 9;
            this.buttonGeometricShapesDetectSave.Text = "Сохранить результат";
            this.buttonGeometricShapesDetectSave.UseVisualStyleBackColor = true;
            this.buttonGeometricShapesDetectSave.Click += new System.EventHandler(this.buttonGeometricShapesDetectSave_Click);
            // 
            // buttonGeometricShapesDetect
            // 
            this.buttonGeometricShapesDetect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGeometricShapesDetect.Location = new System.Drawing.Point(35, 119);
            this.buttonGeometricShapesDetect.Name = "buttonGeometricShapesDetect";
            this.buttonGeometricShapesDetect.Size = new System.Drawing.Size(200, 38);
            this.buttonGeometricShapesDetect.TabIndex = 8;
            this.buttonGeometricShapesDetect.Text = "Распознать";
            this.buttonGeometricShapesDetect.UseVisualStyleBackColor = true;
            this.buttonGeometricShapesDetect.Click += new System.EventHandler(this.buttonGeometricShapesDetect_Click);
            // 
            // buttonFileOpen
            // 
            this.buttonFileOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFileOpen.Location = new System.Drawing.Point(35, 54);
            this.buttonFileOpen.Name = "buttonFileOpen";
            this.buttonFileOpen.Size = new System.Drawing.Size(200, 38);
            this.buttonFileOpen.TabIndex = 7;
            this.buttonFileOpen.Text = "Обзор";
            this.buttonFileOpen.UseVisualStyleBackColor = true;
            this.buttonFileOpen.Click += new System.EventHandler(this.buttonFileOpen_Click);
            // 
            // pictureBoxDetectGeometricShapes
            // 
            this.pictureBoxDetectGeometricShapes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDetectGeometricShapes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxDetectGeometricShapes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDetectGeometricShapes.Location = new System.Drawing.Point(266, 54);
            this.pictureBoxDetectGeometricShapes.Name = "pictureBoxDetectGeometricShapes";
            this.pictureBoxDetectGeometricShapes.Size = new System.Drawing.Size(510, 371);
            this.pictureBoxDetectGeometricShapes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDetectGeometricShapes.TabIndex = 6;
            this.pictureBoxDetectGeometricShapes.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG|*.jpg|PNG|*.png";
            // 
            // Detect_geometric_shapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearPicture);
            this.Controls.Add(this.buttonGeometricShapesDetectSave);
            this.Controls.Add(this.buttonGeometricShapesDetect);
            this.Controls.Add(this.buttonFileOpen);
            this.Controls.Add(this.pictureBoxDetectGeometricShapes);
            this.Name = "Detect_geometric_shapes";
            this.Text = "Обнаружение фигур";
            this.Load += new System.EventHandler(this.Detect_geometric_shapes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetectGeometricShapes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClearPicture;
        private System.Windows.Forms.Button buttonGeometricShapesDetectSave;
        private System.Windows.Forms.Button buttonGeometricShapesDetect;
        private System.Windows.Forms.Button buttonFileOpen;
        private System.Windows.Forms.PictureBox pictureBoxDetectGeometricShapes;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}