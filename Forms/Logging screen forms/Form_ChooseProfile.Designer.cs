namespace CRUDAppProject.Forms
{
    partial class Form_ChooseProfile
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
            ComboBox_ProfileName = new ComboBox();
            Button_LogIn = new Button();
            Button_ExitProfileChoosing = new Button();
            SuspendLayout();
            // 
            // Label_WelcomeMessage
            // 
            Label_WelcomeMessage.AutoSize = true;
            Label_WelcomeMessage.Font = new Font("Segoe UI", 26.25F);
            Label_WelcomeMessage.Location = new Point(638, 9);
            Label_WelcomeMessage.Name = "Label_WelcomeMessage";
            Label_WelcomeMessage.Size = new Size(385, 47);
            Label_WelcomeMessage.TabIndex = 0;
            Label_WelcomeMessage.Text = "Wybór profilu semestru";
            // 
            // Label_ProfileName
            // 
            Label_ProfileName.AutoSize = true;
            Label_ProfileName.Font = new Font("Segoe UI", 18F);
            Label_ProfileName.Location = new Point(505, 203);
            Label_ProfileName.Name = "Label_ProfileName";
            Label_ProfileName.Size = new Size(640, 32);
            Label_ProfileName.TabIndex = 1;
            Label_ProfileName.Text = "Wybierz profil z listy poniżej na który chcesz się zalogować";
            // 
            // ComboBox_ProfileName
            // 
            ComboBox_ProfileName.Font = new Font("Segoe UI", 15F);
            ComboBox_ProfileName.FormattingEnabled = true;
            ComboBox_ProfileName.Location = new Point(505, 265);
            ComboBox_ProfileName.Name = "ComboBox_ProfileName";
            ComboBox_ProfileName.Size = new Size(640, 36);
            ComboBox_ProfileName.TabIndex = 2;
            ComboBox_ProfileName.Text = "Wybierz profil, na który chcesz się zalogować";
            // 
            // Button_LogIn
            // 
            Button_LogIn.Font = new Font("Segoe UI", 18F);
            Button_LogIn.Location = new Point(891, 453);
            Button_LogIn.Name = "Button_LogIn";
            Button_LogIn.Size = new Size(254, 107);
            Button_LogIn.TabIndex = 3;
            Button_LogIn.Text = "Zaloguj się";
            Button_LogIn.UseVisualStyleBackColor = true;
            Button_LogIn.Click += Button_LogIn_Click;

            // 
            // Button_ExitProfileChoosing
            // 
            Button_ExitProfileChoosing.Font = new Font("Segoe UI", 18F);
            Button_ExitProfileChoosing.Location = new Point(505, 453);
            Button_ExitProfileChoosing.Name = "Button_ExitProfileChoosing";
            Button_ExitProfileChoosing.Size = new Size(254, 107);
            Button_ExitProfileChoosing.TabIndex = 4;
            Button_ExitProfileChoosing.Text = "Wróć do głównego menu";
            Button_ExitProfileChoosing.UseVisualStyleBackColor = true;
            Button_ExitProfileChoosing.Click += Button_ExitProfileChoosing_Click;

            // 
            // Form_ChooseProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1600, 737);
            Controls.Add(Button_ExitProfileChoosing);
            Controls.Add(Button_LogIn);
            Controls.Add(ComboBox_ProfileName);
            Controls.Add(Label_ProfileName);
            Controls.Add(Label_WelcomeMessage);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form_ChooseProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_ChooseProfile";
            Load += Form_ChooseProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_WelcomeMessage;
        private Label Label_ProfileName;
        private ComboBox ComboBox_ProfileName;
        private Button Button_LogIn;
        private Button Button_ExitProfileChoosing;
    }
}