﻿using MainForm.Constants;
using Emgu.CV;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainForm.Forms
{
    public partial class Detect_text : Form
    {
        private string filePath = string.Empty;
        private string lang = string.Empty;
        public Detect_text()
        {
            InitializeComponent();
            comboBoxDetectText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            richTextBoxDetectText.ReadOnly = true;
        }
        private void Detect_text_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls) //panelMenu.Controls - возвращает все управляющие элементы (кнопки, радиобаттоны и т.д.)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor; //Присвоит бэкграунд кнопке (определенного цвета)
                    btn.ForeColor = FormConstants.BUTTON_ACTIVATE_FORE_COLOR;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private void buttonFileOpen_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = openFileDialog1.ShowDialog();
                if (res == DialogResult.OK)
                {
                    filePath = openFileDialog1.FileName;

                    pictureBoxDetectText.Image = Image.FromFile(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBoxDetectText_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDetectText.SelectedIndex == 0)
            {
                lang = "rus";
            }
            else if (comboBoxDetectText.SelectedIndex == 1)
            {
                lang = "eng";
            }
            else if (comboBoxDetectText.SelectedIndex == 2)
            {
                lang = "deu";
            }
        }

        private void buttonTextDetect_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(filePath) || String.IsNullOrWhiteSpace(filePath))
                {
                    throw new Exception("Картинка не выбрана!");
                }
                else if(comboBoxDetectText.SelectedItem == null)
                {
                    throw new Exception("Язык не выбран!");
                }
                else
                {
                    Tesseract tesseract = new Tesseract(@"tessdata", lang, OcrEngineMode.TesseractLstmCombined);
                    tesseract.SetImage(new Image<Bgr, byte>(filePath));
                    tesseract.Recognize();
                    richTextBoxDetectText.Text = tesseract.GetUTF8Text();

                    tesseract.Dispose(); //Т.к. при нажатии кнопки будет создаваться новый объект, то Dispose очищает (отдает) все ресурсы которые использовались
                    richTextBoxDetectText.ReadOnly = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTextDetectSave_Click(object sender, EventArgs e)
        {
            var detectTextSave = richTextBoxDetectText.Text;
            try
            {
                Clipboard.SetText(detectTextSave);
                MessageBox.Show("Результат успешно сохранен в буфер обмена", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Отсутствует результат", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearPicture_Click(object sender, EventArgs e)
        {
            pictureBoxDetectText.Image = null;
            filePath = string.Empty;
        }

        private void btnClearText_Click(object sender, EventArgs e)
        {
            richTextBoxDetectText.Text = null;
        }

        private void buttonTextDetectSaveInTXT_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "txt|*.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    richTextBoxDetectText.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                    MessageBox.Show("Данный результат успешно сохранен", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Данный результат не удалось сохранить", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
