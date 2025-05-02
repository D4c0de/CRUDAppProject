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
            Label_TaskTitle = new Label();
            Label_TaskDescription = new Label();
            Label_TaskSource = new Label();
            RichTextBox_TaskSource = new RichTextBox();
            TextBox_TaskTitle = new TextBox();
            Calendar_SetDeadline = new MonthCalendar();
            Label_SetDeadline = new Label();
            RichTextBox_TaskDescription = new RichTextBox();
            Button_ExitExerciseCreator = new Button();
            Button_CreateExercise = new Button();
            ComboBox_ChooseSubject = new ComboBox();
            Label_ChooseSubject = new Label();
            SuspendLayout();
            // 
            // Label_WelcomeMessage
            // 
            Label_WelcomeMessage.AutoSize = true;
            Label_WelcomeMessage.Font = new Font("Segoe UI", 26.25F);
            Label_WelcomeMessage.Location = new Point(566, 9);
            Label_WelcomeMessage.Name = "Label_WelcomeMessage";
            Label_WelcomeMessage.Size = new Size(288, 47);
            Label_WelcomeMessage.TabIndex = 0;
            Label_WelcomeMessage.Text = "Kreator ćwiczenia";
            // 
            // Label_TaskTitle
            // 
            Label_TaskTitle.AutoSize = true;
            Label_TaskTitle.Font = new Font("Segoe UI", 14F);
            Label_TaskTitle.Location = new Point(277, 99);
            Label_TaskTitle.Name = "Label_TaskTitle";
            Label_TaskTitle.Size = new Size(157, 25);
            Label_TaskTitle.TabIndex = 1;
            Label_TaskTitle.Text = "Zatytułuj zadanie";
            // 
            // Label_TaskDescription
            // 
            Label_TaskDescription.AutoSize = true;
            Label_TaskDescription.Font = new Font("Segoe UI", 14F);
            Label_TaskDescription.Location = new Point(242, 212);
            Label_TaskDescription.Name = "Label_TaskDescription";
            Label_TaskDescription.Size = new Size(214, 25);
            Label_TaskDescription.TabIndex = 2;
            Label_TaskDescription.Text = "Wprowadź opis zadania";
            // 
            // Label_TaskSource
            // 
            Label_TaskSource.AutoSize = true;
            Label_TaskSource.Font = new Font("Segoe UI", 14F);
            Label_TaskSource.Location = new Point(242, 468);
            Label_TaskSource.Name = "Label_TaskSource";
            Label_TaskSource.Size = new Size(192, 25);
            Label_TaskSource.TabIndex = 3;
            Label_TaskSource.Text = "Dodaj źródło zadania";
            // 
            // RichTextBox_TaskSource
            // 
            RichTextBox_TaskSource.Location = new Point(35, 496);
            RichTextBox_TaskSource.Name = "RichTextBox_TaskSource";
            RichTextBox_TaskSource.Size = new Size(629, 141);
            RichTextBox_TaskSource.TabIndex = 4;
            RichTextBox_TaskSource.Text = "";
            // 
            // TextBox_TaskTitle
            // 
            TextBox_TaskTitle.Location = new Point(35, 138);
            TextBox_TaskTitle.Name = "TextBox_TaskTitle";
            TextBox_TaskTitle.Size = new Size(629, 23);
            TextBox_TaskTitle.TabIndex = 5;
            // 
            // Calendar_SetDeadline
            // 
            Calendar_SetDeadline.Location = new Point(1075, 266);
            Calendar_SetDeadline.MaxSelectionCount = 1;
            Calendar_SetDeadline.MinDate = DateTime.Now.Date;
            Calendar_SetDeadline.Name = "Calendar_SetDeadline";
            Calendar_SetDeadline.TabIndex = 6;
            // 
            // Label_SetDeadline
            // 
            Label_SetDeadline.AutoSize = true;
            Label_SetDeadline.Font = new Font("Segoe UI", 14F);
            Label_SetDeadline.Location = new Point(1087, 232);
            Label_SetDeadline.Name = "Label_SetDeadline";
            Label_SetDeadline.Size = new Size(242, 25);
            Label_SetDeadline.TabIndex = 7;
            Label_SetDeadline.Text = "Wyznacz termin wykonania";
            // 
            // RichTextBox_TaskDescription
            // 
            RichTextBox_TaskDescription.Location = new Point(35, 254);
            RichTextBox_TaskDescription.Name = "RichTextBox_TaskDescription";
            RichTextBox_TaskDescription.Size = new Size(629, 141);
            RichTextBox_TaskDescription.TabIndex = 8;
            RichTextBox_TaskDescription.Text = "";
            // 
            // Button_ExitExerciseCreator
            // 
            Button_ExitExerciseCreator.Font = new Font("Segoe UI", 18F);
            Button_ExitExerciseCreator.Location = new Point(908, 530);
            Button_ExitExerciseCreator.Name = "Button_ExitExerciseCreator";
            Button_ExitExerciseCreator.Size = new Size(254, 107);
            Button_ExitExerciseCreator.TabIndex = 9;
            Button_ExitExerciseCreator.Text = "Opuść bez zapisywania";
            Button_ExitExerciseCreator.UseVisualStyleBackColor = true;
            // 
            // Button_CreateExercise
            // 
            Button_CreateExercise.Font = new Font("Segoe UI", 18F);
            Button_CreateExercise.Location = new Point(1243, 530);
            Button_CreateExercise.Name = "Button_CreateExercise";
            Button_CreateExercise.Size = new Size(254, 107);
            Button_CreateExercise.TabIndex = 10;
            Button_CreateExercise.Text = "Dodaj zadanie";
            Button_CreateExercise.UseVisualStyleBackColor = true;
            Button_CreateExercise.Click += Button_CreateExercise_Click;
            // 
            // ComboBox_ChooseSubject
            // 
            ComboBox_ChooseSubject.FormattingEnabled = true;
            ComboBox_ChooseSubject.Location = new Point(908, 138);
            ComboBox_ChooseSubject.Name = "ComboBox_ChooseSubject";
            ComboBox_ChooseSubject.Size = new Size(629, 23);
            ComboBox_ChooseSubject.TabIndex = 11;
            // 
            // Label_ChooseSubject
            // 
            Label_ChooseSubject.AutoSize = true;
            Label_ChooseSubject.Font = new Font("Segoe UI", 14F);
            Label_ChooseSubject.Location = new Point(985, 99);
            Label_ChooseSubject.Name = "Label_ChooseSubject";
            Label_ChooseSubject.Size = new Size(479, 25);
            Label_ChooseSubject.TabIndex = 12;
            Label_ChooseSubject.Text = "Wybierz przedmiot do którego chcesz dołączyć zadanie";
            // 
            // Form_CreateExercise
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1608, 745);
            Controls.Add(Label_ChooseSubject);
            Controls.Add(ComboBox_ChooseSubject);
            Controls.Add(Button_CreateExercise);
            Controls.Add(Button_ExitExerciseCreator);
            Controls.Add(RichTextBox_TaskDescription);
            Controls.Add(Label_SetDeadline);
            Controls.Add(Calendar_SetDeadline);
            Controls.Add(TextBox_TaskTitle);
            Controls.Add(RichTextBox_TaskSource);
            Controls.Add(Label_TaskSource);
            Controls.Add(Label_TaskDescription);
            Controls.Add(Label_TaskTitle);
            Controls.Add(Label_WelcomeMessage);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form_CreateExercise";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_CreateExercise";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_WelcomeMessage;
        private Label Label_TaskTitle;
        private Label Label_TaskDescription;
        private Label Label_TaskSource;
        private RichTextBox RichTextBox_TaskSource;
        private TextBox TextBox_TaskTitle;
        private MonthCalendar Calendar_SetDeadline;
        private Label Label_SetDeadline;
        private RichTextBox RichTextBox_TaskDescription;
        private Button Button_ExitExerciseCreator;
        private Button Button_CreateExercise;
        private ComboBox ComboBox_ChooseSubject;
        private Label Label_ChooseSubject;
    }
}