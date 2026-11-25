using Tyuiu.FedorovskikhEO.Sprint6.Task6.V19.Lib;
using System.IO;
namespace Tyuiu.FedorovskikhEO.Sprint6.Task6.V19
{

    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();

        }
        string openFilePath;
        DataService ds = new DataService(); 

        private void buttonOpenFile_FEO_Click(object sender, EventArgs e)
        {
            if (openFileDialogTask6_FEO.ShowDialog() == DialogResult.OK)
            {
                openFilePath = openFileDialogTask6_FEO.FileName;

                textBoxLoadFromFile_FEO.Text = File.ReadAllText(openFilePath);
                buttonDone_FEO.Enabled = true;
            }
        }
        private void labelCondition_FEO_Click(object sender, EventArgs e)
        {

        }

        private void panelRight_FEO_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxResult_FEO_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelOut_FEO_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLoadFromFile_FEO_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e) 
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void panelTop_FEO_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonHelp_FEO_Click(object sender, EventArgs e)
        {
            FormAbout formAbout= new FormAbout();
            formAbout.ShowDialog();
        }

        private void openFileDialogTask6_FEO_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void buttonDone_FEO_Click(object sender, EventArgs e)
        {
            MessageBox.Show(openFilePath);
            textBoxResult_FEO.Text = ds.CollectTextFromFile(openFilePath);
        }
    }
}
