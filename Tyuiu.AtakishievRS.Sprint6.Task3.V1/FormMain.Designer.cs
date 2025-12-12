namespace Tyuiu.AtakishievRS.Sprint6.Task3.V1
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
            groupBoxCon = new GroupBox();
            dataGridViewMTRX_ARS = new DataGridView();
            textBox1 = new TextBox();
            buttonHelp_ARS = new Button();
            buttonDone_ARS = new Button();
            groupBox1 = new GroupBox();
            dataGridViewResult = new DataGridView();
            groupBoxCon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMTRX_ARS).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCon
            // 
            groupBoxCon.Controls.Add(dataGridViewMTRX_ARS);
            groupBoxCon.Controls.Add(textBox1);
            groupBoxCon.Font = new Font("Segoe UI", 12F);
            groupBoxCon.Location = new Point(12, 12);
            groupBoxCon.Name = "groupBoxCon";
            groupBoxCon.Size = new Size(537, 361);
            groupBoxCon.TabIndex = 0;
            groupBoxCon.TabStop = false;
            groupBoxCon.Text = "Условие";
            // 
            // dataGridViewMTRX_ARS
            // 
            dataGridViewMTRX_ARS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMTRX_ARS.Location = new Point(261, 28);
            dataGridViewMTRX_ARS.Name = "dataGridViewMTRX_ARS";
            dataGridViewMTRX_ARS.Size = new Size(256, 230);
            dataGridViewMTRX_ARS.TabIndex = 1;
            dataGridViewMTRX_ARS.CellContentClick += dataGridViewMTRX_ARS_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(10, 33);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 257);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // buttonHelp_ARS
            // 
            buttonHelp_ARS.Location = new Point(6, 307);
            buttonHelp_ARS.Name = "buttonHelp_ARS";
            buttonHelp_ARS.Size = new Size(37, 37);
            buttonHelp_ARS.TabIndex = 1;
            buttonHelp_ARS.Text = "?";
            buttonHelp_ARS.UseVisualStyleBackColor = true;
            buttonHelp_ARS.Click += buttonHelp_ARS_Click;
            // 
            // buttonDone_ARS
            // 
            buttonDone_ARS.Location = new Point(61, 307);
            buttonDone_ARS.Name = "buttonDone_ARS";
            buttonDone_ARS.Size = new Size(137, 37);
            buttonDone_ARS.TabIndex = 2;
            buttonDone_ARS.Text = "Выполнить";
            buttonDone_ARS.UseVisualStyleBackColor = true;
            buttonDone_ARS.Click += buttonDone_ARS_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewResult);
            groupBox1.Controls.Add(buttonDone_ARS);
            groupBox1.Controls.Add(buttonHelp_ARS);
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.Location = new Point(555, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(301, 361);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вывод данных";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Location = new Point(33, 28);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.Size = new Size(248, 230);
            dataGridViewResult.TabIndex = 3;
            dataGridViewResult.CellContentClick += dataGridViewResult_CellContentClick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 385);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxCon);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 1 | Атакишиев Р.С.";
            Load += FormMain_Load;
            groupBoxCon.ResumeLayout(false);
            groupBoxCon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMTRX_ARS).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCon;
        private TextBox textBox1;
        private Button buttonHelp_ARS;
        private Button buttonDone_ARS;
        private GroupBox groupBox1;
        private DataGridView dataGridViewMTRX_ARS;
        private DataGridView dataGridViewResult;
    }
}
