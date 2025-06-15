namespace CRUDAppProject.Forms.Task_editor_forms
{
    partial class Form_EditExercise
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
            Label_TaskSource = new Label();
            Label_TaskSubject = new Label();
            Label_SetDeadline = new Label();
            TextBox_TaskTitle = new TextBox();
            TextBox_ShortDescription = new TextBox();
            RichTextBox_TaskDescription = new RichTextBox();
            RichTextBox_TaskSource = new RichTextBox();
            ComboBox_ChooseSubject = new ComboBox();
            Calendar_SetDeadline = new MonthCalendar();
            Button_ExitExerciseEditor = new Button();
            Button_SaveEditedExercise = new Button();
            Panel_TitleBar = new Panel();
            Label_Title = new Label();
            Button_TitleBar_Minimalize = new Button();
            Button_TitleBar_Maximalize = new Button();
            Button_TtitleBar_ExitProgram = new Button();
            tableLayoutPanel_Menu = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
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
            Label_WelcomeMessage.Location = new Point(289, 0);
            Label_WelcomeMessage.Name = "Label_WelcomeMessage";
            Label_WelcomeMessage.Size = new Size(437, 48);
            Label_WelcomeMessage.TabIndex = 0;
            Label_WelcomeMessage.Text = "Edytowanie ćwiczenia";
            // 
            // Label_TaskTitle
            // 
            Label_TaskTitle.AutoSize = true;
            Label_TaskTitle.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_TaskTitle.Location = new Point(3, 0);
            Label_TaskTitle.Name = "Label_TaskTitle";
            Label_TaskTitle.Size = new Size(151, 32);
            Label_TaskTitle.TabIndex = 1;
            Label_TaskTitle.Text = " Ćwiczenie";
            // 
            // Label_ShortDescription
            // 
            Label_ShortDescription.AutoSize = true;
            Label_ShortDescription.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_ShortDescription.Location = new Point(3, 67);
            Label_ShortDescription.Name = "Label_ShortDescription";
            Label_ShortDescription.Size = new Size(285, 32);
            Label_ShortDescription.TabIndex = 2;
            Label_ShortDescription.Text = "Krótki opis ćwiczenia";
            // 
            // Label_TaskDescription
            // 
            Label_TaskDescription.AutoSize = true;
            Label_TaskDescription.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_TaskDescription.Location = new Point(3, 134);
            Label_TaskDescription.Name = "Label_TaskDescription";
            Label_TaskDescription.Size = new Size(276, 32);
            Label_TaskDescription.TabIndex = 3;
            Label_TaskDescription.Text = "Pełny opis ćwiczenia";
            // 
            // Label_TaskSource
            // 
            Label_TaskSource.AutoSize = true;
            Label_TaskSource.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_TaskSource.Location = new Point(3, 249);
            Label_TaskSource.Name = "Label_TaskSource";
            Label_TaskSource.Size = new Size(228, 32);
            Label_TaskSource.TabIndex = 4;
            Label_TaskSource.Text = "Źródło ćwiczenia";
            // 
            // Label_TaskSubject
            // 
            Label_TaskSubject.AutoSize = true;
            Label_TaskSubject.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_TaskSubject.Location = new Point(3, 0);
            Label_TaskSubject.Name = "Label_TaskSubject";
            Label_TaskSubject.Size = new Size(482, 32);
            Label_TaskSubject.TabIndex = 5;
            Label_TaskSubject.Text = "Przedmiot którego dotyczy ćwiczenie";
            // 
            // Label_SetDeadline
            // 
            Label_SetDeadline.AutoSize = true;
            Label_SetDeadline.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_SetDeadline.Location = new Point(3, 68);
            Label_SetDeadline.Name = "Label_SetDeadline";
            Label_SetDeadline.Size = new Size(235, 32);
            Label_SetDeadline.TabIndex = 6;
            Label_SetDeadline.Text = "Termin zaliczenia";
            // 
            // TextBox_TaskTitle
            // 
            TextBox_TaskTitle.BackColor = Color.FromArgb(25, 25, 35);
            TextBox_TaskTitle.ForeColor = Color.White;
            TextBox_TaskTitle.Location = new Point(3, 36);
            TextBox_TaskTitle.Margin = new Padding(3, 4, 3, 4);
            TextBox_TaskTitle.Name = "TextBox_TaskTitle";
            TextBox_TaskTitle.Size = new Size(492, 27);
            TextBox_TaskTitle.TabIndex = 7;
            // 
            // TextBox_ShortDescription
            // 
            TextBox_ShortDescription.BackColor = Color.FromArgb(25, 25, 35);
            TextBox_ShortDescription.ForeColor = Color.White;
            TextBox_ShortDescription.Location = new Point(3, 103);
            TextBox_ShortDescription.Margin = new Padding(3, 4, 3, 4);
            TextBox_ShortDescription.Name = "TextBox_ShortDescription";
            TextBox_ShortDescription.Size = new Size(492, 27);
            TextBox_ShortDescription.TabIndex = 8;
            // 
            // RichTextBox_TaskDescription
            // 
            RichTextBox_TaskDescription.BackColor = Color.FromArgb(25, 25, 35);
            RichTextBox_TaskDescription.ForeColor = Color.White;
            RichTextBox_TaskDescription.Location = new Point(3, 170);
            RichTextBox_TaskDescription.Margin = new Padding(3, 4, 3, 4);
            RichTextBox_TaskDescription.Name = "RichTextBox_TaskDescription";
            RichTextBox_TaskDescription.Size = new Size(492, 75);
            RichTextBox_TaskDescription.TabIndex = 9;
            RichTextBox_TaskDescription.Text = "";
            // 
            // RichTextBox_TaskSource
            // 
            RichTextBox_TaskSource.BackColor = Color.FromArgb(25, 25, 35);
            RichTextBox_TaskSource.ForeColor = Color.White;
            RichTextBox_TaskSource.Location = new Point(3, 285);
            RichTextBox_TaskSource.Margin = new Padding(3, 4, 3, 4);
            RichTextBox_TaskSource.Name = "RichTextBox_TaskSource";
            RichTextBox_TaskSource.Size = new Size(492, 84);
            RichTextBox_TaskSource.TabIndex = 10;
            RichTextBox_TaskSource.Text = "";
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
            ComboBox_ChooseSubject.TabIndex = 11;
            // 
            // Calendar_SetDeadline
            // 
            Calendar_SetDeadline.Anchor = AnchorStyles.Top;
            Calendar_SetDeadline.Location = new Point(87, 112);
            Calendar_SetDeadline.Margin = new Padding(10, 12, 10, 12);
            Calendar_SetDeadline.Name = "Calendar_SetDeadline";
            Calendar_SetDeadline.TabIndex = 12;
            // 
            // Button_ExitExerciseEditor
            // 
            Button_ExitExerciseEditor.BackColor = Color.FromArgb(0, 31, 132);
            Button_ExitExerciseEditor.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_ExitExerciseEditor.Location = new Point(3, 4);
            Button_ExitExerciseEditor.Margin = new Padding(3, 4, 3, 4);
            Button_ExitExerciseEditor.Name = "Button_ExitExerciseEditor";
            Button_ExitExerciseEditor.Size = new Size(240, 143);
            Button_ExitExerciseEditor.TabIndex = 13;
            Button_ExitExerciseEditor.Text = "Opuść bez zapisywania";
            Button_ExitExerciseEditor.UseVisualStyleBackColor = false;
            Button_ExitExerciseEditor.Click += Button_ExitExerciseEditor_Click;
            Button_ExitExerciseEditor.MouseEnter += Menu_Button_Enter;
            Button_ExitExerciseEditor.MouseLeave += Menu_Button_Leave;
            // 
            // Button_SaveEditedExercise
            // 
            Button_SaveEditedExercise.BackColor = Color.FromArgb(0, 31, 132);
            Button_SaveEditedExercise.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_SaveEditedExercise.Location = new Point(249, 4);
            Button_SaveEditedExercise.Margin = new Padding(3, 4, 3, 4);
            Button_SaveEditedExercise.Name = "Button_SaveEditedExercise";
            Button_SaveEditedExercise.Size = new Size(241, 143);
            Button_SaveEditedExercise.TabIndex = 14;
            Button_SaveEditedExercise.Text = "Zapisz nową treść zadania";
            Button_SaveEditedExercise.UseVisualStyleBackColor = false;
            Button_SaveEditedExercise.Click += Button_SaveEditedExercise_Click;
            Button_SaveEditedExercise.MouseEnter += Menu_Button_Enter;
            Button_SaveEditedExercise.MouseLeave += Menu_Button_Leave;
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
            Panel_TitleBar.Size = new Size(1842, 69);
            Panel_TitleBar.TabIndex = 18;
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
            Button_TitleBar_Minimalize.Location = new Point(1658, 0);
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
            Button_TitleBar_Maximalize.Location = new Point(1722, 0);
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
            Button_TtitleBar_ExitProgram.Location = new Point(1782, 0);
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
            tableLayoutPanel_Menu.Location = new Point(339, 133);
            tableLayoutPanel_Menu.Name = "tableLayoutPanel_Menu";
            tableLayoutPanel_Menu.RowCount = 2;
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Menu.Size = new Size(1015, 600);
            tableLayoutPanel_Menu.TabIndex = 19;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel2.Location = new Point(3, 73);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1009, 524);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(Label_TaskTitle, 0, 0);
            tableLayoutPanel3.Controls.Add(TextBox_TaskTitle, 0, 1);
            tableLayoutPanel3.Controls.Add(Label_ShortDescription, 0, 2);
            tableLayoutPanel3.Controls.Add(TextBox_ShortDescription, 0, 3);
            tableLayoutPanel3.Controls.Add(Label_TaskDescription, 0, 4);
            tableLayoutPanel3.Controls.Add(RichTextBox_TaskDescription, 0, 5);
            tableLayoutPanel3.Controls.Add(RichTextBox_TaskSource, 0, 7);
            tableLayoutPanel3.Controls.Add(Label_TaskSource, 0, 6);
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
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 4);
            tableLayoutPanel4.Controls.Add(Calendar_SetDeadline, 0, 3);
            tableLayoutPanel4.Controls.Add(Label_TaskSubject, 0, 0);
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
            tableLayoutPanel4.Size = new Size(499, 518);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(Button_ExitExerciseEditor, 0, 0);
            tableLayoutPanel5.Controls.Add(Button_SaveEditedExercise, 1, 0);
            tableLayoutPanel5.Location = new Point(3, 334);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(493, 184);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // Form_EditExercise
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 55);
            ClientSize = new Size(1842, 999);
            Controls.Add(tableLayoutPanel_Menu);
            Controls.Add(Panel_TitleBar);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1024, 720);
            Name = "Form_EditExercise";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_EditExercise";
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
        private Label Label_TaskTitle;
        private Label Label_ShortDescription;
        private Label Label_TaskDescription;
        private Label Label_TaskSource;
        private Label Label_TaskSubject;
        private Label Label_SetDeadline;
        private TextBox TextBox_TaskTitle;
        private TextBox TextBox_ShortDescription;
        private RichTextBox RichTextBox_TaskDescription;
        private RichTextBox RichTextBox_TaskSource;
        private ComboBox ComboBox_ChooseSubject;
        private MonthCalendar Calendar_SetDeadline;
        private Button Button_ExitExerciseEditor;
        private Button Button_SaveEditedExercise;
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
    }
}