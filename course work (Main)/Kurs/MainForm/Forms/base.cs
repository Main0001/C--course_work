using MainForm.Constants;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MainForm
{
    public partial class MainForm : Form
    {
        //Поля
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //конструктор
        public MainForm()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] //юзаем длл для возможности передвижения формы мышкой
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Методы
        private Color SelectThemeColor() // тема при нажатии кнопок
        {
            int index = random.Next(ThemeColor.colorList.Count); // получаем случайный цвет из массива цветов
            while(tempIndex == index)
            {
                index = random.Next(ThemeColor.colorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.colorList[index];
            return ColorTranslator.FromHtml(color); //получаем цвета из нашего массива с преобразованием из #...
        }
        private void ActivateButton(object btnSender) //конфигурация цветов кнопки (а также шрифта кнопки) при нажатии
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls) //panelMenu.Controls - возвращает все управляющие элементы (кнопки, радиобаттоны и т.д.)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51,51,76); //Присвоит дефолтный бэкграунд кнопке
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender) //свойства открытия формы (не главной страницы)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            var sec = childForm.Text.Split(' ');
            childForm.Text = "";
            for (int i = 0; i < sec.Length; i++)
            {
                childForm.Text += sec[i] + " "; 
            }

            labelDetectTitle.Text = childForm.Text;
        }
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            labelDetectTitle.Text = "Home page";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnDetectFace_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Detect_face(), sender);
            base.Width = FormConstants.WIDTH;
            base.Height = FormConstants.HEIGHT;
            base.MinimumSize = new System.Drawing.Size(FormConstants.WIDTH, FormConstants.HEIGHT);
        }
        private void btnDetectContours_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Detect_contours(), sender);
            base.Width = FormConstants.WIDTH;
            base.Height = FormConstants.HEIGHT;
            base.MinimumSize = new System.Drawing.Size(FormConstants.WIDTH, FormConstants.HEIGHT);
        }

        private void btnDetectGeometricShapes_Click(object sender, EventArgs e)
        {

            this.MinimumSize = new System.Drawing.Size(FormConstants.WIDTH, FormConstants.HEIGHT);
            this.Width = FormConstants.WIDTH;
            this.Height = FormConstants.HEIGHT;
            OpenChildForm(new Forms.Detect_geometric_shapes(), sender);
        }

        private void btnDetectText_Click(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(1325, 502);
            this.Width = 1325;
            this.Height = 502;
            OpenChildForm(new Forms.Detect_text(), sender);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            base.Width = FormConstants.WIDTH;
            base.Height = FormConstants.HEIGHT;
            base.MinimumSize = new System.Drawing.Size(FormConstants.WIDTH, FormConstants.HEIGHT);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(1325, 502);
            this.Width = 1325;
            this.Height = 502;
            OpenChildForm(new Forms.Detect_pedestrian(), sender);
        }
    }
}
