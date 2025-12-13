namespace Tyuiu.AtakishievRS.Sprint6.Task7.V13
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBoxButtons_ARS = new GroupBox();
            buttonHelp_ARS = new Button();
            buttonSave_ARS = new Button();
            buttonFile_ARS = new Button();
            buttonOpenFile_ARS = new Button();
            groupBoxCon_ARS = new GroupBox();
            labelTask_ARS = new Label();
            groupBoxIn_ARS = new GroupBox();
            dataGridViewIn_ARS = new DataGridView();
            groupBoxOut_ARS = new GroupBox();
            dataGridViewOut_ARS = new DataGridView();
            toolTipButtons = new ToolTip(components);
            openFileDialogTask_ARS = new OpenFileDialog();
            saveFileDialogTask_ARS = new SaveFileDialog();
            groupBoxButtons_ARS.SuspendLayout();
            groupBoxCon_ARS.SuspendLayout();
            groupBoxIn_ARS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_ARS).BeginInit();
            groupBoxOut_ARS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_ARS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxButtons_ARS
            // 
            groupBoxButtons_ARS.Controls.Add(buttonHelp_ARS);
            groupBoxButtons_ARS.Controls.Add(buttonSave_ARS);
            groupBoxButtons_ARS.Controls.Add(buttonFile_ARS);
            groupBoxButtons_ARS.Controls.Add(buttonOpenFile_ARS);
            groupBoxButtons_ARS.Dock = DockStyle.Top;
            groupBoxButtons_ARS.Location = new Point(0, 0);
            groupBoxButtons_ARS.Name = "groupBoxButtons_ARS";
            groupBoxButtons_ARS.Size = new Size(1148, 92);
            groupBoxButtons_ARS.TabIndex = 0;
            groupBoxButtons_ARS.TabStop = false;
            // 
            // buttonHelp_ARS
            // 
            buttonHelp_ARS.Anchor = AnchorStyles.Right;
            buttonHelp_ARS.BackColor = SystemColors.ButtonFace;
            buttonHelp_ARS.Image = (Image)resources.GetObject("buttonHelp_ARS.Image");
            buttonHelp_ARS.Location = new Point(1044, 9);
            buttonHelp_ARS.Name = "buttonHelp_ARS";
            buttonHelp_ARS.Size = new Size(98, 73);
            buttonHelp_ARS.TabIndex = 3;
            toolTipButtons.SetToolTip(buttonHelp_ARS, "Сведения о программе\r\n");
            buttonHelp_ARS.UseVisualStyleBackColor = false;
            buttonHelp_ARS.Click += buttonHelp_ARS_Click;
            // 
            // buttonSave_ARS
            // 
            buttonSave_ARS.BackColor = SystemColors.ButtonFace;
            buttonSave_ARS.Enabled = false;
            buttonSave_ARS.Image = (Image)resources.GetObject("buttonSave_ARS.Image");
            buttonSave_ARS.Location = new Point(251, 9);
            buttonSave_ARS.Name = "buttonSave_ARS";
            buttonSave_ARS.Size = new Size(98, 73);
            buttonSave_ARS.TabIndex = 2;
            toolTipButtons.SetToolTip(buttonSave_ARS, "Сохранить обработанные данные в файл");
            buttonSave_ARS.UseVisualStyleBackColor = false;
            buttonSave_ARS.Click += buttonSave_ARS_Click;
            buttonSave_ARS.MouseEnter += buttonSave_ARS_MouseEnter;
            // 
            // buttonFile_ARS
            // 
            buttonFile_ARS.BackColor = SystemColors.ButtonFace;
            buttonFile_ARS.Enabled = false;
            buttonFile_ARS.Image = (Image)resources.GetObject("buttonFile_ARS.Image");
            buttonFile_ARS.Location = new Point(131, 9);
            buttonFile_ARS.Name = "buttonFile_ARS";
            buttonFile_ARS.Size = new Size(98, 73);
            buttonFile_ARS.TabIndex = 1;
            toolTipButtons.SetToolTip(buttonFile_ARS, "Выполнить обработку данных");
            buttonFile_ARS.UseVisualStyleBackColor = false;
            buttonFile_ARS.Click += buttonFile_ARS_Click;
            buttonFile_ARS.MouseEnter += buttonFile_ARS_MouseEnter;
            // 
            // buttonOpenFile_ARS
            // 
            buttonOpenFile_ARS.BackColor = SystemColors.ButtonFace;
            buttonOpenFile_ARS.Image = (Image)resources.GetObject("buttonOpenFile_ARS.Image");
            buttonOpenFile_ARS.Location = new Point(11, 9);
            buttonOpenFile_ARS.Name = "buttonOpenFile_ARS";
            buttonOpenFile_ARS.Size = new Size(98, 73);
            buttonOpenFile_ARS.TabIndex = 0;
            toolTipButtons.SetToolTip(buttonOpenFile_ARS, "Открыть файл для обработки");
            buttonOpenFile_ARS.UseVisualStyleBackColor = false;
            buttonOpenFile_ARS.Click += buttonOpenFile_ARS_Click;
            buttonOpenFile_ARS.MouseEnter += buttonOpenFile_ARS_MouseEnter;
            // 
            // groupBoxCon_ARS
            // 
            groupBoxCon_ARS.Controls.Add(labelTask_ARS);
            groupBoxCon_ARS.Dock = DockStyle.Top;
            groupBoxCon_ARS.Font = new Font("Segoe UI", 11F);
            groupBoxCon_ARS.Location = new Point(0, 92);
            groupBoxCon_ARS.Name = "groupBoxCon_ARS";
            groupBoxCon_ARS.Size = new Size(1148, 111);
            groupBoxCon_ARS.TabIndex = 1;
            groupBoxCon_ARS.TabStop = false;
            groupBoxCon_ARS.Text = "Условие:";
            // 
            // labelTask_ARS
            // 
            labelTask_ARS.Location = new Point(6, 23);
            labelTask_ARS.Name = "labelTask_ARS";
            labelTask_ARS.Size = new Size(909, 85);
            labelTask_ARS.TabIndex = 0;
            labelTask_ARS.Text = resources.GetString("labelTask_ARS.Text");
            // 
            // groupBoxIn_ARS
            // 
            groupBoxIn_ARS.Controls.Add(dataGridViewIn_ARS);
            groupBoxIn_ARS.Dock = DockStyle.Left;
            groupBoxIn_ARS.Font = new Font("Segoe UI", 11F);
            groupBoxIn_ARS.Location = new Point(0, 203);
            groupBoxIn_ARS.MinimumSize = new Size(604, 370);
            groupBoxIn_ARS.Name = "groupBoxIn_ARS";
            groupBoxIn_ARS.Size = new Size(1148, 370);
            groupBoxIn_ARS.TabIndex = 3;
            groupBoxIn_ARS.TabStop = false;
            groupBoxIn_ARS.Text = "Ввод:";
            groupBoxIn_ARS.Enter += FormMain_Load;
            // 
            // dataGridViewIn_ARS
            // 
            dataGridViewIn_ARS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewIn_ARS.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewIn_ARS.Dock = DockStyle.Fill;
            dataGridViewIn_ARS.Location = new Point(3, 23);
            dataGridViewIn_ARS.Name = "dataGridViewIn_ARS";
            dataGridViewIn_ARS.Size = new Size(1142, 344);
            dataGridViewIn_ARS.TabIndex = 0;
            // 
            // groupBoxOut_ARS
            // 
            groupBoxOut_ARS.Controls.Add(dataGridViewOut_ARS);
            groupBoxOut_ARS.Dock = DockStyle.Right;
            groupBoxOut_ARS.Font = new Font("Segoe UI", 11F);
            groupBoxOut_ARS.Location = new Point(544, 203);
            groupBoxOut_ARS.MinimumSize = new Size(604, 390);
            groupBoxOut_ARS.Name = "groupBoxOut_ARS";
            groupBoxOut_ARS.Size = new Size(604, 390);
            groupBoxOut_ARS.TabIndex = 4;
            groupBoxOut_ARS.TabStop = false;
            groupBoxOut_ARS.Text = "Вывод:";
            // 
            // dataGridViewOut_ARS
            // 
            dataGridViewOut_ARS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewOut_ARS.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewOut_ARS.Dock = DockStyle.Fill;
            dataGridViewOut_ARS.Location = new Point(3, 23);
            dataGridViewOut_ARS.Name = "dataGridViewOut_ARS";
            dataGridViewOut_ARS.Size = new Size(598, 364);
            dataGridViewOut_ARS.TabIndex = 0;
            // 
            // toolTipButtons
            // 
            toolTipButtons.IsBalloon = true;
            toolTipButtons.ToolTipIcon = ToolTipIcon.Info;
            toolTipButtons.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogTask_ARS
            // 
            openFileDialogTask_ARS.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 573);
            Controls.Add(groupBoxOut_ARS);
            Controls.Add(groupBoxIn_ARS);
            Controls.Add(groupBoxCon_ARS);
            Controls.Add(groupBoxButtons_ARS);
            MinimumSize = new Size(1164, 612);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 7 | Таск 7 | Вариант 13 | Атакишиев Р.С.";
            toolTipButtons.SetToolTip(this, "Сведения о программе");
            Load += FormMain_Load;
            groupBoxButtons_ARS.ResumeLayout(false);
            groupBoxCon_ARS.ResumeLayout(false);
            groupBoxIn_ARS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_ARS).EndInit();
            groupBoxOut_ARS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_ARS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxButtons_ARS;
        private Button buttonFile_ARS;
        private Button buttonOpenFile_ARS;
        private GroupBox groupBoxCon_ARS;
        private Button buttonHelp_ARS;
        private Button buttonSave_ARS;
        private Label labelTask_ARS;
        private GroupBox groupBoxIn_ARS;
        private DataGridView dataGridViewIn_ARS;
        private GroupBox groupBoxOut_ARS;
        private DataGridView dataGridViewOut_ARS;
        private ToolTip toolTipButtons;
        private OpenFileDialog openFileDialogTask_ARS;
        private SaveFileDialog saveFileDialogTask_ARS;
    }
}
