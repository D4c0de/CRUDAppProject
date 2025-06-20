﻿using CRUDAppProject.CS.Base;
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
    public partial class Form_DeleteProfile : Form
    {
        public Form_DeleteProfile()
        {
            InitializeComponent();
            this.Resize += Form_Resize;
            this.Resize += Form_Resize_Center_Menu;
            this.Resize += Form_Load_Center_Menu;
            Panel_TitleBar.BringToFront();            
            Base_SemestrProfile.LoadAllProfilesFromFile(ComboBox_ProfileName);
        }


        private void Button_ExitProfileDeletion_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Form_Logging Screen_Logging = new Form_Logging();
            Screen_Logging.Show();
        }


        /// <summary>
        /// Logika usunięcia i usunięcie wybranego profilu 
        /// </summary>
        /// <exception cref="ArgumentException"></exception>

        private void DeleteProfileFromFolder()
        {
            string pathOfProfileToDelete = $"{Base_SemestrProfile.CrudaFolderPath}\\{Side_Format.CapitalizeString(TextBox_RewriteProfileName.Text)}.json";

            if (Base_SemestrProfile.ListOfAllProfiles.Contains(pathOfProfileToDelete) && ComboBox_ProfileName.Text == Side_Format.CapitalizeString(TextBox_RewriteProfileName.Text))
            {
                File.Delete(pathOfProfileToDelete);
                MessageBox.Show("Usuwanie profilu powiodło się.", "Usuwanie profilu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                this.Close();
            }

            else if (!Base_SemestrProfile.ListOfAllProfiles.Contains(pathOfProfileToDelete))
                throw new ArgumentException("Nie znaleziono profilu!", "ProfileNotFound");


            else if (Base_SemestrProfile.ListOfAllProfiles.Contains(pathOfProfileToDelete) && ComboBox_ProfileName.Text != Side_Format.CapitalizeString(TextBox_RewriteProfileName.Text))
                throw new ArgumentException("Nazwy się nie zgadzają!", "NamesDoNotMatch");
        }


        private void Button_ConfirmProfileDeletion_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteProfileFromFolder();
                Form_Logging Screen_Logging = new Form_Logging();
                Screen_Logging.Show();
            }

            catch (ArgumentException ex)
            {
                if (ex.ParamName == "ProfileNotFound")
                    MessageBox.Show("Profil który chcesz usunać nie istnieje!", "Usuwanie profilu nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "NamesDoNotMatch")
                    MessageBox.Show("Nazwa profilu do usunięcia nie zgadza się z wpisaną frazą!", "Usuwanie profilu nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_DeleteProfile_Load(object sender, EventArgs e)
        {

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
        //zmiana koloru czcionki po najechaniu
        private void TitleBar_Button_Enter(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.ForeColor = Color.FromArgb(0, 61, 162);
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

    }
}
