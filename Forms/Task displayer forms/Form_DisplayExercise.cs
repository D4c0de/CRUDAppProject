using CRUDAppProject.CS.Base;
using CRUDAppProject.CS.Tasks;
using CRUDAppProject.Forms.Task_editor_forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDAppProject.Forms.Task_display_forms
{
    partial class Form_DisplayExercise : Form
    {
        Task_Exercise ActiveTask = new Task_Exercise();

        private void FillAllTextBoxes(Task_Exercise task)
        {
            TextBox_TaskTitle.Text = task.Title;
            TextBox_ShortDescription.Text = task.ShortDescription;
            TextBox_TaskSubject.Text = task.ChosenSubject;
            RichTextBox_TaskDescription.Text = task.Description;
            TextBox_TaskDeadline.Text = task.Deadline.ToShortDateString();
            RichTextBox_TaskSource.Text = task.TaskSource;
        }

        public Form_DisplayExercise(Task_Exercise task)
        {
            this.Resize += Form_Resize;
            this.Resize += Form_Load_Center_Menu;
            this.Resize += Form_Load_Center_Menu;
            InitializeComponent();
            ActiveTask = task;
            FillAllTextBoxes(ActiveTask);
        }

        private void Button_ExitExerciseDisplayer_Click(object sender, EventArgs e)
        {            
            this.Hide();
            this.Close();
            Form_LoggedIn screenLoggedIn = new Form_LoggedIn();
            screenLoggedIn.Show();
        }

        private void Button_EditTask_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form_EditExercise screenEditExercise = new Form_EditExercise(ActiveTask);
            screenEditExercise.Show();
        }

        private void Button_RemoveTask_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Czy na pewno chcesz usunąć to zadanie?",
                "Potwierdzenie usunięcia",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.OK)
            {
                ActiveTask.RemoveTask();
                this.Hide();
                this.Close();
                Form_LoggedIn screenLoggedIn = new Form_LoggedIn();
                screenLoggedIn.Show();
            }
           
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
    }
}
