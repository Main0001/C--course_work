using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.Forms
{
    public partial class Detect_car_numbers : Form
    {
        private string filePath = string.Empty;
        public Detect_car_numbers()
        {
            InitializeComponent();
        }

        private void buttonFileOpen_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = openFileDialog1.ShowDialog();
                if (res == DialogResult.OK)
                {
                    filePath = openFileDialog1.FileName;

                    pictureBoxDetectCarNumbers.Image = Image.FromFile(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCarNumbersDetect_Click(object sender, EventArgs e)
        {

        }

        private void buttonCarNumbersDetectSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG|*.png|JPG|*.jpg";
            ImageFormat format = ImageFormat.Jpeg;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxDetectCarNumbersResult.Image.Save(sfd.FileName, format);
            }
        }

        private void btnClearPicture_Click(object sender, EventArgs e)
        {
            pictureBoxDetectCarNumbers.Image = null;
            filePath = string.Empty;
        }

        private void btnClearPictureResult_Click(object sender, EventArgs e)
        {
            pictureBoxDetectCarNumbersResult.Image = null;
            filePath = string.Empty;
        }
    }
}
