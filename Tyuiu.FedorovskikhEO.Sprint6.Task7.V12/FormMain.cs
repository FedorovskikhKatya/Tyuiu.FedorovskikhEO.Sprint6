using System.IO;
using System.Windows.Forms;
using Tyuiu.FedorovskikhEO.Sprint6.Task7.V12.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint6.Task7.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_FEO.Filter = "Значения, разделенные запятыми(* .csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_FEO.Filter = "Значения, разделенные запятыми(* .csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int colums;
        static string openFilePath;

        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            // Разделение на строки.
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Определяем количество строк и столбцов
            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            // Выделите массив данных.
            int[,] arrayValues = new int[rows, colums];

            // Заполняем массив данными.
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');

                for (int c = 0; c < colums; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            return arrayValues;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInput_FEO.ColumnCount = 50;
            dataGridViewOutput_FEO.ColumnCount = 50;
            dataGridViewInput_FEO.RowCount = 50;
            dataGridViewOutput_FEO.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInput_FEO.Columns[i].Width = 25;
                dataGridViewOutput_FEO.Columns[i].Width = 25;
            }
        }

        private void panelLeft_FEO_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelRight_FEO_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelCondition_FEO_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDone_FEO_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    dataGridViewOutput_FEO.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            buttonSaveFile_FEO.Enabled = true;
        }

        private void buttonHelp_FEO_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFIle_FEO_Click(object sender, EventArgs e)
        {
            openFileDialogTask_FEO.ShowDialog();
            openFilePath = openFileDialogTask_FEO.FileName;

            int[,] arrayValues = LoadFromFileData(openFilePath);
            dataGridViewInput_FEO.ColumnCount = colums;
            dataGridViewInput_FEO.RowCount = rows;
            dataGridViewOutput_FEO.ColumnCount = colums;
            dataGridViewOutput_FEO.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewInput_FEO.Columns[i].Width = 25;
                dataGridViewOutput_FEO.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    dataGridViewInput_FEO.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_FEO.Enabled = true;
        }


        private void buttonSaveFile_FEO_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_FEO.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_FEO.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_FEO.ShowDialog();

            string path = saveFileDialogMatrix_FEO.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutput_FEO.RowCount;
            int columns = dataGridViewOutput_FEO.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutput_FEO.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutput_FEO.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        

        private void dataGridViewOutput_FEO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
