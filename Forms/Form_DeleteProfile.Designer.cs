namespace CRUDAppProject.Forms
{
    partial class Form_DeleteProfile
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
            Label_ProfileName = new Label();
            ComboBox_ProfileName = new ComboBox();
            Button_ExitProfileDeletion = new Button();
            Button_ConfirmProfileDeletion = new Button();
            TextBox_RewriteProfileName = new TextBox();
            Label_RewriteProfileName = new Label();
            Label_WelcomeMessage = new Label();
            SuspendLayout();
            // 
            // Label_ProfileName
            // 
            Label_ProfileName.AutoSize = true;
            Label_ProfileName.Font = new Font("Segoe UI", 18F);
            Label_ProfileName.Location = new Point(598, 117);
            Label_ProfileName.Name = "Label_ProfileName";
            Label_ProfileName.Size = new Size(533, 32);
            Label_ProfileName.TabIndex = 0;
            Label_ProfileName.Text = "Wybierz profil z listy poniżej, którychcesz usunąć";
            // 
            // ComboBox_ProfileName
            // 
            ComboBox_ProfileName.Font = new Font("Segoe UI", 15F);
            ComboBox_ProfileName.FormattingEnabled = true;
            ComboBox_ProfileName.Location = new Point(540, 181);
            ComboBox_ProfileName.Name = "ComboBox_ProfileName";
            ComboBox_ProfileName.Size = new Size(655, 36);
            ComboBox_ProfileName.TabIndex = 1;
            ComboBox_ProfileName.Text = "Wybierz profil, który chcesz usunąć";
            
            // 
            // Button_ExitProfileDeletion
            // 
            Button_ExitProfileDeletion.Font = new Font("Segoe UI", 18F);
            Button_ExitProfileDeletion.Location = new Point(540, 535);
            Button_ExitProfileDeletion.Name = "Button_ExitProfileDeletion";
            Button_ExitProfileDeletion.Size = new Size(254, 107);
            Button_ExitProfileDeletion.TabIndex = 2;
            Button_ExitProfileDeletion.Text = "Opuść bez zapisywania";
            Button_ExitProfileDeletion.UseVisualStyleBackColor = true;
            Button_ExitProfileDeletion.Click += Button_ExitProfileDeletion_Click;
            // 
            // Button_ConfirmProfileDeletion
            // 
            Button_ConfirmProfileDeletion.Font = new Font("Segoe UI", 18F);
            Button_ConfirmProfileDeletion.Location = new Point(941, 535);
            Button_ConfirmProfileDeletion.Name = "Button_ConfirmProfileDeletion";
            Button_ConfirmProfileDeletion.Size = new Size(254, 107);
            Button_ConfirmProfileDeletion.TabIndex = 3;
            Button_ConfirmProfileDeletion.Text = "Usuń profil";
            Button_ConfirmProfileDeletion.UseVisualStyleBackColor = true;
            Button_ConfirmProfileDeletion.Click += Button_ConfirmProfileDeletion_Click;
            // 
            // TextBox_RewriteProfileName
            // 
            TextBox_RewriteProfileName.Font = new Font("Segoe UI", 15F);
            TextBox_RewriteProfileName.Location = new Point(540, 421);
            TextBox_RewriteProfileName.Name = "TextBox_RewriteProfileName";
            TextBox_RewriteProfileName.Size = new Size(655, 34);
            TextBox_RewriteProfileName.TabIndex = 4;
            // 
            // Label_RewriteProfileName
            // 
            Label_RewriteProfileName.AutoSize = true;
            Label_RewriteProfileName.Font = new Font("Segoe UI", 18F);
            Label_RewriteProfileName.Location = new Point(388, 354);
            Label_RewriteProfileName.Name = "Label_RewriteProfileName";
            Label_RewriteProfileName.Size = new Size(936, 32);
            Label_RewriteProfileName.TabIndex = 5;
            Label_RewriteProfileName.Text = "Jeśli jesteś pewien, że chcesz konkretny profil usunąć - przepisz dosłownie jego nazwę";
            // 
            // Label_WelcomeMessage
            // 
            Label_WelcomeMessage.AutoSize = true;
            Label_WelcomeMessage.Font = new Font("Segoe UI", 26.25F);
            Label_WelcomeMessage.Location = new Point(638, 9);
            Label_WelcomeMessage.Name = "Label_WelcomeMessage";
            Label_WelcomeMessage.Size = new Size(429, 47);
            Label_WelcomeMessage.TabIndex = 6;
            Label_WelcomeMessage.Text = "Usuwanie profilu semestru";
            // 
            // Form_DeleteProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1600, 737);
            Controls.Add(Label_WelcomeMessage);
            Controls.Add(Label_RewriteProfileName);
            Controls.Add(TextBox_RewriteProfileName);
            Controls.Add(Button_ConfirmProfileDeletion);
            Controls.Add(Button_ExitProfileDeletion);
            Controls.Add(ComboBox_ProfileName);
            Controls.Add(Label_ProfileName);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form_DeleteProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_DeleteProfile";
            Load += Form_DeleteProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_ProfileName;
        private ComboBox ComboBox_ProfileName;
        private Button Button_ExitProfileDeletion;
        private Button Button_ConfirmProfileDeletion;
        private TextBox TextBox_RewriteProfileName;
        private Label Label_RewriteProfileName;
        private Label Label_WelcomeMessage;
    }
}