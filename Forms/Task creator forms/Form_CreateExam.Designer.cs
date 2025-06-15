namespace CRUDAppProject.Forms.Logged_in_forms
{
    partial class Form_CreateExam
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
            Label_TaskTitle = new Label();
            Label_TaskDescription = new Label();
            Label_TaskMaterialScope = new Label();
            Label_ChooseSubject = new Label();
            Button_ExitExamCreator = new Button();
            Button_CreateExam = new Button();
            Calendar_SetDeadline = new MonthCalendar();
            ComboBox_ChooseSubject = new ComboBox();
            TextBox_TaskTitle = new TextBox();
            RichTextBox_TaskDescription = new RichTextBox();
            RichTextBox_TaskMaterialScope = new RichTextBox();
            Label_SetDeadline = new Label();
            TextBox_ShortDescription = new TextBox();
            Label_ShortDescription = new Label();
            Panel_TitleBar = new Panel();
            Label_Title = new Label();
            Button_TitleBar_Minimalize = new Button();
            Button_TitleBar_Maximalize = new Button();
            Button_TtitleBar_ExitProgram = new Button();
            tableLayoutPanel_Menu = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            Panel_TitleBar.SuspendLayout();
            tableLayoutPanel_Menu.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // Label_WelcomeMessage
            // 
            Label_WelcomeMessage.Anchor = AnchorStyles.Top;
            Label_WelcomeMessage.AutoSize = true;
            Label_WelcomeMessage.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            Label_WelcomeMessage.ForeColor = Color.White;
            Label_WelcomeMessage.Location = new Point(331, 0);
            Label_WelcomeMessage.Name = "Label_WelcomeMessage";
            Label_WelcomeMessage.Size = new Size(353, 48);
            Label_WelcomeMessage.TabIndex = 0;
            Label_WelcomeMessage.Text = "Kreator egzaminu";
            // 
            // Label_TaskTitle
            // 
            Label_TaskTitle.AutoSize = true;
            Label_TaskTitle.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_TaskTitle.ForeColor = Color.White;
            Label_TaskTitle.Location = new Point(3, 67);
            Label_TaskTitle.Name = "Label_TaskTitle";
            Label_TaskTitle.Size = new Size(239, 32);
            Label_TaskTitle.TabIndex = 1;
            Label_TaskTitle.Text = "Zatytułuj egzamin";
            // 
            // Label_TaskDescription
            // 
            Label_TaskDescription.AutoSize = true;
            Label_TaskDescription.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_TaskDescription.ForeColor = Color.White;
            Label_TaskDescription.Location = new Point(3, 134);
            Label_TaskDescription.Name = "Label_TaskDescription";
            Label_TaskDescription.Size = new Size(405, 32);
            Label_TaskDescription.TabIndex = 2;
            Label_TaskDescription.Text = "Wprowadź pełny opis egzaminu";
            // 
            // Label_TaskMaterialScope
            // 
            Label_TaskMaterialScope.AutoSize = true;
            Label_TaskMaterialScope.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_TaskMaterialScope.ForeColor = Color.White;
            Label_TaskMaterialScope.Location = new Point(3, 248);
            Label_TaskMaterialScope.Name = "Label_TaskMaterialScope";
            Label_TaskMaterialScope.Size = new Size(302, 32);
            Label_TaskMaterialScope.TabIndex = 3;
            Label_TaskMaterialScope.Text = "Dodaj zakres materiału";
            // 
            // Label_ChooseSubject
            // 
            Label_ChooseSubject.AutoSize = true;
            Label_ChooseSubject.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_ChooseSubject.ForeColor = Color.White;
            Label_ChooseSubject.Location = new Point(3, 0);
            Label_ChooseSubject.Name = "Label_ChooseSubject";
            Label_ChooseSubject.Size = new Size(252, 32);
            Label_ChooseSubject.TabIndex = 4;
            Label_ChooseSubject.Text = "Wybierz przedmiot ";
            // 
            // Button_ExitExamCreator
            // 
            Button_ExitExamCreator.BackColor = Color.FromArgb(0, 31, 132);
            Button_ExitExamCreator.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_ExitExamCreator.ForeColor = Color.White;
            Button_ExitExamCreator.Location = new Point(3, 4);
            Button_ExitExamCreator.Margin = new Padding(3, 4, 3, 4);
            Button_ExitExamCreator.Name = "Button_ExitExamCreator";
            Button_ExitExamCreator.Size = new Size(240, 143);
            Button_ExitExamCreator.TabIndex = 5;
            Button_ExitExamCreator.Text = "Opuść bez zapisywania";
            Button_ExitExamCreator.UseVisualStyleBackColor = false;
            Button_ExitExamCreator.Click += Button_ExitExamCreator_Click;
            Button_ExitExamCreator.MouseEnter += Menu_Button_Enter;
            Button_ExitExamCreator.MouseLeave += Menu_Button_Leave;
            // 
            // Button_CreateExam
            // 
            Button_CreateExam.BackColor = Color.FromArgb(0, 31, 132);
            Button_CreateExam.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_CreateExam.ForeColor = Color.White;
            Button_CreateExam.Location = new Point(249, 4);
            Button_CreateExam.Margin = new Padding(3, 4, 3, 4);
            Button_CreateExam.Name = "Button_CreateExam";
            Button_CreateExam.Size = new Size(241, 144);
            Button_CreateExam.TabIndex = 6;
            Button_CreateExam.Text = "Dodaj egzamin";
            Button_CreateExam.UseVisualStyleBackColor = false;
            Button_CreateExam.Click += Button_CreateExam_Click;
            Button_CreateExam.MouseEnter += Menu_Button_Enter;
            Button_CreateExam.MouseLeave += Menu_Button_Leave;
            // 
            // Calendar_SetDeadline
            // 
            Calendar_SetDeadline.Anchor = AnchorStyles.Top;
            Calendar_SetDeadline.ForeColor = Color.Black;
            Calendar_SetDeadline.Location = new Point(87, 112);
            Calendar_SetDeadline.Margin = new Padding(10, 12, 10, 12);
            Calendar_SetDeadline.MaxSelectionCount = 1;
            Calendar_SetDeadline.MinDate = new DateTime(2025, 5, 2, 0, 0, 0, 0);
            Calendar_SetDeadline.Name = "Calendar_SetDeadline";
            Calendar_SetDeadline.TabIndex = 7;
            // 
            // ComboBox_ChooseSubject
            // 
            ComboBox_ChooseSubject.BackColor = Color.FromArgb(25, 25, 35);
            ComboBox_ChooseSubject.ForeColor = Color.White;
            ComboBox_ChooseSubject.FormattingEnabled = true;
            ComboBox_ChooseSubject.Location = new Point(3, 36);
            ComboBox_ChooseSubject.Margin = new Padding(3, 4, 3, 4);
            ComboBox_ChooseSubject.Name = "ComboBox_ChooseSubject";
            ComboBox_ChooseSubject.Size = new Size(493, 28);
            ComboBox_ChooseSubject.TabIndex = 8;
            // 
            // TextBox_TaskTitle
            // 
            TextBox_TaskTitle.BackColor = Color.FromArgb(25, 25, 35);
            TextBox_TaskTitle.ForeColor = Color.White;
            TextBox_TaskTitle.Location = new Point(3, 103);
            TextBox_TaskTitle.Margin = new Padding(3, 4, 3, 4);
            TextBox_TaskTitle.Name = "TextBox_TaskTitle";
            TextBox_TaskTitle.Size = new Size(492, 27);
            TextBox_TaskTitle.TabIndex = 9;
            // 
            // RichTextBox_TaskDescription
            // 
            RichTextBox_TaskDescription.BackColor = Color.FromArgb(25, 25, 35);
            RichTextBox_TaskDescription.ForeColor = Color.White;
            RichTextBox_TaskDescription.Location = new Point(3, 170);
            RichTextBox_TaskDescription.Margin = new Padding(3, 4, 3, 4);
            RichTextBox_TaskDescription.Name = "RichTextBox_TaskDescription";
            RichTextBox_TaskDescription.Size = new Size(492, 74);
            RichTextBox_TaskDescription.TabIndex = 10;
            RichTextBox_TaskDescription.Text = "";
            // 
            // RichTextBox_TaskMaterialScope
            // 
            RichTextBox_TaskMaterialScope.BackColor = Color.FromArgb(25, 25, 35);
            RichTextBox_TaskMaterialScope.ForeColor = Color.White;
            RichTextBox_TaskMaterialScope.Location = new Point(3, 284);
            RichTextBox_TaskMaterialScope.Margin = new Padding(3, 4, 3, 4);
            RichTextBox_TaskMaterialScope.Name = "RichTextBox_TaskMaterialScope";
            RichTextBox_TaskMaterialScope.Size = new Size(492, 89);
            RichTextBox_TaskMaterialScope.TabIndex = 11;
            RichTextBox_TaskMaterialScope.Text = "";
            // 
            // Label_SetDeadline
            // 
            Label_SetDeadline.AutoSize = true;
            Label_SetDeadline.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_SetDeadline.ForeColor = Color.White;
            Label_SetDeadline.Location = new Point(3, 68);
            Label_SetDeadline.Name = "Label_SetDeadline";
            Label_SetDeadline.Size = new Size(345, 32);
            Label_SetDeadline.TabIndex = 12;
            Label_SetDeadline.Text = "Wyznacz termin zaliczenia";
            // 
            // TextBox_ShortDescription
            // 
            TextBox_ShortDescription.BackColor = Color.FromArgb(25, 25, 35);
            TextBox_ShortDescription.ForeColor = Color.White;
            TextBox_ShortDescription.Location = new Point(3, 36);
            TextBox_ShortDescription.Margin = new Padding(3, 4, 3, 4);
            TextBox_ShortDescription.Name = "TextBox_ShortDescription";
            TextBox_ShortDescription.Size = new Size(492, 27);
            TextBox_ShortDescription.TabIndex = 13;
            // 
            // Label_ShortDescription
            // 
            Label_ShortDescription.AutoSize = true;
            Label_ShortDescription.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_ShortDescription.ForeColor = Color.White;
            Label_ShortDescription.Location = new Point(3, 0);
            Label_ShortDescription.Name = "Label_ShortDescription";
            Label_ShortDescription.Size = new Size(283, 32);
            Label_ShortDescription.TabIndex = 14;
            Label_ShortDescription.Text = "Wprowadź krótki opis";
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
            Panel_TitleBar.Size = new Size(1838, 69);
            Panel_TitleBar.TabIndex = 15;
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
            Button_TitleBar_Minimalize.Location = new Point(1654, 0);
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
            Button_TitleBar_Maximalize.Location = new Point(1718, 0);
            Button_TitleBar_Maximalize.Margin = new Padding(0);
            Button_TitleBar_Maximalize.Name = "Button_TitleBar_Maximalize";
            Button_TitleBar_Maximalize.Size = new Size(60, 69);
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
            Button_TtitleBar_ExitProgram.Location = new Point(1778, 0);
            Button_TtitleBar_ExitProgram.Margin = new Padding(0);
            Button_TtitleBar_ExitProgram.Name = "Button_TtitleBar_ExitProgram";
            Button_TtitleBar_ExitProgram.Size = new Size(60, 69);
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
            tableLayoutPanel_Menu.Controls.Add(Label_WelcomeMessage, 0, 0);
            tableLayoutPanel_Menu.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel_Menu.Location = new Point(328, 107);
            tableLayoutPanel_Menu.Name = "tableLayoutPanel_Menu";
            tableLayoutPanel_Menu.RowCount = 2;
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Menu.Size = new Size(1015, 600);
            tableLayoutPanel_Menu.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 73);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1009, 524);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 4);
            tableLayoutPanel4.Controls.Add(Calendar_SetDeadline, 0, 3);
            tableLayoutPanel4.Controls.Add(Label_SetDeadline, 0, 2);
            tableLayoutPanel4.Controls.Add(ComboBox_ChooseSubject, 0, 1);
            tableLayoutPanel4.Controls.Add(Label_ChooseSubject, 0, 0);
            tableLayoutPanel4.Location = new Point(507, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(499, 518);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(Button_ExitExamCreator, 0, 0);
            tableLayoutPanel5.Controls.Add(Button_CreateExam, 1, 0);
            tableLayoutPanel5.Location = new Point(3, 334);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(493, 152);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(RichTextBox_TaskMaterialScope, 0, 7);
            tableLayoutPanel3.Controls.Add(Label_TaskMaterialScope, 0, 6);
            tableLayoutPanel3.Controls.Add(Label_ShortDescription, 0, 0);
            tableLayoutPanel3.Controls.Add(RichTextBox_TaskDescription, 0, 5);
            tableLayoutPanel3.Controls.Add(TextBox_ShortDescription, 0, 1);
            tableLayoutPanel3.Controls.Add(Label_TaskDescription, 0, 4);
            tableLayoutPanel3.Controls.Add(TextBox_TaskTitle, 0, 3);
            tableLayoutPanel3.Controls.Add(Label_TaskTitle, 0, 2);
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 8;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(498, 518);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // Form_CreateExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 55);
            ClientSize = new Size(1838, 993);
            Controls.Add(tableLayoutPanel_Menu);
            Controls.Add(Panel_TitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1024, 720);
            Name = "Form_CreateExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_CreateExam";
            Panel_TitleBar.ResumeLayout(false);
            Panel_TitleBar.PerformLayout();
            tableLayoutPanel_Menu.ResumeLayout(false);
            tableLayoutPanel_Menu.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Label_WelcomeMessage;
        private Label Label_TaskTitle;
        private Label Label_TaskDescription;
        private Label Label_TaskMaterialScope;
        private Label Label_ChooseSubject;
        private Button Button_ExitExamCreator;
        private Button Button_CreateExam;
        private MonthCalendar Calendar_SetDeadline;
        private ComboBox ComboBox_ChooseSubject;
        private TextBox TextBox_TaskTitle;
        private RichTextBox RichTextBox_TaskDescription;
        private RichTextBox RichTextBox_TaskMaterialScope;
        private Label Label_SetDeadline;
        private TextBox TextBox_ShortDescription;
        private Label Label_ShortDescription;
        private Panel Panel_TitleBar;
        private Label Label_Title;
        private Button Button_TitleBar_Minimalize;
        private Button Button_TitleBar_Maximalize;
        private Button Button_TtitleBar_ExitProgram;
        private TableLayoutPanel tableLayoutPanel_Menu;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel3;
    }
}