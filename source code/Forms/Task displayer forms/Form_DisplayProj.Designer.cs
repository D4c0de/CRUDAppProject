namespace CRUDAppProject.Forms.Task_display_forms
{
    partial class Form_DisplayProj
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
            Label_TaskSubject = new Label();
            Label_TaskDescription = new Label();
            Label_TaskDeadline = new Label();
            Label_TaskMembers = new Label();
            Button_ExitProjectDisplayer = new Button();
            Button_RemoveTask = new Button();
            Button_EditTask = new Button();
            TextBox_TaskTitle = new TextBox();
            TextBox_ShortDescription = new TextBox();
            TextBox_TaskSubject = new TextBox();
            TextBox_TaskDeadline = new TextBox();
            TextBox_TaskMembers = new TextBox();
            RichTextBox_TaskDescription = new RichTextBox();
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
            // Label_WelcomeMessage
            // 
            Label_WelcomeMessage.Anchor = AnchorStyles.Top;
            Label_WelcomeMessage.AutoSize = true;
            Label_WelcomeMessage.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            Label_WelcomeMessage.ForeColor = Color.White;
            Label_WelcomeMessage.Location = new Point(297, 0);
            Label_WelcomeMessage.Name = "Label_WelcomeMessage";
            Label_WelcomeMessage.Size = new Size(436, 48);
            Label_WelcomeMessage.TabIndex = 0;
            Label_WelcomeMessage.Text = "Wyświetlanie projektu";
            // 
            // Label_TaskTitle
            // 
            Label_TaskTitle.AutoSize = true;
            Label_TaskTitle.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_TaskTitle.ForeColor = Color.White;
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
            Label_ShortDescription.ForeColor = Color.White;
            Label_ShortDescription.Location = new Point(3, 67);
            Label_ShortDescription.Name = "Label_ShortDescription";
            Label_ShortDescription.Size = new Size(262, 32);
            Label_ShortDescription.TabIndex = 2;
            Label_ShortDescription.Text = "Krótki opis projektu";
            // 
            // Label_TaskSubject
            // 
            Label_TaskSubject.AutoSize = true;
            Label_TaskSubject.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_TaskSubject.ForeColor = Color.White;
            Label_TaskSubject.Location = new Point(3, 134);
            Label_TaskSubject.Name = "Label_TaskSubject";
            Label_TaskSubject.Size = new Size(444, 32);
            Label_TaskSubject.TabIndex = 3;
            Label_TaskSubject.Text = "Przedmiot którego dotyczy projekt";
            // 
            // Label_TaskDescription
            // 
            Label_TaskDescription.AutoSize = true;
            Label_TaskDescription.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_TaskDescription.ForeColor = Color.White;
            Label_TaskDescription.Location = new Point(3, 201);
            Label_TaskDescription.Name = "Label_TaskDescription";
            Label_TaskDescription.Size = new Size(253, 32);
            Label_TaskDescription.TabIndex = 4;
            Label_TaskDescription.Text = "Pełny opis projektu";
            // 
            // Label_TaskDeadline
            // 
            Label_TaskDeadline.AutoSize = true;
            Label_TaskDeadline.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_TaskDeadline.ForeColor = Color.White;
            Label_TaskDeadline.Location = new Point(3, 295);
            Label_TaskDeadline.Name = "Label_TaskDeadline";
            Label_TaskDeadline.Size = new Size(194, 32);
            Label_TaskDeadline.TabIndex = 5;
            Label_TaskDeadline.Text = "Termin obrony";
            // 
            // Label_TaskMembers
            // 
            Label_TaskMembers.AutoSize = true;
            Label_TaskMembers.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Label_TaskMembers.ForeColor = Color.White;
            Label_TaskMembers.Location = new Point(3, 362);
            Label_TaskMembers.Name = "Label_TaskMembers";
            Label_TaskMembers.Size = new Size(268, 32);
            Label_TaskMembers.TabIndex = 6;
            Label_TaskMembers.Text = "Członkowie projektu";
            // 
            // Button_ExitProjectDisplayer
            // 
            Button_ExitProjectDisplayer.BackColor = Color.FromArgb(0, 31, 132);
            Button_ExitProjectDisplayer.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_ExitProjectDisplayer.ForeColor = Color.White;
            Button_ExitProjectDisplayer.Location = new Point(3, 4);
            Button_ExitProjectDisplayer.Margin = new Padding(3, 4, 3, 4);
            Button_ExitProjectDisplayer.Name = "Button_ExitProjectDisplayer";
            Button_ExitProjectDisplayer.Size = new Size(290, 143);
            Button_ExitProjectDisplayer.TabIndex = 7;
            Button_ExitProjectDisplayer.Text = "Opuść bez zapisywania";
            Button_ExitProjectDisplayer.UseVisualStyleBackColor = false;
            Button_ExitProjectDisplayer.Click += Button_ExitProjectDisplayer_Click;
            Button_ExitProjectDisplayer.MouseEnter += Menu_Button_Enter;
            Button_ExitProjectDisplayer.MouseLeave += Menu_Button_Leave;
            // 
            // Button_RemoveTask
            // 
            Button_RemoveTask.BackColor = Color.FromArgb(0, 31, 132);
            Button_RemoveTask.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_RemoveTask.ForeColor = Color.White;
            Button_RemoveTask.Location = new Point(3, 178);
            Button_RemoveTask.Margin = new Padding(3, 4, 3, 4);
            Button_RemoveTask.Name = "Button_RemoveTask";
            Button_RemoveTask.Size = new Size(290, 143);
            Button_RemoveTask.TabIndex = 8;
            Button_RemoveTask.Text = "Usuń zadanie";
            Button_RemoveTask.UseVisualStyleBackColor = false;
            Button_RemoveTask.Click += Button_RemoveTask_Click;
            Button_RemoveTask.MouseEnter += Menu_Button_Enter;
            Button_RemoveTask.MouseLeave += Menu_Button_Leave;
            // 
            // Button_EditTask
            // 
            Button_EditTask.BackColor = Color.FromArgb(0, 31, 132);
            Button_EditTask.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_EditTask.ForeColor = Color.White;
            Button_EditTask.Location = new Point(3, 352);
            Button_EditTask.Margin = new Padding(3, 4, 3, 4);
            Button_EditTask.Name = "Button_EditTask";
            Button_EditTask.Size = new Size(290, 143);
            Button_EditTask.TabIndex = 9;
            Button_EditTask.Text = "Edytuj treść zadania";
            Button_EditTask.UseVisualStyleBackColor = false;
            Button_EditTask.Click += Button_EditTask_Click;
            Button_EditTask.MouseEnter += Menu_Button_Enter;
            Button_EditTask.MouseLeave += Menu_Button_Leave;
            // 
            // TextBox_TaskTitle
            // 
            TextBox_TaskTitle.BackColor = Color.FromArgb(25, 25, 35);
            TextBox_TaskTitle.ForeColor = Color.White;
            TextBox_TaskTitle.Location = new Point(3, 36);
            TextBox_TaskTitle.Margin = new Padding(3, 4, 3, 4);
            TextBox_TaskTitle.Name = "TextBox_TaskTitle";
            TextBox_TaskTitle.ReadOnly = true;
            TextBox_TaskTitle.Size = new Size(500, 27);
            TextBox_TaskTitle.TabIndex = 10;
            // 
            // TextBox_ShortDescription
            // 
            TextBox_ShortDescription.BackColor = Color.FromArgb(25, 25, 35);
            TextBox_ShortDescription.ForeColor = Color.White;
            TextBox_ShortDescription.Location = new Point(3, 103);
            TextBox_ShortDescription.Margin = new Padding(3, 4, 3, 4);
            TextBox_ShortDescription.Name = "TextBox_ShortDescription";
            TextBox_ShortDescription.ReadOnly = true;
            TextBox_ShortDescription.Size = new Size(500, 27);
            TextBox_ShortDescription.TabIndex = 11;
            // 
            // TextBox_TaskSubject
            // 
            TextBox_TaskSubject.BackColor = Color.FromArgb(25, 25, 35);
            TextBox_TaskSubject.ForeColor = Color.White;
            TextBox_TaskSubject.Location = new Point(3, 170);
            TextBox_TaskSubject.Margin = new Padding(3, 4, 3, 4);
            TextBox_TaskSubject.Name = "TextBox_TaskSubject";
            TextBox_TaskSubject.ReadOnly = true;
            TextBox_TaskSubject.Size = new Size(500, 27);
            TextBox_TaskSubject.TabIndex = 12;
            // 
            // TextBox_TaskDeadline
            // 
            TextBox_TaskDeadline.BackColor = Color.FromArgb(25, 25, 35);
            TextBox_TaskDeadline.ForeColor = Color.White;
            TextBox_TaskDeadline.Location = new Point(3, 331);
            TextBox_TaskDeadline.Margin = new Padding(3, 4, 3, 4);
            TextBox_TaskDeadline.Name = "TextBox_TaskDeadline";
            TextBox_TaskDeadline.ReadOnly = true;
            TextBox_TaskDeadline.Size = new Size(500, 27);
            TextBox_TaskDeadline.TabIndex = 13;
            // 
            // TextBox_TaskMembers
            // 
            TextBox_TaskMembers.BackColor = Color.FromArgb(25, 25, 35);
            TextBox_TaskMembers.ForeColor = Color.White;
            TextBox_TaskMembers.Location = new Point(3, 398);
            TextBox_TaskMembers.Margin = new Padding(3, 4, 3, 4);
            TextBox_TaskMembers.Name = "TextBox_TaskMembers";
            TextBox_TaskMembers.ReadOnly = true;
            TextBox_TaskMembers.Size = new Size(500, 27);
            TextBox_TaskMembers.TabIndex = 14;
            // 
            // RichTextBox_TaskDescription
            // 
            RichTextBox_TaskDescription.BackColor = Color.FromArgb(25, 25, 35);
            RichTextBox_TaskDescription.ForeColor = Color.White;
            RichTextBox_TaskDescription.Location = new Point(3, 237);
            RichTextBox_TaskDescription.Margin = new Padding(3, 4, 3, 4);
            RichTextBox_TaskDescription.Name = "RichTextBox_TaskDescription";
            RichTextBox_TaskDescription.ReadOnly = true;
            RichTextBox_TaskDescription.Size = new Size(500, 54);
            RichTextBox_TaskDescription.TabIndex = 15;
            RichTextBox_TaskDescription.Text = "";
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
            tableLayoutPanel_Menu.AutoSize = true;
            tableLayoutPanel_Menu.BackColor = Color.Transparent;
            tableLayoutPanel_Menu.ColumnCount = 1;
            tableLayoutPanel_Menu.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel_Menu.Controls.Add(Label_WelcomeMessage, 0, 0);
            tableLayoutPanel_Menu.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel_Menu.Location = new Point(58, 191);
            tableLayoutPanel_Menu.Name = "tableLayoutPanel_Menu";
            tableLayoutPanel_Menu.RowCount = 2;
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Menu.Size = new Size(1030, 740);
            tableLayoutPanel_Menu.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 73);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1024, 664);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(Button_ExitProjectDisplayer, 0, 0);
            tableLayoutPanel3.Controls.Add(Button_RemoveTask, 0, 1);
            tableLayoutPanel3.Controls.Add(Button_EditTask, 0, 2);
            tableLayoutPanel3.Location = new Point(726, 70);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(295, 523);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(Label_TaskTitle, 0, 0);
            tableLayoutPanel4.Controls.Add(TextBox_TaskTitle, 0, 1);
            tableLayoutPanel4.Controls.Add(TextBox_TaskMembers, 0, 11);
            tableLayoutPanel4.Controls.Add(RichTextBox_TaskDescription, 0, 7);
            tableLayoutPanel4.Controls.Add(TextBox_TaskDeadline, 0, 9);
            tableLayoutPanel4.Controls.Add(Label_ShortDescription, 0, 2);
            tableLayoutPanel4.Controls.Add(TextBox_ShortDescription, 0, 3);
            tableLayoutPanel4.Controls.Add(Label_TaskMembers, 0, 10);
            tableLayoutPanel4.Controls.Add(Label_TaskSubject, 0, 4);
            tableLayoutPanel4.Controls.Add(TextBox_TaskSubject, 0, 5);
            tableLayoutPanel4.Controls.Add(Label_TaskDescription, 0, 6);
            tableLayoutPanel4.Controls.Add(Label_TaskDeadline, 0, 8);
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 12;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(506, 658);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // Form_DisplayProj
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 55);
            CausesValidation = false;
            ClientSize = new Size(1842, 999);
            Controls.Add(tableLayoutPanel_Menu);
            Controls.Add(Panel_TitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1024, 720);
            Name = "Form_DisplayProj";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_DisplayProj";
            Panel_TitleBar.ResumeLayout(false);
            Panel_TitleBar.PerformLayout();
            tableLayoutPanel_Menu.ResumeLayout(false);
            tableLayoutPanel_Menu.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_WelcomeMessage;
        private Label Label_TaskTitle;
        private Label Label_ShortDescription;
        private Label Label_TaskSubject;
        private Label Label_TaskDescription;
        private Label Label_TaskDeadline;
        private Label Label_TaskMembers;
        private Button Button_ExitProjectDisplayer;
        private Button Button_RemoveTask;
        private Button Button_EditTask;
        private TextBox TextBox_TaskTitle;
        private TextBox TextBox_ShortDescription;
        private TextBox TextBox_TaskSubject;
        private TextBox TextBox_TaskDeadline;
        private TextBox TextBox_TaskMembers;
        private RichTextBox RichTextBox_TaskDescription;
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