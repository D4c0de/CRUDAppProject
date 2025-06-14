using System.Threading.Tasks;

namespace CRUDAppProject.Forms.Logged_in_forms
{
    partial class Form_CreateExercise
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
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            Label_TaskDescription = new Label();
            Label_TaskSource = new Label();
            RichTextBox_TaskDescription = new RichTextBox();
            RichTextBox_TaskSource = new RichTextBox();
            Label_ShortDescription = new Label();
            TextBox_ShortDescription = new TextBox();
            TextBox_TaskTitle = new TextBox();
            Label_TaskTitle = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            Calendar_SetDeadline = new MonthCalendar();
            Label_SetDeadline = new Label();
            ComboBox_ChooseSubject = new ComboBox();
            Label_ChooseSubject = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            Button_CreateExercise = new Button();
            Button_ExitExerciseCreator = new Button();
            tableLayoutPanel_Menu = new TableLayoutPanel();
            Button_TtitleBar_ExitProgram = new Button();
            Button_TitleBar_Maximalize = new Button();
            Button_TitleBar_Minimalize = new Button();
            Label_Title = new Label();
            Panel_TitleBar = new Panel();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel_Menu.SuspendLayout();
            Panel_TitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // Label_WelcomeMessage
            // 
            Label_WelcomeMessage.Anchor = AnchorStyles.Top;
            Label_WelcomeMessage.AutoSize = true;
            Label_WelcomeMessage.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            Label_WelcomeMessage.ForeColor = Color.White;
            Label_WelcomeMessage.Location = new Point(327, 0);
            Label_WelcomeMessage.Name = "Label_WelcomeMessage";
            Label_WelcomeMessage.Size = new Size(361, 48);
            Label_WelcomeMessage.TabIndex = 0;
            Label_WelcomeMessage.Text = "Kreator ćwiczenia";
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
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(Label_TaskTitle, 0, 0);
            tableLayoutPanel3.Controls.Add(TextBox_TaskTitle, 0, 1);
            tableLayoutPanel3.Controls.Add(TextBox_ShortDescription, 0, 3);
            tableLayoutPanel3.Controls.Add(Label_ShortDescription, 0, 2);
            tableLayoutPanel3.Controls.Add(RichTextBox_TaskSource, 0, 7);
            tableLayoutPanel3.Controls.Add(RichTextBox_TaskDescription, 0, 5);
            tableLayoutPanel3.Controls.Add(Label_TaskSource, 0, 6);
            tableLayoutPanel3.Controls.Add(Label_TaskDescription, 0, 4);
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
            // Label_TaskDescription
            // 
            Label_TaskDescription.AutoSize = true;
            Label_TaskDescription.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_TaskDescription.ForeColor = Color.White;
            Label_TaskDescription.Location = new Point(3, 134);
            Label_TaskDescription.Name = "Label_TaskDescription";
            Label_TaskDescription.Size = new Size(381, 32);
            Label_TaskDescription.TabIndex = 2;
            Label_TaskDescription.Text = "Wprowadź pełny opis zadania\r\n";
            // 
            // Label_TaskSource
            // 
            Label_TaskSource.AutoSize = true;
            Label_TaskSource.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_TaskSource.ForeColor = Color.White;
            Label_TaskSource.Location = new Point(3, 248);
            Label_TaskSource.Name = "Label_TaskSource";
            Label_TaskSource.Size = new Size(273, 32);
            Label_TaskSource.TabIndex = 3;
            Label_TaskSource.Text = "Dodaj źródło zadania";
            // 
            // RichTextBox_TaskDescription
            // 
            RichTextBox_TaskDescription.BackColor = Color.FromArgb(25, 25, 35);
            RichTextBox_TaskDescription.ForeColor = Color.White;
            RichTextBox_TaskDescription.Location = new Point(3, 170);
            RichTextBox_TaskDescription.Margin = new Padding(3, 4, 3, 4);
            RichTextBox_TaskDescription.Name = "RichTextBox_TaskDescription";
            RichTextBox_TaskDescription.Size = new Size(492, 74);
            RichTextBox_TaskDescription.TabIndex = 8;
            RichTextBox_TaskDescription.Text = "";
            // 
            // RichTextBox_TaskSource
            // 
            RichTextBox_TaskSource.BackColor = Color.FromArgb(25, 25, 35);
            RichTextBox_TaskSource.ForeColor = Color.White;
            RichTextBox_TaskSource.Location = new Point(3, 284);
            RichTextBox_TaskSource.Margin = new Padding(3, 4, 3, 4);
            RichTextBox_TaskSource.Name = "RichTextBox_TaskSource";
            RichTextBox_TaskSource.Size = new Size(492, 84);
            RichTextBox_TaskSource.TabIndex = 4;
            RichTextBox_TaskSource.Text = "";
            // 
            // Label_ShortDescription
            // 
            Label_ShortDescription.AutoSize = true;
            Label_ShortDescription.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_ShortDescription.ForeColor = Color.White;
            Label_ShortDescription.Location = new Point(3, 67);
            Label_ShortDescription.Name = "Label_ShortDescription";
            Label_ShortDescription.Size = new Size(283, 32);
            Label_ShortDescription.TabIndex = 13;
            Label_ShortDescription.Text = "Wprowadź krótki opis";
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
            // TextBox_TaskTitle
            // 
            TextBox_TaskTitle.BackColor = Color.FromArgb(25, 25, 35);
            TextBox_TaskTitle.ForeColor = Color.White;
            TextBox_TaskTitle.Location = new Point(3, 36);
            TextBox_TaskTitle.Margin = new Padding(3, 4, 3, 4);
            TextBox_TaskTitle.Name = "TextBox_TaskTitle";
            TextBox_TaskTitle.Size = new Size(492, 27);
            TextBox_TaskTitle.TabIndex = 5;
            // 
            // Label_TaskTitle
            // 
            Label_TaskTitle.AutoSize = true;
            Label_TaskTitle.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_TaskTitle.ForeColor = Color.White;
            Label_TaskTitle.Location = new Point(3, 0);
            Label_TaskTitle.Name = "Label_TaskTitle";
            Label_TaskTitle.Size = new Size(230, 32);
            Label_TaskTitle.TabIndex = 1;
            Label_TaskTitle.Text = "Zatytułuj zadanie";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel1, 0, 4);
            tableLayoutPanel4.Controls.Add(Label_ChooseSubject, 0, 0);
            tableLayoutPanel4.Controls.Add(ComboBox_ChooseSubject, 0, 1);
            tableLayoutPanel4.Controls.Add(Label_SetDeadline, 0, 2);
            tableLayoutPanel4.Controls.Add(Calendar_SetDeadline, 0, 3);
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
            // Calendar_SetDeadline
            // 
            Calendar_SetDeadline.Anchor = AnchorStyles.Top;
            Calendar_SetDeadline.Location = new Point(87, 112);
            Calendar_SetDeadline.Margin = new Padding(10, 12, 10, 12);
            Calendar_SetDeadline.MaxSelectionCount = 1;
            Calendar_SetDeadline.MinDate = new DateTime(2025, 5, 2, 0, 0, 0, 0);
            Calendar_SetDeadline.Name = "Calendar_SetDeadline";
            Calendar_SetDeadline.TabIndex = 6;
            // 
            // Label_SetDeadline
            // 
            Label_SetDeadline.AutoSize = true;
            Label_SetDeadline.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_SetDeadline.ForeColor = Color.White;
            Label_SetDeadline.Location = new Point(3, 68);
            Label_SetDeadline.Name = "Label_SetDeadline";
            Label_SetDeadline.Size = new Size(353, 32);
            Label_SetDeadline.TabIndex = 7;
            Label_SetDeadline.Text = "Wyznacz termin wykonania";
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
            // Label_ChooseSubject
            // 
            Label_ChooseSubject.AutoSize = true;
            Label_ChooseSubject.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_ChooseSubject.ForeColor = Color.White;
            Label_ChooseSubject.Location = new Point(3, 0);
            Label_ChooseSubject.Name = "Label_ChooseSubject";
            Label_ChooseSubject.Size = new Size(244, 32);
            Label_ChooseSubject.TabIndex = 12;
            Label_ChooseSubject.Text = "Wybierz przedmiot";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(Button_ExitExerciseCreator, 0, 0);
            tableLayoutPanel1.Controls.Add(Button_CreateExercise, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 334);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(493, 239);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // Button_CreateExercise
            // 
            Button_CreateExercise.BackColor = Color.FromArgb(0, 31, 132);
            Button_CreateExercise.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_CreateExercise.ForeColor = Color.White;
            Button_CreateExercise.Location = new Point(249, 4);
            Button_CreateExercise.Margin = new Padding(3, 4, 3, 4);
            Button_CreateExercise.Name = "Button_CreateExercise";
            Button_CreateExercise.Size = new Size(241, 143);
            Button_CreateExercise.TabIndex = 10;
            Button_CreateExercise.Text = "Dodaj zadanie";
            Button_CreateExercise.UseVisualStyleBackColor = false;
            Button_CreateExercise.Click += Button_CreateExercise_Click;
            Button_CreateExercise.MouseEnter += Menu_Button_Enter;
            Button_CreateExercise.MouseLeave += Menu_Button_Leave;
            // 
            // Button_ExitExerciseCreator
            // 
            Button_ExitExerciseCreator.BackColor = Color.FromArgb(0, 31, 132);
            Button_ExitExerciseCreator.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_ExitExerciseCreator.ForeColor = Color.White;
            Button_ExitExerciseCreator.Location = new Point(3, 4);
            Button_ExitExerciseCreator.Margin = new Padding(3, 4, 3, 4);
            Button_ExitExerciseCreator.Name = "Button_ExitExerciseCreator";
            Button_ExitExerciseCreator.Size = new Size(240, 143);
            Button_ExitExerciseCreator.TabIndex = 9;
            Button_ExitExerciseCreator.Text = "Opuść bez zapisywania";
            Button_ExitExerciseCreator.UseVisualStyleBackColor = false;
            Button_ExitExerciseCreator.Click += Button_ExitExerciseCreator_Click;
            Button_ExitExerciseCreator.MouseEnter += Menu_Button_Enter;
            Button_ExitExerciseCreator.MouseLeave += Menu_Button_Leave;
            // 
            // tableLayoutPanel_Menu
            // 
            tableLayoutPanel_Menu.ColumnCount = 1;
            tableLayoutPanel_Menu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Menu.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel_Menu.Controls.Add(Label_WelcomeMessage, 0, 0);
            tableLayoutPanel_Menu.Location = new Point(257, 119);
            tableLayoutPanel_Menu.Name = "tableLayoutPanel_Menu";
            tableLayoutPanel_Menu.RowCount = 2;
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Menu.Size = new Size(1015, 600);
            tableLayoutPanel_Menu.TabIndex = 17;
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
            // Form_CreateExercise
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
            Name = "Form_CreateExercise";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_CreateExercise";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel_Menu.ResumeLayout(false);
            tableLayoutPanel_Menu.PerformLayout();
            Panel_TitleBar.ResumeLayout(false);
            Panel_TitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Label_WelcomeMessage;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel1;
        private Button Button_ExitExerciseCreator;
        private Button Button_CreateExercise;
        private Label Label_ChooseSubject;
        private ComboBox ComboBox_ChooseSubject;
        private Label Label_SetDeadline;
        private MonthCalendar Calendar_SetDeadline;
        private TableLayoutPanel tableLayoutPanel3;
        private Label Label_TaskTitle;
        private TextBox TextBox_TaskTitle;
        private TextBox TextBox_ShortDescription;
        private Label Label_ShortDescription;
        private RichTextBox RichTextBox_TaskSource;
        private RichTextBox RichTextBox_TaskDescription;
        private Label Label_TaskSource;
        private Label Label_TaskDescription;
        private TableLayoutPanel tableLayoutPanel_Menu;
        private Button Button_TtitleBar_ExitProgram;
        private Button Button_TitleBar_Maximalize;
        private Button Button_TitleBar_Minimalize;
        private Label Label_Title;
        private Panel Panel_TitleBar;
    }
}