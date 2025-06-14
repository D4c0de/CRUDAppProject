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
            Panel_TitleBar = new Panel();
            Label_Title = new Label();
            Button_TitleBar_Minimalize = new Button();
            Button_TitleBar_Maximalize = new Button();
            Button_TtitleBar_ExitProgram = new Button();
            tableLayoutPanel_Menu = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            Panel_TitleBar.SuspendLayout();
            tableLayoutPanel_Menu.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // Button_CreateNewTask
            // 
            Button_CreateNewTask.Anchor = AnchorStyles.Top;
            Button_CreateNewTask.BackColor = Color.FromArgb(0, 31, 132);
            Button_CreateNewTask.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_CreateNewTask.ForeColor = Color.White;
            Button_CreateNewTask.Location = new Point(618, 4);
            Button_CreateNewTask.Margin = new Padding(3, 4, 3, 4);
            Button_CreateNewTask.Name = "Button_CreateNewTask";
            Button_CreateNewTask.Size = new Size(290, 86);
            Button_CreateNewTask.TabIndex = 0;
            Button_CreateNewTask.Text = "Dodaj nowe zadanie";
            Button_CreateNewTask.UseVisualStyleBackColor = false;
            Button_CreateNewTask.Click += Button_CreateNewTask_Click;
            Button_CreateNewTask.MouseEnter += Menu_Button_Enter;
            Button_CreateNewTask.MouseLeave += Menu_Button_Leave;
            // 
            // Button_LogOut
            // 
            Button_LogOut.Anchor = AnchorStyles.Top;
            Button_LogOut.BackColor = Color.FromArgb(0, 31, 132);
            Button_LogOut.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_LogOut.ForeColor = Color.White;
            Button_LogOut.Location = new Point(109, 4);
            Button_LogOut.Margin = new Padding(3, 4, 3, 4);
            Button_LogOut.Name = "Button_LogOut";
            Button_LogOut.Size = new Size(290, 86);
            Button_LogOut.TabIndex = 1;
            Button_LogOut.Text = "Wróć do menu";
            Button_LogOut.UseVisualStyleBackColor = false;
            Button_LogOut.Click += Button_LogOut_Click;
            Button_LogOut.MouseEnter += Menu_Button_Enter;
            Button_LogOut.MouseLeave += Menu_Button_Leave;
            // 
            // Panel_TaskCardsPanel
            // 
            Panel_TaskCardsPanel.AutoScroll = true;
            Panel_TaskCardsPanel.AutoSize = true;
            Panel_TaskCardsPanel.BackColor = Color.Transparent;
            Panel_TaskCardsPanel.ForeColor = Color.White;
            Panel_TaskCardsPanel.Location = new Point(3, 104);
            Panel_TaskCardsPanel.Margin = new Padding(3, 4, 3, 4);
            Panel_TaskCardsPanel.Name = "Panel_TaskCardsPanel";
            Panel_TaskCardsPanel.Size = new Size(0, 0);
            Panel_TaskCardsPanel.TabIndex = 2;
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
            Panel_TitleBar.Size = new Size(1833, 69);
            Panel_TitleBar.TabIndex = 13;
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
            Button_TitleBar_Minimalize.Location = new Point(1641, 0);
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
            Button_TitleBar_Maximalize.Location = new Point(1705, 0);
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
            Button_TtitleBar_ExitProgram.Location = new Point(1774, 0);
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
            // tableLayoutPanel_Menu
            // 
            tableLayoutPanel_Menu.AutoScroll = true;
            tableLayoutPanel_Menu.ColumnCount = 1;
            tableLayoutPanel_Menu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Menu.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel_Menu.Controls.Add(Panel_TaskCardsPanel, 0, 1);
            tableLayoutPanel_Menu.Location = new Point(396, 148);
            tableLayoutPanel_Menu.Name = "tableLayoutPanel_Menu";
            tableLayoutPanel_Menu.RowCount = 2;
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle());
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle());
            tableLayoutPanel_Menu.Size = new Size(1024, 501);
            tableLayoutPanel_Menu.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(Button_LogOut, 0, 0);
            tableLayoutPanel2.Controls.Add(Button_CreateNewTask, 1, 0);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1018, 94);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // Form_LoggedIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(45, 45, 55);
            ClientSize = new Size(1833, 988);
            Controls.Add(tableLayoutPanel_Menu);
            Controls.Add(Panel_TitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1024, 720);
            Name = "Form_LoggedIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_LoggedIn";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            Panel_TitleBar.ResumeLayout(false);
            Panel_TitleBar.PerformLayout();
            tableLayoutPanel_Menu.ResumeLayout(false);
            tableLayoutPanel_Menu.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button Button_CreateNewTask;
        private Button Button_LogOut;
        private Panel Panel_TaskCardsPanel;
        private BindingSource bindingSource1;
        private Panel Panel_TitleBar;
        private Label Label_Title;
        private Button Button_TitleBar_Minimalize;
        private Button Button_TitleBar_Maximalize;
        private Button Button_TtitleBar_ExitProgram;
        private TableLayoutPanel tableLayoutPanel_Menu;
        private TableLayoutPanel tableLayoutPanel2;
    }
}