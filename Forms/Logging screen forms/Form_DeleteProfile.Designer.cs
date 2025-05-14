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
            Panel_TitleBar = new Panel();
            Label_Title = new Label();
            Button_TitleBar_Minimalize = new Button();
            Button_TitleBar_Maximalize = new Button();
            Button_TtitleBar_ExitProgram = new Button();
            tableLayoutPanel_Menu = new TableLayoutPanel();
            Panel_TitleBar.SuspendLayout();
            tableLayoutPanel_Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Label_ProfileName
            // 
            Label_ProfileName.Anchor = AnchorStyles.None;
            Label_ProfileName.AutoSize = true;
            Label_ProfileName.Font = new Font("Arial Black", 17F, FontStyle.Bold);
            Label_ProfileName.ForeColor = Color.White;
            Label_ProfileName.Location = new Point(89, 10);
            Label_ProfileName.Margin = new Padding(3, 10, 3, 10);
            Label_ProfileName.Name = "Label_ProfileName";
            Label_ProfileName.Size = new Size(798, 41);
            Label_ProfileName.TabIndex = 0;
            Label_ProfileName.Text = "Wybierz profil z listy poniżej, który chcesz usunąć";
            // 
            // ComboBox_ProfileName
            // 
            ComboBox_ProfileName.Anchor = AnchorStyles.None;
            ComboBox_ProfileName.BackColor = Color.FromArgb(25, 25, 35);
            ComboBox_ProfileName.Font = new Font("Segoe UI", 15F);
            ComboBox_ProfileName.ForeColor = Color.White;
            ComboBox_ProfileName.FormattingEnabled = true;
            ComboBox_ProfileName.Location = new Point(114, 71);
            ComboBox_ProfileName.Margin = new Padding(3, 10, 3, 10);
            ComboBox_ProfileName.Name = "ComboBox_ProfileName";
            ComboBox_ProfileName.Size = new Size(748, 43);
            ComboBox_ProfileName.TabIndex = 1;
            ComboBox_ProfileName.Text = "Wybierz profil, który chcesz usunąć";
            // 
            // Button_ExitProfileDeletion
            // 
            Button_ExitProfileDeletion.Anchor = AnchorStyles.None;
            Button_ExitProfileDeletion.BackColor = Color.FromArgb(0, 31, 132);
            Button_ExitProfileDeletion.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_ExitProfileDeletion.ForeColor = Color.White;
            Button_ExitProfileDeletion.Location = new Point(3, 417);
            Button_ExitProfileDeletion.Margin = new Padding(3, 10, 3, 10);
            Button_ExitProfileDeletion.Name = "Button_ExitProfileDeletion";
            Button_ExitProfileDeletion.Size = new Size(971, 100);
            Button_ExitProfileDeletion.TabIndex = 2;
            Button_ExitProfileDeletion.Text = "Opuść bez zapisywania";
            Button_ExitProfileDeletion.UseVisualStyleBackColor = false;
            Button_ExitProfileDeletion.Click += Button_ExitProfileDeletion_Click;
            Button_ExitProfileDeletion.MouseEnter += Menu_Button_Enter;
            Button_ExitProfileDeletion.MouseLeave += Menu_Button_Leave;
            // 
            // Button_ConfirmProfileDeletion
            // 
            Button_ConfirmProfileDeletion.Anchor = AnchorStyles.None;
            Button_ConfirmProfileDeletion.BackColor = Color.FromArgb(0, 31, 132);
            Button_ConfirmProfileDeletion.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            Button_ConfirmProfileDeletion.ForeColor = Color.White;
            Button_ConfirmProfileDeletion.Location = new Point(3, 297);
            Button_ConfirmProfileDeletion.Margin = new Padding(3, 10, 3, 10);
            Button_ConfirmProfileDeletion.Name = "Button_ConfirmProfileDeletion";
            Button_ConfirmProfileDeletion.Size = new Size(971, 100);
            Button_ConfirmProfileDeletion.TabIndex = 3;
            Button_ConfirmProfileDeletion.Text = "Usuń profil";
            Button_ConfirmProfileDeletion.UseVisualStyleBackColor = false;
            Button_ConfirmProfileDeletion.Click += Button_ConfirmProfileDeletion_Click;
            Button_ConfirmProfileDeletion.MouseEnter += Menu_Button_Enter;
            Button_ConfirmProfileDeletion.MouseLeave += Menu_Button_Leave;
            // 
            // TextBox_RewriteProfileName
            // 
            TextBox_RewriteProfileName.Anchor = AnchorStyles.None;
            TextBox_RewriteProfileName.BackColor = Color.FromArgb(25, 25, 35);
            TextBox_RewriteProfileName.Font = new Font("Segoe UI", 15F);
            TextBox_RewriteProfileName.ForeColor = Color.White;
            TextBox_RewriteProfileName.Location = new Point(114, 236);
            TextBox_RewriteProfileName.Margin = new Padding(3, 10, 3, 10);
            TextBox_RewriteProfileName.Name = "TextBox_RewriteProfileName";
            TextBox_RewriteProfileName.Size = new Size(748, 41);
            TextBox_RewriteProfileName.TabIndex = 4;
            // 
            // Label_RewriteProfileName
            // 
            Label_RewriteProfileName.Anchor = AnchorStyles.None;
            Label_RewriteProfileName.AutoSize = true;
            Label_RewriteProfileName.Font = new Font("Arial Black", 17F, FontStyle.Bold);
            Label_RewriteProfileName.ForeColor = Color.White;
            Label_RewriteProfileName.Location = new Point(38, 134);
            Label_RewriteProfileName.Margin = new Padding(3, 10, 3, 10);
            Label_RewriteProfileName.MaximumSize = new Size(1000, 0);
            Label_RewriteProfileName.Name = "Label_RewriteProfileName";
            Label_RewriteProfileName.Size = new Size(900, 82);
            Label_RewriteProfileName.TabIndex = 5;
            Label_RewriteProfileName.Text = "Jeśli jesteś pewien, że chcesz konkretny profil usunąć - przepisz dosłownie jego nazwę";
            Label_RewriteProfileName.TextAlign = ContentAlignment.MiddleCenter;
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
            Panel_TitleBar.Size = new Size(1829, 69);
            Panel_TitleBar.TabIndex = 11;
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
            Button_TitleBar_Minimalize.Location = new Point(1645, 0);
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
            Button_TitleBar_Maximalize.Location = new Point(1709, 0);
            Button_TitleBar_Maximalize.Margin = new Padding(0);
            Button_TitleBar_Maximalize.Name = "Button_TitleBar_Maximalize";
            Button_TitleBar_Maximalize.Size = new Size(60, 69);
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
            Button_TtitleBar_ExitProgram.Location = new Point(1769, 0);
            Button_TtitleBar_ExitProgram.Margin = new Padding(0);
            Button_TtitleBar_ExitProgram.Name = "Button_TtitleBar_ExitProgram";
            Button_TtitleBar_ExitProgram.Size = new Size(60, 69);
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
            tableLayoutPanel_Menu.AutoSize = true;
            tableLayoutPanel_Menu.ColumnCount = 1;
            tableLayoutPanel_Menu.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel_Menu.Controls.Add(Label_ProfileName, 0, 0);
            tableLayoutPanel_Menu.Controls.Add(ComboBox_ProfileName, 0, 1);
            tableLayoutPanel_Menu.Controls.Add(Button_ExitProfileDeletion, 0, 5);
            tableLayoutPanel_Menu.Controls.Add(Label_RewriteProfileName, 0, 2);
            tableLayoutPanel_Menu.Controls.Add(TextBox_RewriteProfileName, 0, 3);
            tableLayoutPanel_Menu.Controls.Add(Button_ConfirmProfileDeletion, 0, 4);
            tableLayoutPanel_Menu.Location = new Point(384, 188);
            tableLayoutPanel_Menu.Margin = new Padding(3, 10, 3, 10);
            tableLayoutPanel_Menu.Name = "tableLayoutPanel_Menu";
            tableLayoutPanel_Menu.RowCount = 6;
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle());
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle());
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle());
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle());
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle());
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle());
            tableLayoutPanel_Menu.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_Menu.Size = new Size(977, 527);
            tableLayoutPanel_Menu.TabIndex = 13;
            // 
            // Form_DeleteProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 55);
            ClientSize = new Size(1829, 983);
            Controls.Add(tableLayoutPanel_Menu);
            Controls.Add(Panel_TitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1024, 720);
            Name = "Form_DeleteProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_DeleteProfile";
            Load += Form_DeleteProfile_Load;
            Panel_TitleBar.ResumeLayout(false);
            Panel_TitleBar.PerformLayout();
            tableLayoutPanel_Menu.ResumeLayout(false);
            tableLayoutPanel_Menu.PerformLayout();
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
        private Panel Panel_TitleBar;
        private Label Label_Title;
        private Button Button_TitleBar_Minimalize;
        private Button Button_TitleBar_Maximalize;
        private Button Button_TtitleBar_ExitProgram;
        private TableLayoutPanel tableLayoutPanel_Menu;
    }
}