namespace CRUDAppProject.Forms
{
    partial class Form_EditProfile
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
            Button_ExitProfileEditing = new Button();
            Button_EditChosenProfile = new Button();
            ComboBox_ProfileName = new ComboBox();
            SuspendLayout();
            // 
            // Label_WelcomeMessage
            // 
            Label_WelcomeMessage.AutoSize = true;
            Label_WelcomeMessage.Font = new Font("Segoe UI", 26.25F);
            Label_WelcomeMessage.Location = new Point(571, 9);
            Label_WelcomeMessage.Name = "Label_WelcomeMessage";
            Label_WelcomeMessage.Size = new Size(535, 47);
            Label_WelcomeMessage.TabIndex = 0;
            Label_WelcomeMessage.Text = "Wybór profilu semestru do edycji";
            // 
            // Label_ProfileName
            // 
            Label_ProfileName.AutoSize = true;
            Label_ProfileName.Font = new Font("Segoe UI", 18F);
            Label_ProfileName.Location = new Point(540, 170);
            Label_ProfileName.Name = "Label_ProfileName";
            Label_ProfileName.Size = new Size(566, 32);
            Label_ProfileName.TabIndex = 1;
            Label_ProfileName.Text = "Wybierz profil z listy poniżej, który chcesz edytować";
            // 
            // Button_ExitProfileEditing
            // 
            Button_ExitProfileEditing.Font = new Font("Segoe UI", 18F);
            Button_ExitProfileEditing.Location = new Point(466, 504);
            Button_ExitProfileEditing.Name = "Button_ExitProfileEditing";
            Button_ExitProfileEditing.Size = new Size(254, 107);
            Button_ExitProfileEditing.TabIndex = 3;
            Button_ExitProfileEditing.Text = "Wróć do głównego menu";
            Button_ExitProfileEditing.UseVisualStyleBackColor = true;
            Button_ExitProfileEditing.Click += Button_ExitProfileEditing_Click;
            // 
            // Button_EditChosenProfile
            // 
            Button_EditChosenProfile.Font = new Font("Segoe UI", 18F);
            Button_EditChosenProfile.Location = new Point(867, 504);
            Button_EditChosenProfile.Name = "Button_EditChosenProfile";
            Button_EditChosenProfile.Size = new Size(254, 107);
            Button_EditChosenProfile.TabIndex = 4;
            Button_EditChosenProfile.Text = "Edytuj wybrany profil";
            Button_EditChosenProfile.UseVisualStyleBackColor = true;
            Button_EditChosenProfile.Click += Button_EditChosenProfile_Click;
            // 
            // ComboBox_ProfileName
            // 
            ComboBox_ProfileName.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_ProfileName.FormattingEnabled = true;
            ComboBox_ProfileName.Location = new Point(481, 205);
            ComboBox_ProfileName.Name = "ComboBox_ProfileName";
            ComboBox_ProfileName.Size = new Size(640, 23);
            ComboBox_ProfileName.TabIndex = 5;
            // 
            // Form_EditProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1600, 737);
            Controls.Add(ComboBox_ProfileName);
            Controls.Add(Button_EditChosenProfile);
            Controls.Add(Button_ExitProfileEditing);
            Controls.Add(Label_ProfileName);
            Controls.Add(Label_WelcomeMessage);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form_EditProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_EditProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_WelcomeMessage;
        private Label Label_ProfileName;
        private Button Button_ExitProfileEditing;
        private Button Button_EditChosenProfile;
        private ComboBox ComboBox_ProfileName;
    }
}