namespace CRUDAppProject.Forms
{
    partial class Form_CreateProfile
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
            Label_ListOfSubjects = new Label();
            RichTextBox_ListOfSubjects = new RichTextBox();
            Button_CreateProfile = new Button();
            TextBox_ProfileName = new TextBox();
            Button_ExitProfileCreator = new Button();
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
            Label_WelcomeMessage.AutoSize = true;
            Label_WelcomeMessage.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Label_WelcomeMessage.Location = new Point(753, 12);
            Label_WelcomeMessage.Name = "Label_WelcomeMessage";
            Label_WelcomeMessage.Size = new Size(496, 60);
            Label_WelcomeMessage.TabIndex = 1;
            Label_WelcomeMessage.Text = "Kreator profilu semestru";
            // 
            // Label_ProfileName
            // 
            Label_ProfileName.Anchor = AnchorStyles.None;
            Label_ProfileName.AutoSize = true;
            Label_ProfileName.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            Label_ProfileName.ForeColor = Color.White;
            Label_ProfileName.Location = new Point(363, 11);
            Label_ProfileName.Margin = new Padding(3, 11, 3, 11);
            Label_ProfileName.Name = "Label_ProfileName";
            Label_ProfileName.Size = new Size(530, 48);
            Label_ProfileName.TabIndex = 2;
            Label_ProfileName.Text = "Wprowadź nazwę semestru";
            // 
            // Label_ListOfSubjects
            // 
            Label_ListOfSubjects.Anchor = AnchorStyles.None;
            Label_ListOfSubjects.AutoSize = true;
            Label_ListOfSubjects.BackColor = Color.Transparent;
            Label_ListOfSubjects.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_ListOfSubjects.ForeColor = Color.White;
            Label_ListOfSubjects.Location = new Point(3, 143);
            Label_ListOfSubjects.Margin = new Padding(3, 11, 3, 11);
            Label_ListOfSubjects.Name = "Label_ListOfSubjects";
            Label_ListOfSubjects.Size = new Size(1251, 32);
            Label_ListOfSubjects.TabIndex = 4;
            Label_ListOfSubjects.Text = "Wprowadź przedmioty po przecinku, których zajęcia odbywają się w ramach powyższego semestru";
            // 
            // RichTextBox_ListOfSubjects
            // 
            RichTextBox_ListOfSubjects.Anchor = AnchorStyles.None;
            RichTextBox_ListOfSubjects.BackColor = Color.FromArgb(25, 25, 35);
            RichTextBox_ListOfSubjects.Font = new Font("Arial Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            RichTextBox_ListOfSubjects.ForeColor = Color.FromArgb(65, 65, 85);
            RichTextBox_ListOfSubjects.Location = new Point(254, 197);
            RichTextBox_ListOfSubjects.Margin = new Padding(3, 11, 3, 11);
            RichTextBox_ListOfSubjects.Name = "RichTextBox_ListOfSubjects";
            RichTextBox_ListOfSubjects.Size = new Size(748, 151);
            RichTextBox_ListOfSubjects.TabIndex = 2;
            RichTextBox_ListOfSubjects.Text = "Wpisz, Swoje, Przedmioty, W, Taki, Sposób";
            RichTextBox_ListOfSubjects.Click += RichTextBox_ListOfSubjects_Click;
            // 
            // Button_CreateProfile
            // 
            Button_CreateProfile.Anchor = AnchorStyles.None;
            Button_CreateProfile.BackColor = Color.FromArgb(0, 31, 132);
            Button_CreateProfile.Cursor = Cursors.Hand;
            Button_CreateProfile.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_CreateProfile.ForeColor = Color.White;
            Button_CreateProfile.Location = new Point(143, 370);
            Button_CreateProfile.Margin = new Padding(3, 11, 3, 11);
            Button_CreateProfile.Name = "Button_CreateProfile";
            Button_CreateProfile.Size = new Size(971, 100);
            Button_CreateProfile.TabIndex = 7;
            Button_CreateProfile.Text = "Dodaj nowy semestr";
            Button_CreateProfile.UseVisualStyleBackColor = false;
            Button_CreateProfile.Click += Button_CreateProfile_Click;
            Button_CreateProfile.MouseEnter += Menu_Button_Enter;
            Button_CreateProfile.MouseLeave += Menu_Button_Leave;
            // 
            // TextBox_ProfileName
            // 
            TextBox_ProfileName.Anchor = AnchorStyles.None;
            TextBox_ProfileName.BackColor = Color.FromArgb(25, 25, 35);
            TextBox_ProfileName.Font = new Font("Arial Black", 13.8F);
            TextBox_ProfileName.ForeColor = Color.FromArgb(65, 65, 85);
            TextBox_ProfileName.Location = new Point(254, 81);
            TextBox_ProfileName.Margin = new Padding(3, 11, 3, 11);
            TextBox_ProfileName.Name = "TextBox_ProfileName";
            TextBox_ProfileName.Size = new Size(748, 40);
            TextBox_ProfileName.TabIndex = 1;
            TextBox_ProfileName.Click += TextBox_ProfileName_Click;
            // 
            // Button_ExitProfileCreator
            // 
            Button_ExitProfileCreator.Anchor = AnchorStyles.None;
            Button_ExitProfileCreator.BackColor = Color.FromArgb(0, 31, 132);
            Button_ExitProfileCreator.Cursor = Cursors.Hand;
            Button_ExitProfileCreator.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_ExitProfileCreator.ForeColor = Color.White;
            Button_ExitProfileCreator.Location = new Point(143, 496);
            Button_ExitProfileCreator.Margin = new Padding(3, 11, 3, 11);
            Button_ExitProfileCreator.Name = "Button_ExitProfileCreator";
            Button_ExitProfileCreator.Size = new Size(971, 100);
            Button_ExitProfileCreator.TabIndex = 9;
            Button_ExitProfileCreator.Text = "Opuść bez zapisywania";
            Button_ExitProfileCreator.UseVisualStyleBackColor = false;
            Button_ExitProfileCreator.Click += Button_ExitProfileCreator_Click;
            Button_ExitProfileCreator.MouseEnter += Menu_Button_Enter;
            Button_ExitProfileCreator.MouseLeave += Menu_Button_Leave;
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
            Panel_TitleBar.TabIndex = 99;
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
            tableLayoutPanel_Menu.AutoSize = true;
            tableLayoutPanel_Menu.BackColor = Color.Transparent;
            tableLayoutPanel_Menu.ColumnCount = 1;
            tableLayoutPanel_Menu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Menu.Controls.Add(Label_ProfileName, 0, 0);
            tableLayoutPanel_Menu.Controls.Add(TextBox_ProfileName, 0, 1);
            tableLayoutPanel_Menu.Controls.Add(Label_ListOfSubjects, 0, 2);
            tableLayoutPanel_Menu.Controls.Add(Button_CreateProfile, 0, 4);
            tableLayoutPanel_Menu.Controls.Add(Button_ExitProfileCreator, 0, 5);
            tableLayoutPanel_Menu.Controls.Add(RichTextBox_ListOfSubjects, 0, 3);
            tableLayoutPanel_Menu.Location = new Point(405, 104);
            tableLayoutPanel_Menu.Name = "tableLayoutPanel_Menu";
            tableLayoutPanel_Menu.RowCount = 6;
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle());
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle());
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle());
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle());
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle());
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle());
            tableLayoutPanel_Menu.Size = new Size(1257, 611);
            tableLayoutPanel_Menu.TabIndex = 11;
            // 
            // Form_CreateProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(45, 45, 55);
            ClientSize = new Size(1829, 983);
            Controls.Add(tableLayoutPanel_Menu);
            Controls.Add(Panel_TitleBar);
            Controls.Add(Label_WelcomeMessage);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1024, 720);
            Name = "Form_CreateProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "7";
            Panel_TitleBar.ResumeLayout(false);
            Panel_TitleBar.PerformLayout();
            tableLayoutPanel_Menu.ResumeLayout(false);
            tableLayoutPanel_Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion
        private Label Label_WelcomeMessage;
        private Label Label_ProfileName;
        private Label Label_ListOfSubjects;
        private RichTextBox RichTextBox_ListOfSubjects;
        private Button Button_CreateProfile;
        private TextBox TextBox_ProfileName;
        private Button Button_ExitProfileCreator;
        private Panel Panel_TitleBar;
        private Label Label_Title;
        private Button Button_TitleBar_Minimalize;
        private Button Button_TitleBar_Maximalize;
        private Button Button_TtitleBar_ExitProgram;
        private TableLayoutPanel tableLayoutPanel_Menu;
    }
}