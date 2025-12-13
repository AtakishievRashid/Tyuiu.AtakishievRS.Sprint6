namespace Tyuiu.AtakishievRS.Sprint6.Task6.V3
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAvatar_ARS = new PictureBox();
            textBoxAbout_ARS = new TextBox();
            buttonOK_ARS = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_ARS).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_ARS
            // 
            pictureBoxAvatar_ARS.Image = (Image)resources.GetObject("pictureBoxAvatar_ARS.Image");
            pictureBoxAvatar_ARS.Location = new Point(2, 14);
            pictureBoxAvatar_ARS.Name = "pictureBoxAvatar_ARS";
            pictureBoxAvatar_ARS.Size = new Size(210, 237);
            pictureBoxAvatar_ARS.TabIndex = 0;
            pictureBoxAvatar_ARS.TabStop = false;
            // 
            // textBoxAbout_ARS
            // 
            textBoxAbout_ARS.Font = new Font("Segoe UI", 12F);
            textBoxAbout_ARS.Location = new Point(232, 16);
            textBoxAbout_ARS.Multiline = true;
            textBoxAbout_ARS.Name = "textBoxAbout_ARS";
            textBoxAbout_ARS.ReadOnly = true;
            textBoxAbout_ARS.Size = new Size(309, 196);
            textBoxAbout_ARS.TabIndex = 1;
            textBoxAbout_ARS.Text = "Разработчик: Атакишиев Рашид Саркар оглы\r\nГруппа РППб-25-1\r\n\r\n\r\n\r\nВнутреннее имя: Tyuiu.AtakishievRS.Sprint6.Task6.V3";
            // 
            // buttonOK_ARS
            // 
            buttonOK_ARS.Font = new Font("SimSun", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOK_ARS.Location = new Point(446, 218);
            buttonOK_ARS.Name = "buttonOK_ARS";
            buttonOK_ARS.Size = new Size(95, 33);
            buttonOK_ARS.TabIndex = 2;
            buttonOK_ARS.Text = "Ок";
            buttonOK_ARS.UseVisualStyleBackColor = true;
            buttonOK_ARS.Click += buttonOK_ARS_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 263);
            Controls.Add(buttonOK_ARS);
            Controls.Add(textBoxAbout_ARS);
            Controls.Add(pictureBoxAvatar_ARS);
            MaximumSize = new Size(569, 302);
            MinimumSize = new Size(569, 302);
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_ARS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar_ARS;
        private TextBox textBoxAbout_ARS;
        private Button buttonOK_ARS;
    }
}