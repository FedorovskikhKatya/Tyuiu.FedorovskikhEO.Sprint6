using System.IO;
using Tyuiu.FedorovskikhEO.Sprint6.Task5.V22.Lib;

namespace Tyuiu.FedorovskikhEO.Sprint6.Task5.V22
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutDataFileTask5V22.txt";
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelTop_FEO_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDone_FEO_Click(object sender, EventArgs e)
        {
            dataGridViewNums_FEO.ColumnCount = 2;
            dataGridViewNums_FEO.Columns[0].Width = 20;
            dataGridViewNums_FEO.Columns[1].Width = 50;

            this.chartDiag_FEO.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_FEO.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_FEO.Series[0].Points.Clear();

            double[] numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_FEO.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_FEO.Series[0].Points.AddXY(i, numsMass[i]);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнила студентка группы ИСТНб-26-1 Федоровских Е.О.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonOpen_FEO_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelOutPut_FEO_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panelLeft_FEO_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chartDiag_FEO_Click(object sender, EventArgs e)
        {

        }

        private void panelRight_FEO_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
