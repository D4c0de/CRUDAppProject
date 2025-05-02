namespace CRUDAppProject.Forms
{
    partial class Form_Logging : Form
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
            Button_ChooseProfile = new Button();
            Button_AddNewProfile = new Button();
            Button_DeleteProfile = new Button();
            Button_ExitProgram = new Button();
            SuspendLayout();
            // 
            // Button_ChooseProfile
            // 
            Button_ChooseProfile.Location = new Point(409, 230);
            Button_ChooseProfile.Name = "Button_ChooseProfile";
            Button_ChooseProfile.Size = new Size(850, 75);
            Button_ChooseProfile.TabIndex = 0;
            Button_ChooseProfile.Text = "Wybierz istniejący semestr";
            Button_ChooseProfile.UseVisualStyleBackColor = true;
            Button_ChooseProfile.Click += button1_Click;
            // 
            // Button_AddNewProfile
            // 
            Button_AddNewProfile.Location = new Point(409, 311);
            Button_AddNewProfile.Name = "Button_AddNewProfile";
            Button_AddNewProfile.Size = new Size(850, 75);
            Button_AddNewProfile.TabIndex = 1;
            Button_AddNewProfile.Text = "Dodaj nowy semestr";
            Button_AddNewProfile.UseVisualStyleBackColor = true;
            Button_AddNewProfile.Click += button2_Click;
            // 
            // Button_DeleteProfile
            // 
            Button_DeleteProfile.Location = new Point(409, 392);
            Button_DeleteProfile.Name = "Button_DeleteProfile";
            Button_DeleteProfile.Size = new Size(850, 75);
            Button_DeleteProfile.TabIndex = 2;
            Button_DeleteProfile.Text = "Usuń istniejacy semestr";
            Button_DeleteProfile.UseVisualStyleBackColor = true;
            Button_DeleteProfile.Click += Button_DeleteProfile_Click;
            // 
            // Button_ExitProgram
            // 
            Button_ExitProgram.Location = new Point(409, 473);
            Button_ExitProgram.Name = "Button_ExitProgram";
            Button_ExitProgram.Size = new Size(850, 75);
            Button_ExitProgram.TabIndex = 3;
            Button_ExitProgram.Text = "Opuść program";
            Button_ExitProgram.UseVisualStyleBackColor = true;
            // 
            // Form_Logging
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1600, 737);
            Controls.Add(Button_ExitProgram);
            Controls.Add(Button_DeleteProfile);
            Controls.Add(Button_AddNewProfile);
            Controls.Add(Button_ChooseProfile);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form_Logging";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Logging";
            ResumeLayout(false);
        }

        #endregion

        private Button Button_ChooseProfile;
        private Button Button_AddNewProfile;
        private Button Button_DeleteProfile;
        private Button Button_ExitProgram;
    }
}