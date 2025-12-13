using System.Windows.Forms;
using Tyuiu.AtakishievRS.Sprint6.Task7.V13.Lib;
namespace Tyuiu.AtakishievRS.Sprint6.Task7.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        static int rows;
        static int columns;
        static string openFilePath;

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxIn_ARS_Enter(object sender, EventArgs e)
        {

        }
        public static int[,] LoadFromData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] result = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return result;
        }
        private void buttonOpenFile_ARS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_ARS.ShowDialog();
            openFilePath = openFileDialogTask_ARS.FileName;
            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromData(openFilePath);
            dataGridViewIn_ARS.ColumnCount = columns;
            dataGridViewIn_ARS.RowCount = rows;
            dataGridViewOut_ARS.ColumnCount = columns;
            dataGridViewOut_ARS.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_ARS.Columns[i].Width = 25;
                dataGridViewOut_ARS.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewIn_ARS.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonFile_ARS.Enabled = true;
        }

        private void buttonFile_ARS_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOut_ARS.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            buttonSave_ARS.Enabled = true;
        }

        private void buttonSave_ARS_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_ARS.FileName = "OutPutFileTask7V13.csv";
            saveFileDialogTask_ARS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_ARS.ShowDialog();
            string path = saveFileDialogTask_ARS.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExzist = fileInfo.Exists;
            if (fileExzist)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOut_ARS.RowCount;
            int col = dataGridViewOut_ARS.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != col - 1)
                    {
                        str += dataGridViewOut_ARS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOut_ARS.Rows[i].Cells[j].Value;
                    }
                }
            }
            File.AppendAllText(path, str + Environment.NewLine);
            str = "";
        }

        private void buttonHelp_ARS_Click(object sender, EventArgs e)
        {
            toolTipButtons.ToolTipTitle = "Справка";

            FormAbout_ARS form = new FormAbout_ARS();
            form.ShowDialog();
        }

        private void buttonOpenFile_ARS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons.ToolTipTitle = "Открыть файл";
        }

        private void buttonFile_ARS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_ARS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons.ToolTipTitle = "Сохранить в файл";
        }
    }
}
