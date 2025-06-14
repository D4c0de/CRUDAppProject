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
            tableLayoutPanel_Menu = new TableLayoutPanel();
            Panel_TitleBar = new Panel();
            Label_Title = new Label();
            Button_TitleBar_Minimalize = new Button();
            Button_TitleBar_Maximalize = new Button();
            Button_TtitleBar_ExitProgram = new Button();
            tableLayoutPanel_Menu.SuspendLayout();
            Panel_TitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // Label_TaskType
            // 
            Label_TaskType.Anchor = AnchorStyles.None;
            Label_TaskType.AutoSize = true;
            Label_TaskType.Font = new Font("Arial Black", 17F, FontStyle.Bold);
            Label_TaskType.ForeColor = Color.White;
            Label_TaskType.Location = new Point(146, 197);
            Label_TaskType.Name = "Label_TaskType";
            Label_TaskType.Size = new Size(720, 41);
            Label_TaskType.TabIndex = 0;
            Label_TaskType.Text = "Wybierz rodzaj zadania jaki chcesz stworzyć";
            // 
            // Button_ExitTaskTypePicker
            // 
            Button_ExitTaskTypePicker.Anchor = AnchorStyles.None;
            Button_ExitTaskTypePicker.BackColor = Color.FromArgb(0, 31, 132);
            Button_ExitTaskTypePicker.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_ExitTaskTypePicker.ForeColor = Color.White;
            Button_ExitTaskTypePicker.Location = new Point(20, 604);
            Button_ExitTaskTypePicker.Margin = new Padding(3, 4, 3, 4);
            Button_ExitTaskTypePicker.Name = "Button_ExitTaskTypePicker";
            Button_ExitTaskTypePicker.Size = new Size(971, 100);
            Button_ExitTaskTypePicker.TabIndex = 2;
            Button_ExitTaskTypePicker.Text = "Wróć do zadań bez zapisywania";
            Button_ExitTaskTypePicker.UseVisualStyleBackColor = false;
            Button_ExitTaskTypePicker.Click += Button_ExitTaskTypePicker_Click;
            Button_ExitTaskTypePicker.MouseEnter += Menu_Button_Enter;
            Button_ExitTaskTypePicker.MouseLeave += Menu_Button_Leave;
            // 
            // Button_EnterTaskCreator
            // 
            Button_EnterTaskCreator.Anchor = AnchorStyles.None;
            Button_EnterTaskCreator.BackColor = Color.FromArgb(0, 31, 132);
            Button_EnterTaskCreator.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_EnterTaskCreator.ForeColor = Color.White;
            Button_EnterTaskCreator.Location = new Point(20, 457);
            Button_EnterTaskCreator.Margin = new Padding(3, 4, 3, 4);
            Button_EnterTaskCreator.Name = "Button_EnterTaskCreator";
            Button_EnterTaskCreator.Size = new Size(971, 100);
            Button_EnterTaskCreator.TabIndex = 3;
            Button_EnterTaskCreator.Text = "Przejdź do kreatora zadania";
            Button_EnterTaskCreator.UseVisualStyleBackColor = false;
            Button_EnterTaskCreator.Click += Button_EnterTaskCreator_Click;
            Button_EnterTaskCreator.MouseEnter += Menu_Button_Enter;
            Button_EnterTaskCreator.MouseLeave += Menu_Button_Leave;
            // 
            // Label_WelcomeMessage
            // 
            Label_WelcomeMessage.Anchor = AnchorStyles.None;
            Label_WelcomeMessage.AutoSize = true;
            Label_WelcomeMessage.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            Label_WelcomeMessage.ForeColor = Color.White;
            Label_WelcomeMessage.Location = new Point(149, 48);
            Label_WelcomeMessage.Name = "Label_WelcomeMessage";
            Label_WelcomeMessage.Size = new Size(713, 48);
            Label_WelcomeMessage.TabIndex = 4;
            Label_WelcomeMessage.Text = "Wybór rodzaju zadania do stworzenia";
            // 
            // Listbox_TaskTypes
            // 
            Listbox_TaskTypes.Anchor = AnchorStyles.None;
            Listbox_TaskTypes.BackColor = Color.FromArgb(25, 25, 35);
            Listbox_TaskTypes.Font = new Font("Segoe UI", 15F);
            Listbox_TaskTypes.ForeColor = Color.White;
            Listbox_TaskTypes.FormattingEnabled = true;
            Listbox_TaskTypes.ItemHeight = 35;
            Listbox_TaskTypes.Location = new Point(233, 308);
            Listbox_TaskTypes.Margin = new Padding(3, 4, 3, 4);
            Listbox_TaskTypes.Name = "Listbox_TaskTypes";
            Listbox_TaskTypes.Size = new Size(546, 109);
            Listbox_TaskTypes.TabIndex = 5;
            // 
            // tableLayoutPanel_Menu
            // 
            tableLayoutPanel_Menu.ColumnCount = 1;
            tableLayoutPanel_Menu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Menu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Menu.Controls.Add(Label_WelcomeMessage, 0, 0);
            tableLayoutPanel_Menu.Controls.Add(Button_EnterTaskCreator, 0, 3);
            tableLayoutPanel_Menu.Controls.Add(Listbox_TaskTypes, 0, 2);
            tableLayoutPanel_Menu.Controls.Add(Button_ExitTaskTypePicker, 0, 4);
            tableLayoutPanel_Menu.Controls.Add(Label_TaskType, 0, 1);
            tableLayoutPanel_Menu.Location = new Point(297, 166);
            tableLayoutPanel_Menu.Name = "tableLayoutPanel_Menu";
            tableLayoutPanel_Menu.RowCount = 5;
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Menu.Size = new Size(1012, 729);
            tableLayoutPanel_Menu.TabIndex = 6;
            // 
            // Panel_TitleBar
            // 
            Panel_TitleBar.BackColor = Color.Transparent;
            Panel_TitleBar.Controls.Add(Label_Title);
            Panel_TitleBar.Controls.Add(Button_TitleBar_Minimalize);
            Panel_TitleBar.Controls.Add(Button_TitleBar_Maximalize);
            Panel_TitleBar.Controls.Add(Button_TtitleBar_ExitProgram);
            Panel_TitleBar.Dock = DockStyle.Top;
            Panel_TitleBar.Location = new Point(0, 0);
            Panel_TitleBar.Name = "Panel_TitleBar";
            Panel_TitleBar.Size = new Size(1838, 69);
            Panel_TitleBar.TabIndex = 12;
            Panel_TitleBar.MouseDown += Panel_TitleBar_MouseDown;
            // 
            // Label_Title
            // 
            Label_Title.AutoSize = true;
            Label_Title.Font = new Font("Segoe UI", 20F);
            Label_Title.ForeColor = Color.White;
            Label_Title.Location = new Point(3, 7);
            Label_Title.Name = "Label_Title";
            Label_Title.Size = new Size(274, 46);
            Label_Title.TabIndex = 3;
            Label_Title.Text = "CRUDAppProject";
            // 
            // Button_TitleBar_Minimalize
            // 
            Button_TitleBar_Minimalize.AutoSize = true;
            Button_TitleBar_Minimalize.BackColor = Color.Transparent;
            Button_TitleBar_Minimalize.Cursor = Cursors.Hand;
            Button_TitleBar_Minimalize.Dock = DockStyle.Right;
            Button_TitleBar_Minimalize.FlatAppearance.BorderSize = 0;
            Button_TitleBar_Minimalize.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Button_TitleBar_Minimalize.FlatStyle = FlatStyle.Flat;
            Button_TitleBar_Minimalize.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Button_TitleBar_Minimalize.ForeColor = Color.White;
            Button_TitleBar_Minimalize.ImageAlign = ContentAlignment.TopCenter;
            Button_TitleBar_Minimalize.Location = new Point(1646, 0);
            Button_TitleBar_Minimalize.Margin = new Padding(0);
            Button_TitleBar_Minimalize.Name = "Button_TitleBar_Minimalize";
            Button_TitleBar_Minimalize.Size = new Size(64, 69);
            Button_TitleBar_Minimalize.TabIndex = 2;
            Button_TitleBar_Minimalize.Text = "–";
            Button_TitleBar_Minimalize.UseVisualStyleBackColor = false;
            Button_TitleBar_Minimalize.Click += Button_TitleBar_Minimalize_Click;
            Button_TitleBar_Minimalize.MouseEnter += TitleBar_Button_Enter;
            Button_TitleBar_Minimalize.MouseLeave += TitleBar_Button_Leave;
            // 
            // Button_TitleBar_Maximalize
            // 
            Button_TitleBar_Maximalize.AutoSize = true;
            Button_TitleBar_Maximalize.BackColor = Color.Transparent;
            Button_TitleBar_Maximalize.Cursor = Cursors.Hand;
            Button_TitleBar_Maximalize.Dock = DockStyle.Right;
            Button_TitleBar_Maximalize.FlatAppearance.BorderSize = 0;
            Button_TitleBar_Maximalize.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Button_TitleBar_Maximalize.FlatStyle = FlatStyle.Flat;
            Button_TitleBar_Maximalize.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Button_TitleBar_Maximalize.ForeColor = Color.White;
            Button_TitleBar_Maximalize.ImageAlign = ContentAlignment.TopCenter;
            Button_TitleBar_Maximalize.Location = new Point(1710, 0);
            Button_TitleBar_Maximalize.Margin = new Padding(0);
            Button_TitleBar_Maximalize.Name = "Button_TitleBar_Maximalize";
            Button_TitleBar_Maximalize.Size = new Size(69, 69);
            Button_TitleBar_Maximalize.TabIndex = 1;
            Button_TitleBar_Maximalize.Text = "◱";
            Button_TitleBar_Maximalize.UseVisualStyleBackColor = false;
            Button_TitleBar_Maximalize.Click += Button_TitleBar_Maximalize_Click;
            Button_TitleBar_Maximalize.MouseEnter += TitleBar_Button_Enter;
            Button_TitleBar_Maximalize.MouseLeave += TitleBar_Button_Leave;
            // 
            // Button_TtitleBar_ExitProgram
            // 
            Button_TtitleBar_ExitProgram.AutoSize = true;
            Button_TtitleBar_ExitProgram.Cursor = Cursors.Hand;
            Button_TtitleBar_ExitProgram.Dock = DockStyle.Right;
            Button_TtitleBar_ExitProgram.FlatAppearance.BorderSize = 0;
            Button_TtitleBar_ExitProgram.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Button_TtitleBar_ExitProgram.FlatStyle = FlatStyle.Flat;
            Button_TtitleBar_ExitProgram.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Button_TtitleBar_ExitProgram.ForeColor = Color.White;
            Button_TtitleBar_ExitProgram.ImageAlign = ContentAlignment.TopCenter;
            Button_TtitleBar_ExitProgram.Location = new Point(1779, 0);
            Button_TtitleBar_ExitProgram.Margin = new Padding(0);
            Button_TtitleBar_ExitProgram.Name = "Button_TtitleBar_ExitProgram";
            Button_TtitleBar_ExitProgram.Size = new Size(59, 69);
            Button_TtitleBar_ExitProgram.TabIndex = 0;
            Button_TtitleBar_ExitProgram.Text = "x";
            Button_TtitleBar_ExitProgram.TextAlign = ContentAlignment.TopCenter;
            Button_TtitleBar_ExitProgram.UseVisualStyleBackColor = true;
            Button_TtitleBar_ExitProgram.Click += Button_TtitleBar_ExitProgram_Click;
            Button_TtitleBar_ExitProgram.MouseEnter += TitleBar_Button_Enter;
            Button_TtitleBar_ExitProgram.MouseLeave += TitleBar_Button_Leave;
            // 
            // Form_CreateTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(45, 45, 55);
            ClientSize = new Size(1838, 993);
            Controls.Add(Panel_TitleBar);
            Controls.Add(tableLayoutPanel_Menu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1024, 720);
            Name = "Form_CreateTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_CreateTask";
            tableLayoutPanel_Menu.ResumeLayout(false);
            tableLayoutPanel_Menu.PerformLayout();
            Panel_TitleBar.ResumeLayout(false);
            Panel_TitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Label_TaskType;
        private Button Button_ExitTaskTypePicker;
        private Button Button_EnterTaskCreator;
        private Label Label_WelcomeMessage;
        private ListBox Listbox_TaskTypes;
        private TableLayoutPanel tableLayoutPanel_Menu;
        private Panel Panel_TitleBar;
        private Label Label_Title;
        private Button Button_TitleBar_Minimalize;
        private Button Button_TitleBar_Maximalize;
        private Button Button_TtitleBar_ExitProgram;
    }
}