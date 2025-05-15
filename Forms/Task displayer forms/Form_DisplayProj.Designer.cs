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
            Button_MarkAsDone = new Button();
            Button_EditTask = new Button();
            TextBox_TaskTitle = new TextBox();
            TextBox_ShortDescription = new TextBox();
            TextBox_TaskSubject = new TextBox();
            TextBox_TaskDeadline = new TextBox();
            TextBox_TaskMembers = new TextBox();
            RichTextBox_TaskDescription = new RichTextBox();
            SuspendLayout();
            // 
            // Label_WelcomeMessage
            // 
            Label_WelcomeMessage.AutoSize = true;
            Label_WelcomeMessage.Font = new Font("Segoe UI", 26.25F);
            Label_WelcomeMessage.Location = new Point(597, 9);
            Label_WelcomeMessage.Name = "Label_WelcomeMessage";
            Label_WelcomeMessage.Size = new Size(359, 47);
            Label_WelcomeMessage.TabIndex = 0;
            Label_WelcomeMessage.Text = "Wyświetlanie projektu";
            // 
            // Label_TaskTitle
            // 
            Label_TaskTitle.AutoSize = true;
            Label_TaskTitle.Font = new Font("Segoe UI", 14F);
            Label_TaskTitle.Location = new Point(60, 86);
            Label_TaskTitle.Name = "Label_TaskTitle";
            Label_TaskTitle.Size = new Size(71, 25);
            Label_TaskTitle.TabIndex = 1;
            Label_TaskTitle.Text = "Projekt";
            // 
            // Label_ShortDescription
            // 
            Label_ShortDescription.AutoSize = true;
            Label_ShortDescription.Font = new Font("Segoe UI", 14F);
            Label_ShortDescription.Location = new Point(60, 157);
            Label_ShortDescription.Name = "Label_ShortDescription";
            Label_ShortDescription.Size = new Size(176, 25);
            Label_ShortDescription.TabIndex = 2;
            Label_ShortDescription.Text = "Krótki opis projektu";
            // 
            // Label_TaskSubject
            // 
            Label_TaskSubject.AutoSize = true;
            Label_TaskSubject.Font = new Font("Segoe UI", 14F);
            Label_TaskSubject.Location = new Point(60, 235);
            Label_TaskSubject.Name = "Label_TaskSubject";
            Label_TaskSubject.Size = new Size(301, 25);
            Label_TaskSubject.TabIndex = 3;
            Label_TaskSubject.Text = "Przedmiot którego dotyczy projekt";
            // 
            // Label_TaskDescription
            // 
            Label_TaskDescription.AutoSize = true;
            Label_TaskDescription.Font = new Font("Segoe UI", 14F);
            Label_TaskDescription.Location = new Point(60, 311);
            Label_TaskDescription.Name = "Label_TaskDescription";
            Label_TaskDescription.Size = new Size(172, 25);
            Label_TaskDescription.TabIndex = 4;
            Label_TaskDescription.Text = "Pełny opis projektu";
            // 
            // Label_TaskDeadline
            // 
            Label_TaskDeadline.AutoSize = true;
            Label_TaskDeadline.Font = new Font("Segoe UI", 14F);
            Label_TaskDeadline.Location = new Point(60, 510);
            Label_TaskDeadline.Name = "Label_TaskDeadline";
            Label_TaskDeadline.Size = new Size(164, 25);
            Label_TaskDeadline.TabIndex = 5;
            Label_TaskDeadline.Text = "Termin wykonania";
            // 
            // Label_TaskMembers
            // 
            Label_TaskMembers.AutoSize = true;
            Label_TaskMembers.Font = new Font("Segoe UI", 14F);
            Label_TaskMembers.Location = new Point(60, 589);
            Label_TaskMembers.Name = "Label_TaskMembers";
            Label_TaskMembers.Size = new Size(184, 25);
            Label_TaskMembers.TabIndex = 6;
            Label_TaskMembers.Text = "Członkowie projektu";
            // 
            // Button_ExitProjectDisplayer
            // 
            Button_ExitProjectDisplayer.Font = new Font("Segoe UI", 18F);
            Button_ExitProjectDisplayer.Location = new Point(1189, 114);
            Button_ExitProjectDisplayer.Name = "Button_ExitProjectDisplayer";
            Button_ExitProjectDisplayer.Size = new Size(254, 107);
            Button_ExitProjectDisplayer.TabIndex = 7;
            Button_ExitProjectDisplayer.Text = "Opuść bez zapisywania";
            Button_ExitProjectDisplayer.UseVisualStyleBackColor = true;
            Button_ExitProjectDisplayer.Click += Button_ExitProjectDisplayer_Click;
            // 
            // Button_MarkAsDone
            // 
            Button_MarkAsDone.Font = new Font("Segoe UI", 18F);
            Button_MarkAsDone.Location = new Point(1189, 286);
            Button_MarkAsDone.Name = "Button_MarkAsDone";
            Button_MarkAsDone.Size = new Size(254, 107);
            Button_MarkAsDone.TabIndex = 8;
            Button_MarkAsDone.Text = "Oznacz jako wykonane";
            Button_MarkAsDone.UseVisualStyleBackColor = true;
            // 
            // Button_EditTask
            // 
            Button_EditTask.Font = new Font("Segoe UI", 18F);
            Button_EditTask.Location = new Point(1189, 517);
            Button_EditTask.Name = "Button_EditTask";
            Button_EditTask.Size = new Size(254, 107);
            Button_EditTask.TabIndex = 9;
            Button_EditTask.Text = "Edytuj treść zadania";
            Button_EditTask.UseVisualStyleBackColor = true;
            // 
            // TextBox_TaskTitle
            // 
            TextBox_TaskTitle.Location = new Point(60, 114);
            TextBox_TaskTitle.Name = "TextBox_TaskTitle";
            TextBox_TaskTitle.ReadOnly = true;
            TextBox_TaskTitle.Size = new Size(629, 23);
            TextBox_TaskTitle.TabIndex = 10;
            // 
            // TextBox_ShortDescription
            // 
            TextBox_ShortDescription.Location = new Point(60, 185);
            TextBox_ShortDescription.Name = "TextBox_ShortDescription";
            TextBox_ShortDescription.ReadOnly = true;
            TextBox_ShortDescription.Size = new Size(629, 23);
            TextBox_ShortDescription.TabIndex = 11;
            // 
            // TextBox_TaskSubject
            // 
            TextBox_TaskSubject.Location = new Point(60, 263);
            TextBox_TaskSubject.Name = "TextBox_TaskSubject";
            TextBox_TaskSubject.ReadOnly = true;
            TextBox_TaskSubject.Size = new Size(629, 23);
            TextBox_TaskSubject.TabIndex = 12;
            // 
            // TextBox_TaskDeadline
            // 
            TextBox_TaskDeadline.Location = new Point(60, 538);
            TextBox_TaskDeadline.Name = "TextBox_TaskDeadline";
            TextBox_TaskDeadline.ReadOnly = true;
            TextBox_TaskDeadline.Size = new Size(629, 23);
            TextBox_TaskDeadline.TabIndex = 13;
            // 
            // TextBox_TaskMembers
            // 
            TextBox_TaskMembers.Location = new Point(60, 617);
            TextBox_TaskMembers.Name = "TextBox_TaskMembers";
            TextBox_TaskMembers.ReadOnly = true;
            TextBox_TaskMembers.Size = new Size(629, 23);
            TextBox_TaskMembers.TabIndex = 14;
            // 
            // RichTextBox_TaskDescription
            // 
            RichTextBox_TaskDescription.Location = new Point(60, 339);
            RichTextBox_TaskDescription.Name = "RichTextBox_TaskDescription";
            RichTextBox_TaskDescription.ReadOnly = true;
            RichTextBox_TaskDescription.Size = new Size(629, 141);
            RichTextBox_TaskDescription.TabIndex = 15;
            RichTextBox_TaskDescription.Text = "";
            // 
            // Form_DisplayProj
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            CausesValidation = false;
            ClientSize = new Size(1612, 749);
            Controls.Add(RichTextBox_TaskDescription);
            Controls.Add(TextBox_TaskMembers);
            Controls.Add(TextBox_TaskDeadline);
            Controls.Add(TextBox_TaskSubject);
            Controls.Add(TextBox_ShortDescription);
            Controls.Add(TextBox_TaskTitle);
            Controls.Add(Button_EditTask);
            Controls.Add(Button_MarkAsDone);
            Controls.Add(Button_ExitProjectDisplayer);
            Controls.Add(Label_TaskMembers);
            Controls.Add(Label_TaskDeadline);
            Controls.Add(Label_TaskDescription);
            Controls.Add(Label_TaskSubject);
            Controls.Add(Label_ShortDescription);
            Controls.Add(Label_TaskTitle);
            Controls.Add(Label_WelcomeMessage);
            Name = "Form_DisplayProj";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_DisplayProj";
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
        private Button Button_MarkAsDone;
        private Button Button_EditTask;
        private TextBox TextBox_TaskTitle;
        private TextBox TextBox_ShortDescription;
        private TextBox TextBox_TaskSubject;
        private TextBox TextBox_TaskDeadline;
        private TextBox TextBox_TaskMembers;
        private RichTextBox RichTextBox_TaskDescription;
    }
}