namespace Tyuiu.AtakishievRS.Sprint6.Task4.V3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxCon_ARS = new GroupBox();
            textBoxTask_ARS = new TextBox();
            groupBoxVvod_ARS = new GroupBox();
            buttonHelp_ARS = new Button();
            buttonSave_ARS = new Button();
            buttonDone_ARS = new Button();
            textBoxB_ARS = new TextBox();
            textBoxA_ARS = new TextBox();
            textBoxEnd_ARS = new TextBox();
            textBoxStart_ARS = new TextBox();
            textBoxVivod_ARS = new TextBox();
            textBoxResult_ARS = new TextBox();
            chartFunc_ARS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxCon_ARS.SuspendLayout();
            groupBoxVvod_ARS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunc_ARS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCon_ARS
            // 
            groupBoxCon_ARS.Controls.Add(textBoxTask_ARS);
            groupBoxCon_ARS.Dock = DockStyle.Top;
            groupBoxCon_ARS.Font = new Font("Segoe UI", 11F);
            groupBoxCon_ARS.Location = new Point(0, 0);
            groupBoxCon_ARS.Name = "groupBoxCon_ARS";
            groupBoxCon_ARS.Size = new Size(1080, 108);
            groupBoxCon_ARS.TabIndex = 0;
            groupBoxCon_ARS.TabStop = false;
            groupBoxCon_ARS.Text = "Условие: ";
            // 
            // textBoxTask_ARS
            // 
            textBoxTask_ARS.BorderStyle = BorderStyle.None;
            textBoxTask_ARS.Location = new Point(12, 22);
            textBoxTask_ARS.Multiline = true;
            textBoxTask_ARS.Name = "textBoxTask_ARS";
            textBoxTask_ARS.ReadOnly = true;
            textBoxTask_ARS.Size = new Size(483, 80);
            textBoxTask_ARS.TabIndex = 0;
            textBoxTask_ARS.Text = "Написать программу, которая выводит таблицу значений f(x)\r\nна диапазоне от -5 до 5 с шагом 1.\r\nРезультат вывести на TextBox, построить график функции и сохранить файл.\r\n\r\n ";
            // 
            // groupBoxVvod_ARS
            // 
            groupBoxVvod_ARS.Controls.Add(buttonHelp_ARS);
            groupBoxVvod_ARS.Controls.Add(buttonSave_ARS);
            groupBoxVvod_ARS.Controls.Add(buttonDone_ARS);
            groupBoxVvod_ARS.Controls.Add(textBoxB_ARS);
            groupBoxVvod_ARS.Controls.Add(textBoxA_ARS);
            groupBoxVvod_ARS.Controls.Add(textBoxEnd_ARS);
            groupBoxVvod_ARS.Controls.Add(textBoxStart_ARS);
            groupBoxVvod_ARS.Dock = DockStyle.Bottom;
            groupBoxVvod_ARS.Font = new Font("Segoe UI", 11F);
            groupBoxVvod_ARS.Location = new Point(0, 624);
            groupBoxVvod_ARS.Name = "groupBoxVvod_ARS";
            groupBoxVvod_ARS.Size = new Size(1080, 108);
            groupBoxVvod_ARS.TabIndex = 1;
            groupBoxVvod_ARS.TabStop = false;
            groupBoxVvod_ARS.Text = "Ввод данных";
            // 
            // buttonHelp_ARS
            // 
            buttonHelp_ARS.Anchor = AnchorStyles.Right;
            buttonHelp_ARS.BackColor = Color.MediumTurquoise;
            buttonHelp_ARS.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonHelp_ARS.Location = new Point(985, 26);
            buttonHelp_ARS.Name = "buttonHelp_ARS";
            buttonHelp_ARS.Size = new Size(83, 66);
            buttonHelp_ARS.TabIndex = 6;
            buttonHelp_ARS.Text = "Справка";
            buttonHelp_ARS.UseVisualStyleBackColor = false;
            buttonHelp_ARS.Click += buttonHelp_ARS_Click;
            // 
            // buttonSave_ARS
            // 
            buttonSave_ARS.BackColor = Color.SteelBlue;
            buttonSave_ARS.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave_ARS.Location = new Point(386, 22);
            buttonSave_ARS.Name = "buttonSave_ARS";
            buttonSave_ARS.Size = new Size(86, 66);
            buttonSave_ARS.TabIndex = 5;
            buttonSave_ARS.Text = "Сохранить";
            buttonSave_ARS.UseVisualStyleBackColor = false;
            buttonSave_ARS.Click += buttonSave_ARS_Click;
            // 
            // buttonDone_ARS
            // 
            buttonDone_ARS.BackColor = Color.ForestGreen;
            buttonDone_ARS.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDone_ARS.Location = new Point(295, 22);
            buttonDone_ARS.Name = "buttonDone_ARS";
            buttonDone_ARS.Size = new Size(85, 66);
            buttonDone_ARS.TabIndex = 4;
            buttonDone_ARS.Text = "Выполнить";
            buttonDone_ARS.UseVisualStyleBackColor = false;
            buttonDone_ARS.Click += buttonDone_ARS_Click;
            // 
            // textBoxB_ARS
            // 
            textBoxB_ARS.Location = new Point(158, 61);
            textBoxB_ARS.Name = "textBoxB_ARS";
            textBoxB_ARS.Size = new Size(121, 27);
            textBoxB_ARS.TabIndex = 3;
            // 
            // textBoxA_ARS
            // 
            textBoxA_ARS.Location = new Point(6, 61);
            textBoxA_ARS.Name = "textBoxA_ARS";
            textBoxA_ARS.Size = new Size(120, 27);
            textBoxA_ARS.TabIndex = 2;
            // 
            // textBoxEnd_ARS
            // 
            textBoxEnd_ARS.BorderStyle = BorderStyle.None;
            textBoxEnd_ARS.Font = new Font("Segoe UI", 10F);
            textBoxEnd_ARS.Location = new Point(158, 32);
            textBoxEnd_ARS.Multiline = true;
            textBoxEnd_ARS.Name = "textBoxEnd_ARS";
            textBoxEnd_ARS.ReadOnly = true;
            textBoxEnd_ARS.Size = new Size(100, 23);
            textBoxEnd_ARS.TabIndex = 1;
            textBoxEnd_ARS.Text = "Конец шага:";
            // 
            // textBoxStart_ARS
            // 
            textBoxStart_ARS.BorderStyle = BorderStyle.None;
            textBoxStart_ARS.Font = new Font("Segoe UI", 10F);
            textBoxStart_ARS.Location = new Point(6, 32);
            textBoxStart_ARS.Multiline = true;
            textBoxStart_ARS.Name = "textBoxStart_ARS";
            textBoxStart_ARS.ReadOnly = true;
            textBoxStart_ARS.Size = new Size(107, 29);
            textBoxStart_ARS.TabIndex = 0;
            textBoxStart_ARS.Text = "Старт шага:";
            // 
            // textBoxVivod_ARS
            // 
            textBoxVivod_ARS.BorderStyle = BorderStyle.None;
            textBoxVivod_ARS.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxVivod_ARS.Location = new Point(12, 120);
            textBoxVivod_ARS.Multiline = true;
            textBoxVivod_ARS.Name = "textBoxVivod_ARS";
            textBoxVivod_ARS.ReadOnly = true;
            textBoxVivod_ARS.Size = new Size(110, 31);
            textBoxVivod_ARS.TabIndex = 2;
            textBoxVivod_ARS.Text = "Вывод:";
            // 
            // textBoxResult_ARS
            // 
            textBoxResult_ARS.BackColor = SystemColors.ControlLightLight;
            textBoxResult_ARS.BorderStyle = BorderStyle.FixedSingle;
            textBoxResult_ARS.Dock = DockStyle.Left;
            textBoxResult_ARS.Location = new Point(0, 108);
            textBoxResult_ARS.Multiline = true;
            textBoxResult_ARS.Name = "textBoxResult_ARS";
            textBoxResult_ARS.ReadOnly = true;
            textBoxResult_ARS.ScrollBars = ScrollBars.Vertical;
            textBoxResult_ARS.Size = new Size(296, 516);
            textBoxResult_ARS.TabIndex = 3;
            // 
            // chartFunc_ARS
            // 
            chartArea1.Name = "ChartArea1";
            chartFunc_ARS.ChartAreas.Add(chartArea1);
            chartFunc_ARS.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunc_ARS.Legends.Add(legend1);
            chartFunc_ARS.Location = new Point(296, 108);
            chartFunc_ARS.Name = "chartFunc_ARS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Функция ";
            chartFunc_ARS.Series.Add(series1);
            chartFunc_ARS.Size = new Size(784, 516);
            chartFunc_ARS.TabIndex = 4;
            chartFunc_ARS.Text = "chart1";
            title1.BackColor = Color.White;
            title1.BorderColor = Color.White;
            title1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            title1.ForeColor = Color.DodgerBlue;
            title1.Name = "Title1";
            title1.Text = "График функции sin(x)";
            chartFunc_ARS.Titles.Add(title1);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 732);
            Controls.Add(chartFunc_ARS);
            Controls.Add(textBoxResult_ARS);
            Controls.Add(textBoxVivod_ARS);
            Controls.Add(groupBoxVvod_ARS);
            Controls.Add(groupBoxCon_ARS);
            MinimumSize = new Size(1096, 771);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 3 | Атакишиев Р.С.";
            groupBoxCon_ARS.ResumeLayout(false);
            groupBoxCon_ARS.PerformLayout();
            groupBoxVvod_ARS.ResumeLayout(false);
            groupBoxVvod_ARS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunc_ARS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxCon_ARS;
        private TextBox textBoxTask_ARS;
        private GroupBox groupBoxVvod_ARS;
        private Button buttonDone_ARS;
        private TextBox textBoxB_ARS;
        private TextBox textBoxA_ARS;
        private TextBox textBoxEnd_ARS;
        private TextBox textBoxStart_ARS;
        private Button buttonHelp_ARS;
        private Button buttonSave_ARS;
        private TextBox textBoxVivod_ARS;
        private TextBox textBoxResult_ARS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc_ARS;
    }
}
