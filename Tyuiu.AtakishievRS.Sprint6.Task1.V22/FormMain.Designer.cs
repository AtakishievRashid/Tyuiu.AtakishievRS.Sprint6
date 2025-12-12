namespace Tyuiu.AtakishievRS.Sprint6.Task1.V22
{
    partial class Form1
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
            groupBoxCond_ARS = new GroupBox();
            groupBoxTask_ARS = new GroupBox();
            groupBoxEnd_ARS = new GroupBox();
            textBoxResult_ARS = new TextBox();
            groupBoxResult_ARS = new GroupBox();
            buttonDone_ARS = new Button();
            buttonHelp_ARS = new Button();
            groupBoxVvod_ARS = new GroupBox();
            groupBoxEnd = new GroupBox();
            textBoxEnd_ARS = new TextBox();
            groupBoxStart = new GroupBox();
            textBoxStart_ARS = new TextBox();
            groupBoxCond_ARS.SuspendLayout();
            groupBoxEnd_ARS.SuspendLayout();
            groupBoxVvod_ARS.SuspendLayout();
            groupBoxEnd.SuspendLayout();
            groupBoxStart.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCond_ARS
            // 
            groupBoxCond_ARS.Controls.Add(groupBoxTask_ARS);
            groupBoxCond_ARS.Font = new Font("Segoe UI", 11F);
            groupBoxCond_ARS.Location = new Point(12, 12);
            groupBoxCond_ARS.Name = "groupBoxCond_ARS";
            groupBoxCond_ARS.Size = new Size(576, 339);
            groupBoxCond_ARS.TabIndex = 0;
            groupBoxCond_ARS.TabStop = false;
            groupBoxCond_ARS.Text = "Условие";
            // 
            // groupBoxTask_ARS
            // 
            groupBoxTask_ARS.Location = new Point(0, 26);
            groupBoxTask_ARS.Name = "groupBoxTask_ARS";
            groupBoxTask_ARS.Size = new Size(576, 313);
            groupBoxTask_ARS.TabIndex = 0;
            groupBoxTask_ARS.TabStop = false;
            groupBoxTask_ARS.Text = "Протабулировать функцию cos(x)  на заданном диапазоне. Результат выввести в виде таблицы.";
            // 
            // groupBoxEnd_ARS
            // 
            groupBoxEnd_ARS.Controls.Add(textBoxResult_ARS);
            groupBoxEnd_ARS.Controls.Add(groupBoxResult_ARS);
            groupBoxEnd_ARS.Font = new Font("Segoe UI", 11F);
            groupBoxEnd_ARS.Location = new Point(620, 12);
            groupBoxEnd_ARS.Name = "groupBoxEnd_ARS";
            groupBoxEnd_ARS.Size = new Size(295, 448);
            groupBoxEnd_ARS.TabIndex = 2;
            groupBoxEnd_ARS.TabStop = false;
            groupBoxEnd_ARS.Text = "Вывод данных:";
            // 
            // textBoxResult_ARS
            // 
            textBoxResult_ARS.Location = new Point(6, 52);
            textBoxResult_ARS.Multiline = true;
            textBoxResult_ARS.Name = "textBoxResult_ARS";
            textBoxResult_ARS.ReadOnly = true;
            textBoxResult_ARS.ScrollBars = ScrollBars.Vertical;
            textBoxResult_ARS.Size = new Size(289, 390);
            textBoxResult_ARS.TabIndex = 5;
            textBoxResult_ARS.TextChanged += textBoxResult_ARS_TextChanged;
            // 
            // groupBoxResult_ARS
            // 
            groupBoxResult_ARS.Location = new Point(0, 26);
            groupBoxResult_ARS.Name = "groupBoxResult_ARS";
            groupBoxResult_ARS.Size = new Size(200, 100);
            groupBoxResult_ARS.TabIndex = 0;
            groupBoxResult_ARS.TabStop = false;
            groupBoxResult_ARS.Text = "Результат:";
            // 
            // buttonDone_ARS
            // 
            buttonDone_ARS.BackColor = Color.LimeGreen;
            buttonDone_ARS.Font = new Font("Segoe UI Light", 14F);
            buttonDone_ARS.ForeColor = SystemColors.ActiveCaptionText;
            buttonDone_ARS.Location = new Point(433, 372);
            buttonDone_ARS.Name = "buttonDone_ARS";
            buttonDone_ARS.Size = new Size(155, 70);
            buttonDone_ARS.TabIndex = 3;
            buttonDone_ARS.Text = "Выполнить";
            buttonDone_ARS.UseVisualStyleBackColor = false;
            buttonDone_ARS.Click += buttonDone_ARS_Click;
            // 
            // buttonHelp_ARS
            // 
            buttonHelp_ARS.BackColor = Color.DeepSkyBlue;
            buttonHelp_ARS.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonHelp_ARS.Location = new Point(350, 372);
            buttonHelp_ARS.Name = "buttonHelp_ARS";
            buttonHelp_ARS.Size = new Size(77, 70);
            buttonHelp_ARS.TabIndex = 4;
            buttonHelp_ARS.Text = "Справка";
            buttonHelp_ARS.UseVisualStyleBackColor = false;
            buttonHelp_ARS.Click += buttonHelp_ARS_Click;
            // 
            // groupBoxVvod_ARS
            // 
            groupBoxVvod_ARS.Controls.Add(groupBoxEnd);
            groupBoxVvod_ARS.Controls.Add(groupBoxStart);
            groupBoxVvod_ARS.Font = new Font("Segoe UI", 10F);
            groupBoxVvod_ARS.Location = new Point(12, 372);
            groupBoxVvod_ARS.Name = "groupBoxVvod_ARS";
            groupBoxVvod_ARS.Size = new Size(332, 82);
            groupBoxVvod_ARS.TabIndex = 5;
            groupBoxVvod_ARS.TabStop = false;
            groupBoxVvod_ARS.Text = "Ввод данных:";
            // 
            // groupBoxEnd
            // 
            groupBoxEnd.Controls.Add(textBoxEnd_ARS);
            groupBoxEnd.Location = new Point(162, 18);
            groupBoxEnd.Name = "groupBoxEnd";
            groupBoxEnd.Size = new Size(164, 64);
            groupBoxEnd.TabIndex = 1;
            groupBoxEnd.TabStop = false;
            groupBoxEnd.Text = "Конец шага:";
            // 
            // textBoxEnd_ARS
            // 
            textBoxEnd_ARS.Location = new Point(6, 33);
            textBoxEnd_ARS.Name = "textBoxEnd_ARS";
            textBoxEnd_ARS.Size = new Size(152, 25);
            textBoxEnd_ARS.TabIndex = 0;
            textBoxEnd_ARS.TextChanged += textBoxEnd_ARS_TextChanged;
            // 
            // groupBoxStart
            // 
            groupBoxStart.Controls.Add(textBoxStart_ARS);
            groupBoxStart.Font = new Font("Segoe UI", 10F);
            groupBoxStart.Location = new Point(0, 18);
            groupBoxStart.Name = "groupBoxStart";
            groupBoxStart.Size = new Size(156, 65);
            groupBoxStart.TabIndex = 0;
            groupBoxStart.TabStop = false;
            groupBoxStart.Text = "Старт шага:";
            // 
            // textBoxStart_ARS
            // 
            textBoxStart_ARS.Location = new Point(6, 33);
            textBoxStart_ARS.Name = "textBoxStart_ARS";
            textBoxStart_ARS.Size = new Size(141, 25);
            textBoxStart_ARS.TabIndex = 0;
            textBoxStart_ARS.TextChanged += textBoxStart_ARS_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 467);
            Controls.Add(groupBoxVvod_ARS);
            Controls.Add(buttonHelp_ARS);
            Controls.Add(groupBoxEnd_ARS);
            Controls.Add(buttonDone_ARS);
            Controls.Add(groupBoxCond_ARS);
            Name = "Form1";
            Text = "Спринт 6 | Таск 1 | Вариант 22 | Атакишиев Р.С";
            groupBoxCond_ARS.ResumeLayout(false);
            groupBoxEnd_ARS.ResumeLayout(false);
            groupBoxEnd_ARS.PerformLayout();
            groupBoxVvod_ARS.ResumeLayout(false);
            groupBoxEnd.ResumeLayout(false);
            groupBoxEnd.PerformLayout();
            groupBoxStart.ResumeLayout(false);
            groupBoxStart.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCond_ARS;
        private GroupBox groupBoxTask_ARS;
        private GroupBox groupBoxEnd_ARS;
        private GroupBox groupBoxResult_ARS;
        private Button buttonDone_ARS;
        private Button buttonHelp_ARS;
        private TextBox textBoxResult_ARS;
        private GroupBox groupBoxVvod_ARS;
        private GroupBox groupBoxEnd;
        private TextBox textBoxEnd_ARS;
        private GroupBox groupBoxStart;
        private TextBox textBoxStart_ARS;
    }
}
