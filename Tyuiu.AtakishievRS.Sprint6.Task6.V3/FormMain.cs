using Tyuiu.AtakishievRS.Sprint6.Task6.V3.Lib;
namespace Tyuiu.AtakishievRS.Sprint6.Task6.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string openFilePath;
        private void buttonOpen_ARS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_ARS.ShowDialog();
            openFilePath = openFileDialogTask_ARS.FileName;
            textBoxIn_ARS.Text = File.ReadAllText(openFilePath);
            groupBoxOut_ARS.Text = groupBoxOut_ARS.Text + " " + openFileDialogTask_ARS.FileName;
            buttonOut_ARS.Enabled = true;
        }

        private void buttonOut_ARS_Click(object sender, EventArgs e)
        {
            textBoxOut_ARS.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonWorld_ARS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
