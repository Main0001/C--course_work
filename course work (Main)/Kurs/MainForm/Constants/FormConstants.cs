using System.Drawing;
using System.Drawing.Imaging;

namespace MainForm.Constants
{
    internal class FormConstants
    {
        /////////////////BASE////////////////////
        public const int WIDTH = 847;
        public const int HEIGHT = 463;
        public const int COUNT = 0;

        public const int INCREASED_WIDTH = 1325;
        public const int INCREASED_HEIGHT = 502;

        static public Color BUTTON_DEFAULT_BACKGROUND_COLOR = Color.FromArgb(51, 51, 76);
        static public Color BUTTON_DEFAULT_FORE_COLOR = Color.Gainsboro;
        static public Font BUTTON_DEFAULT_FONT = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

        static public Font BUTTON_ACTIVATE_FONT = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        static public Color BUTTON_ACTIVATE_FORE_COLOR = Color.White;

        static public Color PANEL_TITLE_BAR_BACKGROUND_COLOR = Color.FromArgb(0, 150, 136);
        static public Color PANEL_LOGO_BACKGROUND_COLOR = Color.FromArgb(39, 39, 58);
        //////////////////////////////////////////OTHER///////////////////////////////////////
        public const string FILTER = "PNG|*.png|JPG|*.jpg";
        static public ImageFormat FORMAT = ImageFormat.Jpeg;
    }
}
