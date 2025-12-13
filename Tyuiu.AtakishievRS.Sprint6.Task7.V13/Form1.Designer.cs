namespace Tyuiu.AtakishievRS.Sprint6.Task7.V13
{
    partial class FormAbout_ARS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_ARS));
            pictureBox_ARS = new PictureBox();
            labelForm_ARS = new Label();
            buttonOK = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_ARS).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_ARS
            // 
            pictureBox_ARS.Image = (Image)resources.GetObject("pictureBox_ARS.Image");
            pictureBox_ARS.Location = new Point(12, 12);
            pictureBox_ARS.Name = "pictureBox_ARS";
            pictureBox_ARS.Size = new Size(207, 227);
            pictureBox_ARS.TabIndex = 0;
            pictureBox_ARS.TabStop = false;
            // 
            // labelForm_ARS
            // 
            labelForm_ARS.Font = new Font("Segoe UI", 11F);
            labelForm_ARS.Location = new Point(225, 12);
            labelForm_ARS.Name = "labelForm_ARS";
            labelForm_ARS.Size = new Size(272, 230);
            labelForm_ARS.TabIndex = 1;
            labelForm_ARS.Text = "Атакишиев Рашид Саркар оглы\r\n\r\nЭта программа создана студентом группы РППб-25-1\r\n\r\n2025\r\n";
            // 
            // buttonOK
            // 
            buttonOK.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOK.Location = new Point(388, 207);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(109, 35);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "ОК";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // FormAbout_ARS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 251);
            Controls.Add(buttonOK);
            Controls.Add(labelForm_ARS);
            Controls.Add(pictureBox_ARS);
            MaximumSize = new Size(525, 290);
            MinimumSize = new Size(525, 290);
            Name = "FormAbout_ARS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox_ARS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox_ARS;
        private Label labelForm_ARS;
        private Button buttonOK;
    }
}