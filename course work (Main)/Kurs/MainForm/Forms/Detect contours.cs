using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace MainForm.Forms
{
    public partial class Detect_contours : Form
    {
        private Image<Bgr, byte> inputImage = null;
        private string filePath = string.Empty;
        private int count = 0;
        public Detect_contours()
        {
            InitializeComponent();
        }

        private void Detect_contours_Load(object sender, EventArgs e)
        {
            LoadTheme();
            checkBoxContoursBlackBackground.Text = "Show contours in the black" + "\r\n" + "background";
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls) //panelMenu.Controls - возвращает все управляющие элементы (кнопки, радиобаттоны и т.д.)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor; //Присвоит дефолтный бэкграунд кнопке
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
                    inputImage = new Image<Bgr, byte>(openFileDialog1.FileName);

                    pictureBoxDetectContours.Image = inputImage.Bitmap; // .Bitmap - преобразует изображение в растровое
                    count = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonContoursDetect_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath) || String.IsNullOrWhiteSpace(filePath))
                {
                    throw new Exception("Картинка не выбрана!");
                }
                else
                {
                    count++;

                    Image<Gray, byte> outputImage = inputImage.Convert<Gray, byte>().ThresholdBinary(new Gray(100), new Gray(255)); //конвертируем наше изображение под класс Image<Gray, byte>, затем преобразуем изображение в оттенки серого, чтобы убрать лишний шум (улучшает работу машины) ThresholdBinary

                    VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint(); // создаем вектора для контуров

                    Mat hierarchy = new Mat(); // хранение иерархии чисел точек изображения (пикселей)

                    CvInvoke.FindContours(outputImage, contours, hierarchy, Emgu.CV.CvEnum.RetrType.Tree, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple); //Emgu.CV.CvEnum.RetrType.Tree - режим поиска и режим отображения контуров (Tree - ищет все конутры и восстанавливает иерархию вложенных контуров); Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple - режим отрисовки контуров (ChainApproxSimple - отрисовывает по точкам старого контура новый контур)

                    if (checkBoxContoursBlackBackground.Checked)
                    {
                        Image<Gray, byte> blackBackground = new Image<Gray, byte>(inputImage.Width, inputImage.Height, new Gray(0));
                        CvInvoke.DrawContours(blackBackground, contours, -1, new MCvScalar(255, 0, 0), 3); // -1 - отрисовка всех найденных контуров
                        pictureBoxDetectContours.Image = blackBackground.Bitmap;
                    }
                    else
                    {
                        if (count <= 1)
                        {
                            CvInvoke.DrawContours(inputImage, contours, -1, new MCvScalar(255, 0, 0), 3);
                            pictureBoxDetectContours.Image = inputImage.Bitmap;

                        }
                        else
                        {
                            pictureBoxDetectContours.Image = inputImage.Bitmap;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonContoursSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG|*.png|JPG|*.jpg";
            ImageFormat format = ImageFormat.Jpeg;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxDetectContours.Image.Save(sfd.FileName, format);
            }
        }

        private void btnClearPicture_Click(object sender, EventArgs e)
        {
            pictureBoxDetectContours.Image = null;
            count = 0;
            filePath = string.Empty;
        }
    }
}
