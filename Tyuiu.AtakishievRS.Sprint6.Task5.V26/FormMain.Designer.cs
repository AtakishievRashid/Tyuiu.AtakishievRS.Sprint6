namespace Tyuiu.AtakishievRS.Sprint6.Task5.V26
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
            buttonDone_ARS = new Button();
            buttonOpen_ARS = new Button();
            textBoxTask_ARS = new TextBox();
            buttonHelp_ARS = new Button();
            groupBoxVivod_ARS = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBoxOutput_ARS = new GroupBox();
            splitterBuild_ARS = new Splitter();
            dataGridView_ARS = new DataGridView();
            chartFunc_ARS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxCon_ARS.SuspendLayout();
            groupBoxVivod_ARS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxOutput_ARS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ARS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunc_ARS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCon_ARS
            // 
            groupBoxCon_ARS.Controls.Add(buttonDone_ARS);
            groupBoxCon_ARS.Controls.Add(buttonOpen_ARS);
            groupBoxCon_ARS.Controls.Add(textBoxTask_ARS);
            groupBoxCon_ARS.Controls.Add(buttonHelp_ARS);
            groupBoxCon_ARS.Dock = DockStyle.Top;
            groupBoxCon_ARS.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxCon_ARS.Location = new Point(0, 0);
            groupBoxCon_ARS.Name = "groupBoxCon_ARS";
            groupBoxCon_ARS.Size = new Size(1007, 111);
            groupBoxCon_ARS.TabIndex = 0;
            groupBoxCon_ARS.TabStop = false;
            groupBoxCon_ARS.Text = "Условие:";
            // 
            // buttonDone_ARS
            // 
            buttonDone_ARS.BackColor = Color.ForestGreen;
            buttonDone_ARS.Location = new Point(607, 22);
            buttonDone_ARS.Name = "buttonDone_ARS";
            buttonDone_ARS.Size = new Size(117, 74);
            buttonDone_ARS.TabIndex = 5;
            buttonDone_ARS.Text = "Выполнить";
            buttonDone_ARS.UseVisualStyleBackColor = false;
            buttonDone_ARS.Click += buttonDone_ARS_Click;
            // 
            // buttonOpen_ARS
            // 
            buttonOpen_ARS.BackColor = Color.MediumSlateBlue;
            buttonOpen_ARS.Location = new Point(750, 21);
            buttonOpen_ARS.Name = "buttonOpen_ARS";
            buttonOpen_ARS.Size = new Size(117, 75);
            buttonOpen_ARS.TabIndex = 4;
            buttonOpen_ARS.Text = "Открыть файл";
            buttonOpen_ARS.UseVisualStyleBackColor = false;
            buttonOpen_ARS.Click += buttonOpen_ARS_Click;
            // 
            // textBoxTask_ARS
            // 
            textBoxTask_ARS.BorderStyle = BorderStyle.None;
            textBoxTask_ARS.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_ARS.Location = new Point(6, 30);
            textBoxTask_ARS.Multiline = true;
            textBoxTask_ARS.Name = "textBoxTask_ARS";
            textBoxTask_ARS.ReadOnly = true;
            textBoxTask_ARS.Size = new Size(562, 75);
            textBoxTask_ARS.TabIndex = 0;
            textBoxTask_ARS.Text = "Прочитать данные из файла InPutFileTask5V26.txt. Вывести в dataGridView. \r\nВывести все числа, кратные 5. Построить диаграмму по этим значениям.";
            // 
            // buttonHelp_ARS
            // 
            buttonHelp_ARS.Anchor = AnchorStyles.Right;
            buttonHelp_ARS.BackColor = SystemColors.MenuHighlight;
            buttonHelp_ARS.Location = new Point(888, 21);
            buttonHelp_ARS.Name = "buttonHelp_ARS";
            buttonHelp_ARS.Size = new Size(109, 75);
            buttonHelp_ARS.TabIndex = 3;
            buttonHelp_ARS.Text = "Справка";
            buttonHelp_ARS.UseVisualStyleBackColor = false;
            buttonHelp_ARS.Click += buttonHelp_ARS_Click;
            // 
            // groupBoxVivod_ARS
            // 
            groupBoxVivod_ARS.Controls.Add(dataGridView1);
            groupBoxVivod_ARS.Dock = DockStyle.Left;
            groupBoxVivod_ARS.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxVivod_ARS.Location = new Point(0, 0);
            groupBoxVivod_ARS.Name = "groupBoxVivod_ARS";
            groupBoxVivod_ARS.Size = new Size(206, 549);
            groupBoxVivod_ARS.TabIndex = 0;
            groupBoxVivod_ARS.TabStop = false;
            groupBoxVivod_ARS.Text = "Вывод данных:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(188, 517);
            dataGridView1.TabIndex = 0;
            // 
            // groupBoxOutput_ARS
            // 
            groupBoxOutput_ARS.Controls.Add(splitterBuild_ARS);
            groupBoxOutput_ARS.Controls.Add(dataGridView_ARS);
            groupBoxOutput_ARS.Dock = DockStyle.Left;
            groupBoxOutput_ARS.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxOutput_ARS.Location = new Point(0, 111);
            groupBoxOutput_ARS.Name = "groupBoxOutput_ARS";
            groupBoxOutput_ARS.Size = new Size(229, 549);
            groupBoxOutput_ARS.TabIndex = 1;
            groupBoxOutput_ARS.TabStop = false;
            groupBoxOutput_ARS.Text = "Вывод данных:";
            groupBoxOutput_ARS.Enter += groupBoxOutput_ARS_Enter;
            // 
            // splitterBuild_ARS
            // 
            splitterBuild_ARS.Location = new Point(3, 23);
            splitterBuild_ARS.Name = "splitterBuild_ARS";
            splitterBuild_ARS.Size = new Size(3, 523);
            splitterBuild_ARS.TabIndex = 1;
            splitterBuild_ARS.TabStop = false;
            // 
            // dataGridView_ARS
            // 
            dataGridView_ARS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_ARS.Location = new Point(6, 26);
            dataGridView_ARS.Name = "dataGridView_ARS";
            dataGridView_ARS.Size = new Size(217, 509);
            dataGridView_ARS.TabIndex = 0;
            // 
            // chartFunc_ARS
            // 
            chartArea1.Name = "ChartArea1";
            chartFunc_ARS.ChartAreas.Add(chartArea1);
            chartFunc_ARS.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunc_ARS.Legends.Add(legend1);
            chartFunc_ARS.Location = new Point(229, 111);
            chartFunc_ARS.Name = "chartFunc_ARS";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunc_ARS.Series.Add(series1);
            chartFunc_ARS.Size = new Size(778, 549);
            chartFunc_ARS.TabIndex = 2;
            chartFunc_ARS.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 660);
            Controls.Add(chartFunc_ARS);
            Controls.Add(groupBoxOutput_ARS);
            Controls.Add(groupBoxCon_ARS);
            MinimumSize = new Size(1023, 699);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 26 | Атакишиев Р.С.";
            groupBoxCon_ARS.ResumeLayout(false);
            groupBoxCon_ARS.PerformLayout();
            groupBoxVivod_ARS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxOutput_ARS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_ARS).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunc_ARS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCon_ARS;
        private TextBox textBoxTask_ARS;
        private Button buttonHelp_ARS;
        private GroupBox groupBoxVivod_ARS;
        private DataGridView dataGridView1;
        private GroupBox groupBoxOutput_ARS;
        private DataGridView dataGridView_ARS;
        private Splitter splitterBuild_ARS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc_ARS;
        private Button buttonOpen_ARS;
        private Button buttonDone_ARS;
    }
}
