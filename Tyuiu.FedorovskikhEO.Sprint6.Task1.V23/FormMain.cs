using Tyuiu.FedorovskikhEO.Sprint6.Task1.V23.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint6.Task1.V23
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCondition_FEO_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelStopStep_FEO_Click(object sender, EventArgs e)
        {

        }

        private void buttonHelp_FEO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студент группы ИСТНб-26-1 Федоровских Екатерина Олеговна", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void buttonCalculate_FEO_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_FEO.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_FEO.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxResult_FEO.Text = "";

                textBoxResult_FEO.Text = "";

                textBoxResult_FEO.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_FEO.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult_FEO.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format ("|{0,2:d}   | {1,6:f2} |", startStep, valueArray[i]);
                    textBoxResult_FEO.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_FEO.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBoxResult_FEO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
