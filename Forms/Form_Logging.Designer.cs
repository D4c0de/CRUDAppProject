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
            Panel_TitleBar = new Panel();
            Label_Title = new Label();
            Button_TitleBar_Minimalize = new Button();
            Button_TitleBar_Maximalize = new Button();
            Button_TtitleBar_ExitProgram = new Button();
            Button_ExitProgram = new Button();
            Button_DeleteProfile = new Button();
            Button_AddNewProfile = new Button();
            Button_ChooseProfile = new Button();
            tableLayoutPanel_Menu = new TableLayoutPanel();
            Panel_TitleBar.SuspendLayout();
            tableLayoutPanel_Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Panel_TitleBar
            // 
            Panel_TitleBar.BackColor = Color.Transparent;
            Panel_TitleBar.Controls.Add(Label_Title);
            Panel_TitleBar.Controls.Add(Button_TitleBar_Minimalize);
            Panel_TitleBar.Controls.Add(Button_TitleBar_Maximalize);
            Panel_TitleBar.Controls.Add(Button_TtitleBar_ExitProgram);
            Panel_TitleBar.Dock = DockStyle.Top;
            Panel_TitleBar.Location = new Point(0, 0);
            Panel_TitleBar.Name = "Panel_TitleBar";
            Panel_TitleBar.Size = new Size(1829, 69);
            Panel_TitleBar.TabIndex = 4;
            Panel_TitleBar.MouseDown += title_bar_MouseDown;
            // 
            // Label_Title
            // 
            Label_Title.AutoSize = true;
            Label_Title.Font = new Font("Segoe UI", 20F);
            Label_Title.ForeColor = Color.White;
            Label_Title.Location = new Point(3, 7);
            Label_Title.Name = "Label_Title";
            Label_Title.Size = new Size(274, 46);
            Label_Title.TabIndex = 3;
            Label_Title.Text = "CRUDAppProject";
            // 
            // Button_TitleBar_Minimalize
            // 
            Button_TitleBar_Minimalize.AutoSize = true;
            Button_TitleBar_Minimalize.BackColor = Color.Transparent;
            Button_TitleBar_Minimalize.Cursor = Cursors.Hand;
            Button_TitleBar_Minimalize.Dock = DockStyle.Right;
            Button_TitleBar_Minimalize.FlatAppearance.BorderSize = 0;
            Button_TitleBar_Minimalize.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Button_TitleBar_Minimalize.FlatStyle = FlatStyle.Flat;
            Button_TitleBar_Minimalize.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Button_TitleBar_Minimalize.ForeColor = Color.White;
            Button_TitleBar_Minimalize.ImageAlign = ContentAlignment.TopCenter;
            Button_TitleBar_Minimalize.Location = new Point(1645, 0);
            Button_TitleBar_Minimalize.Margin = new Padding(0);
            Button_TitleBar_Minimalize.Name = "Button_TitleBar_Minimalize";
            Button_TitleBar_Minimalize.Size = new Size(64, 69);
            Button_TitleBar_Minimalize.TabIndex = 2;
            Button_TitleBar_Minimalize.Text = "–";
            Button_TitleBar_Minimalize.UseVisualStyleBackColor = false;
            Button_TitleBar_Minimalize.Click += btn_min_Click;
            Button_TitleBar_Minimalize.MouseEnter += TitleBar_Button_Enter;
            Button_TitleBar_Minimalize.MouseLeave += TitleBar_Button_Leave;
            // 
            // Button_TitleBar_Maximalize
            // 
            Button_TitleBar_Maximalize.AutoSize = true;
            Button_TitleBar_Maximalize.BackColor = Color.Transparent;
            Button_TitleBar_Maximalize.Cursor = Cursors.Hand;
            Button_TitleBar_Maximalize.Dock = DockStyle.Right;
            Button_TitleBar_Maximalize.FlatAppearance.BorderSize = 0;
            Button_TitleBar_Maximalize.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Button_TitleBar_Maximalize.FlatStyle = FlatStyle.Flat;
            Button_TitleBar_Maximalize.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Button_TitleBar_Maximalize.ForeColor = Color.White;
            Button_TitleBar_Maximalize.ImageAlign = ContentAlignment.TopCenter;
            Button_TitleBar_Maximalize.Location = new Point(1709, 0);
            Button_TitleBar_Maximalize.Margin = new Padding(0);
            Button_TitleBar_Maximalize.Name = "Button_TitleBar_Maximalize";
            Button_TitleBar_Maximalize.Size = new Size(60, 69);
            Button_TitleBar_Maximalize.TabIndex = 1;
            Button_TitleBar_Maximalize.Text = "◱";
            Button_TitleBar_Maximalize.UseVisualStyleBackColor = false;
            Button_TitleBar_Maximalize.Click += btn_max_Click;
            Button_TitleBar_Maximalize.MouseEnter += TitleBar_Button_Enter;
            Button_TitleBar_Maximalize.MouseLeave += TitleBar_Button_Leave;
            // 
            // Button_TtitleBar_ExitProgram
            // 
            Button_TtitleBar_ExitProgram.AutoSize = true;
            Button_TtitleBar_ExitProgram.Cursor = Cursors.Hand;
            Button_TtitleBar_ExitProgram.Dock = DockStyle.Right;
            Button_TtitleBar_ExitProgram.FlatAppearance.BorderSize = 0;
            Button_TtitleBar_ExitProgram.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Button_TtitleBar_ExitProgram.FlatStyle = FlatStyle.Flat;
            Button_TtitleBar_ExitProgram.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Button_TtitleBar_ExitProgram.ForeColor = Color.White;
            Button_TtitleBar_ExitProgram.ImageAlign = ContentAlignment.TopCenter;
            Button_TtitleBar_ExitProgram.Location = new Point(1769, 0);
            Button_TtitleBar_ExitProgram.Margin = new Padding(0);
            Button_TtitleBar_ExitProgram.Name = "Button_TtitleBar_ExitProgram";
            Button_TtitleBar_ExitProgram.Size = new Size(60, 69);
            Button_TtitleBar_ExitProgram.TabIndex = 0;
            Button_TtitleBar_ExitProgram.Text = "x";
            Button_TtitleBar_ExitProgram.TextAlign = ContentAlignment.TopCenter;
            Button_TtitleBar_ExitProgram.UseVisualStyleBackColor = true;
            Button_TtitleBar_ExitProgram.Click += btn_close_Click;
            Button_TtitleBar_ExitProgram.MouseEnter += TitleBar_Button_Enter;
            Button_TtitleBar_ExitProgram.MouseLeave += TitleBar_Button_Leave;
            // 
            // Button_ExitProgram
            // 
            Button_ExitProgram.Anchor = AnchorStyles.None;
            Button_ExitProgram.BackColor = Color.FromArgb(0, 31, 132);
            Button_ExitProgram.Cursor = Cursors.Hand;
            Button_ExitProgram.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_ExitProgram.ForeColor = Color.White;
            Button_ExitProgram.Location = new Point(4, 332);
            Button_ExitProgram.Margin = new Padding(3, 4, 3, 4);
            Button_ExitProgram.Name = "Button_ExitProgram";
            Button_ExitProgram.Size = new Size(971, 100);
            Button_ExitProgram.TabIndex = 8;
            Button_ExitProgram.Text = "Edytuj istniejący semestr";
            Button_ExitProgram.UseVisualStyleBackColor = false;
            Button_ExitProgram.Click += Button_ExitProgram_Click;
            Button_ExitProgram.MouseEnter += Menu_Button_Enter;
            Button_ExitProgram.MouseLeave += Menu_Button_Leave;
            // 
            // Button_DeleteProfile
            // 
            Button_DeleteProfile.Anchor = AnchorStyles.None;
            Button_DeleteProfile.BackColor = Color.FromArgb(0, 31, 132);
            Button_DeleteProfile.Cursor = Cursors.Hand;
            Button_DeleteProfile.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_DeleteProfile.ForeColor = Color.White;
            Button_DeleteProfile.Location = new Point(4, 222);
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
            Button_AddNewProfile.BackColor = Color.FromArgb(0, 31, 132);
            Button_AddNewProfile.Cursor = Cursors.Hand;
            Button_AddNewProfile.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_AddNewProfile.ForeColor = Color.White;
            Button_AddNewProfile.Location = new Point(4, 113);
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
            Button_ChooseProfile.BackColor = Color.FromArgb(0, 31, 132);
            Button_ChooseProfile.Cursor = Cursors.Hand;
            Button_ChooseProfile.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Button_ChooseProfile.ForeColor = Color.White;
            Button_ChooseProfile.Location = new Point(3, 4);
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
            // tableLayoutPanel_Menu
            // 
            tableLayoutPanel_Menu.AutoSize = true;
            tableLayoutPanel_Menu.ColumnCount = 1;
            tableLayoutPanel_Menu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Menu.Controls.Add(Button_ChooseProfile, 0, 0);
            tableLayoutPanel_Menu.Controls.Add(Button_ExitProgram, 0, 3);
            tableLayoutPanel_Menu.Controls.Add(Button_AddNewProfile, 0, 1);
            tableLayoutPanel_Menu.Controls.Add(Button_DeleteProfile, 0, 2);
            tableLayoutPanel_Menu.Location = new Point(451, 211);
            tableLayoutPanel_Menu.Name = "tableLayoutPanel_Menu";
            tableLayoutPanel_Menu.RowCount = 4;
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel_Menu.Size = new Size(979, 437);
            tableLayoutPanel_Menu.TabIndex = 9;
            // 
            // Form_Logging
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(45, 45, 55);
            ClientSize = new Size(1829, 983);
            Controls.Add(tableLayoutPanel_Menu);
            Controls.Add(Panel_TitleBar);
            Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1024, 720);
            Name = "Form_Logging";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Logging";
            Panel_TitleBar.ResumeLayout(false);
            Panel_TitleBar.PerformLayout();
            tableLayoutPanel_Menu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel Panel_TitleBar;
        private Button Button_TitleBar_Minimalize;
        private Button Button_TitleBar_Maximalize;
        private Button Button_TtitleBar_ExitProgram;
        private TextBox textBox1;
        private Label Label_Title;
        private Button Button_ExitProgram;
        private Button Button_DeleteProfile;
        private Button Button_AddNewProfile;
        private Button Button_ChooseProfile;
        private TableLayoutPanel tableLayoutPanel_Menu;
    }
}