namespace CRUDAppProject.Forms
{
    partial class Form_Logging : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            btn_min = new Button();
            btn_max = new Button();
            btn_close = new Button();
            imageList1 = new ImageList(components);
            Button_ExitProgram = new Button();
            Button_DeleteProfile = new Button();
            Button_AddNewProfile = new Button();
            Button_ChooseProfile = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_min);
            panel1.Controls.Add(btn_max);
            panel1.Controls.Add(btn_close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1829, 40);
            panel1.TabIndex = 4;
            panel1.MouseDown += title_bar_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(162, 28);
            label1.TabIndex = 3;
            label1.Text = "CRUDAppProject";
            // 
            // btn_min
            // 
            btn_min.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_min.AutoSize = true;
            btn_min.BackColor = Color.Transparent;
            btn_min.Cursor = Cursors.Hand;
            btn_min.FlatAppearance.BorderSize = 0;
            btn_min.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_min.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_min.FlatStyle = FlatStyle.Flat;
            btn_min.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_min.ForeColor = Color.Black;
            btn_min.Location = new Point(1689, 0);
            btn_min.Margin = new Padding(0);
            btn_min.Name = "btn_min";
            btn_min.Size = new Size(40, 40);
            btn_min.TabIndex = 2;
            btn_min.Text = "-";
            btn_min.UseVisualStyleBackColor = false;
            btn_min.Click += btn_min_Click;
            btn_min.MouseEnter += TitleBar_Button_Enter;
            btn_min.MouseLeave += TitleBar_Button_Leave;
            // 
            // btn_max
            // 
            btn_max.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_max.AutoSize = true;
            btn_max.BackColor = Color.Transparent;
            btn_max.Cursor = Cursors.Hand;
            btn_max.FlatAppearance.BorderSize = 0;
            btn_max.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_max.FlatStyle = FlatStyle.Flat;
            btn_max.Font = new Font("Segoe UI", 12F);
            btn_max.ForeColor = Color.Black;
            btn_max.Location = new Point(1739, 0);
            btn_max.Margin = new Padding(0);
            btn_max.Name = "btn_max";
            btn_max.Size = new Size(40, 40);
            btn_max.TabIndex = 1;
            btn_max.Text = "▢";
            btn_max.UseVisualStyleBackColor = false;
            btn_max.Click += btn_max_Click;
            btn_max.MouseEnter += TitleBar_Button_Enter;
            btn_max.MouseLeave += TitleBar_Button_Leave;
            // 
            // btn_close
            // 
            btn_close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_close.AutoSize = true;
            btn_close.Cursor = Cursors.Hand;
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Font = new Font("Segoe UI", 12F);
            btn_close.ForeColor = Color.Black;
            btn_close.Location = new Point(1789, 0);
            btn_close.Margin = new Padding(0);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(40, 40);
            btn_close.TabIndex = 0;
            btn_close.Text = "x";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            btn_close.MouseEnter += TitleBar_Button_Enter;
            btn_close.MouseLeave += TitleBar_Button_Leave;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Button_ExitProgram
            // 
            Button_ExitProgram.Anchor = AnchorStyles.None;
            Button_ExitProgram.BackColor = Color.DodgerBlue;
            Button_ExitProgram.Cursor = Cursors.Hand;
            Button_ExitProgram.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_ExitProgram.ForeColor = Color.White;
            Button_ExitProgram.Location = new Point(429, 603);
            Button_ExitProgram.Margin = new Padding(3, 4, 3, 4);
            Button_ExitProgram.Name = "Button_ExitProgram";
            Button_ExitProgram.Size = new Size(971, 100);
            Button_ExitProgram.TabIndex = 8;
            Button_ExitProgram.Text = "Opuść program";
            Button_ExitProgram.UseVisualStyleBackColor = false;
            Button_ExitProgram.Click += Button_ExitProgram_Click;
            Button_ExitProgram.MouseEnter += Menu_Button_Enter;
            Button_ExitProgram.MouseLeave += Menu_Button_Leave;
            // 
            // Button_DeleteProfile
            // 
            Button_DeleteProfile.Anchor = AnchorStyles.None;
            Button_DeleteProfile.BackColor = Color.DodgerBlue;
            Button_DeleteProfile.Cursor = Cursors.Hand;
            Button_DeleteProfile.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_DeleteProfile.ForeColor = Color.White;
            Button_DeleteProfile.Location = new Point(429, 495);
            Button_DeleteProfile.Margin = new Padding(3, 4, 3, 4);
            Button_DeleteProfile.Name = "Button_DeleteProfile";
            Button_DeleteProfile.Size = new Size(971, 100);
            Button_DeleteProfile.TabIndex = 7;
            Button_DeleteProfile.Text = "Usuń istniejacy semestr";
            Button_DeleteProfile.UseVisualStyleBackColor = false;
            Button_DeleteProfile.Click += Button_DeleteProfile_Click_1;
            Button_DeleteProfile.MouseEnter += Menu_Button_Enter;
            Button_DeleteProfile.MouseLeave += Menu_Button_Leave;
            // 
            // Button_AddNewProfile
            // 
            Button_AddNewProfile.Anchor = AnchorStyles.None;
            Button_AddNewProfile.BackColor = Color.DodgerBlue;
            Button_AddNewProfile.Cursor = Cursors.Hand;
            Button_AddNewProfile.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_AddNewProfile.ForeColor = Color.White;
            Button_AddNewProfile.Location = new Point(429, 387);
            Button_AddNewProfile.Margin = new Padding(3, 4, 3, 4);
            Button_AddNewProfile.Name = "Button_AddNewProfile";
            Button_AddNewProfile.Size = new Size(971, 100);
            Button_AddNewProfile.TabIndex = 6;
            Button_AddNewProfile.Text = "Dodaj nowy semestr";
            Button_AddNewProfile.UseVisualStyleBackColor = false;
            Button_AddNewProfile.Click += Button_AddNewProfile_Click;
            Button_AddNewProfile.MouseEnter += Menu_Button_Enter;
            Button_AddNewProfile.MouseLeave += Menu_Button_Leave;
            // 
            // Button_ChooseProfile
            // 
            Button_ChooseProfile.Anchor = AnchorStyles.None;
            Button_ChooseProfile.BackColor = Color.DodgerBlue;
            Button_ChooseProfile.Cursor = Cursors.Hand;
            Button_ChooseProfile.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Button_ChooseProfile.ForeColor = Color.White;
            Button_ChooseProfile.Location = new Point(429, 279);
            Button_ChooseProfile.Margin = new Padding(3, 4, 3, 4);
            Button_ChooseProfile.Name = "Button_ChooseProfile";
            Button_ChooseProfile.Size = new Size(971, 100);
            Button_ChooseProfile.TabIndex = 5;
            Button_ChooseProfile.Text = "Wybierz istniejący semestr";
            Button_ChooseProfile.UseVisualStyleBackColor = false;
            Button_ChooseProfile.Click += Button_ChooseProfile_Click;
            Button_ChooseProfile.MouseEnter += Menu_Button_Enter;
            Button_ChooseProfile.MouseLeave += Menu_Button_Leave;
            // 
            // Form_Logging
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1829, 983);
            Controls.Add(Button_ExitProgram);
            Controls.Add(Button_DeleteProfile);
            Controls.Add(Button_AddNewProfile);
            Controls.Add(Button_ChooseProfile);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1024, 720);
            Name = "Form_Logging";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Logging";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btn_min;
        private Button btn_max;
        private Button btn_close;
        private ImageList imageList1;
        private TextBox textBox1;
        private Label label1;
        private Button Button_ExitProgram;
        private Button Button_DeleteProfile;
        private Button Button_AddNewProfile;
        private Button Button_ChooseProfile;
    }
}