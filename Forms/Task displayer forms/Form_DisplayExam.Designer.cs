namespace CRUDAppProject.Forms.Task_display_forms
{
    partial class Form_DisplayExam
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
            Label_TaskTitle = new Label();
            Label_ShortDescription = new Label();
            Label_TaskSubject = new Label();
            Label_TaskDescription = new Label();
            Label_TaskDeadline = new Label();
            Label_TaskMaterialScope = new Label();
            Label_WelcomeMessage = new Label();
            TextBox_TaskTitle = new TextBox();
            TextBox_ShortDescription = new TextBox();
            TextBox_TaskSubject = new TextBox();
            TextBox_TaskDeadline = new TextBox();
            RichTextBox_TaskDescription = new RichTextBox();
            RichTextBox_TaskMaterialScope = new RichTextBox();
            Button_ExitExamDisplayer = new Button();
            Button_RemoveTask = new Button();
            Button_EditTask = new Button();
            Panel_TitleBar = new Panel();
            Label_Title = new Label();
            Button_TitleBar_Minimalize = new Button();
            Button_TitleBar_Maximalize = new Button();
            Button_TtitleBar_ExitProgram = new Button();
            tableLayoutPanel_Menu = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            Panel_TitleBar.SuspendLayout();
            tableLayoutPanel_Menu.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // Label_TaskTitle
            // 
            Label_TaskTitle.AutoSize = true;
            Label_TaskTitle.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_TaskTitle.Location = new Point(3, 0);
            Label_TaskTitle.Name = "Label_TaskTitle";
            Label_TaskTitle.Size = new Size(120, 32);
            Label_TaskTitle.TabIndex = 0;
            Label_TaskTitle.Text = "Egzamin";
            // 
            // Label_ShortDescription
            // 
            Label_ShortDescription.AutoSize = true;
            Label_ShortDescription.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_ShortDescription.Location = new Point(3, 67);
            Label_ShortDescription.Name = "Label_ShortDescription";
            Label_ShortDescription.Size = new Size(279, 32);
            Label_ShortDescription.TabIndex = 1;
            Label_ShortDescription.Text = "Krótki opis egzaminu";
            // 
            // Label_TaskSubject
            // 
            Label_TaskSubject.AutoSize = true;
            Label_TaskSubject.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_TaskSubject.Location = new Point(3, 134);
            Label_TaskSubject.Name = "Label_TaskSubject";
            Label_TaskSubject.Size = new Size(461, 32);
            Label_TaskSubject.TabIndex = 2;
            Label_TaskSubject.Text = "Przedmiot którego dotyczy egzamin";
            // 
            // Label_TaskDescription
            // 
            Label_TaskDescription.AutoSize = true;
            Label_TaskDescription.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_TaskDescription.Location = new Point(3, 201);
            Label_TaskDescription.Name = "Label_TaskDescription";
            Label_TaskDescription.Size = new Size(270, 32);
            Label_TaskDescription.TabIndex = 3;
            Label_TaskDescription.Text = "Pełny opis egzaminu";
            // 
            // Label_TaskDeadline
            // 
            Label_TaskDeadline.AutoSize = true;
            Label_TaskDeadline.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_TaskDeadline.Location = new Point(3, 279);
            Label_TaskDeadline.Name = "Label_TaskDeadline";
            Label_TaskDeadline.Size = new Size(243, 32);
            Label_TaskDeadline.TabIndex = 4;
            Label_TaskDeadline.Text = "Termin zaliczenia ";
            // 
            // Label_TaskMaterialScope
            // 
            Label_TaskMaterialScope.AutoSize = true;
            Label_TaskMaterialScope.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_TaskMaterialScope.Location = new Point(3, 346);
            Label_TaskMaterialScope.Name = "Label_TaskMaterialScope";
            Label_TaskMaterialScope.Size = new Size(227, 32);
            Label_TaskMaterialScope.TabIndex = 5;
            Label_TaskMaterialScope.Text = "Zakres materiału";
            // 
            // Label_WelcomeMessage
            // 
            Label_WelcomeMessage.Anchor = AnchorStyles.Top;
            Label_WelcomeMessage.AutoSize = true;
            Label_WelcomeMessage.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            Label_WelcomeMessage.Location = new Point(280, 0);
            Label_WelcomeMessage.Name = "Label_WelcomeMessage";
            Label_WelcomeMessage.Size = new Size(459, 48);
            Label_WelcomeMessage.TabIndex = 6;
            Label_WelcomeMessage.Text = "Wyświetlanie egzaminu";
            // 
            // TextBox_TaskTitle
            // 
            TextBox_TaskTitle.BackColor = Color.FromArgb(25, 25, 35);
            TextBox_TaskTitle.Location = new Point(3, 36);
            TextBox_TaskTitle.Margin = new Padding(3, 4, 3, 4);
            TextBox_TaskTitle.Name = "TextBox_TaskTitle";
            TextBox_TaskTitle.ReadOnly = true;
            TextBox_TaskTitle.Size = new Size(495, 27);
            TextBox_TaskTitle.TabIndex = 7;
            // 
            // TextBox_ShortDescription
            // 
            TextBox_ShortDescription.BackColor = Color.FromArgb(25, 25, 35);
            TextBox_ShortDescription.Location = new Point(3, 103);
            TextBox_ShortDescription.Margin = new Padding(3, 4, 3, 4);
            TextBox_ShortDescription.Name = "TextBox_ShortDescription";
            TextBox_ShortDescription.ReadOnly = true;
            TextBox_ShortDescription.Size = new Size(495, 27);
            TextBox_ShortDescription.TabIndex = 8;
            // 
            // TextBox_TaskSubject
            // 
            TextBox_TaskSubject.BackColor = Color.FromArgb(25, 25, 35);
            TextBox_TaskSubject.Location = new Point(3, 170);
            TextBox_TaskSubject.Margin = new Padding(3, 4, 3, 4);
            TextBox_TaskSubject.Name = "TextBox_TaskSubject";
            TextBox_TaskSubject.ReadOnly = true;
            TextBox_TaskSubject.Size = new Size(495, 27);
            TextBox_TaskSubject.TabIndex = 9;
            // 
            // TextBox_TaskDeadline
            // 
            TextBox_TaskDeadline.BackColor = Color.FromArgb(25, 25, 35);
            TextBox_TaskDeadline.Location = new Point(3, 315);
            TextBox_TaskDeadline.Margin = new Padding(3, 4, 3, 4);
            TextBox_TaskDeadline.Name = "TextBox_TaskDeadline";
            TextBox_TaskDeadline.ReadOnly = true;
            TextBox_TaskDeadline.Size = new Size(495, 27);
            TextBox_TaskDeadline.TabIndex = 10;
            // 
            // RichTextBox_TaskDescription
            // 
            RichTextBox_TaskDescription.BackColor = Color.FromArgb(25, 25, 35);
            RichTextBox_TaskDescription.Location = new Point(3, 237);
            RichTextBox_TaskDescription.Margin = new Padding(3, 4, 3, 4);
            RichTextBox_TaskDescription.Name = "RichTextBox_TaskDescription";
            RichTextBox_TaskDescription.ReadOnly = true;
            RichTextBox_TaskDescription.Size = new Size(495, 38);
            RichTextBox_TaskDescription.TabIndex = 11;
            RichTextBox_TaskDescription.Text = "";
            // 
            // RichTextBox_TaskMaterialScope
            // 
            RichTextBox_TaskMaterialScope.BackColor = Color.FromArgb(25, 25, 35);
            RichTextBox_TaskMaterialScope.Location = new Point(3, 382);
            RichTextBox_TaskMaterialScope.Margin = new Padding(3, 4, 3, 4);
            RichTextBox_TaskMaterialScope.Name = "RichTextBox_TaskMaterialScope";
            RichTextBox_TaskMaterialScope.ReadOnly = true;
            RichTextBox_TaskMaterialScope.Size = new Size(495, 44);
            RichTextBox_TaskMaterialScope.TabIndex = 12;
            RichTextBox_TaskMaterialScope.Text = "";
            // 
            // Button_ExitExamDisplayer
            // 
            Button_ExitExamDisplayer.BackColor = Color.FromArgb(0, 31, 132);
            Button_ExitExamDisplayer.Font = new Font("Segoe UI", 18F);
            Button_ExitExamDisplayer.Location = new Point(3, 4);
            Button_ExitExamDisplayer.Margin = new Padding(3, 4, 3, 4);
            Button_ExitExamDisplayer.Name = "Button_ExitExamDisplayer";
            Button_ExitExamDisplayer.Size = new Size(290, 143);
            Button_ExitExamDisplayer.TabIndex = 13;
            Button_ExitExamDisplayer.Text = "Opuść bez zapisywania";
            Button_ExitExamDisplayer.UseVisualStyleBackColor = false;
            Button_ExitExamDisplayer.Click += Button_ExitExamDisplayer_Click;
            Button_ExitExamDisplayer.MouseEnter += Menu_Button_Enter;
            Button_ExitExamDisplayer.MouseLeave += Menu_Button_Leave;
            // 
            // Button_RemoveTask
            // 
            Button_RemoveTask.BackColor = Color.FromArgb(0, 31, 132);
            Button_RemoveTask.Font = new Font("Segoe UI", 18F);
            Button_RemoveTask.Location = new Point(3, 155);
            Button_RemoveTask.Margin = new Padding(3, 4, 3, 4);
            Button_RemoveTask.Name = "Button_RemoveTask";
            Button_RemoveTask.Size = new Size(290, 143);
            Button_RemoveTask.TabIndex = 14;
            Button_RemoveTask.Text = "Usuń zadanie";
            Button_RemoveTask.UseVisualStyleBackColor = false;
            Button_RemoveTask.Click += Button_RemoveTask_Click;
            Button_RemoveTask.MouseEnter += Menu_Button_Enter;
            Button_RemoveTask.MouseLeave += Menu_Button_Leave;
            // 
            // Button_EditTask
            // 
            Button_EditTask.BackColor = Color.FromArgb(0, 31, 132);
            Button_EditTask.Font = new Font("Segoe UI", 18F);
            Button_EditTask.Location = new Point(3, 306);
            Button_EditTask.Margin = new Padding(3, 4, 3, 4);
            Button_EditTask.Name = "Button_EditTask";
            Button_EditTask.Size = new Size(290, 143);
            Button_EditTask.TabIndex = 15;
            Button_EditTask.Text = "Edytuj treść zadania";
            Button_EditTask.UseVisualStyleBackColor = false;
            Button_EditTask.Click += Button_EditTask_Click;
            Button_EditTask.MouseEnter += Menu_Button_Enter;
            Button_EditTask.MouseLeave += Menu_Button_Leave;
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
            tableLayoutPanel_Menu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel_Menu.ColumnCount = 1;
            tableLayoutPanel_Menu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Menu.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel_Menu.Controls.Add(Label_WelcomeMessage, 0, 0);
            tableLayoutPanel_Menu.ForeColor = Color.White;
            tableLayoutPanel_Menu.Location = new Point(328, 138);
            tableLayoutPanel_Menu.Name = "tableLayoutPanel_Menu";
            tableLayoutPanel_Menu.RowCount = 2;
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Menu.Size = new Size(1020, 740);
            tableLayoutPanel_Menu.TabIndex = 18;
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
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1014, 664);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(Label_TaskTitle, 0, 0);
            tableLayoutPanel3.Controls.Add(TextBox_TaskTitle, 0, 1);
            tableLayoutPanel3.Controls.Add(RichTextBox_TaskMaterialScope, 0, 11);
            tableLayoutPanel3.Controls.Add(Label_ShortDescription, 0, 2);
            tableLayoutPanel3.Controls.Add(Label_TaskMaterialScope, 0, 10);
            tableLayoutPanel3.Controls.Add(TextBox_TaskDeadline, 0, 9);
            tableLayoutPanel3.Controls.Add(RichTextBox_TaskDescription, 0, 7);
            tableLayoutPanel3.Controls.Add(TextBox_ShortDescription, 0, 3);
            tableLayoutPanel3.Controls.Add(Label_TaskDeadline, 0, 8);
            tableLayoutPanel3.Controls.Add(Label_TaskSubject, 0, 4);
            tableLayoutPanel3.Controls.Add(TextBox_TaskSubject, 0, 5);
            tableLayoutPanel3.Controls.Add(Label_TaskDescription, 0, 6);
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 12;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(501, 658);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(Button_ExitExamDisplayer, 0, 0);
            tableLayoutPanel4.Controls.Add(Button_RemoveTask, 0, 1);
            tableLayoutPanel4.Controls.Add(Button_EditTask, 0, 2);
            tableLayoutPanel4.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            tableLayoutPanel4.Location = new Point(715, 103);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(296, 457);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // Form_DisplayExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 55);
            ClientSize = new Size(1842, 999);
            Controls.Add(tableLayoutPanel_Menu);
            Controls.Add(Panel_TitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1024, 720);
            Name = "Form_DisplayExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_DisplayExam";
            Panel_TitleBar.ResumeLayout(false);
            Panel_TitleBar.PerformLayout();
            tableLayoutPanel_Menu.ResumeLayout(false);
            tableLayoutPanel_Menu.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label Label_TaskTitle;
        private Label Label_ShortDescription;
        private Label Label_TaskSubject;
        private Label Label_TaskDescription;
        private Label Label_TaskDeadline;
        private Label Label_TaskMaterialScope;
        private Label Label_WelcomeMessage;
        private TextBox TextBox_TaskTitle;
        private TextBox TextBox_ShortDescription;
        private TextBox TextBox_TaskSubject;
        private TextBox TextBox_TaskDeadline;
        private RichTextBox RichTextBox_TaskDescription;
        private RichTextBox RichTextBox_TaskMaterialScope;
        private Button Button_ExitExamDisplayer;
        private Button Button_RemoveTask;
        private Button Button_EditTask;
        private Panel Panel_TitleBar;
        private Label Label_Title;
        private Button Button_TitleBar_Minimalize;
        private Button Button_TitleBar_Maximalize;
        private Button Button_TtitleBar_ExitProgram;
        private TableLayoutPanel tableLayoutPanel_Menu;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
    }
}