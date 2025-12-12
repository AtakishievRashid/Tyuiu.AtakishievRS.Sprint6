using Tyuiu.AtakishievRS.Sprint6.Task2.V28.Lib;
namespace Tyuiu.AtakishievRS.Sprint6.Task2.V28;

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
            int startStep = Convert.ToInt32(textBoxStart_ARS.Text);
            int stopStep = Convert.ToInt32(textBoxEnd_ARS.Text);

            int len = ds.GetMassFunction(startStep, stopStep).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startStep, stopStep);

            this.chartFunc.Titles.Add("График данной функции");

            this.chartFunc.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartFunc.ChartAreas[0].AxisY.Title = "Ось Y";

            for (int i = 0; i <= len - 1; i++)
            {
                this.dataGridViewTask.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                this.chartFunc.Series[0].Points.AddXY(startStep, valueArray[i]);
                startStep++;
            }
        }
        catch
        {
            MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonHelp_ARS_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Таск 2 выполнил студент группы РППб-25-1 Атакишиев Рашид Саркар оглы", "Ошибка", MessageBoxButtons.OK);
    }

    private void dataGridViewTask_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void buttonDone_ARS_MouseDown(object sender, MouseEventArgs e)
    {
        buttonDone_ARS.BackColor = Color.Blue;
    }

    private void buttonDone_ARS_MouseLeave(object sender, EventArgs e)
    {
        buttonDone_ARS.BackColor = Color.Green;
    }

    private void buttonDone_ARS_MouseEnter(object sender, EventArgs e)
    {
        buttonDone_ARS.BackColor = Color.Red;
    }

    private void chartFunc_Click(object sender, EventArgs e)
    {

    }
}
