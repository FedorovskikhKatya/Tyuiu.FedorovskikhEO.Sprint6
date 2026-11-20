
using Tyuiu.FedorovskikhEO.Sprint6.Task2.V22.Lib;

namespace Tyuiu.FedorovskikhEO.Sprint6.Task2.V22
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_FEO_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_FEO.Text);
                int stopStep = Convert.ToInt32(textBoxStop_FEO.Text);


                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction.Titles.Clear();
                this.chartFunction.Titles.Add("График функции F(x)");

                this.chartFunction.ChartAreas[0].AxisX.Title = "";
                this.chartFunction.ChartAreas[0].AxisY.Title = "";

                this.dataGridViewFunction_FEO.Rows.Clear();
                this.chartFunction.Series[0].Points.Clear();

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_FEO.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_FEO_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_FEO.BackColor = Color.Red;
        }

        private void buttonDone_FEO_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_FEO.BackColor = Color.Green;
        }

        private void buttonDone_FEO_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_FEO.BackColor = Color.Blue;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнила студентка группы ИСТНб-26-1 Федоровских Екатерина Олеговна. Вариант 22.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonHelp_FEO_Click(object sender, EventArgs e)
        {
            buttonHelp_Click(sender, e);
        }

        private void dataGridViewFunction_FEO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridViewFunction_FEO_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void chartFunction_Click(object sender, EventArgs e)
        {
        }

        private void labelStart_FEO_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }
    }
}