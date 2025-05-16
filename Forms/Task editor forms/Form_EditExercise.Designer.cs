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
            SuspendLayout();
            // 
            // Label_WelcomeMessage
            // 
            Label_WelcomeMessage.AutoSize = true;
            Label_WelcomeMessage.Font = new Font("Segoe UI", 26.25F);
            Label_WelcomeMessage.Location = new Point(641, 9);
            Label_WelcomeMessage.Name = "Label_WelcomeMessage";
            Label_WelcomeMessage.Size = new Size(353, 47);
            Label_WelcomeMessage.TabIndex = 0;
            Label_WelcomeMessage.Text = "Edytowanie ćwiczenia";
            // 
            // Label_TaskTitle
            // 
            Label_TaskTitle.AutoSize = true;
            Label_TaskTitle.Font = new Font("Segoe UI", 14F);
            Label_TaskTitle.Location = new Point(42, 71);
            Label_TaskTitle.Name = "Label_TaskTitle";
            Label_TaskTitle.Size = new Size(102, 25);
            Label_TaskTitle.TabIndex = 1;
            Label_TaskTitle.Text = " Ćwiczenie";
            // 
            // Label_ShortDescription
            // 
            Label_ShortDescription.AutoSize = true;
            Label_ShortDescription.Font = new Font("Segoe UI", 14F);
            Label_ShortDescription.Location = new Point(42, 153);
            Label_ShortDescription.Name = "Label_ShortDescription";
            Label_ShortDescription.Size = new Size(188, 25);
            Label_ShortDescription.TabIndex = 2;
            Label_ShortDescription.Text = "Krótki opis ćwiczenia";
            // 
            // Label_TaskDescription
            // 
            Label_TaskDescription.AutoSize = true;
            Label_TaskDescription.Font = new Font("Segoe UI", 14F);
            Label_TaskDescription.Location = new Point(42, 251);
            Label_TaskDescription.Name = "Label_TaskDescription";
            Label_TaskDescription.Size = new Size(184, 25);
            Label_TaskDescription.TabIndex = 3;
            Label_TaskDescription.Text = "Pełny opis ćwiczenia";
            // 
            // Label_TaskSource
            // 
            Label_TaskSource.AutoSize = true;
            Label_TaskSource.Font = new Font("Segoe UI", 14F);
            Label_TaskSource.Location = new Point(42, 447);
            Label_TaskSource.Name = "Label_TaskSource";
            Label_TaskSource.Size = new Size(155, 25);
            Label_TaskSource.TabIndex = 4;
            Label_TaskSource.Text = "Źródło ćwiczenia";
            // 
            // Label_TaskSubject
            // 
            Label_TaskSubject.AutoSize = true;
            Label_TaskSubject.Font = new Font("Segoe UI", 14F);
            Label_TaskSubject.Location = new Point(1065, 100);
            Label_TaskSubject.Name = "Label_TaskSubject";
            Label_TaskSubject.Size = new Size(324, 25);
            Label_TaskSubject.TabIndex = 5;
            Label_TaskSubject.Text = "Przedmiot którego dotyczy ćwiczenie";
            // 
            // Label_SetDeadline
            // 
            Label_SetDeadline.AutoSize = true;
            Label_SetDeadline.Font = new Font("Segoe UI", 14F);
            Label_SetDeadline.Location = new Point(1090, 245);
            Label_SetDeadline.Name = "Label_SetDeadline";
            Label_SetDeadline.Size = new Size(157, 25);
            Label_SetDeadline.TabIndex = 6;
            Label_SetDeadline.Text = "Termin zaliczenia";
            // 
            // TextBox_TaskTitle
            // 
            TextBox_TaskTitle.Location = new Point(42, 99);
            TextBox_TaskTitle.Name = "TextBox_TaskTitle";
            TextBox_TaskTitle.Size = new Size(629, 23);
            TextBox_TaskTitle.TabIndex = 7;
            // 
            // TextBox_ShortDescription
            // 
            TextBox_ShortDescription.Location = new Point(42, 180);
            TextBox_ShortDescription.Name = "TextBox_ShortDescription";
            TextBox_ShortDescription.Size = new Size(629, 23);
            TextBox_ShortDescription.TabIndex = 8;
            // 
            // RichTextBox_TaskDescription
            // 
            RichTextBox_TaskDescription.Location = new Point(42, 279);
            RichTextBox_TaskDescription.Name = "RichTextBox_TaskDescription";
            RichTextBox_TaskDescription.Size = new Size(629, 141);
            RichTextBox_TaskDescription.TabIndex = 9;
            RichTextBox_TaskDescription.Text = "";
            // 
            // RichTextBox_TaskSource
            // 
            RichTextBox_TaskSource.Location = new Point(42, 480);
            RichTextBox_TaskSource.Name = "RichTextBox_TaskSource";
            RichTextBox_TaskSource.Size = new Size(629, 141);
            RichTextBox_TaskSource.TabIndex = 10;
            RichTextBox_TaskSource.Text = "";
            // 
            // ComboBox_ChooseSubject
            // 
            ComboBox_ChooseSubject.FormattingEnabled = true;
            ComboBox_ChooseSubject.Location = new Point(870, 128);
            ComboBox_ChooseSubject.Name = "ComboBox_ChooseSubject";
            ComboBox_ChooseSubject.Size = new Size(629, 23);
            ComboBox_ChooseSubject.TabIndex = 11;
            // 
            // Calendar_SetDeadline
            // 
            Calendar_SetDeadline.Location = new Point(1047, 279);
            Calendar_SetDeadline.Name = "Calendar_SetDeadline";
            Calendar_SetDeadline.TabIndex = 12;
            // 
            // Button_ExitExerciseEditor
            // 
            Button_ExitExerciseEditor.Font = new Font("Segoe UI", 18F);
            Button_ExitExerciseEditor.Location = new Point(879, 514);
            Button_ExitExerciseEditor.Name = "Button_ExitExerciseEditor";
            Button_ExitExerciseEditor.Size = new Size(254, 107);
            Button_ExitExerciseEditor.TabIndex = 13;
            Button_ExitExerciseEditor.Text = "Opuść bez zapisywania";
            Button_ExitExerciseEditor.UseVisualStyleBackColor = true;
            // 
            // Button_SaveEditedExercise
            // 
            Button_SaveEditedExercise.Font = new Font("Segoe UI", 18F);
            Button_SaveEditedExercise.Location = new Point(1254, 514);
            Button_SaveEditedExercise.Name = "Button_SaveEditedExercise";
            Button_SaveEditedExercise.Size = new Size(254, 107);
            Button_SaveEditedExercise.TabIndex = 14;
            Button_SaveEditedExercise.Text = "Zapisz nową treść zadania";
            Button_SaveEditedExercise.UseVisualStyleBackColor = true;
            // 
            // Form_EditExercise
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1612, 749);
            Controls.Add(Button_SaveEditedExercise);
            Controls.Add(Button_ExitExerciseEditor);
            Controls.Add(Calendar_SetDeadline);
            Controls.Add(ComboBox_ChooseSubject);
            Controls.Add(RichTextBox_TaskSource);
            Controls.Add(RichTextBox_TaskDescription);
            Controls.Add(TextBox_ShortDescription);
            Controls.Add(TextBox_TaskTitle);
            Controls.Add(Label_SetDeadline);
            Controls.Add(Label_TaskSubject);
            Controls.Add(Label_TaskSource);
            Controls.Add(Label_TaskDescription);
            Controls.Add(Label_ShortDescription);
            Controls.Add(Label_TaskTitle);
            Controls.Add(Label_WelcomeMessage);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form_EditExercise";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_EditExercise";
            ResumeLayout(false);
            PerformLayout();
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
    }
}