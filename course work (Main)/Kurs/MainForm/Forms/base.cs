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
                    currentButton.Font = FormConstants.BUTTON_ACTIVATE_FONT;
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
                    previousBtn.BackColor = FormConstants.BUTTON_DEFAULT_BACKGROUND_COLOR; //Присвоит дефолтный бэкграунд кнопке
                    previousBtn.ForeColor = FormConstants.BUTTON_DEFAULT_FORE_COLOR;
                    previousBtn.Font = FormConstants.BUTTON_DEFAULT_FONT;
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
            labelDetectTitle.Text = "Главная страница";
            panelTitleBar.BackColor = FormConstants.PANEL_TITLE_BAR_BACKGROUND_COLOR;
            panelLogo.BackColor = FormConstants.PANEL_LOGO_BACKGROUND_COLOR;
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void MainForm_Load(object sender, EventArgs e)
        {
            base.MinimumSize = new System.Drawing.Size(FormConstants.WIDTH, FormConstants.HEIGHT);
            base.Width = FormConstants.WIDTH;
            base.Height = FormConstants.HEIGHT;
        }
        private void btnDetectObjects_Click(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(FormConstants.WIDTH, FormConstants.HEIGHT);
            this.Width = FormConstants.WIDTH;
            this.Height = FormConstants.HEIGHT;
            OpenChildForm(new Forms.Detect_objects(), sender);
        }
        private void btnDetectContours_Click(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(FormConstants.WIDTH, FormConstants.HEIGHT);
            this.Width = FormConstants.WIDTH;
            this.Height = FormConstants.HEIGHT;
            OpenChildForm(new Forms.Detect_contours(), sender);
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
            this.MinimumSize = new System.Drawing.Size(FormConstants.INCREASED_WIDTH, FormConstants.INCREASED_HEIGHT);
            this.Width = FormConstants.INCREASED_WIDTH;
            this.Height = FormConstants.INCREASED_HEIGHT;
            OpenChildForm(new Forms.Detect_text(), sender);
        }

        private void buttonDetectPedestrian_Click(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(FormConstants.INCREASED_WIDTH, FormConstants.INCREASED_HEIGHT);
            this.Width = FormConstants.INCREASED_WIDTH;
            this.Height = FormConstants.INCREASED_HEIGHT;
            OpenChildForm(new Forms.Detect_pedestrian(), sender);
        }

        private void buttonAboutProgram_Click(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(FormConstants.WIDTH, FormConstants.HEIGHT);
            this.Width = FormConstants.WIDTH;
            this.Height = FormConstants.HEIGHT;
            OpenChildForm(new Forms.About_program(), sender);
        }
    }
}
