namespace CRUDAppProject.Forms.Logging_screen_forms.Editing_profile
{
    partial class Form_ProfileEditor
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
            TextBox_ProfileName = new TextBox();
            RichTextBox_ListOfSubjects = new RichTextBox();
            Label_ProfileName = new Label();
            Label_ListOfSubjects = new Label();
            Button_ExitProfileEditor = new Button();
            Button_SaveEditedProfile = new Button();
            SuspendLayout();
            // 
            // Label_WelcomeMessage
            // 
            Label_WelcomeMessage.AutoSize = true;
            Label_WelcomeMessage.Font = new Font("Segoe UI", 26.25F);
            Label_WelcomeMessage.Location = new Point(542, 9);
            Label_WelcomeMessage.Name = "Label_WelcomeMessage";
            Label_WelcomeMessage.Size = new Size(459, 47);
            Label_WelcomeMessage.TabIndex = 0;
            Label_WelcomeMessage.Text = "Edytowanie profilu semestru";
            // 
            // TextBox_ProfileName
            // 
            TextBox_ProfileName.Location = new Point(479, 152);
            TextBox_ProfileName.Name = "TextBox_ProfileName";
            TextBox_ProfileName.Size = new Size(640, 23);
            TextBox_ProfileName.TabIndex = 1;
            // 
            // RichTextBox_ListOfSubjects
            // 
            RichTextBox_ListOfSubjects.Location = new Point(479, 245);
            RichTextBox_ListOfSubjects.Name = "RichTextBox_ListOfSubjects";
            RichTextBox_ListOfSubjects.Size = new Size(640, 114);
            RichTextBox_ListOfSubjects.TabIndex = 2;
            RichTextBox_ListOfSubjects.Text = "";
            // 
            // Label_ProfileName
            // 
            Label_ProfileName.AutoSize = true;
            Label_ProfileName.Font = new Font("Segoe UI", 18F);
            Label_ProfileName.Location = new Point(598, 104);
            Label_ProfileName.Name = "Label_ProfileName";
            Label_ProfileName.Size = new Size(445, 32);
            Label_ProfileName.TabIndex = 3;
            Label_ProfileName.Text = "Wprowadź nową nazwę profilu semestru";
            // 
            // Label_ListOfSubjects
            // 
            Label_ListOfSubjects.AutoSize = true;
            Label_ListOfSubjects.Font = new Font("Segoe UI", 18F);
            Label_ListOfSubjects.Location = new Point(312, 201);
            Label_ListOfSubjects.Name = "Label_ListOfSubjects";
            Label_ListOfSubjects.Size = new Size(1062, 32);
            Label_ListOfSubjects.TabIndex = 4;
            Label_ListOfSubjects.Text = "Wprowadź przedmioty po przecinku, których zajęcia odbywają się w ramach powyższego semestru";
            // 
            // Button_ExitProfileEditor
            // 
            Button_ExitProfileEditor.Font = new Font("Segoe UI", 18F);
            Button_ExitProfileEditor.Location = new Point(479, 500);
            Button_ExitProfileEditor.Name = "Button_ExitProfileEditor";
            Button_ExitProfileEditor.Size = new Size(254, 107);
            Button_ExitProfileEditor.TabIndex = 5;
            Button_ExitProfileEditor.Text = "Opuść bez zapisywania";
            Button_ExitProfileEditor.UseVisualStyleBackColor = true;
            Button_ExitProfileEditor.Click += Button_ExitProfileEditor_Click;
            // 
            // Button_SaveEditedProfile
            // 
            Button_SaveEditedProfile.Font = new Font("Segoe UI", 18F);
            Button_SaveEditedProfile.Location = new Point(865, 500);
            Button_SaveEditedProfile.Name = "Button_SaveEditedProfile";
            Button_SaveEditedProfile.Size = new Size(254, 107);
            Button_SaveEditedProfile.TabIndex = 6;
            Button_SaveEditedProfile.Text = "Zapisz edytowany profil";
            Button_SaveEditedProfile.UseVisualStyleBackColor = true;
            Button_SaveEditedProfile.Click += Button_SaveEditedProfile_Click;
            // 
            // Form_ProfileEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1604, 741);
            Controls.Add(Button_SaveEditedProfile);
            Controls.Add(Button_ExitProfileEditor);
            Controls.Add(Label_ListOfSubjects);
            Controls.Add(Label_ProfileName);
            Controls.Add(RichTextBox_ListOfSubjects);
            Controls.Add(TextBox_ProfileName);
            Controls.Add(Label_WelcomeMessage);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form_ProfileEditor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_ProfileEditor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_WelcomeMessage;
        private TextBox TextBox_ProfileName;
        private RichTextBox RichTextBox_ListOfSubjects;
        private Label Label_ProfileName;
        private Label Label_ListOfSubjects;
        private Button Button_ExitProfileEditor;
        private Button Button_SaveEditedProfile;
    }
}