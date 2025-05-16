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
            SuspendLayout();
            // 
            // Label_TaskTitle
            // 
            Label_TaskTitle.AutoSize = true;
            Label_TaskTitle.Font = new Font("Segoe UI", 14F);
            Label_TaskTitle.Location = new Point(35, 49);
            Label_TaskTitle.Name = "Label_TaskTitle";
            Label_TaskTitle.Size = new Size(84, 25);
            Label_TaskTitle.TabIndex = 0;
            Label_TaskTitle.Text = "Egzamin";
            // 
            // Label_ShortDescription
            // 
            Label_ShortDescription.AutoSize = true;
            Label_ShortDescription.Font = new Font("Segoe UI", 14F);
            Label_ShortDescription.Location = new Point(35, 111);
            Label_ShortDescription.Name = "Label_ShortDescription";
            Label_ShortDescription.Size = new Size(189, 25);
            Label_ShortDescription.TabIndex = 1;
            Label_ShortDescription.Text = "Krótki opis egzaminu";
            // 
            // Label_TaskSubject
            // 
            Label_TaskSubject.AutoSize = true;
            Label_TaskSubject.Font = new Font("Segoe UI", 14F);
            Label_TaskSubject.Location = new Point(35, 181);
            Label_TaskSubject.Name = "Label_TaskSubject";
            Label_TaskSubject.Size = new Size(314, 25);
            Label_TaskSubject.TabIndex = 2;
            Label_TaskSubject.Text = "Przedmiot którego dotyczy egzamin";
            // 
            // Label_TaskDescription
            // 
            Label_TaskDescription.AutoSize = true;
            Label_TaskDescription.Font = new Font("Segoe UI", 14F);
            Label_TaskDescription.Location = new Point(35, 251);
            Label_TaskDescription.Name = "Label_TaskDescription";
            Label_TaskDescription.Size = new Size(185, 25);
            Label_TaskDescription.TabIndex = 3;
            Label_TaskDescription.Text = "Pełny opis egzaminu";
            // 
            // Label_TaskDeadline
            // 
            Label_TaskDeadline.AutoSize = true;
            Label_TaskDeadline.Font = new Font("Segoe UI", 14F);
            Label_TaskDeadline.Location = new Point(35, 443);
            Label_TaskDeadline.Name = "Label_TaskDeadline";
            Label_TaskDeadline.Size = new Size(162, 25);
            Label_TaskDeadline.TabIndex = 4;
            Label_TaskDeadline.Text = "Termin zaliczenia ";
            // 
            // Label_TaskMaterialScope
            // 
            Label_TaskMaterialScope.AutoSize = true;
            Label_TaskMaterialScope.Font = new Font("Segoe UI", 14F);
            Label_TaskMaterialScope.Location = new Point(35, 525);
            Label_TaskMaterialScope.Name = "Label_TaskMaterialScope";
            Label_TaskMaterialScope.Size = new Size(152, 25);
            Label_TaskMaterialScope.TabIndex = 5;
            Label_TaskMaterialScope.Text = "Zakres materiału";
            // 
            // Label_WelcomeMessage
            // 
            Label_WelcomeMessage.AutoSize = true;
            Label_WelcomeMessage.Font = new Font("Segoe UI", 26.25F);
            Label_WelcomeMessage.Location = new Point(668, 9);
            Label_WelcomeMessage.Name = "Label_WelcomeMessage";
            Label_WelcomeMessage.Size = new Size(381, 47);
            Label_WelcomeMessage.TabIndex = 6;
            Label_WelcomeMessage.Text = "Wyświetlanie egzaminu";
            // 
            // TextBox_TaskTitle
            // 
            TextBox_TaskTitle.Location = new Point(35, 77);
            TextBox_TaskTitle.Name = "TextBox_TaskTitle";
            TextBox_TaskTitle.ReadOnly = true;
            TextBox_TaskTitle.Size = new Size(629, 23);
            TextBox_TaskTitle.TabIndex = 7;
            // 
            // TextBox_ShortDescription
            // 
            TextBox_ShortDescription.Location = new Point(35, 139);
            TextBox_ShortDescription.Name = "TextBox_ShortDescription";
            TextBox_ShortDescription.ReadOnly = true;
            TextBox_ShortDescription.Size = new Size(629, 23);
            TextBox_ShortDescription.TabIndex = 8;
            // 
            // TextBox_TaskSubject
            // 
            TextBox_TaskSubject.Location = new Point(35, 209);
            TextBox_TaskSubject.Name = "TextBox_TaskSubject";
            TextBox_TaskSubject.ReadOnly = true;
            TextBox_TaskSubject.Size = new Size(629, 23);
            TextBox_TaskSubject.TabIndex = 9;
            // 
            // TextBox_TaskDeadline
            // 
            TextBox_TaskDeadline.Location = new Point(35, 471);
            TextBox_TaskDeadline.Name = "TextBox_TaskDeadline";
            TextBox_TaskDeadline.ReadOnly = true;
            TextBox_TaskDeadline.Size = new Size(629, 23);
            TextBox_TaskDeadline.TabIndex = 10;
            // 
            // RichTextBox_TaskDescription
            // 
            RichTextBox_TaskDescription.Location = new Point(35, 279);
            RichTextBox_TaskDescription.Name = "RichTextBox_TaskDescription";
            RichTextBox_TaskDescription.ReadOnly = true;
            RichTextBox_TaskDescription.Size = new Size(629, 141);
            RichTextBox_TaskDescription.TabIndex = 11;
            RichTextBox_TaskDescription.Text = "";
            // 
            // RichTextBox_TaskMaterialScope
            // 
            RichTextBox_TaskMaterialScope.Location = new Point(35, 553);
            RichTextBox_TaskMaterialScope.Name = "RichTextBox_TaskMaterialScope";
            RichTextBox_TaskMaterialScope.ReadOnly = true;
            RichTextBox_TaskMaterialScope.Size = new Size(629, 141);
            RichTextBox_TaskMaterialScope.TabIndex = 12;
            RichTextBox_TaskMaterialScope.Text = "";
            // 
            // Button_ExitExamDisplayer
            // 
            Button_ExitExamDisplayer.Font = new Font("Segoe UI", 18F);
            Button_ExitExamDisplayer.Location = new Point(1154, 77);
            Button_ExitExamDisplayer.Name = "Button_ExitExamDisplayer";
            Button_ExitExamDisplayer.Size = new Size(254, 107);
            Button_ExitExamDisplayer.TabIndex = 13;
            Button_ExitExamDisplayer.Text = "Opuść bez zapisywania";
            Button_ExitExamDisplayer.UseVisualStyleBackColor = true;
            Button_ExitExamDisplayer.Click += Button_ExitExamDisplayer_Click;
            // 
            // Button_RemoveTask
            // 
            Button_RemoveTask.Font = new Font("Segoe UI", 18F);
            Button_RemoveTask.Location = new Point(1154, 313);
            Button_RemoveTask.Name = "Button_RemoveTask";
            Button_RemoveTask.Size = new Size(254, 107);
            Button_RemoveTask.TabIndex = 14;
            Button_RemoveTask.Text = "Usuń zadanie";
            Button_RemoveTask.UseVisualStyleBackColor = true;
            Button_RemoveTask.Click += Button_RemoveTask_Click;
            // 
            // Button_EditTask
            // 
            Button_EditTask.Font = new Font("Segoe UI", 18F);
            Button_EditTask.Location = new Point(1154, 587);
            Button_EditTask.Name = "Button_EditTask";
            Button_EditTask.Size = new Size(254, 107);
            Button_EditTask.TabIndex = 15;
            Button_EditTask.Text = "Edytuj treść zadania";
            Button_EditTask.UseVisualStyleBackColor = true;
            Button_EditTask.Click += Button_EditTask_Click;
            // 
            // Form_DisplayExam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1612, 749);
            Controls.Add(Button_EditTask);
            Controls.Add(Button_RemoveTask);
            Controls.Add(Button_ExitExamDisplayer);
            Controls.Add(RichTextBox_TaskMaterialScope);
            Controls.Add(RichTextBox_TaskDescription);
            Controls.Add(TextBox_TaskDeadline);
            Controls.Add(TextBox_TaskSubject);
            Controls.Add(TextBox_ShortDescription);
            Controls.Add(TextBox_TaskTitle);
            Controls.Add(Label_WelcomeMessage);
            Controls.Add(Label_TaskMaterialScope);
            Controls.Add(Label_TaskDeadline);
            Controls.Add(Label_TaskDescription);
            Controls.Add(Label_TaskSubject);
            Controls.Add(Label_ShortDescription);
            Controls.Add(Label_TaskTitle);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form_DisplayExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_DisplayExam";
            ResumeLayout(false);
            PerformLayout();
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
    }
}