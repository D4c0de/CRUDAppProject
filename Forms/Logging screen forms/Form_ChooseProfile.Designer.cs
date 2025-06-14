namespace CRUDAppProject.Forms
{
    partial class Form_ChooseProfile
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
            Label_WelcomeMessage = new Label();
            Label_ProfileName = new Label();
            ComboBox_ProfileName = new ComboBox();
            Button_LogIn = new Button();
            Button_ExitProfileChoosing = new Button();
            Panel_TitleBar = new Panel();
            Label_Title = new Label();
            Button_TitleBar_Minimalize = new Button();
            Button_TitleBar_Maximalize = new Button();
            Button_TtitleBar_ExitProgram = new Button();
            tableLayoutPanel_Menu = new TableLayoutPanel();
            Panel_TitleBar.SuspendLayout();
            tableLayoutPanel_Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Label_WelcomeMessage
            // 
            Label_WelcomeMessage.Anchor = AnchorStyles.None;
            Label_WelcomeMessage.AutoSize = true;
            Label_WelcomeMessage.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            Label_WelcomeMessage.ForeColor = Color.White;
            Label_WelcomeMessage.Location = new Point(335, 34);
            Label_WelcomeMessage.Name = "Label_WelcomeMessage";
            Label_WelcomeMessage.Size = new Size(454, 48);
            Label_WelcomeMessage.TabIndex = 0;
            Label_WelcomeMessage.Text = "Wybór profilu semestru";
            // 
            // Label_ProfileName
            // 
            Label_ProfileName.Anchor = AnchorStyles.None;
            Label_ProfileName.AutoSize = true;
            Label_ProfileName.Font = new Font("Arial Black", 17F, FontStyle.Bold);
            Label_ProfileName.ForeColor = Color.White;
            Label_ProfileName.Location = new Point(84, 153);
            Label_ProfileName.Name = "Label_ProfileName";
            Label_ProfileName.Size = new Size(956, 41);
            Label_ProfileName.TabIndex = 1;
            Label_ProfileName.Text = "Wybierz profil z listy poniżej na który chcesz się zalogować";
            // 
            // ComboBox_ProfileName
            // 
            ComboBox_ProfileName.Anchor = AnchorStyles.None;
            ComboBox_ProfileName.BackColor = Color.FromArgb(25, 25, 35);
            ComboBox_ProfileName.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_ProfileName.Font = new Font("Segoe UI", 15F);
            ComboBox_ProfileName.ForeColor = Color.White;
            ComboBox_ProfileName.FormattingEnabled = true;
            ComboBox_ProfileName.Location = new Point(196, 268);
            ComboBox_ProfileName.Margin = new Padding(3, 4, 3, 4);
            ComboBox_ProfileName.Name = "ComboBox_ProfileName";
            ComboBox_ProfileName.Size = new Size(731, 43);
            ComboBox_ProfileName.TabIndex = 2;
            // 
            // Button_LogIn
            // 
            Button_LogIn.Anchor = AnchorStyles.None;
            Button_LogIn.BackColor = Color.FromArgb(0, 31, 132);
            Button_LogIn.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_LogIn.ForeColor = Color.White;
            Button_LogIn.Location = new Point(76, 356);
            Button_LogIn.Margin = new Padding(3, 4, 3, 4);
            Button_LogIn.Name = "Button_LogIn";
            Button_LogIn.Size = new Size(971, 100);
            Button_LogIn.TabIndex = 3;
            Button_LogIn.Text = "Zaloguj się";
            Button_LogIn.UseVisualStyleBackColor = false;
            Button_LogIn.Click += Button_LogIn_Click;
            Button_LogIn.MouseEnter += Menu_Button_Enter;
            Button_LogIn.MouseLeave += Menu_Button_Leave;
            // 
            // Button_ExitProfileChoosing
            // 
            Button_ExitProfileChoosing.Anchor = AnchorStyles.None;
            Button_ExitProfileChoosing.BackColor = Color.FromArgb(0, 31, 132);
            Button_ExitProfileChoosing.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_ExitProfileChoosing.ForeColor = Color.White;
            Button_ExitProfileChoosing.Location = new Point(76, 473);
            Button_ExitProfileChoosing.Margin = new Padding(3, 4, 3, 4);
            Button_ExitProfileChoosing.Name = "Button_ExitProfileChoosing";
            Button_ExitProfileChoosing.Size = new Size(971, 100);
            Button_ExitProfileChoosing.TabIndex = 4;
            Button_ExitProfileChoosing.Text = "Wróć do głównego menu";
            Button_ExitProfileChoosing.UseVisualStyleBackColor = false;
            Button_ExitProfileChoosing.Click += Button_ExitProfileChoosing_Click;
            Button_ExitProfileChoosing.MouseEnter += Menu_Button_Enter;
            Button_ExitProfileChoosing.MouseLeave += Menu_Button_Leave;
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
            Panel_TitleBar.TabIndex = 100;
            Panel_TitleBar.MouseDown += Panel_TitleBar_MouseDown;
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
            Button_TitleBar_Minimalize.Location = new Point(1637, 0);
            Button_TitleBar_Minimalize.Margin = new Padding(0);
            Button_TitleBar_Minimalize.Name = "Button_TitleBar_Minimalize";
            Button_TitleBar_Minimalize.Size = new Size(64, 69);
            Button_TitleBar_Minimalize.TabIndex = 2;
            Button_TitleBar_Minimalize.Text = "–";
            Button_TitleBar_Minimalize.UseVisualStyleBackColor = false;
            Button_TitleBar_Minimalize.Click += Button_TitleBar_Minimalize_Click;
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
            Button_TitleBar_Maximalize.Location = new Point(1701, 0);
            Button_TitleBar_Maximalize.Margin = new Padding(0);
            Button_TitleBar_Maximalize.Name = "Button_TitleBar_Maximalize";
            Button_TitleBar_Maximalize.Size = new Size(69, 69);
            Button_TitleBar_Maximalize.TabIndex = 1;
            Button_TitleBar_Maximalize.Text = "◱";
            Button_TitleBar_Maximalize.UseVisualStyleBackColor = false;
            Button_TitleBar_Maximalize.Click += Button_TitleBar_Maximalize_Click;
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
            Button_TtitleBar_ExitProgram.Location = new Point(1770, 0);
            Button_TtitleBar_ExitProgram.Margin = new Padding(0);
            Button_TtitleBar_ExitProgram.Name = "Button_TtitleBar_ExitProgram";
            Button_TtitleBar_ExitProgram.Size = new Size(59, 69);
            Button_TtitleBar_ExitProgram.TabIndex = 0;
            Button_TtitleBar_ExitProgram.Text = "x";
            Button_TtitleBar_ExitProgram.TextAlign = ContentAlignment.TopCenter;
            Button_TtitleBar_ExitProgram.UseVisualStyleBackColor = true;
            Button_TtitleBar_ExitProgram.Click += Button_TtitleBar_ExitProgram_Click;
            Button_TtitleBar_ExitProgram.MouseEnter += TitleBar_Button_Enter;
            Button_TtitleBar_ExitProgram.MouseLeave += TitleBar_Button_Leave;
            // 
            // tableLayoutPanel_Menu
            // 
            tableLayoutPanel_Menu.ColumnCount = 1;
            tableLayoutPanel_Menu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Menu.Controls.Add(Button_LogIn, 0, 3);
            tableLayoutPanel_Menu.Controls.Add(Button_ExitProfileChoosing, 0, 4);
            tableLayoutPanel_Menu.Controls.Add(Label_WelcomeMessage, 0, 0);
            tableLayoutPanel_Menu.Controls.Add(ComboBox_ProfileName, 0, 2);
            tableLayoutPanel_Menu.Controls.Add(Label_ProfileName, 0, 1);
            tableLayoutPanel_Menu.Location = new Point(238, 98);
            tableLayoutPanel_Menu.Name = "tableLayoutPanel_Menu";
            tableLayoutPanel_Menu.RowCount = 5;
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Menu.Size = new Size(1124, 583);
            tableLayoutPanel_Menu.TabIndex = 101;
            // 
            // Form_ChooseProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(45, 45, 55);
            ClientSize = new Size(1829, 983);
            Controls.Add(tableLayoutPanel_Menu);
            Controls.Add(Panel_TitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1024, 720);
            Name = "Form_ChooseProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_ChooseProfile";
            Panel_TitleBar.ResumeLayout(false);
            Panel_TitleBar.PerformLayout();
            tableLayoutPanel_Menu.ResumeLayout(false);
            tableLayoutPanel_Menu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Label_WelcomeMessage;
        private Label Label_ProfileName;
        private ComboBox ComboBox_ProfileName;
        private Button Button_LogIn;
        private Button Button_ExitProfileChoosing;
        private Panel Panel_TitleBar;
        private Label Label_Title;
        private Button Button_TitleBar_Minimalize;
        private Button Button_TitleBar_Maximalize;
        private Button Button_TtitleBar_ExitProgram;
        private TableLayoutPanel tableLayoutPanel_Menu;
    }
}