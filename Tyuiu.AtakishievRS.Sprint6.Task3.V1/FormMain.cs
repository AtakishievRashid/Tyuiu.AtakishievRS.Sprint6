using System.Data.Common;
using System.Windows.Forms;
using Tyuiu.AtakishievRS.Sprint6.Task3.V1.Lib;
namespace Tyuiu.AtakishievRS.Sprint6.Task3.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { 25, 20, 28, 2, 6},
                                      { 19, 9, 18, -7, 24},
                                      { 21, 16, 5, -7, -8},
                                      { 30, -13, 1, -15, 2 },
                                      { 31, 9, -3, -9, -18 } };
        private void buttonHelp_ARS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы РППб-25-1 Атакишиев Рашид Саркар оглы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_ARS_Click(object sender, EventArgs e)
        {

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.GetUpperBound(1) + 1;

            dataGridViewResult.ColumnCount = columns;
            dataGridViewResult.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult.Columns[i].Width = 40;
            }
            int[,] res = ds.Calculate(mtrx);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }   

        private void FormMain_Load(object sender, EventArgs e)
        {

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.GetUpperBound(1) + 1;

            dataGridViewMTRX_ARS.ColumnCount = columns;
            dataGridViewMTRX_ARS.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMTRX_ARS.Columns[i].Width = 40;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMTRX_ARS.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void dataGridViewMTRX_ARS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}