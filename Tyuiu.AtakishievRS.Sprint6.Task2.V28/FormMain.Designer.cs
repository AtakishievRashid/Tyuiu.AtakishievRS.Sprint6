namespace Tyuiu.AtakishievRS.Sprint6.Task2.V28
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
            groupBoxCon_ARS = new GroupBox();
            textBoxTask_ARS = new TextBox();
            groupBoxVvod_ARS = new GroupBox();
            textBoxEnd_ARS = new TextBox();
            textBoxStart_ARS = new TextBox();
            textBoxforEnd_ARS = new TextBox();
            textBoxforStart_ARS = new TextBox();
            buttonHelp_ARS = new Button();
            buttonDone_ARS = new Button();
            dataGridViewTask = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            groupBoxVivod_ARS = new GroupBox();
            chartFunc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBox1 = new TextBox();
            groupBoxCon_ARS.SuspendLayout();
            groupBoxVvod_ARS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask).BeginInit();
            groupBoxVivod_ARS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunc).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCon_ARS
            // 
            groupBoxCon_ARS.Controls.Add(textBoxTask_ARS);
            groupBoxCon_ARS.Font = new Font("Segoe UI", 14F);
            groupBoxCon_ARS.Location = new Point(12, 12);
            groupBoxCon_ARS.Name = "groupBoxCon_ARS";
            groupBoxCon_ARS.Size = new Size(542, 316);
            groupBoxCon_ARS.TabIndex = 0;
            groupBoxCon_ARS.TabStop = false;
            groupBoxCon_ARS.Text = "Условие";
            // 
            // textBoxTask_ARS
            // 
            textBoxTask_ARS.BackColor = SystemColors.MenuBar;
            textBoxTask_ARS.BorderStyle = BorderStyle.None;
            textBoxTask_ARS.Font = new Font("Segoe UI", 13F);
            textBoxTask_ARS.ForeColor = SystemColors.MenuText;
            textBoxTask_ARS.Location = new Point(6, 31);
            textBoxTask_ARS.Multiline = true;
            textBoxTask_ARS.Name = "textBoxTask_ARS";
            textBoxTask_ARS.Size = new Size(536, 279);
            textBoxTask_ARS.TabIndex = 0;
            textBoxTask_ARS.Text = "Протабулировать функцию sin(x) на заданном диапазоне.\r\nРезультат вывести в DataGridView и построить график функции.\r\n";
            // 
            // groupBoxVvod_ARS
            // 
            groupBoxVvod_ARS.Controls.Add(textBoxEnd_ARS);
            groupBoxVvod_ARS.Controls.Add(textBoxStart_ARS);
            groupBoxVvod_ARS.Controls.Add(textBoxforEnd_ARS);
            groupBoxVvod_ARS.Controls.Add(textBoxforStart_ARS);
            groupBoxVvod_ARS.Font = new Font("Segoe UI", 10F);
            groupBoxVvod_ARS.Location = new Point(12, 331);
            groupBoxVvod_ARS.Name = "groupBoxVvod_ARS";
            groupBoxVvod_ARS.Size = new Size(309, 80);
            groupBoxVvod_ARS.TabIndex = 1;
            groupBoxVvod_ARS.TabStop = false;
            groupBoxVvod_ARS.Text = "Ввод данных";
            // 
            // textBoxEnd_ARS
            // 
            textBoxEnd_ARS.Location = new Point(171, 53);
            textBoxEnd_ARS.Name = "textBoxEnd_ARS";
            textBoxEnd_ARS.Size = new Size(132, 25);
            textBoxEnd_ARS.TabIndex = 3;
            // 
            // textBoxStart_ARS
            // 
            textBoxStart_ARS.Location = new Point(6, 53);
            textBoxStart_ARS.Name = "textBoxStart_ARS";
            textBoxStart_ARS.Size = new Size(125, 25);
            textBoxStart_ARS.TabIndex = 2;
            // 
            // textBoxforEnd_ARS
            // 
            textBoxforEnd_ARS.BackColor = SystemColors.Menu;
            textBoxforEnd_ARS.BorderStyle = BorderStyle.None;
            textBoxforEnd_ARS.Location = new Point(171, 24);
            textBoxforEnd_ARS.Multiline = true;
            textBoxforEnd_ARS.Name = "textBoxforEnd_ARS";
            textBoxforEnd_ARS.Size = new Size(100, 23);
            textBoxforEnd_ARS.TabIndex = 1;
            textBoxforEnd_ARS.Text = "Конец шага:";
            // 
            // textBoxforStart_ARS
            // 
            textBoxforStart_ARS.BackColor = SystemColors.Menu;
            textBoxforStart_ARS.BorderStyle = BorderStyle.None;
            textBoxforStart_ARS.Location = new Point(6, 24);
            textBoxforStart_ARS.Multiline = true;
            textBoxforStart_ARS.Name = "textBoxforStart_ARS";
            textBoxforStart_ARS.Size = new Size(100, 23);
            textBoxforStart_ARS.TabIndex = 0;
            textBoxforStart_ARS.Text = "Старт шага:";
            // 
            // buttonHelp_ARS
            // 
            buttonHelp_ARS.BackColor = Color.DeepSkyBlue;
            buttonHelp_ARS.Font = new Font("Segoe UI", 10F);
            buttonHelp_ARS.Location = new Point(348, 343);
            buttonHelp_ARS.Name = "buttonHelp_ARS";
            buttonHelp_ARS.Size = new Size(77, 68);
            buttonHelp_ARS.TabIndex = 2;
            buttonHelp_ARS.Text = "Справка";
            buttonHelp_ARS.UseVisualStyleBackColor = false;
            buttonHelp_ARS.Click += buttonHelp_ARS_Click;
            // 
            // buttonDone_ARS
            // 
            buttonDone_ARS.BackColor = Color.LimeGreen;
            buttonDone_ARS.Font = new Font("Segoe UI", 11F);
            buttonDone_ARS.Location = new Point(431, 343);
            buttonDone_ARS.Name = "buttonDone_ARS";
            buttonDone_ARS.Size = new Size(123, 66);
            buttonDone_ARS.TabIndex = 0;
            buttonDone_ARS.Text = "Выполнить";
            buttonDone_ARS.UseVisualStyleBackColor = false;
            buttonDone_ARS.Click += buttonDone_ARS_Click;
            buttonDone_ARS.MouseDown += buttonDone_ARS_MouseDown;
            buttonDone_ARS.MouseEnter += buttonDone_ARS_MouseEnter;
            buttonDone_ARS.MouseLeave += buttonDone_ARS_MouseLeave;
            // 
            // dataGridViewTask
            // 
            dataGridViewTask.BackgroundColor = SystemColors.AppWorkspace;
            dataGridViewTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTask.Columns.AddRange(new DataGridViewColumn[] { X, Column1 });
            dataGridViewTask.Location = new Point(6, 58);
            dataGridViewTask.Name = "dataGridViewTask";
            dataGridViewTask.RowHeadersVisible = false;
            dataGridViewTask.Size = new Size(148, 328);
            dataGridViewTask.TabIndex = 3;
            dataGridViewTask.CellContentClick += dataGridViewTask_CellContentClick;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 70;
            // 
            // Column1
            // 
            Column1.HeaderText = "F(X)";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 70;
            // 
            // groupBoxVivod_ARS
            // 
            groupBoxVivod_ARS.Controls.Add(chartFunc);
            groupBoxVivod_ARS.Controls.Add(textBox1);
            groupBoxVivod_ARS.Controls.Add(dataGridViewTask);
            groupBoxVivod_ARS.Font = new Font("Segoe UI", 12F);
            groupBoxVivod_ARS.Location = new Point(560, 21);
            groupBoxVivod_ARS.Name = "groupBoxVivod_ARS";
            groupBoxVivod_ARS.Size = new Size(600, 388);
            groupBoxVivod_ARS.TabIndex = 4;
            groupBoxVivod_ARS.TabStop = false;
            groupBoxVivod_ARS.Text = "Вывод данных";
            // 
            // chartFunc
            // 
            chartArea1.Name = "ChartArea1";
            chartFunc.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunc.Legends.Add(legend1);
            chartFunc.Location = new Point(160, 58);
            chartFunc.Name = "chartFunc";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunc.Series.Add(series1);
            chartFunc.Size = new Size(434, 330);
            chartFunc.TabIndex = 5;
            chartFunc.Text = "chart1";
            chartFunc.Click += chartFunc_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(6, 28);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(109, 22);
            textBox1.TabIndex = 4;
            textBox1.Text = "Результат:";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 423);
            Controls.Add(groupBoxVivod_ARS);
            Controls.Add(buttonDone_ARS);
            Controls.Add(buttonHelp_ARS);
            Controls.Add(groupBoxVvod_ARS);
            Controls.Add(groupBoxCon_ARS);
            Name = "FormMain";
            Text = "Спринт 6 | Тсаск 2 | Вариант 28 | Атакишиев Р.С.";
            groupBoxCon_ARS.ResumeLayout(false);
            groupBoxCon_ARS.PerformLayout();
            groupBoxVvod_ARS.ResumeLayout(false);
            groupBoxVvod_ARS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask).EndInit();
            groupBoxVivod_ARS.ResumeLayout(false);
            groupBoxVivod_ARS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCon_ARS;
        private TextBox textBoxTask_ARS;
        private GroupBox groupBoxVvod_ARS;
        private TextBox textBoxforStart_ARS;
        private TextBox textBoxEnd_ARS;
        private TextBox textBoxStart_ARS;
        private TextBox textBoxforEnd_ARS;
        private Button buttonHelp_ARS;
        private Button buttonDone_ARS;
        private DataGridView dataGridViewTask;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Column1;
        private GroupBox groupBoxVivod_ARS;
        private TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc;
    }
}
