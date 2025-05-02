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
            Label_TaskTitle = new Label();
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
            SuspendLayout();
            // 
            // Label_WelcomeMessage
            // 
            Label_WelcomeMessage.AutoSize = true;
            Label_WelcomeMessage.Font = new Font("Segoe UI", 26.25F);
            Label_WelcomeMessage.Location = new Point(623, 9);
            Label_WelcomeMessage.Name = "Label_WelcomeMessage";
            Label_WelcomeMessage.Size = new Size(272, 47);
            Label_WelcomeMessage.TabIndex = 0;
            Label_WelcomeMessage.Text = "Kreator projektu";
            // 
            // Label_TaskTitle
            // 
            Label_TaskTitle.AutoSize = true;
            Label_TaskTitle.Font = new Font("Segoe UI", 14F);
            Label_TaskTitle.Location = new Point(289, 123);
            Label_TaskTitle.Name = "Label_TaskTitle";
            Label_TaskTitle.Size = new Size(161, 25);
            Label_TaskTitle.TabIndex = 1;
            Label_TaskTitle.Text = "Zatytuułuj projekt";
            // 
            // Label_TaskDescription
            // 
            Label_TaskDescription.AutoSize = true;
            Label_TaskDescription.Font = new Font("Segoe UI", 14F);
            Label_TaskDescription.Location = new Point(225, 328);
            Label_TaskDescription.Name = "Label_TaskDescription";
            Label_TaskDescription.Size = new Size(269, 25);
            Label_TaskDescription.TabIndex = 2;
            Label_TaskDescription.Text = "Wprowadź pełny opis projektu";
            // 
            // Label_TaskMembers
            // 
            Label_TaskMembers.AutoSize = true;
            Label_TaskMembers.Font = new Font("Segoe UI", 14F);
            Label_TaskMembers.Location = new Point(229, 573);
            Label_TaskMembers.Name = "Label_TaskMembers";
            Label_TaskMembers.Size = new Size(221, 25);
            Label_TaskMembers.TabIndex = 3;
            Label_TaskMembers.Text = "Dodaj członków projektu";
            // 
            // Label_ChooseSubject
            // 
            Label_ChooseSubject.AutoSize = true;
            Label_ChooseSubject.Font = new Font("Segoe UI", 14F);
            Label_ChooseSubject.Location = new Point(950, 122);
            Label_ChooseSubject.Name = "Label_ChooseSubject";
            Label_ChooseSubject.Size = new Size(479, 25);
            Label_ChooseSubject.TabIndex = 4;
            Label_ChooseSubject.Text = "Wybierz przedmiot do którego chcesz dołączyć zadanie";
            // 
            // Label_SetDeadline
            // 
            Label_SetDeadline.AutoSize = true;
            Label_SetDeadline.Font = new Font("Segoe UI", 14F);
            Label_SetDeadline.Location = new Point(1098, 232);
            Label_SetDeadline.Name = "Label_SetDeadline";
            Label_SetDeadline.Size = new Size(212, 25);
            Label_SetDeadline.TabIndex = 5;
            Label_SetDeadline.Text = "Wyznacz termin obrony";
            Label_SetDeadline.Click += Label_SetDeadline_Click;
            // 
            // Button_ExitProjectCreator
            // 
            Button_ExitProjectCreator.Font = new Font("Segoe UI", 18F);
            Button_ExitProjectCreator.Location = new Point(923, 530);
            Button_ExitProjectCreator.Name = "Button_ExitProjectCreator";
            Button_ExitProjectCreator.Size = new Size(254, 107);
            Button_ExitProjectCreator.TabIndex = 6;
            Button_ExitProjectCreator.Text = "Opuść bez zapisywania";
            Button_ExitProjectCreator.UseVisualStyleBackColor = true;
            // 
            // Button_CreateProject
            // 
            Button_CreateProject.Font = new Font("Segoe UI", 18F);
            Button_CreateProject.Location = new Point(1223, 530);
            Button_CreateProject.Name = "Button_CreateProject";
            Button_CreateProject.Size = new Size(254, 107);
            Button_CreateProject.TabIndex = 7;
            Button_CreateProject.Text = "Dodaj projekt";
            Button_CreateProject.UseVisualStyleBackColor = true;
            Button_CreateProject.Click += Button_CreateProject_Click;
            // 
            // Calendar_SetDeadline
            // 
            Calendar_SetDeadline.Location = new Point(1075, 266);
            Calendar_SetDeadline.Name = "Calendar_SetDeadline";
            Calendar_SetDeadline.TabIndex = 6;
            // 
            // TextBox_TaskTitle
            // 
            TextBox_TaskTitle.Location = new Point(32, 154);
            TextBox_TaskTitle.Name = "TextBox_TaskTitle";
            TextBox_TaskTitle.Size = new Size(629, 23);
            TextBox_TaskTitle.TabIndex = 9;
            // 
            // RichTextBox_TaskDescription
            // 
            RichTextBox_TaskDescription.Location = new Point(32, 356);
            RichTextBox_TaskDescription.Name = "RichTextBox_TaskDescription";
            RichTextBox_TaskDescription.Size = new Size(629, 141);
            RichTextBox_TaskDescription.TabIndex = 10;
            RichTextBox_TaskDescription.Text = "";
            // 
            // ComboBox_ChooseSubject
            // 
            ComboBox_ChooseSubject.FormattingEnabled = true;
            ComboBox_ChooseSubject.Location = new Point(865, 150);
            ComboBox_ChooseSubject.Name = "ComboBox_ChooseSubject";
            ComboBox_ChooseSubject.Size = new Size(629, 23);
            ComboBox_ChooseSubject.TabIndex = 12;
            // 
            // TextBox_TaskMembers
            // 
            TextBox_TaskMembers.Location = new Point(32, 614);
            TextBox_TaskMembers.Name = "TextBox_TaskMembers";
            TextBox_TaskMembers.Size = new Size(629, 23);
            TextBox_TaskMembers.TabIndex = 13;
            // 
            // TextBox_ShortDescription
            // 
            TextBox_ShortDescription.Location = new Point(32, 252);
            TextBox_ShortDescription.Name = "TextBox_ShortDescription";
            TextBox_ShortDescription.Size = new Size(629, 23);
            TextBox_ShortDescription.TabIndex = 14;
            // 
            // Label_ShortDescription
            // 
            Label_ShortDescription.AutoSize = true;
            Label_ShortDescription.Font = new Font("Segoe UI", 14F);
            Label_ShortDescription.Location = new Point(255, 224);
            Label_ShortDescription.Name = "Label_ShortDescription";
            Label_ShortDescription.Size = new Size(195, 25);
            Label_ShortDescription.TabIndex = 15;
            Label_ShortDescription.Text = "Wprowadź krótki opis";
            Label_ShortDescription.Click += label1_Click;
            // 
            // Form_CreateProj
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1608, 745);
            Controls.Add(Label_ShortDescription);
            Controls.Add(TextBox_ShortDescription);
            Controls.Add(TextBox_TaskMembers);
            Controls.Add(ComboBox_ChooseSubject);
            Controls.Add(RichTextBox_TaskDescription);
            Controls.Add(TextBox_TaskTitle);
            Controls.Add(Calendar_SetDeadline);
            Controls.Add(Button_CreateProject);
            Controls.Add(Button_ExitProjectCreator);
            Controls.Add(Label_SetDeadline);
            Controls.Add(Label_ChooseSubject);
            Controls.Add(Label_TaskMembers);
            Controls.Add(Label_TaskDescription);
            Controls.Add(Label_TaskTitle);
            Controls.Add(Label_WelcomeMessage);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form_CreateProj";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_CreateProj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_WelcomeMessage;
        private Label Label_TaskTitle;
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
    }
}