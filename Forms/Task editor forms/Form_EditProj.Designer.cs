namespace CRUDAppProject.Forms.Task_editor_forms
{
    partial class Form_EditProj
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
            Label_TaskMembers = new Label();
            Label_ChooseSubject = new Label();
            Label_SetDeadline = new Label();
            Button_ExitProjEditor = new Button();
            Button_SaveEditedProj = new Button();
            Calendar_SetDeadline = new MonthCalendar();
            ComboBox_ChooseSubject = new ComboBox();
            TextBox_TaskTitle = new TextBox();
            TextBox_ShortDescription = new TextBox();
            RichTextBox_TaskDescription = new RichTextBox();
            TextBox_TaskMembers = new TextBox();
            SuspendLayout();
            // 
            // Label_WelcomeMessage
            // 
            Label_WelcomeMessage.AutoSize = true;
            Label_WelcomeMessage.Font = new Font("Segoe UI", 26.25F);
            Label_WelcomeMessage.Location = new Point(661, 9);
            Label_WelcomeMessage.Name = "Label_WelcomeMessage";
            Label_WelcomeMessage.Size = new Size(337, 47);
            Label_WelcomeMessage.TabIndex = 0;
            Label_WelcomeMessage.Text = "Edytowanie projektu";
            // 
            // Label_TaskTitle
            // 
            Label_TaskTitle.AutoSize = true;
            Label_TaskTitle.Font = new Font("Segoe UI", 14F);
            Label_TaskTitle.Location = new Point(39, 130);
            Label_TaskTitle.Name = "Label_TaskTitle";
            Label_TaskTitle.Size = new Size(71, 25);
            Label_TaskTitle.TabIndex = 1;
            Label_TaskTitle.Text = "Projekt";
            // 
            // Label_ShortDescription
            // 
            Label_ShortDescription.AutoSize = true;
            Label_ShortDescription.Font = new Font("Segoe UI", 14F);
            Label_ShortDescription.Location = new Point(39, 207);
            Label_ShortDescription.Name = "Label_ShortDescription";
            Label_ShortDescription.Size = new Size(176, 25);
            Label_ShortDescription.TabIndex = 2;
            Label_ShortDescription.Text = "Krótki opis projektu";
            // 
            // Label_TaskDescription
            // 
            Label_TaskDescription.AutoSize = true;
            Label_TaskDescription.Font = new Font("Segoe UI", 14F);
            Label_TaskDescription.Location = new Point(39, 305);
            Label_TaskDescription.Name = "Label_TaskDescription";
            Label_TaskDescription.Size = new Size(172, 25);
            Label_TaskDescription.TabIndex = 3;
            Label_TaskDescription.Text = "Pełny opis projektu";
            // 
            // Label_TaskMembers
            // 
            Label_TaskMembers.AutoSize = true;
            Label_TaskMembers.Font = new Font("Segoe UI", 14F);
            Label_TaskMembers.Location = new Point(39, 502);
            Label_TaskMembers.Name = "Label_TaskMembers";
            Label_TaskMembers.Size = new Size(184, 25);
            Label_TaskMembers.TabIndex = 4;
            Label_TaskMembers.Text = "Członkowie projektu";
            // 
            // Label_ChooseSubject
            // 
            Label_ChooseSubject.AutoSize = true;
            Label_ChooseSubject.Font = new Font("Segoe UI", 14F);
            Label_ChooseSubject.Location = new Point(1040, 130);
            Label_ChooseSubject.Name = "Label_ChooseSubject";
            Label_ChooseSubject.Size = new Size(301, 25);
            Label_ChooseSubject.TabIndex = 5;
            Label_ChooseSubject.Text = "Przedmiot którego dotyczy projekt";
            // 
            // Label_SetDeadline
            // 
            Label_SetDeadline.AutoSize = true;
            Label_SetDeadline.Font = new Font("Segoe UI", 14F);
            Label_SetDeadline.Location = new Point(1139, 238);
            Label_SetDeadline.Name = "Label_SetDeadline";
            Label_SetDeadline.Size = new Size(134, 25);
            Label_SetDeadline.TabIndex = 6;
            Label_SetDeadline.Text = "Termin obrony";
            // 
            // Button_ExitProjEditor
            // 
            Button_ExitProjEditor.Font = new Font("Segoe UI", 18F);
            Button_ExitProjEditor.Location = new Point(943, 547);
            Button_ExitProjEditor.Name = "Button_ExitProjEditor";
            Button_ExitProjEditor.Size = new Size(254, 107);
            Button_ExitProjEditor.TabIndex = 7;
            Button_ExitProjEditor.Text = "Opuść bez zapisywania";
            Button_ExitProjEditor.UseVisualStyleBackColor = true;
            Button_ExitProjEditor.Click += Button_ExitProjEditor_Click;
            // 
            // Button_SaveEditedProj
            // 
            Button_SaveEditedProj.Font = new Font("Segoe UI", 18F);
            Button_SaveEditedProj.Location = new Point(1244, 547);
            Button_SaveEditedProj.Name = "Button_SaveEditedProj";
            Button_SaveEditedProj.Size = new Size(254, 107);
            Button_SaveEditedProj.TabIndex = 8;
            Button_SaveEditedProj.Text = "Zapisz nową treść zadania";
            Button_SaveEditedProj.UseVisualStyleBackColor = true;
            Button_SaveEditedProj.Click += Button_SaveEditedProj_Click;
            // 
            // Calendar_SetDeadline
            // 
            Calendar_SetDeadline.Location = new Point(1072, 272);
            Calendar_SetDeadline.Name = "Calendar_SetDeadline";
            Calendar_SetDeadline.TabIndex = 9;
            // 
            // ComboBox_ChooseSubject
            // 
            ComboBox_ChooseSubject.FormattingEnabled = true;
            ComboBox_ChooseSubject.Location = new Point(869, 158);
            ComboBox_ChooseSubject.Name = "ComboBox_ChooseSubject";
            ComboBox_ChooseSubject.Size = new Size(629, 23);
            ComboBox_ChooseSubject.TabIndex = 10;
            // 
            // TextBox_TaskTitle
            // 
            TextBox_TaskTitle.Location = new Point(39, 158);
            TextBox_TaskTitle.Name = "TextBox_TaskTitle";
            TextBox_TaskTitle.Size = new Size(629, 23);
            TextBox_TaskTitle.TabIndex = 11;
            // 
            // TextBox_ShortDescription
            // 
            TextBox_ShortDescription.Location = new Point(39, 235);
            TextBox_ShortDescription.Name = "TextBox_ShortDescription";
            TextBox_ShortDescription.Size = new Size(629, 23);
            TextBox_ShortDescription.TabIndex = 12;
            // 
            // RichTextBox_TaskDescription
            // 
            RichTextBox_TaskDescription.Location = new Point(39, 349);
            RichTextBox_TaskDescription.Name = "RichTextBox_TaskDescription";
            RichTextBox_TaskDescription.Size = new Size(629, 141);
            RichTextBox_TaskDescription.TabIndex = 13;
            RichTextBox_TaskDescription.Text = "";
            // 
            // TextBox_TaskMembers
            // 
            TextBox_TaskMembers.Location = new Point(39, 530);
            TextBox_TaskMembers.Name = "TextBox_TaskMembers";
            TextBox_TaskMembers.Size = new Size(629, 23);
            TextBox_TaskMembers.TabIndex = 14;
            // 
            // Form_EditProj
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1616, 753);
            Controls.Add(TextBox_TaskMembers);
            Controls.Add(RichTextBox_TaskDescription);
            Controls.Add(TextBox_ShortDescription);
            Controls.Add(TextBox_TaskTitle);
            Controls.Add(ComboBox_ChooseSubject);
            Controls.Add(Calendar_SetDeadline);
            Controls.Add(Button_SaveEditedProj);
            Controls.Add(Button_ExitProjEditor);
            Controls.Add(Label_SetDeadline);
            Controls.Add(Label_ChooseSubject);
            Controls.Add(Label_TaskMembers);
            Controls.Add(Label_TaskDescription);
            Controls.Add(Label_ShortDescription);
            Controls.Add(Label_TaskTitle);
            Controls.Add(Label_WelcomeMessage);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form_EditProj";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_EditProj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_WelcomeMessage;
        private Label Label_TaskTitle;
        private Label Label_ShortDescription;
        private Label Label_TaskDescription;
        private Label Label_TaskMembers;
        private Label Label_ChooseSubject;
        private Label Label_SetDeadline;
        private Button Button_ExitProjEditor;
        private Button Button_SaveEditedProj;
        private MonthCalendar Calendar_SetDeadline;
        private ComboBox ComboBox_ChooseSubject;
        private TextBox TextBox_TaskTitle;
        private TextBox TextBox_ShortDescription;
        private RichTextBox RichTextBox_TaskDescription;
        private TextBox TextBox_TaskMembers;
    }
}