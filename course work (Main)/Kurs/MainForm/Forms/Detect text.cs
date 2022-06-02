using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.OCR;
using Emgu.CV.Structure;

namespace MainForm.Forms
{
    public partial class Detect_text : Form
    {
        private string filePath = string.Empty;
        private string lang = string.Empty;
        public Detect_text()
        {
            InitializeComponent();
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
                    btn.ForeColor = Color.White;
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
            Clipboard.SetText(detectTextSave);
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
    }
}
