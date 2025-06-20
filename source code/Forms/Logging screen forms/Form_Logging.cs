﻿#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CRUDAppProject.Forms
{
    public partial class Form_Logging : Form
    {
        public Form_Logging()
        {
            InitializeComponent();
            this.Resize += Form_Resize;
            this.Resize += Form_Resize_Center_Buttons;
            this.Resize += Form_Load_Center_Buttons;
            this.Padding = new Padding(2);                        
        }

        //Przycisk zamykania

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Przycisk maksymalizowania
        private void btn_max_Click(object sender, EventArgs e)
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
        // Przycisk minimalizowania
        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Funckaj pozwalajaca na proszuanie oknem

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void title_bar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
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


        private void Button_AddNewProfile_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Form_CreateProfile Screen_CreateProfile = new Form_CreateProfile();
            Screen_CreateProfile.Show();
        }

        private void Button_DeleteProfile_Click_1(object sender, EventArgs e)
        {

            try 
            {
                Form_DeleteProfile Screen_DeleteProfile = new Form_DeleteProfile(); 
                Screen_DeleteProfile.Show(); 
                this.Close();                               
                this.Hide();  
            }

            catch (ArgumentException ex) 
            {
                if (ex.ParamName == "CRUDADirectoryDoesNotExist")
                    MessageBox.Show("Żaden profil nie został nigdy utworzony!", "Usuwanie profilu nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "NoProfilesFound")
                    MessageBox.Show("Brak zapisanych profili w systemie!", "Usuwanie profilu nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_EditProfile_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_ChooseProfile_Click(object sender, EventArgs e)
        {
            try
            {
                Form_ChooseProfile Screen_ChooseProfile = new Form_ChooseProfile();
                Screen_ChooseProfile.Show();
                this.Close();
                this.Hide();
            }

            catch (ArgumentException ex)
            {
                if (ex.ParamName == "CRUDADirectoryDoesNotExist")
                    MessageBox.Show("Żaden profil nie został nigdy utworzony!", "Usuwanie profilu nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "NoProfilesFound")
                    MessageBox.Show("Brak zapisanych profili w systemie!", "Usuwanie profilu nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //zmiana koloru czcionki po najechaniu
        private void TitleBar_Button_Enter(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.ForeColor = Color.FromArgb(0, 61, 162);
        }
        
        private void TitleBar_Button_Leave(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.ForeColor = Color.White;
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
        //Funckja centrujaca przyciski
        private void Center_Buttons()
        {
            int x = (this.ClientSize.Width - tableLayoutPanel_Menu.Width) / 2;
            int y = (this.ClientSize.Height - tableLayoutPanel_Menu.Height) / 2;
            tableLayoutPanel_Menu.Location = new Point(x, y);
        }
        //event ktory centruje przyciski onLoad
        private void Form_Load_Center_Buttons(object? sender, EventArgs e)
        {
            Center_Buttons();
        }
        //event ktory centruje przyciski podczas zmiany rozmiaru okna
        private void Form_Resize_Center_Buttons(object? sender, EventArgs e)
        {
            Center_Buttons();
        }



    }
}
