using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.Forms
{
    public partial class Detect_pedestrian : Form
    {
        private VideoCapture capture = null; // отвечает за видео
        private double frames; // кадры видео (общее количество)
        private double framesCounter; // текущий кадр видео
        private double fps; // частота кадров
        private bool play;
        public Detect_pedestrian()
        {
            InitializeComponent();
        }
        private Image<Bgr, byte> FindPedestrian(Image<Bgr, byte> image)
        {
            MCvObjectDetection[] regions;
            using (HOGDescriptor descriptor = new HOGDescriptor())
            {
                descriptor.SetSVMDetector(HOGDescriptor.GetDefaultPeopleDetector()); //Получаем детектор людей
                regions = descriptor.DetectMultiScale(image); // получаем найденных людей в масиив объектов
            }

            foreach(MCvObjectDetection pesh in regions)
            {
                image.Draw(pesh.Rect, new Bgr(Color.Red), 3);
                CvInvoke.PutText(image, "Pedestrian", new Point(pesh.Rect.X, pesh.Rect.Y), Emgu.CV.CvEnum.FontFace.HersheyPlain, 1, new MCvScalar(255, 255, 255), 2);
            }
            return image;
        }
        private async void ReadFrames()
        {
            Mat m = new Mat();
            while(play && framesCounter < frames)
            {
                framesCounter += 1;
                capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, framesCounter); // свойство для работы с кадрами и их перемоткой (привязывает значение кадров к видео)
                capture.Read(m);

                pictureBoxDetectPedestrian.Image = m.Bitmap;
                pictureBoxDetectPedestrianResult.Image = FindPedestrian(m.ToImage<Bgr, byte>()).Bitmap; //выводим каждый кадр (картинку) с обнаруженными пешеходами (для этого в каждом кадре вызываем метод обнаруежния пешеходов)

                labelFrames.Text = $"{framesCounter} / {frames}"; //счетчик кадров

                await Task.Delay(1000 / Convert.ToInt16(fps)); //без этого программа зависает, также нужно для задержки между кадрами, чтобы мы могли видеть их воспроизведение

                if (framesCounter < 0)
                {
                    framesCounter = 0;
                }
                else if (framesCounter == frames - 1)
                {
                    framesCounter = 0;
                    play = true;
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
                    capture = new VideoCapture(openFileDialog1.FileName);
                    Mat m = new Mat();

                    capture.Read(m); // считываем видео (картинка)
                    pictureBoxDetectPedestrian.Image = m.Bitmap; //Устанавливает картинку (первый кадр)

                    fps = capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps); // получаем частоту кадров
                    frames = capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount); // получаем количество кадров
                    framesCounter = 1; //текущий кадр = 1

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPedestrianDetect_Click(object sender, EventArgs e)
        {
            try
            {
                if(capture == null)
                {
                    throw new Exception("Видео не выбрано");
                }
                else
                {
                    play = true;

                    ReadFrames();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnbtnPauseVideo_Click(object sender, EventArgs e)
        {
            try
            {
                play = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRewindBack_Click(object sender, EventArgs e)
        {
            try
            {
                framesCounter -= Convert.ToDouble(numericUpDownFrames.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRewindForward_Click(object sender, EventArgs e)
        {
            try
            {
                framesCounter += Convert.ToDouble(numericUpDownFrames.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Detect_pedestrian_FormClosed(object sender, FormClosedEventArgs e)
        {
            play = false;
        }
    }
}
