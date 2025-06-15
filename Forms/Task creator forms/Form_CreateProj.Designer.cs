namespace CRUDAppProject.Forms
{
    partial class Form_CreateProj
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
            Label_TaskDescription = new Label();
            Label_TaskMembers = new Label();
            Label_ChooseSubject = new Label();
            Label_SetDeadline = new Label();
            Button_ExitProjectCreator = new Button();
            Button_CreateProject = new Button();
            Calendar_SetDeadline = new MonthCalendar();
            TextBox_TaskTitle = new TextBox();
            RichTextBox_TaskDescription = new RichTextBox();
            ComboBox_ChooseSubject = new ComboBox();
            TextBox_TaskMembers = new TextBox();
            TextBox_ShortDescription = new TextBox();
            Label_ShortDescription = new Label();
            Panel_TitleBar = new Panel();
            Label_Title = new Label();
            Button_TitleBar_Minimalize = new Button();
            Button_TitleBar_Maximalize = new Button();
            Button_TtitleBar_ExitProgram = new Button();
            tableLayoutPanel_Menu = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            Panel_TitleBar.SuspendLayout();
            tableLayoutPanel_Menu.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // Label_WelcomeMessage
            // 
            Label_WelcomeMessage.Anchor = AnchorStyles.Top;
            Label_WelcomeMessage.AutoSize = true;
            Label_WelcomeMessage.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            Label_WelcomeMessage.ForeColor = Color.White;
            Label_WelcomeMessage.Location = new Point(342, 0);
            Label_WelcomeMessage.Name = "Label_WelcomeMessage";
            Label_WelcomeMessage.Size = new Size(330, 48);
            Label_WelcomeMessage.TabIndex = 0;
            Label_WelcomeMessage.Text = "Kreator projektu";
            // 
            // Label_TaskDescription
            // 
            Label_TaskDescription.AutoSize = true;
            Label_TaskDescription.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_TaskDescription.ForeColor = Color.White;
            Label_TaskDescription.Location = new Point(3, 134);
            Label_TaskDescription.Name = "Label_TaskDescription";
            Label_TaskDescription.Size = new Size(388, 32);
            Label_TaskDescription.TabIndex = 2;
            Label_TaskDescription.Text = "Wprowadź pełny opis projektu";
            // 
            // Label_TaskMembers
            // 
            Label_TaskMembers.AutoSize = true;
            Label_TaskMembers.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_TaskMembers.ForeColor = Color.White;
            Label_TaskMembers.Location = new Point(3, 289);
            Label_TaskMembers.Name = "Label_TaskMembers";
            Label_TaskMembers.Size = new Size(322, 32);
            Label_TaskMembers.TabIndex = 3;
            Label_TaskMembers.Text = "Dodaj członków projektu";
            // 
            // Label_ChooseSubject
            // 
            Label_ChooseSubject.AutoSize = true;
            Label_ChooseSubject.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_ChooseSubject.ForeColor = Color.White;
            Label_ChooseSubject.Location = new Point(3, 0);
            Label_ChooseSubject.Name = "Label_ChooseSubject";
            Label_ChooseSubject.Size = new Size(244, 32);
            Label_ChooseSubject.TabIndex = 4;
            Label_ChooseSubject.Text = "Wybierz przedmiot";
            // 
            // Label_SetDeadline
            // 
            Label_SetDeadline.AutoSize = true;
            Label_SetDeadline.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_SetDeadline.ForeColor = Color.White;
            Label_SetDeadline.Location = new Point(3, 68);
            Label_SetDeadline.Name = "Label_SetDeadline";
            Label_SetDeadline.Size = new Size(304, 32);
            Label_SetDeadline.TabIndex = 5;
            Label_SetDeadline.Text = "Wyznacz termin obrony";
            // 
            // Button_ExitProjectCreator
            // 
            Button_ExitProjectCreator.BackColor = Color.FromArgb(0, 31, 132);
            Button_ExitProjectCreator.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_ExitProjectCreator.ForeColor = Color.White;
            Button_ExitProjectCreator.Location = new Point(3, 4);
            Button_ExitProjectCreator.Margin = new Padding(3, 4, 3, 4);
            Button_ExitProjectCreator.Name = "Button_ExitProjectCreator";
            Button_ExitProjectCreator.Size = new Size(240, 141);
            Button_ExitProjectCreator.TabIndex = 6;
            Button_ExitProjectCreator.Text = "Opuść bez zapisywania";
            Button_ExitProjectCreator.UseVisualStyleBackColor = false;
            Button_ExitProjectCreator.Click += Button_ExitProjectCreator_Click;
            Button_ExitProjectCreator.MouseEnter += Menu_Button_Enter;
            Button_ExitProjectCreator.MouseLeave += Menu_Button_Leave;
            // 
            // Button_CreateProject
            // 
            Button_CreateProject.BackColor = Color.FromArgb(0, 31, 132);
            Button_CreateProject.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_CreateProject.ForeColor = Color.White;
            Button_CreateProject.Location = new Point(249, 4);
            Button_CreateProject.Margin = new Padding(3, 4, 3, 4);
            Button_CreateProject.Name = "Button_CreateProject";
            Button_CreateProject.Size = new Size(241, 141);
            Button_CreateProject.TabIndex = 7;
            Button_CreateProject.Text = "Dodaj projekt";
            Button_CreateProject.UseVisualStyleBackColor = false;
            Button_CreateProject.Click += Button_CreateProject_Click;
            Button_CreateProject.MouseEnter += Menu_Button_Enter;
            Button_CreateProject.MouseLeave += Menu_Button_Leave;
            // 
            // Calendar_SetDeadline
            // 
            Calendar_SetDeadline.Anchor = AnchorStyles.Top;
            Calendar_SetDeadline.Location = new Point(87, 112);
            Calendar_SetDeadline.Margin = new Padding(10, 12, 10, 12);
            Calendar_SetDeadline.Name = "Calendar_SetDeadline";
            Calendar_SetDeadline.TabIndex = 6;
            // 
            // TextBox_TaskTitle
            // 
            TextBox_TaskTitle.BackColor = Color.FromArgb(25, 25, 35);
            TextBox_TaskTitle.ForeColor = Color.White;
            TextBox_TaskTitle.Location = new Point(3, 36);
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
            RichTextBox_TaskDescription.Size = new Size(492, 115);
            RichTextBox_TaskDescription.TabIndex = 10;
            RichTextBox_TaskDescription.Text = "";
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
            ComboBox_ChooseSubject.TabIndex = 12;
            // 
            // TextBox_TaskMembers
            // 
            TextBox_TaskMembers.BackColor = Color.FromArgb(25, 25, 35);
            TextBox_TaskMembers.ForeColor = Color.White;
            TextBox_TaskMembers.Location = new Point(3, 325);
            TextBox_TaskMembers.Margin = new Padding(3, 4, 3, 4);
            TextBox_TaskMembers.Name = "TextBox_TaskMembers";
            TextBox_TaskMembers.Size = new Size(492, 27);
            TextBox_TaskMembers.TabIndex = 13;
            // 
            // TextBox_ShortDescription
            // 
            TextBox_ShortDescription.BackColor = Color.FromArgb(25, 25, 35);
            TextBox_ShortDescription.ForeColor = Color.White;
            TextBox_ShortDescription.Location = new Point(3, 103);
            TextBox_ShortDescription.Margin = new Padding(3, 4, 3, 4);
            TextBox_ShortDescription.Name = "TextBox_ShortDescription";
            TextBox_ShortDescription.Size = new Size(492, 27);
            TextBox_ShortDescription.TabIndex = 14;
            // 
            // Label_ShortDescription
            // 
            Label_ShortDescription.AutoSize = true;
            Label_ShortDescription.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_ShortDescription.ForeColor = Color.White;
            Label_ShortDescription.Location = new Point(3, 67);
            Label_ShortDescription.Name = "Label_ShortDescription";
            Label_ShortDescription.Size = new Size(283, 32);
            Label_ShortDescription.TabIndex = 15;
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
            Panel_TitleBar.TabIndex = 16;
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
            tableLayoutPanel_Menu.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel_Menu.Controls.Add(Label_WelcomeMessage, 0, 0);
            tableLayoutPanel_Menu.Location = new Point(391, 143);
            tableLayoutPanel_Menu.Name = "tableLayoutPanel_Menu";
            tableLayoutPanel_Menu.RowCount = 2;
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Menu.Size = new Size(1015, 600);
            tableLayoutPanel_Menu.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel2.Location = new Point(3, 63);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1009, 534);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(Label_ShortDescription, 0, 2);
            tableLayoutPanel3.Controls.Add(TextBox_ShortDescription, 0, 3);
            tableLayoutPanel3.Controls.Add(TextBox_TaskMembers, 0, 7);
            tableLayoutPanel3.Controls.Add(TextBox_TaskTitle, 0, 1);
            tableLayoutPanel3.Controls.Add(RichTextBox_TaskDescription, 0, 5);
            tableLayoutPanel3.Controls.Add(Label_TaskDescription, 0, 4);
            tableLayoutPanel3.Controls.Add(Label_TaskMembers, 0, 6);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
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
            tableLayoutPanel3.Size = new Size(498, 528);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(230, 32);
            label1.TabIndex = 16;
            label1.Text = "Zatytułuj zadanie";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 4);
            tableLayoutPanel4.Controls.Add(Calendar_SetDeadline, 0, 3);
            tableLayoutPanel4.Controls.Add(Label_ChooseSubject, 0, 0);
            tableLayoutPanel4.Controls.Add(ComboBox_ChooseSubject, 0, 1);
            tableLayoutPanel4.Controls.Add(Label_SetDeadline, 0, 2);
            tableLayoutPanel4.Location = new Point(507, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(499, 528);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(Button_ExitProjectCreator, 0, 0);
            tableLayoutPanel5.Controls.Add(Button_CreateProject, 1, 0);
            tableLayoutPanel5.Location = new Point(3, 334);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(493, 149);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // Form_CreateProj
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
            Name = "Form_CreateProj";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_CreateProj";
            Panel_TitleBar.ResumeLayout(false);
            Panel_TitleBar.PerformLayout();
            tableLayoutPanel_Menu.ResumeLayout(false);
            tableLayoutPanel_Menu.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label Label_WelcomeMessage;
        private Label Label_TaskDescription;
        private Label Label_TaskMembers;
        private Label Label_ChooseSubject;
        private Label Label_SetDeadline;
        private Button Button_ExitProjectCreator;
        private Button Button_CreateProject;
        private MonthCalendar Calendar_SetDeadline;
        private TextBox TextBox_TaskTitle;
        private RichTextBox RichTextBox_TaskDescription;
        private ComboBox ComboBox_ChooseSubject;
        private TextBox TextBox_TaskMembers;
        private TextBox TextBox_ShortDescription;
        private Label Label_ShortDescription;
        private Panel Panel_TitleBar;
        private Label Label_Title;
        private Button Button_TitleBar_Minimalize;
        private Button Button_TitleBar_Maximalize;
        private Button Button_TtitleBar_ExitProgram;
        private TableLayoutPanel tableLayoutPanel_Menu;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label1;
    }
}