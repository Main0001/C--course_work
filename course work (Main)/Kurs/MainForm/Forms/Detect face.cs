using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace MainForm.Forms
{
    public partial class Detect_face : Form
    {
        private static CascadeClassifier classifier = new CascadeClassifier(@"XmlWeights\haarcascade_frontalface_alt_tree.xml");
        private string filePath = string.Empty;
        public Detect_face()
        {
            InitializeComponent();
        }
        private void Detect_Face_Load(object sender, EventArgs e)
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

                    pictureBoxDetectFace.Image = Image.FromFile(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFaceDetect_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath) || String.IsNullOrWhiteSpace(filePath))
                {
                    throw new Exception("Картинка не выбрана!");
                }
                else if (comboBoxObjectDetect.SelectedItem == null)
                {
                    throw new Exception("Не выбран тип объекта!");
                }
                else
                {
                    var bitmap = new Bitmap(pictureBoxDetectFace.Image);
                    Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);
                    Rectangle[] faces = classifier.DetectMultiScale(grayImage, 1.4, 0); //1.4 - увеличение изображения на 40% (1.0 - 0%)

                    foreach (Rectangle face in faces)
                    {
                        using (Graphics graphics = Graphics.FromImage(bitmap)) // используем Graphics для рисования прямоугольников
                        {
                            using (Pen pen = new Pen(Color.Yellow, 3)) //создаем кисточку, которой будем рисовать (3 - толщина)
                            {
                                graphics.DrawRectangle(pen, face);
                            }
                        }
                    }
                    pictureBoxDetectFace.Image = bitmap;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonFaceDetectSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG|*.png|JPG|*.jpg";
            ImageFormat format = ImageFormat.Jpeg;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxDetectFace.Image.Save(sfd.FileName, format);
            }
        }

        private void btnClearPicture_Click(object sender, EventArgs e)
        {
            pictureBoxDetectFace.Image = null;
            filePath = string.Empty;
        }

        private void comboBoxObjectDetect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxObjectDetect.SelectedIndex == 0)
            {
                classifier = new CascadeClassifier(@"XmlWeights\haarcascade_frontalface_alt_tree.xml");
            }
            else if (comboBoxObjectDetect.SelectedIndex == 1)
            {
                classifier = new CascadeClassifier(@"XmlWeights\haarcascade_fullbody.xml");
            }
            else if (comboBoxObjectDetect.SelectedIndex == 2)
            {
                classifier = new CascadeClassifier(@"XmlWeights\haarcascade_eye_tree_eyeglasses.xml");
            }
        }
    }
}
