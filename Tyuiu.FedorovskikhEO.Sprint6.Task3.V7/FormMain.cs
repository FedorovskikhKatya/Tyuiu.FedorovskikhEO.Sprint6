
namespace Tyuiu.FedorovskikhEO.Sprint6.Task3.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewMatrix_FEO.ColumnCount = 5;
            dataGridViewMatrix_FEO.RowCount = 5;

            dataGridViewMatrix_FEO.Rows[0].SetValues(31, 25, -18, 12, 9);
            dataGridViewMatrix_FEO.Rows[1].SetValues(6, 34, -2, 2, -18);
            dataGridViewMatrix_FEO.Rows[2].SetValues(-5, 4, 27, 4, -1);
            dataGridViewMatrix_FEO.Rows[3].SetValues(4, 15, 34, -6, -10);
            dataGridViewMatrix_FEO.Rows[4].SetValues(0, 8, 5, 14, -17);
        }

        private void dataGridViewMatrix_FEO_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBoxResult_FEO_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonDone_FEO_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = Convert.ToInt32(dataGridViewMatrix_FEO.Rows[i].Cells[j].Value);
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4 - i; j++)
                {
                    if (matrix[j, 3] > matrix[j + 1, 3])
                    {
                        int savedValue = matrix[j, 3];
                        matrix[j, 3] = matrix[j + 1, 3];
                        matrix[j + 1, 3] = savedValue;
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridViewMatrix_FEO.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }
        private void buttonHelp_FEO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнила: Федоровских Е.О. Вариант 7");
        }
    }
}
