using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace MainForm.Forms
{
    public partial class Detect_geometric_shapes : Form
    {
        private Image<Bgr, byte> inputImage = null;
        private int count = 0;
        private string filePath = string.Empty;
        public Detect_geometric_shapes()
        {
            InitializeComponent();
        }
        private void Detect_geometric_shapes_Load(object sender, EventArgs e)
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
                    inputImage = new Image<Bgr, byte>(filePath);
                    pictureBoxDetectGeometricShapes.Image = inputImage.Bitmap;
                    count = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGeometricShapesDetect_Click(object sender, EventArgs e)
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
                    Image<Gray, byte> grayImage = inputImage.SmoothGaussian(5).Convert<Gray, byte>().ThresholdBinaryInv(new Gray(230), new Gray(255)); //Размытие по гаусу, затем конвертация в оттенки серого, затем инвертация цветов (оттенков серого)
                    VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
                    Mat hierarchy = new Mat();

                    CvInvoke.FindContours(grayImage, contours, hierarchy, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple); //Emgu.CV.CvEnum.RetrType.External - только внешние контуры
                    if (count <= 1)
                    {
                        for (int i = 0; i < contours.Size; i++)
                        {
                            double perimeter = CvInvoke.ArcLength(contours[i], true); //Определеяет периметр элемента контура, true - кривая замкнутая (пример = круг)
                            VectorOfPoint approximation = new VectorOfPoint(); //апроксимация контура - разложение кривой на набор прямых отрезков

                            CvInvoke.ApproxPolyDP(contours[i], approximation, 0.04 * perimeter, true); //0.04 - точность апроксимации контуров
                            CvInvoke.DrawContours(inputImage, contours, i, new MCvScalar(0, 0, 255), 2); //2 - толщина линии

                            Moments moments = CvInvoke.Moments(contours[i]); //вычисляет пространственные и центральные моменты (грубо говоря с помощью моментов узнаем координаты фигур)

                            int x = (int)(moments.M10 / moments.M00); //пространственные моменты (какие моменты брать - смотреть в интернете) (нужны для вычисления координат)
                            int y = (int)(moments.M01 / moments.M00);
                            if (approximation.Size == 3)
                            {
                                CvInvoke.PutText(inputImage, "Triangle", new Point(x, y), Emgu.CV.CvEnum.FontFace.HersheyPlain, 1, new MCvScalar(0, 0, 0), 1);
                            }
                            else if (approximation.Size == 4)
                            {
                                Rectangle rect = CvInvoke.BoundingRectangle(contours[i]); //возвращает верхний правый ограничивающий прямоугольник для набора 2d точек (получаем rect.Width и rect.Height)
                                double aspectRatio = (double)rect.Width / rect.Height; //хранит соотношение сторон (если примерно 1.0, то квадрат, иначе прямоугольгник) (соотношение сторон - одну сторону поделить на другую (rect.Width / rect.Height))

                                if (aspectRatio > 0.95 && aspectRatio < 1.05)
                                {
                                    CvInvoke.PutText(inputImage, "Square", new Point(x, y), Emgu.CV.CvEnum.FontFace.HersheyPlain, 1, new MCvScalar(0, 0, 0), 1);
                                }
                                else
                                {
                                    CvInvoke.PutText(inputImage, "Rectangle", new Point(x, y), Emgu.CV.CvEnum.FontFace.HersheyPlain, 1, new MCvScalar(0, 0, 0), 1);
                                }
                            }
                            else if (approximation.Size == 5)
                            {
                                CvInvoke.PutText(inputImage, "Pentagon", new Point(x, y), Emgu.CV.CvEnum.FontFace.HersheyPlain, 1, new MCvScalar(0, 0, 0), 1);
                            }
                            else if (approximation.Size == 6)
                            {
                                CvInvoke.PutText(inputImage, "Hexagon", new Point(x, y), Emgu.CV.CvEnum.FontFace.HersheyPlain, 1, new MCvScalar(0, 0, 0), 1);
                            }
                            else if (approximation.Size > 6)
                            {
                                CvInvoke.PutText(inputImage, "Circle", new Point(x, y), Emgu.CV.CvEnum.FontFace.HersheyPlain, 1, new MCvScalar(0, 0, 0), 1);
                            }
                            pictureBoxDetectGeometricShapes.Image = inputImage.Bitmap;
                        }
                    }
                    else
                    {
                        pictureBoxDetectGeometricShapes.Image = inputImage.Bitmap;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGeometricShapesDetectSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG|*.png|JPG|*.jpg";
            ImageFormat format = ImageFormat.Jpeg;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxDetectGeometricShapes.Image.Save(sfd.FileName, format);
            }
        }

        private void btnClearPicture_Click(object sender, EventArgs e)
        {
            pictureBoxDetectGeometricShapes.Image = null;
            filePath = string.Empty;
            count = 0;
        }
    }
}
