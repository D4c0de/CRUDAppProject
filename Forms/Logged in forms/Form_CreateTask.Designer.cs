namespace CRUDAppProject.Forms.Logged_in_forms
{
    partial class Form_CreateTask
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
            Label_TaskType = new Label();
            Button_ExitTaskTypePicker = new Button();
            Button_EnterTaskCreator = new Button();
            Label_WelcomeMessage = new Label();
            Listbox_TaskTypes = new ListBox();
            SuspendLayout();
            // 
            // Label_TaskType
            // 
            Label_TaskType.AutoSize = true;
            Label_TaskType.Font = new Font("Segoe UI", 18F);
            Label_TaskType.Location = new Point(586, 165);
            Label_TaskType.Name = "Label_TaskType";
            Label_TaskType.Size = new Size(478, 32);
            Label_TaskType.TabIndex = 0;
            Label_TaskType.Text = "Wybierz rodzaj zadania jaki chcesz stworzyć";
            // 
            // Button_ExitTaskTypePicker
            // 
            Button_ExitTaskTypePicker.Font = new Font("Segoe UI", 18F);
            Button_ExitTaskTypePicker.Location = new Point(505, 460);
            Button_ExitTaskTypePicker.Name = "Button_ExitTaskTypePicker";
            Button_ExitTaskTypePicker.Size = new Size(254, 107);
            Button_ExitTaskTypePicker.TabIndex = 2;
            Button_ExitTaskTypePicker.Text = "Wróć do zadań bez zapisywania";
            Button_ExitTaskTypePicker.UseVisualStyleBackColor = true;
            // 
            // Button_EnterTaskCreator
            // 
            Button_EnterTaskCreator.Font = new Font("Segoe UI", 18F);
            Button_EnterTaskCreator.Location = new Point(891, 460);
            Button_EnterTaskCreator.Name = "Button_EnterTaskCreator";
            Button_EnterTaskCreator.Size = new Size(254, 107);
            Button_EnterTaskCreator.TabIndex = 3;
            Button_EnterTaskCreator.Text = "Przejdź do kreatora zadania";
            Button_EnterTaskCreator.UseVisualStyleBackColor = true;
            Button_EnterTaskCreator.Click += Button_EnterTaskCreator_Click;
            // 
            // Label_WelcomeMessage
            // 
            Label_WelcomeMessage.AutoSize = true;
            Label_WelcomeMessage.Font = new Font("Segoe UI", 26.25F);
            Label_WelcomeMessage.Location = new Point(527, 9);
            Label_WelcomeMessage.Name = "Label_WelcomeMessage";
            Label_WelcomeMessage.Size = new Size(606, 47);
            Label_WelcomeMessage.TabIndex = 4;
            Label_WelcomeMessage.Text = "Wybór rodzaju zadania do stworzenia";
            // 
            // Listbox_TaskTypes
            // 
            Listbox_TaskTypes.Font = new Font("Segoe UI", 15F);
            Listbox_TaskTypes.FormattingEnabled = true;
            Listbox_TaskTypes.ItemHeight = 28;
            Listbox_TaskTypes.Location = new Point(586, 259);
            Listbox_TaskTypes.Name = "Listbox_TaskTypes";
            Listbox_TaskTypes.Size = new Size(478, 88);
            Listbox_TaskTypes.TabIndex = 5;
            // 
            // Form_CreateTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1608, 745);
            Controls.Add(Listbox_TaskTypes);
            Controls.Add(Label_WelcomeMessage);
            Controls.Add(Button_EnterTaskCreator);
            Controls.Add(Button_ExitTaskTypePicker);
            Controls.Add(Label_TaskType);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form_CreateTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_CreateTask";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_TaskType;
        private Button Button_ExitTaskTypePicker;
        private Button Button_EnterTaskCreator;
        private Label Label_WelcomeMessage;
        private ListBox Listbox_TaskTypes;
    }
}