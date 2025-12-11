namespace Tyuiu.AtakishievRS.Sprint6.Task0.V9
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            button1 = new Button();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            Help = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(593, 384);
            button1.Name = "button1";
            button1.Size = new Size(195, 54);
            button1.TabIndex = 0;
            button1.Text = "Выполниь";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(133, 384);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyPress += textBox1_KeyPress;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(591, 339);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(197, 23);
            textBox4.TabIndex = 4;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // Help
            // 
            Help.FlatStyle = FlatStyle.Flat;
            Help.Location = new Point(515, 384);
            Help.Name = "Help";
            Help.Size = new Size(55, 54);
            Help.TabIndex = 5;
            Help.Text = "?";
            Help.UseVisualStyleBackColor = true;
            Help.Click += Help_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(525, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 151);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Segoe UI", 16F);
            groupBox1.Location = new Point(10, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(471, 273);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("Segoe UI", 14F);
            groupBox2.Location = new Point(10, 56);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(414, 185);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вычислить значение по формуле";
            // 
            // groupBox3
            // 
            groupBox3.Font = new Font("Segoe UI", 16F);
            groupBox3.Location = new Point(120, 321);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(182, 61);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Переменная X";
            // 
            // groupBox4
            // 
            groupBox4.Font = new Font("Segoe UI", 14F);
            groupBox4.Location = new Point(629, 289);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(113, 44);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Результат";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(Help);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 9 | Атакишиев Р.С.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox2;
        private TextBox textBox4;
        private Button Help;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
    }
}
