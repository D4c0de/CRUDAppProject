namespace CRUDAppProject.Forms.Task_editor_forms
{
    partial class Form_EditProj
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
            Label_ShortDescription = new Label();
            Label_TaskDescription = new Label();
            Label_TaskMembers = new Label();
            Label_ChooseSubject = new Label();
            Label_SetDeadline = new Label();
            Button_ExitProjEditor = new Button();
            Button_SaveEditedProj = new Button();
            Calendar_SetDeadline = new MonthCalendar();
            ComboBox_ChooseSubject = new ComboBox();
            TextBox_TaskTitle = new TextBox();
            TextBox_ShortDescription = new TextBox();
            RichTextBox_TaskDescription = new RichTextBox();
            TextBox_TaskMembers = new TextBox();
            Panel_TitleBar = new Panel();
            Label_Title = new Label();
            Button_TitleBar_Minimalize = new Button();
            Button_TitleBar_Maximalize = new Button();
            Button_TtitleBar_ExitProgram = new Button();
            tableLayoutPanel_Menu = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            Panel_TitleBar.SuspendLayout();
            tableLayoutPanel_Menu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // Label_WelcomeMessage
            // 
            Label_WelcomeMessage.Anchor = AnchorStyles.Top;
            Label_WelcomeMessage.AutoSize = true;
            Label_WelcomeMessage.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            Label_WelcomeMessage.Location = new Point(304, 0);
            Label_WelcomeMessage.Name = "Label_WelcomeMessage";
            Label_WelcomeMessage.Size = new Size(406, 48);
            Label_WelcomeMessage.TabIndex = 0;
            Label_WelcomeMessage.Text = "Edytowanie projektu";
            // 
            // Label_TaskTitle
            // 
            Label_TaskTitle.AutoSize = true;
            Label_TaskTitle.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_TaskTitle.Location = new Point(3, 0);
            Label_TaskTitle.Name = "Label_TaskTitle";
            Label_TaskTitle.Size = new Size(104, 32);
            Label_TaskTitle.TabIndex = 1;
            Label_TaskTitle.Text = "Projekt";
            // 
            // Label_ShortDescription
            // 
            Label_ShortDescription.AutoSize = true;
            Label_ShortDescription.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_ShortDescription.Location = new Point(3, 67);
            Label_ShortDescription.Name = "Label_ShortDescription";
            Label_ShortDescription.Size = new Size(262, 32);
            Label_ShortDescription.TabIndex = 2;
            Label_ShortDescription.Text = "Krótki opis projektu";
            // 
            // Label_TaskDescription
            // 
            Label_TaskDescription.AutoSize = true;
            Label_TaskDescription.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_TaskDescription.Location = new Point(3, 134);
            Label_TaskDescription.Name = "Label_TaskDescription";
            Label_TaskDescription.Size = new Size(253, 32);
            Label_TaskDescription.TabIndex = 3;
            Label_TaskDescription.Text = "Pełny opis projektu";
            // 
            // Label_TaskMembers
            // 
            Label_TaskMembers.AutoSize = true;
            Label_TaskMembers.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_TaskMembers.Location = new Point(3, 265);
            Label_TaskMembers.Name = "Label_TaskMembers";
            Label_TaskMembers.Size = new Size(268, 32);
            Label_TaskMembers.TabIndex = 4;
            Label_TaskMembers.Text = "Członkowie projektu";
            // 
            // Label_ChooseSubject
            // 
            Label_ChooseSubject.AutoSize = true;
            Label_ChooseSubject.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_ChooseSubject.Location = new Point(3, 0);
            Label_ChooseSubject.Name = "Label_ChooseSubject";
            Label_ChooseSubject.Size = new Size(444, 32);
            Label_ChooseSubject.TabIndex = 5;
            Label_ChooseSubject.Text = "Przedmiot którego dotyczy projekt";
            // 
            // Label_SetDeadline
            // 
            Label_SetDeadline.AutoSize = true;
            Label_SetDeadline.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_SetDeadline.Location = new Point(3, 68);
            Label_SetDeadline.Name = "Label_SetDeadline";
            Label_SetDeadline.Size = new Size(194, 32);
            Label_SetDeadline.TabIndex = 6;
            Label_SetDeadline.Text = "Termin obrony";
            // 
            // Button_ExitProjEditor
            // 
            Button_ExitProjEditor.BackColor = Color.FromArgb(0, 31, 132);
            Button_ExitProjEditor.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_ExitProjEditor.Location = new Point(3, 4);
            Button_ExitProjEditor.Margin = new Padding(3, 4, 3, 4);
            Button_ExitProjEditor.Name = "Button_ExitProjEditor";
            Button_ExitProjEditor.Size = new Size(240, 117);
            Button_ExitProjEditor.TabIndex = 7;
            Button_ExitProjEditor.Text = "Opuść bez zapisywania";
            Button_ExitProjEditor.UseVisualStyleBackColor = false;
            Button_ExitProjEditor.Click += Button_ExitProjEditor_Click;
            Button_ExitProjEditor.MouseEnter += Menu_Button_Enter;
            Button_ExitProjEditor.MouseLeave += Menu_Button_Leave;
            // 
            // Button_SaveEditedProj
            // 
            Button_SaveEditedProj.BackColor = Color.FromArgb(0, 31, 132);
            Button_SaveEditedProj.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_SaveEditedProj.Location = new Point(249, 4);
            Button_SaveEditedProj.Margin = new Padding(3, 4, 3, 4);
            Button_SaveEditedProj.Name = "Button_SaveEditedProj";
            Button_SaveEditedProj.Size = new Size(241, 117);
            Button_SaveEditedProj.TabIndex = 8;
            Button_SaveEditedProj.Text = "Zapisz nową treść zadania";
            Button_SaveEditedProj.UseVisualStyleBackColor = false;
            Button_SaveEditedProj.Click += Button_SaveEditedProj_Click;
            Button_SaveEditedProj.MouseEnter += Menu_Button_Enter;
            Button_SaveEditedProj.MouseLeave += Menu_Button_Leave;
            // 
            // Calendar_SetDeadline
            // 
            Calendar_SetDeadline.Location = new Point(10, 112);
            Calendar_SetDeadline.Margin = new Padding(10, 12, 10, 12);
            Calendar_SetDeadline.Name = "Calendar_SetDeadline";
            Calendar_SetDeadline.TabIndex = 9;
            // 
            // ComboBox_ChooseSubject
            // 
            ComboBox_ChooseSubject.BackColor = Color.FromArgb(25, 25, 35);
            ComboBox_ChooseSubject.FormattingEnabled = true;
            ComboBox_ChooseSubject.Location = new Point(3, 36);
            ComboBox_ChooseSubject.Margin = new Padding(3, 4, 3, 4);
            ComboBox_ChooseSubject.Name = "ComboBox_ChooseSubject";
            ComboBox_ChooseSubject.Size = new Size(493, 28);
            ComboBox_ChooseSubject.TabIndex = 10;
            // 
            // TextBox_TaskTitle
            // 
            TextBox_TaskTitle.BackColor = Color.FromArgb(25, 25, 35);
            TextBox_TaskTitle.Location = new Point(3, 36);
            TextBox_TaskTitle.Margin = new Padding(3, 4, 3, 4);
            TextBox_TaskTitle.Name = "TextBox_TaskTitle";
            TextBox_TaskTitle.Size = new Size(492, 27);
            TextBox_TaskTitle.TabIndex = 11;
            // 
            // TextBox_ShortDescription
            // 
            TextBox_ShortDescription.BackColor = Color.FromArgb(25, 25, 35);
            TextBox_ShortDescription.Location = new Point(3, 103);
            TextBox_ShortDescription.Margin = new Padding(3, 4, 3, 4);
            TextBox_ShortDescription.Name = "TextBox_ShortDescription";
            TextBox_ShortDescription.Size = new Size(492, 27);
            TextBox_ShortDescription.TabIndex = 12;
            // 
            // RichTextBox_TaskDescription
            // 
            RichTextBox_TaskDescription.BackColor = Color.FromArgb(25, 25, 35);
            RichTextBox_TaskDescription.Location = new Point(3, 170);
            RichTextBox_TaskDescription.Margin = new Padding(3, 4, 3, 4);
            RichTextBox_TaskDescription.Name = "RichTextBox_TaskDescription";
            RichTextBox_TaskDescription.Size = new Size(492, 91);
            RichTextBox_TaskDescription.TabIndex = 13;
            RichTextBox_TaskDescription.Text = "";
            // 
            // TextBox_TaskMembers
            // 
            TextBox_TaskMembers.BackColor = Color.FromArgb(25, 25, 35);
            TextBox_TaskMembers.Location = new Point(3, 301);
            TextBox_TaskMembers.Margin = new Padding(3, 4, 3, 4);
            TextBox_TaskMembers.Name = "TextBox_TaskMembers";
            TextBox_TaskMembers.Size = new Size(492, 27);
            TextBox_TaskMembers.TabIndex = 14;
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
            Panel_TitleBar.Size = new Size(1847, 69);
            Panel_TitleBar.TabIndex = 19;
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
            Button_TitleBar_Minimalize.Location = new Point(1663, 0);
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
            Button_TitleBar_Maximalize.Location = new Point(1727, 0);
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
            Button_TtitleBar_ExitProgram.Location = new Point(1787, 0);
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
            tableLayoutPanel_Menu.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel_Menu.Location = new Point(362, 235);
            tableLayoutPanel_Menu.Name = "tableLayoutPanel_Menu";
            tableLayoutPanel_Menu.RowCount = 2;
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Menu.Size = new Size(1015, 600);
            tableLayoutPanel_Menu.TabIndex = 20;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 73);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1009, 524);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(Label_TaskTitle, 0, 0);
            tableLayoutPanel2.Controls.Add(TextBox_TaskTitle, 0, 1);
            tableLayoutPanel2.Controls.Add(TextBox_TaskMembers, 0, 7);
            tableLayoutPanel2.Controls.Add(Label_ShortDescription, 0, 2);
            tableLayoutPanel2.Controls.Add(RichTextBox_TaskDescription, 0, 5);
            tableLayoutPanel2.Controls.Add(TextBox_ShortDescription, 0, 3);
            tableLayoutPanel2.Controls.Add(Label_TaskDescription, 0, 4);
            tableLayoutPanel2.Controls.Add(Label_TaskMembers, 0, 6);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(498, 518);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 4);
            tableLayoutPanel3.Controls.Add(Calendar_SetDeadline, 0, 3);
            tableLayoutPanel3.Controls.Add(ComboBox_ChooseSubject, 0, 1);
            tableLayoutPanel3.Controls.Add(Label_SetDeadline, 0, 2);
            tableLayoutPanel3.Controls.Add(Label_ChooseSubject, 0, 0);
            tableLayoutPanel3.Location = new Point(507, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(499, 518);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(Button_SaveEditedProj, 1, 0);
            tableLayoutPanel4.Controls.Add(Button_ExitProjEditor, 0, 0);
            tableLayoutPanel4.Location = new Point(3, 334);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(493, 125);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // Form_EditProj
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 55);
            ClientSize = new Size(1847, 1004);
            Controls.Add(tableLayoutPanel_Menu);
            Controls.Add(Panel_TitleBar);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1024, 720);
            Name = "Form_EditProj";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_EditProj";
            Panel_TitleBar.ResumeLayout(false);
            Panel_TitleBar.PerformLayout();
            tableLayoutPanel_Menu.ResumeLayout(false);
            tableLayoutPanel_Menu.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label Label_WelcomeMessage;
        private Label Label_TaskTitle;
        private Label Label_ShortDescription;
        private Label Label_TaskDescription;
        private Label Label_TaskMembers;
        private Label Label_ChooseSubject;
        private Label Label_SetDeadline;
        private Button Button_ExitProjEditor;
        private Button Button_SaveEditedProj;
        private MonthCalendar Calendar_SetDeadline;
        private ComboBox ComboBox_ChooseSubject;
        private TextBox TextBox_TaskTitle;
        private TextBox TextBox_ShortDescription;
        private RichTextBox RichTextBox_TaskDescription;
        private TextBox TextBox_TaskMembers;
        private Panel Panel_TitleBar;
        private Label Label_Title;
        private Button Button_TitleBar_Minimalize;
        private Button Button_TitleBar_Maximalize;
        private Button Button_TtitleBar_ExitProgram;
        private TableLayoutPanel tableLayoutPanel_Menu;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
    }
}