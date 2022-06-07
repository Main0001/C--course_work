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
        private VideoCapture capture = null;
        private double frames;
        private double framesCounter;
        private double fps;
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
                descriptor.SetSVMDetector(HOGDescriptor.GetDefaultPeopleDetector());
                regions = descriptor.DetectMultiScale(image);
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
                capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, framesCounter);
                capture.Read(m);

                pictureBoxDetectPedestrian.Image = m.Bitmap;
                pictureBoxDetectPedestrianResult.Image = FindPedestrian(m.ToImage<Bgr, byte>()).Bitmap;

                labelFrames.Text = $"{framesCounter} / {frames}";

                await Task.Delay(1000 / Convert.ToInt16(fps));
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

                    capture.Read(m);
                    pictureBoxDetectPedestrian.Image = m.Bitmap;

                    fps = capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps);
                    frames = capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount);
                    framesCounter = 1;

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

        private void btnbtnWatchVideo_Click(object sender, EventArgs e)
        {
            try
            {
                if (capture == null)
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
    }
}
