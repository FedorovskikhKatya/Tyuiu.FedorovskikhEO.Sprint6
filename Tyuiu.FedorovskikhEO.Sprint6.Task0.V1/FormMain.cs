using Tyuiu.FedorovskikhEO.Sprint6.Task0.V1.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint6.Task0.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
             
        }

        private void labelCondition_FEO_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelVarX_FEO_Click(object sender, EventArgs e)
        {

        }

        private void textBoxVarX_FEO_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonExecute_FEO_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                textBoxResult_FEO.Text = Convert.ToString(
                    ds.Calculate(Convert.ToInt32(textBoxVarX_FEO.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_FEO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_FEO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнила: Федоровских Екатерина Олеговна\n" + "Группа: ИСТНб-26-1\n" + "Вариант: 1\n" + "Вычислить выражение y(x) = x / (x^3 + 2)", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBoxInput_FEO_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxOutput_FEO_Enter(object sender, EventArgs e)
        {

        }
    }
}
