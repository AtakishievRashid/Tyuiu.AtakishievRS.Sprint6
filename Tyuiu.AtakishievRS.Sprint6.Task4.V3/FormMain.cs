using Tyuiu.AtakishievRS.Sprint6.Task4.V3.Lib;
namespace Tyuiu.AtakishievRS.Sprint6.Task4.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_ARS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxA_ARS.Text);
                int stopStep = Convert.ToInt32(textBoxB_ARS.Text);

                double[] valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunc_ARS.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunc_ARS.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_ARS.Text = "";
                chartFunc_ARS.Series[0].Points.Clear();

                for (int i = 0; i < valueArray.Length; i++)
                {
                    int x = startStep + i; 
                    this.chartFunc_ARS.Series[0].Points.AddXY(x, valueArray[i]);
                    textBoxResult_ARS.AppendText($"x = {x}: {valueArray[i]}{Environment.NewLine}");
                }


            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_ARS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы РППб-25-1 Атакишиев Рашид Саркар оглы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_ARS_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V3.txt";
                File.WriteAllText(path, textBoxResult_ARS.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранён успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}