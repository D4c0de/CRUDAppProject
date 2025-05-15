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
            SuspendLayout();
            // 
            // Label_WelcomeMessage
            // 
            Label_WelcomeMessage.AutoSize = true;
            Label_WelcomeMessage.Font = new Font("Segoe UI", 26.25F);
            Label_WelcomeMessage.Location = new Point(661, 9);
            Label_WelcomeMessage.Name = "Label_WelcomeMessage";
            Label_WelcomeMessage.Size = new Size(294, 47);
            Label_WelcomeMessage.TabIndex = 0;
            Label_WelcomeMessage.Text = "Kreator egzaminu";
            // 
            // Label_TaskTitle
            // 
            Label_TaskTitle.AutoSize = true;
            Label_TaskTitle.Font = new Font("Segoe UI", 14F);
            Label_TaskTitle.Location = new Point(252, 110);
            Label_TaskTitle.Name = "Label_TaskTitle";
            Label_TaskTitle.Size = new Size(163, 25);
            Label_TaskTitle.TabIndex = 1;
            Label_TaskTitle.Text = "Zatytułuj egzamin";
            // 
            // Label_TaskDescription
            // 
            Label_TaskDescription.AutoSize = true;
            Label_TaskDescription.Font = new Font("Segoe UI", 14F);
            Label_TaskDescription.Location = new Point(223, 266);
            Label_TaskDescription.Name = "Label_TaskDescription";
            Label_TaskDescription.Size = new Size(282, 25);
            Label_TaskDescription.TabIndex = 2;
            Label_TaskDescription.Text = "Wprowadź pełny opis egzaminu";
            // 
            // Label_TaskMaterialScope
            // 
            Label_TaskMaterialScope.AutoSize = true;
            Label_TaskMaterialScope.Font = new Font("Segoe UI", 14F);
            Label_TaskMaterialScope.Location = new Point(242, 468);
            Label_TaskMaterialScope.Name = "Label_TaskMaterialScope";
            Label_TaskMaterialScope.Size = new Size(205, 25);
            Label_TaskMaterialScope.TabIndex = 3;
            Label_TaskMaterialScope.Text = "Dodaj zakres materiału";
            // 
            // Label_ChooseSubject
            // 
            Label_ChooseSubject.AutoSize = true;
            Label_ChooseSubject.Font = new Font("Segoe UI", 14F);
            Label_ChooseSubject.Location = new Point(985, 99);
            Label_ChooseSubject.Name = "Label_ChooseSubject";
            Label_ChooseSubject.Size = new Size(479, 25);
            Label_ChooseSubject.TabIndex = 4;
            Label_ChooseSubject.Text = "Wybierz przedmiot do którego chcesz dołączyć zadanie";
            // 
            // Button_ExitExamCreator
            // 
            Button_ExitExamCreator.Font = new Font("Segoe UI", 18F);
            Button_ExitExamCreator.Location = new Point(908, 530);
            Button_ExitExamCreator.Name = "Button_ExitExamCreator";
            Button_ExitExamCreator.Size = new Size(254, 107);
            Button_ExitExamCreator.TabIndex = 5;
            Button_ExitExamCreator.Text = "Opuść bez zapisywania";
            Button_ExitExamCreator.UseVisualStyleBackColor = true;
            Button_ExitExamCreator.Click += Button_ExitExamCreator_Click;
            // 
            // Button_CreateExam
            // 
            Button_CreateExam.Font = new Font("Segoe UI", 18F);
            Button_CreateExam.Location = new Point(1243, 530);
            Button_CreateExam.Name = "Button_CreateExam";
            Button_CreateExam.Size = new Size(254, 107);
            Button_CreateExam.TabIndex = 6;
            Button_CreateExam.Text = "Dodaj egzamin";
            Button_CreateExam.UseVisualStyleBackColor = true;
            Button_CreateExam.Click += Button_CreateExam_Click;
            // 
            // Calendar_SetDeadline
            // 
            Calendar_SetDeadline.Location = new Point(1075, 266);
            Calendar_SetDeadline.MaxSelectionCount = 1;
            Calendar_SetDeadline.MinDate = new DateTime(2025, 5, 2, 0, 0, 0, 0);
            Calendar_SetDeadline.Name = "Calendar_SetDeadline";
            Calendar_SetDeadline.TabIndex = 7;
            // 
            // ComboBox_ChooseSubject
            // 
            ComboBox_ChooseSubject.FormattingEnabled = true;
            ComboBox_ChooseSubject.Location = new Point(908, 138);
            ComboBox_ChooseSubject.Name = "ComboBox_ChooseSubject";
            ComboBox_ChooseSubject.Size = new Size(629, 23);
            ComboBox_ChooseSubject.TabIndex = 8;
            // 
            // TextBox_TaskTitle
            // 
            TextBox_TaskTitle.Location = new Point(35, 138);
            TextBox_TaskTitle.Name = "TextBox_TaskTitle";
            TextBox_TaskTitle.Size = new Size(629, 23);
            TextBox_TaskTitle.TabIndex = 9;
            // 
            // RichTextBox_TaskDescription
            // 
            RichTextBox_TaskDescription.Location = new Point(35, 294);
            RichTextBox_TaskDescription.Name = "RichTextBox_TaskDescription";
            RichTextBox_TaskDescription.Size = new Size(629, 141);
            RichTextBox_TaskDescription.TabIndex = 10;
            RichTextBox_TaskDescription.Text = "";
            // 
            // RichTextBox_TaskMaterialScope
            // 
            RichTextBox_TaskMaterialScope.Location = new Point(35, 496);
            RichTextBox_TaskMaterialScope.Name = "RichTextBox_TaskMaterialScope";
            RichTextBox_TaskMaterialScope.Size = new Size(629, 141);
            RichTextBox_TaskMaterialScope.TabIndex = 11;
            RichTextBox_TaskMaterialScope.Text = "";
            // 
            // Label_SetDeadline
            // 
            Label_SetDeadline.AutoSize = true;
            Label_SetDeadline.Font = new Font("Segoe UI", 14F);
            Label_SetDeadline.Location = new Point(1087, 232);
            Label_SetDeadline.Name = "Label_SetDeadline";
            Label_SetDeadline.Size = new Size(235, 25);
            Label_SetDeadline.TabIndex = 12;
            Label_SetDeadline.Text = "Wyznacz termin zaliczenia";
            // 
            // TextBox_ShortDescription
            // 
            TextBox_ShortDescription.Location = new Point(35, 209);
            TextBox_ShortDescription.Name = "TextBox_ShortDescription";
            TextBox_ShortDescription.Size = new Size(629, 23);
            TextBox_ShortDescription.TabIndex = 13;
            // 
            // Label_ShortDescription
            // 
            Label_ShortDescription.AutoSize = true;
            Label_ShortDescription.Font = new Font("Segoe UI", 14F);
            Label_ShortDescription.Location = new Point(252, 181);
            Label_ShortDescription.Name = "Label_ShortDescription";
            Label_ShortDescription.Size = new Size(195, 25);
            Label_ShortDescription.TabIndex = 14;
            Label_ShortDescription.Text = "Wprowadź krótki opis";
            // 
            // Form_CreateExam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1608, 745);
            Controls.Add(Label_ShortDescription);
            Controls.Add(TextBox_ShortDescription);
            Controls.Add(Label_SetDeadline);
            Controls.Add(RichTextBox_TaskMaterialScope);
            Controls.Add(RichTextBox_TaskDescription);
            Controls.Add(TextBox_TaskTitle);
            Controls.Add(ComboBox_ChooseSubject);
            Controls.Add(Calendar_SetDeadline);
            Controls.Add(Button_CreateExam);
            Controls.Add(Button_ExitExamCreator);
            Controls.Add(Label_ChooseSubject);
            Controls.Add(Label_TaskMaterialScope);
            Controls.Add(Label_TaskDescription);
            Controls.Add(Label_TaskTitle);
            Controls.Add(Label_WelcomeMessage);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form_CreateExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_CreateExam";
            ResumeLayout(false);
            PerformLayout();
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
    }
}