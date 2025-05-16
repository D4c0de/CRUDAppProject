namespace CRUDAppProject.Forms.Task_editor_forms
{
    partial class Form_EditExam
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
            Label_TaskMaterialScope = new Label();
            Label_TaskSubject = new Label();
            Button_ExitExamEditor = new Button();
            Button_SaveEditedExam = new Button();
            Calendar_SetDeadline = new MonthCalendar();
            ComboBox_ChooseSubject = new ComboBox();
            TextBox_TaskTitle = new TextBox();
            TextBox_ShortDescription = new TextBox();
            RichTextBox_TaskDescription = new RichTextBox();
            RichTextBox_TaskMaterialScope = new RichTextBox();
            Label_SetDeadline = new Label();
            SuspendLayout();
            // 
            // Label_WelcomeMessage
            // 
            Label_WelcomeMessage.AutoSize = true;
            Label_WelcomeMessage.Font = new Font("Segoe UI", 26.25F);
            Label_WelcomeMessage.Location = new Point(592, 9);
            Label_WelcomeMessage.Name = "Label_WelcomeMessage";
            Label_WelcomeMessage.Size = new Size(359, 47);
            Label_WelcomeMessage.TabIndex = 0;
            Label_WelcomeMessage.Text = "Edytowanie egzaminu";
            // 
            // Label_TaskTitle
            // 
            Label_TaskTitle.AutoSize = true;
            Label_TaskTitle.Font = new Font("Segoe UI", 14F);
            Label_TaskTitle.Location = new Point(33, 92);
            Label_TaskTitle.Name = "Label_TaskTitle";
            Label_TaskTitle.Size = new Size(84, 25);
            Label_TaskTitle.TabIndex = 1;
            Label_TaskTitle.Text = "Egzamin";
            // 
            // Label_ShortDescription
            // 
            Label_ShortDescription.AutoSize = true;
            Label_ShortDescription.Font = new Font("Segoe UI", 14F);
            Label_ShortDescription.Location = new Point(33, 163);
            Label_ShortDescription.Name = "Label_ShortDescription";
            Label_ShortDescription.Size = new Size(189, 25);
            Label_ShortDescription.TabIndex = 2;
            Label_ShortDescription.Text = "Krótki opis egzaminu";
            // 
            // Label_TaskDescription
            // 
            Label_TaskDescription.AutoSize = true;
            Label_TaskDescription.Font = new Font("Segoe UI", 14F);
            Label_TaskDescription.Location = new Point(33, 252);
            Label_TaskDescription.Name = "Label_TaskDescription";
            Label_TaskDescription.Size = new Size(185, 25);
            Label_TaskDescription.TabIndex = 3;
            Label_TaskDescription.Text = "Pełny opis egzaminu";
            // 
            // Label_TaskMaterialScope
            // 
            Label_TaskMaterialScope.AutoSize = true;
            Label_TaskMaterialScope.Font = new Font("Segoe UI", 14F);
            Label_TaskMaterialScope.Location = new Point(33, 451);
            Label_TaskMaterialScope.Name = "Label_TaskMaterialScope";
            Label_TaskMaterialScope.Size = new Size(152, 25);
            Label_TaskMaterialScope.TabIndex = 4;
            Label_TaskMaterialScope.Text = "Zakres materiału";
            // 
            // Label_TaskSubject
            // 
            Label_TaskSubject.AutoSize = true;
            Label_TaskSubject.Font = new Font("Segoe UI", 14F);
            Label_TaskSubject.Location = new Point(1086, 92);
            Label_TaskSubject.Name = "Label_TaskSubject";
            Label_TaskSubject.Size = new Size(314, 25);
            Label_TaskSubject.TabIndex = 0;
            Label_TaskSubject.Text = "Przedmiot którego dotyczy egzamin";
            // 
            // Button_ExitExamEditor
            // 
            Button_ExitExamEditor.Font = new Font("Segoe UI", 18F);
            Button_ExitExamEditor.Location = new Point(905, 530);
            Button_ExitExamEditor.Name = "Button_ExitExamEditor";
            Button_ExitExamEditor.Size = new Size(254, 107);
            Button_ExitExamEditor.TabIndex = 5;
            Button_ExitExamEditor.Text = "Opuść bez zapisywania";
            Button_ExitExamEditor.UseVisualStyleBackColor = true;
            // 
            // Button_SaveEditedExam
            // 
            Button_SaveEditedExam.Font = new Font("Segoe UI", 18F);
            Button_SaveEditedExam.Location = new Point(1253, 530);
            Button_SaveEditedExam.Name = "Button_SaveEditedExam";
            Button_SaveEditedExam.Size = new Size(254, 107);
            Button_SaveEditedExam.TabIndex = 7;
            Button_SaveEditedExam.Text = "Zapisz nową treść zadania";
            Button_SaveEditedExam.UseVisualStyleBackColor = true;
            // 
            // Calendar_SetDeadline
            // 
            Calendar_SetDeadline.Location = new Point(1076, 252);
            Calendar_SetDeadline.Name = "Calendar_SetDeadline";
            Calendar_SetDeadline.TabIndex = 8;
            // 
            // ComboBox_ChooseSubject
            // 
            ComboBox_ChooseSubject.FormattingEnabled = true;
            ComboBox_ChooseSubject.Location = new Point(878, 120);
            ComboBox_ChooseSubject.Name = "ComboBox_ChooseSubject";
            ComboBox_ChooseSubject.Size = new Size(629, 23);
            ComboBox_ChooseSubject.TabIndex = 9;
            // 
            // TextBox_TaskTitle
            // 
            TextBox_TaskTitle.Location = new Point(33, 120);
            TextBox_TaskTitle.Name = "TextBox_TaskTitle";
            TextBox_TaskTitle.Size = new Size(629, 23);
            TextBox_TaskTitle.TabIndex = 10;
            // 
            // TextBox_ShortDescription
            // 
            TextBox_ShortDescription.Location = new Point(33, 200);
            TextBox_ShortDescription.Name = "TextBox_ShortDescription";
            TextBox_ShortDescription.Size = new Size(629, 23);
            TextBox_ShortDescription.TabIndex = 11;
            // 
            // RichTextBox_TaskDescription
            // 
            RichTextBox_TaskDescription.Location = new Point(33, 289);
            RichTextBox_TaskDescription.Name = "RichTextBox_TaskDescription";
            RichTextBox_TaskDescription.Size = new Size(629, 141);
            RichTextBox_TaskDescription.TabIndex = 12;
            RichTextBox_TaskDescription.Text = "";
            // 
            // RichTextBox_TaskMaterialScope
            // 
            RichTextBox_TaskMaterialScope.Location = new Point(33, 496);
            RichTextBox_TaskMaterialScope.Name = "RichTextBox_TaskMaterialScope";
            RichTextBox_TaskMaterialScope.Size = new Size(629, 141);
            RichTextBox_TaskMaterialScope.TabIndex = 13;
            RichTextBox_TaskMaterialScope.Text = "";
            // 
            // Label_SetDeadline
            // 
            Label_SetDeadline.AutoSize = true;
            Label_SetDeadline.Font = new Font("Segoe UI", 14F);
            Label_SetDeadline.Location = new Point(1115, 200);
            Label_SetDeadline.Name = "Label_SetDeadline";
            Label_SetDeadline.Size = new Size(162, 25);
            Label_SetDeadline.TabIndex = 14;
            Label_SetDeadline.Text = "Termin zaliczenia ";
            // 
            // Form_EditExam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1616, 753);
            Controls.Add(Label_SetDeadline);
            Controls.Add(RichTextBox_TaskMaterialScope);
            Controls.Add(RichTextBox_TaskDescription);
            Controls.Add(TextBox_ShortDescription);
            Controls.Add(TextBox_TaskTitle);
            Controls.Add(ComboBox_ChooseSubject);
            Controls.Add(Calendar_SetDeadline);
            Controls.Add(Button_SaveEditedExam);
            Controls.Add(Button_ExitExamEditor);
            Controls.Add(Label_TaskSubject);
            Controls.Add(Label_TaskMaterialScope);
            Controls.Add(Label_TaskDescription);
            Controls.Add(Label_ShortDescription);
            Controls.Add(Label_TaskTitle);
            Controls.Add(Label_WelcomeMessage);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form_EditExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_EditExam";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_WelcomeMessage;
        private Label Label_TaskTitle;
        private Label Label_ShortDescription;
        private Label Label_TaskDescription;
        private Label Label_TaskMaterialScope;
        private Label Label_TaskSubject;
        private Button Button_ExitExamEditor;
        private Button Button_SaveEditedExam;
        private MonthCalendar Calendar_SetDeadline;
        private ComboBox ComboBox_ChooseSubject;
        private TextBox TextBox_TaskTitle;
        private TextBox TextBox_ShortDescription;
        private RichTextBox RichTextBox_TaskDescription;
        private RichTextBox RichTextBox_TaskMaterialScope;
        private Label Label_SetDeadline;
    }
}