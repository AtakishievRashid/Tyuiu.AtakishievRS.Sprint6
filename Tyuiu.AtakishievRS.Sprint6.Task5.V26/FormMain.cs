using Tyuiu.AtakishievRS.Sprint6.Task5.V26.Lib;
namespace Tyuiu.AtakishievRS.Sprint6.Task5.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\Users\bogra\Desktop\ПРОГАВУЗТИУ\Файлы\InPutDataFileTask5V26.txt";
        private void groupBoxOutput_ARS_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDone_ARS_Click(object sender, EventArgs e)
        {
            dataGridView_ARS.ColumnCount = 2;
            dataGridView_ARS.Columns[0].Width = 20;
            dataGridView_ARS.Columns[1].Width = 50;

            this.chartFunc_ARS.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunc_ARS.ChartAreas[0].AxisY.Title = "Ось Y";

            chartFunc_ARS.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridView_ARS.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunc_ARS.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_ARS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_ARS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы РППб-25-1 Атакишиев Рашид Саркар оглы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
