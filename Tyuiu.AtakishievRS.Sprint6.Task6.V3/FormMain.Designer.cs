namespace Tyuiu.AtakishievRS.Sprint6.Task6.V3
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
            groupBoxButtons_ARS = new GroupBox();
            buttonOpen_ARS = new Button();
            buttonWorld_ARS = new Button();
            buttonOut_ARS = new Button();
            groupBoxCon_ARS = new GroupBox();
            textBoxTask_ARS = new TextBox();
            groupBoxIn_ARS = new GroupBox();
            textBoxIn_ARS = new TextBox();
            groupBoxOut_ARS = new GroupBox();
            textBoxOut_ARS = new TextBox();
            openFileDialogTask_ARS = new OpenFileDialog();
            toolTip_ARS = new ToolTip(components);
            groupBoxButtons_ARS.SuspendLayout();
            groupBoxCon_ARS.SuspendLayout();
            groupBoxIn_ARS.SuspendLayout();
            groupBoxOut_ARS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxButtons_ARS
            // 
            groupBoxButtons_ARS.Controls.Add(buttonOpen_ARS);
            groupBoxButtons_ARS.Controls.Add(buttonWorld_ARS);
            groupBoxButtons_ARS.Controls.Add(buttonOut_ARS);
            groupBoxButtons_ARS.Dock = DockStyle.Top;
            groupBoxButtons_ARS.Location = new Point(0, 0);
            groupBoxButtons_ARS.Name = "groupBoxButtons_ARS";
            groupBoxButtons_ARS.Size = new Size(1146, 87);
            groupBoxButtons_ARS.TabIndex = 0;
            groupBoxButtons_ARS.TabStop = false;
            // 
            // buttonOpen_ARS
            // 
            buttonOpen_ARS.BackColor = SystemColors.ButtonFace;
            buttonOpen_ARS.Image = (Image)resources.GetObject("buttonOpen_ARS.Image");
            buttonOpen_ARS.Location = new Point(12, 9);
            buttonOpen_ARS.Name = "buttonOpen_ARS";
            buttonOpen_ARS.Size = new Size(100, 72);
            buttonOpen_ARS.TabIndex = 3;
            toolTip_ARS.SetToolTip(buttonOpen_ARS, "Открыть файл.\r\nВыберите нужный файл из папки.\r\n");
            buttonOpen_ARS.UseVisualStyleBackColor = false;
            buttonOpen_ARS.Click += buttonOpen_ARS_Click;
            // 
            // buttonWorld_ARS
            // 
            buttonWorld_ARS.Anchor = AnchorStyles.Right;
            buttonWorld_ARS.BackColor = SystemColors.ButtonFace;
            buttonWorld_ARS.Image = (Image)resources.GetObject("buttonWorld_ARS.Image");
            buttonWorld_ARS.Location = new Point(1033, 9);
            buttonWorld_ARS.Name = "buttonWorld_ARS";
            buttonWorld_ARS.Size = new Size(100, 72);
            buttonWorld_ARS.TabIndex = 2;
            toolTip_ARS.SetToolTip(buttonWorld_ARS, "Намжите, для большой информации.");
            buttonWorld_ARS.UseVisualStyleBackColor = false;
            buttonWorld_ARS.Click += buttonWorld_ARS_Click;
            // 
            // buttonOut_ARS
            // 
            buttonOut_ARS.BackColor = SystemColors.ButtonFace;
            buttonOut_ARS.Image = (Image)resources.GetObject("buttonOut_ARS.Image");
            buttonOut_ARS.Location = new Point(132, 9);
            buttonOut_ARS.Name = "buttonOut_ARS";
            buttonOut_ARS.Size = new Size(100, 72);
            buttonOut_ARS.TabIndex = 1;
            toolTip_ARS.SetToolTip(buttonOut_ARS, "Нажмите, чтобы найти решение.");
            buttonOut_ARS.UseVisualStyleBackColor = false;
            buttonOut_ARS.Click += buttonOut_ARS_Click;
            // 
            // groupBoxCon_ARS
            // 
            groupBoxCon_ARS.Controls.Add(textBoxTask_ARS);
            groupBoxCon_ARS.Dock = DockStyle.Top;
            groupBoxCon_ARS.Font = new Font("Segoe UI", 11F);
            groupBoxCon_ARS.Location = new Point(0, 87);
            groupBoxCon_ARS.Name = "groupBoxCon_ARS";
            groupBoxCon_ARS.Size = new Size(1146, 95);
            groupBoxCon_ARS.TabIndex = 1;
            groupBoxCon_ARS.TabStop = false;
            groupBoxCon_ARS.Text = "Условие:";
            // 
            // textBoxTask_ARS
            // 
            textBoxTask_ARS.BorderStyle = BorderStyle.None;
            textBoxTask_ARS.Location = new Point(6, 26);
            textBoxTask_ARS.Multiline = true;
            textBoxTask_ARS.Name = "textBoxTask_ARS";
            textBoxTask_ARS.ReadOnly = true;
            textBoxTask_ARS.Size = new Size(903, 63);
            textBoxTask_ARS.TabIndex = 0;
            textBoxTask_ARS.Text = "Дан файл InPutFileTask6V3.txt который может находится в любом месте на диске. \r\nЗагрузить файл в textBoxIn через openFileDialog. Вывести слова в которых встречается r в результирующею строку";
            // 
            // groupBoxIn_ARS
            // 
            groupBoxIn_ARS.Controls.Add(textBoxIn_ARS);
            groupBoxIn_ARS.Dock = DockStyle.Left;
            groupBoxIn_ARS.Font = new Font("Segoe UI", 11F);
            groupBoxIn_ARS.Location = new Point(0, 182);
            groupBoxIn_ARS.Name = "groupBoxIn_ARS";
            groupBoxIn_ARS.Size = new Size(546, 516);
            groupBoxIn_ARS.TabIndex = 2;
            groupBoxIn_ARS.TabStop = false;
            groupBoxIn_ARS.Text = "Ввод:";
            // 
            // textBoxIn_ARS
            // 
            textBoxIn_ARS.BackColor = SystemColors.ControlLightLight;
            textBoxIn_ARS.Location = new Point(0, 26);
            textBoxIn_ARS.Multiline = true;
            textBoxIn_ARS.Name = "textBoxIn_ARS";
            textBoxIn_ARS.ReadOnly = true;
            textBoxIn_ARS.ScrollBars = ScrollBars.Vertical;
            textBoxIn_ARS.Size = new Size(546, 490);
            textBoxIn_ARS.TabIndex = 0;
            // 
            // groupBoxOut_ARS
            // 
            groupBoxOut_ARS.Controls.Add(textBoxOut_ARS);
            groupBoxOut_ARS.Dock = DockStyle.Fill;
            groupBoxOut_ARS.Font = new Font("Segoe UI", 11F);
            groupBoxOut_ARS.Location = new Point(546, 182);
            groupBoxOut_ARS.Name = "groupBoxOut_ARS";
            groupBoxOut_ARS.Size = new Size(600, 516);
            groupBoxOut_ARS.TabIndex = 3;
            groupBoxOut_ARS.TabStop = false;
            groupBoxOut_ARS.Text = "Вывод:";
            // 
            // textBoxOut_ARS
            // 
            textBoxOut_ARS.BackColor = SystemColors.ControlLightLight;
            textBoxOut_ARS.Location = new Point(6, 26);
            textBoxOut_ARS.Multiline = true;
            textBoxOut_ARS.Name = "textBoxOut_ARS";
            textBoxOut_ARS.ReadOnly = true;
            textBoxOut_ARS.Size = new Size(588, 490);
            textBoxOut_ARS.TabIndex = 0;
            // 
            // openFileDialogTask_ARS
            // 
            openFileDialogTask_ARS.FileName = "openFileDialog1";
            // 
            // toolTip_ARS
            // 
            toolTip_ARS.ToolTipIcon = ToolTipIcon.Info;
            toolTip_ARS.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 698);
            Controls.Add(groupBoxOut_ARS);
            Controls.Add(groupBoxIn_ARS);
            Controls.Add(groupBoxCon_ARS);
            Controls.Add(groupBoxButtons_ARS);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 3 | Атакишиев Р.С. ";
            groupBoxButtons_ARS.ResumeLayout(false);
            groupBoxCon_ARS.ResumeLayout(false);
            groupBoxCon_ARS.PerformLayout();
            groupBoxIn_ARS.ResumeLayout(false);
            groupBoxIn_ARS.PerformLayout();
            groupBoxOut_ARS.ResumeLayout(false);
            groupBoxOut_ARS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxButtons_ARS;
        private Button buttonOut_ARS;
        private Button buttonWorld_ARS;
        private GroupBox groupBoxCon_ARS;
        private TextBox textBoxTask_ARS;
        private GroupBox groupBoxIn_ARS;
        private TextBox textBoxIn_ARS;
        private GroupBox groupBoxOut_ARS;
        private TextBox textBoxOut_ARS;
        private Button buttonOpen_ARS;
        private OpenFileDialog openFileDialogTask_ARS;
        private ToolTip toolTip_ARS;
    }
}
