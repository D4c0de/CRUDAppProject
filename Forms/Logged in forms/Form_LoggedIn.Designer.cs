namespace CRUDAppProject.Forms
{
    partial class Form_LoggedIn
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
            components = new System.ComponentModel.Container();
            Button_CreateNewTask = new Button();
            Button_LogOut = new Button();
            Panel_TaskCardsPanel = new Panel();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // Button_CreateNewTask
            // 
            Button_CreateNewTask.Location = new Point(1049, 12);
            Button_CreateNewTask.Name = "Button_CreateNewTask";
            Button_CreateNewTask.Size = new Size(150, 50);
            Button_CreateNewTask.TabIndex = 0;
            Button_CreateNewTask.Text = "Dodaj nowe zadanie";
            Button_CreateNewTask.UseVisualStyleBackColor = true;
            Button_CreateNewTask.Click += Button_CreateNewTask_Click;
            // 
            // Button_LogOut
            // 
            Button_LogOut.Location = new Point(467, 12);
            Button_LogOut.Name = "Button_LogOut";
            Button_LogOut.Size = new Size(150, 50);
            Button_LogOut.TabIndex = 1;
            Button_LogOut.Text = "Wróć do menu";
            Button_LogOut.UseVisualStyleBackColor = true;
            Button_LogOut.Click += Button_LogOut_Click;
            // 
            // Panel_TaskCardsPanel
            // 
            Panel_TaskCardsPanel.Location = new Point(182, 97);
            Panel_TaskCardsPanel.Name = "Panel_TaskCardsPanel";
            Panel_TaskCardsPanel.Size = new Size(1200, 630);
            Panel_TaskCardsPanel.TabIndex = 2;
            // 
            // Form_LoggedIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1604, 741);
            Controls.Add(Panel_TaskCardsPanel);
            Controls.Add(Button_LogOut);
            Controls.Add(Button_CreateNewTask);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form_LoggedIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_LoggedIn";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Button_CreateNewTask;
        private Button Button_LogOut;
        private Panel Panel_TaskCardsPanel;
        private BindingSource bindingSource1;
    }
}