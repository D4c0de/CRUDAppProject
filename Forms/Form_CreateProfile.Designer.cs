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
            label1 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            richTextBox2 = new RichTextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(659, 9);
            label1.Name = "label1";
            label1.Size = new Size(394, 47);
            label1.TabIndex = 1;
            label1.Text = "Kreator profilu semestru";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(716, 104);
            label2.Name = "label2";
            label2.Size = new Size(304, 32);
            label2.TabIndex = 2;
            label2.Text = "Wprowadź nazwę semestru";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 238);
            richTextBox1.Location = new Point(540, 155);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(655, 50);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "Twoja nazwa semestru";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(366, 296);
            label3.Name = "label3";
            label3.Size = new Size(1062, 32);
            label3.TabIndex = 4;
            label3.Text = "Wprowadź przedmioty po przecinku, których zajęcia odbywają się w ramach powyższego semestru";
            // 
            // richTextBox2
            // 
            richTextBox2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 238);
            richTextBox2.Location = new Point(540, 341);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(655, 189);
            richTextBox2.TabIndex = 5;
            richTextBox2.Text = "Wpisz, Swoje, Przedmioty, W, Taki, Sposób";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F);
            button2.Location = new Point(766, 602);
            button2.Name = "button2";
            button2.Size = new Size(254, 107);
            button2.TabIndex = 7;
            button2.Text = "Gotowe!";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form_CreateProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1604, 741);
            Controls.Add(button2);
            Controls.Add(richTextBox2);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form_CreateProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_CreateProfile";
            Load += Form_CreateProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
        private Label label3;
        private RichTextBox richTextBox2;
        private Button button2;
    }
}