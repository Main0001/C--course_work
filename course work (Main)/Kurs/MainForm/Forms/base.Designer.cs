﻿namespace MainForm
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonAboutProgram = new System.Windows.Forms.Button();
            this.buttonDetectPedestrian = new System.Windows.Forms.Button();
            this.btnDetectText = new System.Windows.Forms.Button();
            this.btnDetectGeometricShapes = new System.Windows.Forms.Button();
            this.btnDetectContours = new System.Windows.Forms.Button();
            this.btnDetectObjects = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelProgramName = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.labelDetectTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.buttonAboutProgram);
            this.panelMenu.Controls.Add(this.buttonDetectPedestrian);
            this.panelMenu.Controls.Add(this.btnDetectText);
            this.panelMenu.Controls.Add(this.btnDetectGeometricShapes);
            this.panelMenu.Controls.Add(this.btnDetectContours);
            this.panelMenu.Controls.Add(this.btnDetectObjects);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(309, 441);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonAboutProgram
            // 
            this.buttonAboutProgram.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAboutProgram.FlatAppearance.BorderSize = 0;
            this.buttonAboutProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAboutProgram.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAboutProgram.Image = ((System.Drawing.Image)(resources.GetObject("buttonAboutProgram.Image")));
            this.buttonAboutProgram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAboutProgram.Location = new System.Drawing.Point(0, 375);
            this.buttonAboutProgram.Name = "buttonAboutProgram";
            this.buttonAboutProgram.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonAboutProgram.Size = new System.Drawing.Size(309, 60);
            this.buttonAboutProgram.TabIndex = 8;
            this.buttonAboutProgram.Text = "О программе";
            this.buttonAboutProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAboutProgram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAboutProgram.UseVisualStyleBackColor = true;
            this.buttonAboutProgram.Click += new System.EventHandler(this.buttonAboutProgram_Click);
            // 
            // buttonDetectPedestrian
            // 
            this.buttonDetectPedestrian.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDetectPedestrian.FlatAppearance.BorderSize = 0;
            this.buttonDetectPedestrian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDetectPedestrian.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDetectPedestrian.Image = ((System.Drawing.Image)(resources.GetObject("buttonDetectPedestrian.Image")));
            this.buttonDetectPedestrian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDetectPedestrian.Location = new System.Drawing.Point(0, 315);
            this.buttonDetectPedestrian.Name = "buttonDetectPedestrian";
            this.buttonDetectPedestrian.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonDetectPedestrian.Size = new System.Drawing.Size(309, 60);
            this.buttonDetectPedestrian.TabIndex = 7;
            this.buttonDetectPedestrian.Text = "Обнаружение пешеходов на видео";
            this.buttonDetectPedestrian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDetectPedestrian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDetectPedestrian.UseVisualStyleBackColor = true;
            this.buttonDetectPedestrian.Click += new System.EventHandler(this.buttonDetectPedestrian_Click);
            // 
            // btnDetectText
            // 
            this.btnDetectText.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDetectText.FlatAppearance.BorderSize = 0;
            this.btnDetectText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetectText.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDetectText.Image = ((System.Drawing.Image)(resources.GetObject("btnDetectText.Image")));
            this.btnDetectText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetectText.Location = new System.Drawing.Point(0, 255);
            this.btnDetectText.Name = "btnDetectText";
            this.btnDetectText.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDetectText.Size = new System.Drawing.Size(309, 60);
            this.btnDetectText.TabIndex = 6;
            this.btnDetectText.Text = "Считывание текста из  изображения\r\n";
            this.btnDetectText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetectText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetectText.UseVisualStyleBackColor = true;
            this.btnDetectText.Click += new System.EventHandler(this.btnDetectText_Click);
            // 
            // btnDetectGeometricShapes
            // 
            this.btnDetectGeometricShapes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDetectGeometricShapes.FlatAppearance.BorderSize = 0;
            this.btnDetectGeometricShapes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetectGeometricShapes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDetectGeometricShapes.Image = ((System.Drawing.Image)(resources.GetObject("btnDetectGeometricShapes.Image")));
            this.btnDetectGeometricShapes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetectGeometricShapes.Location = new System.Drawing.Point(0, 195);
            this.btnDetectGeometricShapes.Name = "btnDetectGeometricShapes";
            this.btnDetectGeometricShapes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDetectGeometricShapes.Size = new System.Drawing.Size(309, 60);
            this.btnDetectGeometricShapes.TabIndex = 5;
            this.btnDetectGeometricShapes.Text = "Обнаружение фигур на изображении";
            this.btnDetectGeometricShapes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetectGeometricShapes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetectGeometricShapes.UseVisualStyleBackColor = true;
            this.btnDetectGeometricShapes.Click += new System.EventHandler(this.btnDetectGeometricShapes_Click);
            // 
            // btnDetectContours
            // 
            this.btnDetectContours.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDetectContours.FlatAppearance.BorderSize = 0;
            this.btnDetectContours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetectContours.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDetectContours.Image = ((System.Drawing.Image)(resources.GetObject("btnDetectContours.Image")));
            this.btnDetectContours.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetectContours.Location = new System.Drawing.Point(0, 135);
            this.btnDetectContours.Name = "btnDetectContours";
            this.btnDetectContours.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDetectContours.Size = new System.Drawing.Size(309, 60);
            this.btnDetectContours.TabIndex = 4;
            this.btnDetectContours.Text = "Обнаружение контуров на изображении";
            this.btnDetectContours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetectContours.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetectContours.UseVisualStyleBackColor = true;
            this.btnDetectContours.Click += new System.EventHandler(this.btnDetectContours_Click);
            // 
            // btnDetectObjects
            // 
            this.btnDetectObjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDetectObjects.FlatAppearance.BorderSize = 0;
            this.btnDetectObjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetectObjects.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDetectObjects.Image = ((System.Drawing.Image)(resources.GetObject("btnDetectObjects.Image")));
            this.btnDetectObjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetectObjects.Location = new System.Drawing.Point(0, 75);
            this.btnDetectObjects.Name = "btnDetectObjects";
            this.btnDetectObjects.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDetectObjects.Size = new System.Drawing.Size(309, 60);
            this.btnDetectObjects.TabIndex = 2;
            this.btnDetectObjects.Text = "Обнаружение объектов на изображении";
            this.btnDetectObjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetectObjects.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetectObjects.UseVisualStyleBackColor = true;
            this.btnDetectObjects.Click += new System.EventHandler(this.btnDetectObjects_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.labelProgramName);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(309, 75);
            this.panelLogo.TabIndex = 1;
            // 
            // labelProgramName
            // 
            this.labelProgramName.AutoSize = true;
            this.labelProgramName.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F);
            this.labelProgramName.ForeColor = System.Drawing.Color.White;
            this.labelProgramName.Location = new System.Drawing.Point(75, 10);
            this.labelProgramName.Name = "labelProgramName";
            this.labelProgramName.Size = new System.Drawing.Size(148, 46);
            this.labelProgramName.TabIndex = 2;
            this.labelProgramName.Text = "OС V 1.0";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnCloseForm);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.labelDetectTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(309, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(692, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(595, -9);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 42);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "O";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(623, -9);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(38, 42);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.Text = "O";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseForm.Location = new System.Drawing.Point(660, -9);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(29, 42);
            this.btnCloseForm.TabIndex = 2;
            this.btnCloseForm.Text = "O";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildForm.Image")));
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 75);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // labelDetectTitle
            // 
            this.labelDetectTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDetectTitle.AutoSize = true;
            this.labelDetectTitle.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDetectTitle.ForeColor = System.Drawing.Color.White;
            this.labelDetectTitle.Location = new System.Drawing.Point(104, 10);
            this.labelDetectTitle.Name = "labelDetectTitle";
            this.labelDetectTitle.Size = new System.Drawing.Size(306, 46);
            this.labelDetectTitle.TabIndex = 0;
            this.labelDetectTitle.Text = "Главная страница";
            this.labelDetectTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelDesktop.Location = new System.Drawing.Point(309, 75);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(692, 366);
            this.panelDesktop.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 441);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1019, 468);
            this.Name = "MainForm";
            this.Text = "Open CV V 1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnDetectGeometricShapes;
        private System.Windows.Forms.Button btnDetectContours;
        private System.Windows.Forms.Button btnDetectObjects;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelDetectTitle;
        private System.Windows.Forms.Label labelProgramName;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnDetectText;
        private System.Windows.Forms.Button buttonDetectPedestrian;
        private System.Windows.Forms.Button buttonAboutProgram;
    }
}

