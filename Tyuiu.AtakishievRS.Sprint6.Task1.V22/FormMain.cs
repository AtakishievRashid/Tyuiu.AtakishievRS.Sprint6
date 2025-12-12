using System.Linq.Expressions;
using System.Windows.Forms.VisualStyles;
using Tyuiu.AtakishievRS.Sprint6.Task1.V22.Lib;

namespace Tyuiu.AtakishievRS.Sprint6.Task1.V22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_ARS_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_ARS.Text);
                int stopValue = Convert.ToInt32(textBoxEnd_ARS.Text);

                string strLine;
                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);

                textBoxResult_ARS.Text = "";
                textBoxResult_ARS.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_ARS.AppendText("|    X     |    F     |" + Environment.NewLine);
                textBoxResult_ARS.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5}    |  {1, 5:f2}   |", startValue, valueArray[i]);
                    textBoxResult_ARS.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_ARS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы РППб-25-1 Атакишиев Рашид Саркар оглы", "Ошибка", MessageBoxButtons.OK);
        }

        private void textBoxResult_ARS_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStart_ARS_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEnd_ARS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
