namespace CRUDAppProject.Forms
{
    partial class Form_CreateProfile
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
            Label_ProfileName = new Label();
            Label_ListOfSubjects = new Label();
            RichTextBox_ListOfSubjects = new RichTextBox();
            Button_CreateProfile = new Button();
            TextBox_ProfileName = new TextBox();
            Button_ExitProfileCreator = new Button();
            SuspendLayout();
            // 
            // Label_WelcomeMessage
            // 
            Label_WelcomeMessage.AutoSize = true;
            Label_WelcomeMessage.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Label_WelcomeMessage.Location = new Point(659, 9);
            Label_WelcomeMessage.Name = "Label_WelcomeMessage";
            Label_WelcomeMessage.Size = new Size(394, 47);
            Label_WelcomeMessage.TabIndex = 1;
            Label_WelcomeMessage.Text = "Kreator profilu semestru";
            
            // 
            // Label_ProfileName
            // 
            Label_ProfileName.AutoSize = true;
            Label_ProfileName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Label_ProfileName.Location = new Point(716, 104);
            Label_ProfileName.Name = "Label_ProfileName";
            Label_ProfileName.Size = new Size(304, 32);
            Label_ProfileName.TabIndex = 2;
            Label_ProfileName.Text = "Wprowadź nazwę semestru";
            // 
            // Label_ListOfSubjects
            // 
            Label_ListOfSubjects.AutoSize = true;
            Label_ListOfSubjects.Font = new Font("Segoe UI", 18F);
            Label_ListOfSubjects.Location = new Point(366, 296);
            Label_ListOfSubjects.Name = "Label_ListOfSubjects";
            Label_ListOfSubjects.Size = new Size(1062, 32);
            Label_ListOfSubjects.TabIndex = 4;
            Label_ListOfSubjects.Text = "Wprowadź przedmioty po przecinku, których zajęcia odbywają się w ramach powyższego semestru";
            // 
            // RichTextBox_ListOfSubjects
            // 
            RichTextBox_ListOfSubjects.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 238);
            RichTextBox_ListOfSubjects.Location = new Point(540, 341);
            RichTextBox_ListOfSubjects.Name = "RichTextBox_ListOfSubjects";
            RichTextBox_ListOfSubjects.Size = new Size(655, 189);
            RichTextBox_ListOfSubjects.TabIndex = 5;
            RichTextBox_ListOfSubjects.Text = "Wpisz, Swoje, Przedmioty, W, Taki, Sposób";
            // 
            // Button_CreateProfile
            // 
            Button_CreateProfile.Font = new Font("Segoe UI", 18F);
            Button_CreateProfile.Location = new Point(941, 602);
            Button_CreateProfile.Name = "Button_CreateProfile";
            Button_CreateProfile.Size = new Size(254, 107);
            Button_CreateProfile.TabIndex = 7;
            Button_CreateProfile.Text = "Zapisz nowy profil";
            Button_CreateProfile.UseVisualStyleBackColor = true;
            Button_CreateProfile.Click += Button_CreateProfile_Click;
            // 
            // TextBox_ProfileName
            // 
            TextBox_ProfileName.Font = new Font("Segoe UI", 15F);
            TextBox_ProfileName.Location = new Point(540, 166);
            TextBox_ProfileName.Name = "TextBox_ProfileName";
            TextBox_ProfileName.Size = new Size(655, 34);
            TextBox_ProfileName.TabIndex = 8;
            TextBox_ProfileName.Text = "Twoja nazwa semestru";
            
            // 
            // Button_ExitProfileCreator
            // 
            Button_ExitProfileCreator.Font = new Font("Segoe UI", 18F);
            Button_ExitProfileCreator.Location = new Point(540, 602);
            Button_ExitProfileCreator.Name = "Button_ExitProfileCreator";
            Button_ExitProfileCreator.Size = new Size(254, 107);
            Button_ExitProfileCreator.TabIndex = 9;
            Button_ExitProfileCreator.Text = "Opuść bez zapisywania";
            Button_ExitProfileCreator.UseVisualStyleBackColor = true;
            Button_ExitProfileCreator.Click += Button_ExitProfileCreator_Click;
            // 
            // Form_CreateProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1600, 737);
            Controls.Add(Button_ExitProfileCreator);
            Controls.Add(TextBox_ProfileName);
            Controls.Add(Button_CreateProfile);
            Controls.Add(RichTextBox_ListOfSubjects);
            Controls.Add(Label_ListOfSubjects);
            Controls.Add(Label_ProfileName);
            Controls.Add(Label_WelcomeMessage);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form_CreateProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_CreateProfile";
            
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion
        private Label Label_WelcomeMessage;
        private Label Label_ProfileName;
        private Label Label_ListOfSubjects;
        private RichTextBox RichTextBox_ListOfSubjects;
        private Button Button_CreateProfile;
        private TextBox TextBox_ProfileName;
        private Button Button_ExitProfileCreator;
    }
}