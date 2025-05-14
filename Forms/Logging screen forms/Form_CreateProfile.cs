using CRUDAppProject.CS.Base;
using CRUDAppProject.CS.Interfaces;
using CRUDAppProject.CS.Side;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDAppProject.Forms
{
    public partial class Form_CreateProfile : Form
    {
        public Form_CreateProfile()
        {
            this.Resize += Form_Resize;
            this.Resize += Form_Resize_Center_Menu;
            this.Resize += Form_Load_Center_Menu;
            InitializeComponent();
            Panel_TitleBar.BringToFront();
        }

        private void Button_CreateProfile_Click(object sender, EventArgs e)
        {
            Base_SemestrProfile Profile = new Base_SemestrProfile();

            Profile.Name = TextBox_ProfileName.Text;

            Profile.ListOfSubjects = Side_Format.CutIntoSingleWords(RichTextBox_ListOfSubjects.Text);


            try
            {
                Profile.SaveDataToFile();

                // Jeśli wszystko ok - cofnij się do głównego ekranu logowania

                this.Close();
                this.Hide();
                Form_Logging form_Logging = new Form_Logging();
                form_Logging.Show();
            }


            // Obsłuż wyjątek, w którym lista jest pusta (bo to jedyny wyjątek jaki wyrzucamy)
            // Profil nie ma żadnej nazwy tylko działa
            catch (ArgumentException ex)
            {
                if (ex.ParamName == "FileAlreadyExists")
                {
                    MessageBox.Show(ex.Message, "Nazwy profili nie mogą się powtarzać.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (ex.ParamName == "EmptyListOfSubjects")
                {
                    MessageBox.Show(ex.Message, "Lista nie może być pusta.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (ex.ParamName == "NullOrEmptyFileName")
                {
                    MessageBox.Show(ex.Message, "Nazwa profilu nie może być pusta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void Button_ExitProfileCreator_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();

            Form_Logging Screen_Logging = new Form_Logging();
            Screen_Logging.Show();
        }

        //Rysowanie obramowki
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int borderThickness = 2;

            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
                Color.FromArgb(0, 61, 162), borderThickness, ButtonBorderStyle.Solid,
                Color.FromArgb(0, 61, 162), borderThickness, ButtonBorderStyle.Solid,
                Color.FromArgb(0, 61, 162), borderThickness, ButtonBorderStyle.Solid,
                Color.FromArgb(0, 61, 162), borderThickness, ButtonBorderStyle.Solid);
        }
        private void Form_Resize(object? sender, EventArgs e)
        {

            this.Invalidate();
        }
        //zmiana koloru czcionki po najechaniu
        private void TitleBar_Button_Enter(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.ForeColor = Color.DodgerBlue;
        }
        //zmiana koloru czcionki  na bazowy kolor
        private void TitleBar_Button_Leave(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.ForeColor = Color.White;
        }
        // Funkcja pozwalajaca na resizing okna
        protected override void WndProc(ref Message m)
        {
            const int RESIZE_HANDLE_SIZE = 10;
            const int WM_NCHITTEST = 0x84;
            const int HTCLIENT = 1;
            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;

            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);
                Point cursor = this.PointToClient(Cursor.Position);

                if (cursor.X <= RESIZE_HANDLE_SIZE)
                {
                    if (cursor.Y <= RESIZE_HANDLE_SIZE)
                        m.Result = (IntPtr)HTTOPLEFT;
                    else if (cursor.Y >= this.ClientSize.Height - RESIZE_HANDLE_SIZE)
                        m.Result = (IntPtr)HTBOTTOMLEFT;
                    else
                        m.Result = (IntPtr)HTLEFT;
                }
                else if (cursor.X >= this.ClientSize.Width - RESIZE_HANDLE_SIZE)
                {
                    if (cursor.Y <= RESIZE_HANDLE_SIZE)
                        m.Result = (IntPtr)HTTOPRIGHT;
                    else if (cursor.Y >= this.ClientSize.Height - RESIZE_HANDLE_SIZE)
                        m.Result = (IntPtr)HTBOTTOMRIGHT;
                    else
                        m.Result = (IntPtr)HTRIGHT;
                }
                else if (cursor.Y <= RESIZE_HANDLE_SIZE)
                {
                    m.Result = (IntPtr)HTTOP;
                }
                else if (cursor.Y >= this.ClientSize.Height - RESIZE_HANDLE_SIZE)
                {
                    m.Result = (IntPtr)HTBOTTOM;
                }
                else
                {
                    m.Result = (IntPtr)HTCLIENT;
                }

                return;
            }

            base.WndProc(ref m);
        }
        // Funckaj pozwalajaca na proszuanie oknem

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Panel_TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Przycisk minimalizowania

        private void Button_TitleBar_Minimalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Przycisk maksymalizowania
        private void Button_TitleBar_Maximalize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {

                this.WindowState = FormWindowState.Normal;
            }
            else
            {

                this.WindowState = FormWindowState.Maximized;
            }
        }
        //Przycisk zamykania
        private void Button_TtitleBar_ExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //zmiana koloru przycisku po najechaniu
        private void Menu_Button_Enter(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = Color.FromArgb(0, 61, 162);
        }

        private void Menu_Button_Leave(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = Color.FromArgb(0, 31, 132);
        }


        private void RichTextBox_ListOfSubjects_Click(object sender, EventArgs e)
        {
            RichTextBox_ListOfSubjects.ForeColor = Color.White;
            RichTextBox_ListOfSubjects.Text = "";
        }

        private void TextBox_ProfileName_Click(object sender, EventArgs e)
        {
            TextBox_ProfileName.ForeColor = Color.White;
            TextBox_ProfileName.Text = "";
        }

        //Funckja centrujaca przyciski
        private void Center_Menu()
        {
            int x = (this.ClientSize.Width - tableLayoutPanel_Menu.Width) / 2;
            int y = (this.ClientSize.Height - tableLayoutPanel_Menu.Height) / 2;
            tableLayoutPanel_Menu.Location = new Point(x, y);
        }
        //event ktory centruje przyciski onLoad
        private void Form_Load_Center_Menu(object? sender, EventArgs e)
        {
            Center_Menu();
        }
        //event ktory centruje przyciski podczas zmiany rozmiaru okna
        private void Form_Resize_Center_Menu(object? sender, EventArgs e)
        {
            Center_Menu();
        }
    }

}
