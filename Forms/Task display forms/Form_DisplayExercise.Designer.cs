namespace CRUDAppProject.Forms.Task_display_forms
{
    partial class Form_DisplayExercise
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
            Label_TaskSource = new Label();
            Label_TaskSubject = new Label();
            Label_TaskDeadline = new Label();
            Button_ExitExerciseDisplayer = new Button();
            Button_MarkAsDone = new Button();
            Button_EditTask = new Button();
            TextBox_TaskTitle = new TextBox();
            TextBox_ShortDescription = new TextBox();
            RichTextBox_TaskDescription = new RichTextBox();
            RichTextBox_TaskSource = new RichTextBox();
            TextBox_TaskDeadline = new TextBox();
            TextBox_TaskSubject = new TextBox();
            Label_ShortDescription = new Label();
            SuspendLayout();
            // 
            // Label_WelcomeMessage
            // 
            Label_WelcomeMessage.AutoSize = true;
            Label_WelcomeMessage.Font = new Font("Segoe UI", 26.25F);
            Label_WelcomeMessage.Location = new Point(640, 9);
            Label_WelcomeMessage.Name = "Label_WelcomeMessage";
            Label_WelcomeMessage.Size = new Size(375, 47);
            Label_WelcomeMessage.TabIndex = 0;
            Label_WelcomeMessage.Text = "Wyświetlanie ćwiczenia";
            // 
            // Label_TaskTitle
            // 
            Label_TaskTitle.AutoSize = true;
            Label_TaskTitle.Font = new Font("Segoe UI", 14F);
            Label_TaskTitle.Location = new Point(50, 84);
            Label_TaskTitle.Name = "Label_TaskTitle";
            Label_TaskTitle.Size = new Size(97, 25);
            Label_TaskTitle.TabIndex = 1;
            Label_TaskTitle.Text = "Ćwiczenie";
            // 
            // Label_TaskDescription
            // 
            Label_TaskDescription.AutoSize = true;
            Label_TaskDescription.Font = new Font("Segoe UI", 14F);
            Label_TaskDescription.Location = new Point(50, 302);
            Label_TaskDescription.Name = "Label_TaskDescription";
            Label_TaskDescription.Size = new Size(184, 25);
            Label_TaskDescription.TabIndex = 3;
            Label_TaskDescription.Text = "Pełny opis ćwiczenia";
            // 
            // Label_TaskSource
            // 
            Label_TaskSource.AutoSize = true;
            Label_TaskSource.Font = new Font("Segoe UI", 14F);
            Label_TaskSource.Location = new Point(50, 558);
            Label_TaskSource.Name = "Label_TaskSource";
            Label_TaskSource.Size = new Size(155, 25);
            Label_TaskSource.TabIndex = 4;
            Label_TaskSource.Text = "Źródło ćwiczenia";
            // 
            // Label_TaskSubject
            // 
            Label_TaskSubject.AutoSize = true;
            Label_TaskSubject.Font = new Font("Segoe UI", 14F);
            Label_TaskSubject.Location = new Point(50, 227);
            Label_TaskSubject.Name = "Label_TaskSubject";
            Label_TaskSubject.Size = new Size(308, 25);
            Label_TaskSubject.TabIndex = 5;
            Label_TaskSubject.Text = "Przedmiot którego dotyczy zadanie";
            // 
            // Label_TaskDeadline
            // 
            Label_TaskDeadline.AutoSize = true;
            Label_TaskDeadline.Font = new Font("Segoe UI", 14F);
            Label_TaskDeadline.Location = new Point(50, 490);
            Label_TaskDeadline.Name = "Label_TaskDeadline";
            Label_TaskDeadline.Size = new Size(164, 25);
            Label_TaskDeadline.TabIndex = 6;
            Label_TaskDeadline.Text = "Termin wykonania";
            // 
            // Button_ExitExerciseDisplayer
            // 
            Button_ExitExerciseDisplayer.Font = new Font("Segoe UI", 18F);
            Button_ExitExerciseDisplayer.Location = new Point(1155, 122);
            Button_ExitExerciseDisplayer.Name = "Button_ExitExerciseDisplayer";
            Button_ExitExerciseDisplayer.Size = new Size(254, 107);
            Button_ExitExerciseDisplayer.TabIndex = 7;
            Button_ExitExerciseDisplayer.Text = "Opuść bez zapisywania";
            Button_ExitExerciseDisplayer.UseVisualStyleBackColor = true;
            Button_ExitExerciseDisplayer.Click += Button_ExitExerciseDisplayer_Click;
            // 
            // Button_MarkAsDone
            // 
            Button_MarkAsDone.Font = new Font("Segoe UI", 18F);
            Button_MarkAsDone.Location = new Point(1155, 364);
            Button_MarkAsDone.Name = "Button_MarkAsDone";
            Button_MarkAsDone.Size = new Size(254, 107);
            Button_MarkAsDone.TabIndex = 8;
            Button_MarkAsDone.Text = "Oznacz jako wykonane";
            Button_MarkAsDone.UseVisualStyleBackColor = true;
            // 
            // Button_EditTask
            // 
            Button_EditTask.Font = new Font("Segoe UI", 18F);
            Button_EditTask.Location = new Point(1155, 620);
            Button_EditTask.Name = "Button_EditTask";
            Button_EditTask.Size = new Size(254, 107);
            Button_EditTask.TabIndex = 9;
            Button_EditTask.Text = "Edytuj treść zadania";
            Button_EditTask.UseVisualStyleBackColor = true;
            // 
            // TextBox_TaskTitle
            // 
            TextBox_TaskTitle.Location = new Point(50, 122);
            TextBox_TaskTitle.Name = "TextBox_TaskTitle";
            TextBox_TaskTitle.ReadOnly = true;
            TextBox_TaskTitle.Size = new Size(629, 23);
            TextBox_TaskTitle.TabIndex = 10;
            // 
            // TextBox_ShortDescription
            // 
            TextBox_ShortDescription.Location = new Point(50, 187);
            TextBox_ShortDescription.Name = "TextBox_ShortDescription";
            TextBox_ShortDescription.ReadOnly = true;
            TextBox_ShortDescription.Size = new Size(629, 23);
            TextBox_ShortDescription.TabIndex = 11;
            // 
            // RichTextBox_TaskDescription
            // 
            RichTextBox_TaskDescription.Location = new Point(50, 330);
            RichTextBox_TaskDescription.Name = "RichTextBox_TaskDescription";
            RichTextBox_TaskDescription.ReadOnly = true;
            RichTextBox_TaskDescription.Size = new Size(629, 141);
            RichTextBox_TaskDescription.TabIndex = 12;
            RichTextBox_TaskDescription.Text = "";
            // 
            // RichTextBox_TaskSource
            // 
            RichTextBox_TaskSource.Location = new Point(50, 586);
            RichTextBox_TaskSource.Name = "RichTextBox_TaskSource";
            RichTextBox_TaskSource.ReadOnly = true;
            RichTextBox_TaskSource.Size = new Size(629, 141);
            RichTextBox_TaskSource.TabIndex = 13;
            RichTextBox_TaskSource.Text = "";
            // 
            // TextBox_TaskDeadline
            // 
            TextBox_TaskDeadline.Location = new Point(50, 518);
            TextBox_TaskDeadline.Name = "TextBox_TaskDeadline";
            TextBox_TaskDeadline.ReadOnly = true;
            TextBox_TaskDeadline.Size = new Size(629, 23);
            TextBox_TaskDeadline.TabIndex = 14;
            // 
            // TextBox_TaskSubject
            // 
            TextBox_TaskSubject.Location = new Point(50, 255);
            TextBox_TaskSubject.Name = "TextBox_TaskSubject";
            TextBox_TaskSubject.ReadOnly = true;
            TextBox_TaskSubject.Size = new Size(629, 23);
            TextBox_TaskSubject.TabIndex = 15;
            // 
            // Label_ShortDescription
            // 
            Label_ShortDescription.AutoSize = true;
            Label_ShortDescription.Font = new Font("Segoe UI", 14F);
            Label_ShortDescription.Location = new Point(50, 159);
            Label_ShortDescription.Name = "Label_ShortDescription";
            Label_ShortDescription.Size = new Size(188, 25);
            Label_ShortDescription.TabIndex = 2;
            Label_ShortDescription.Text = "Krótki opis ćwiczenia";
            // 
            // Form_DisplayExercise
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1612, 749);
            Controls.Add(TextBox_TaskSubject);
            Controls.Add(TextBox_TaskDeadline);
            Controls.Add(RichTextBox_TaskSource);
            Controls.Add(RichTextBox_TaskDescription);
            Controls.Add(TextBox_ShortDescription);
            Controls.Add(TextBox_TaskTitle);
            Controls.Add(Button_EditTask);
            Controls.Add(Button_MarkAsDone);
            Controls.Add(Button_ExitExerciseDisplayer);
            Controls.Add(Label_TaskDeadline);
            Controls.Add(Label_TaskSubject);
            Controls.Add(Label_TaskSource);
            Controls.Add(Label_TaskDescription);
            Controls.Add(Label_ShortDescription);
            Controls.Add(Label_TaskTitle);
            Controls.Add(Label_WelcomeMessage);
            Name = "Form_DisplayExercise";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_DisplayExercise";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_WelcomeMessage;
        private Label Label_TaskTitle;
        private Label Label_TaskDescription;
        private Label Label_TaskSource;
        private Label Label_TaskSubject;
        private Label Label_TaskDeadline;
        private Button Button_ExitExerciseDisplayer;
        private Button Button_MarkAsDone;
        private Button Button_EditTask;
        private TextBox TextBox_TaskTitle;
        private TextBox TextBox_ShortDescription;
        private RichTextBox RichTextBox_TaskDescription;
        private RichTextBox RichTextBox_TaskSource;
        private TextBox TextBox_TaskDeadline;
        private TextBox TextBox_TaskSubject;
        private Label Label_ShortDescription;
    }
}