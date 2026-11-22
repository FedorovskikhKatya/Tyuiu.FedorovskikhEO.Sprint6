using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.FedorovskikhEO.Sprint6.Task4.V27.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint6.Task4.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelStart_FEO_Click(object sender, EventArgs e)
        {

        }

        private void textBoxStartStep_FEO_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_FEO_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_FEO.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_FEO.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                chartFunction_FEO.Series[0].Points.Clear();

                chartFunction_FEO.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction_FEO.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_FEO.Text = "";

                for (int i = 0; i < len; i++)
                {
                    chartFunction_FEO.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_FEO.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonSave_FEO_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "OutPutFileTask4V27.txt");

                File.WriteAllText(path, textBoxResult_FEO.Text);

                DialogResult dialogResult = MessageBox.Show(
                    "Файл " + path + " сохранен успешно!\nОткрыть его в блокноте?",
                    "Сообщение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void buttonHelp_FEO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнила: Федоровских Е.О.\nГруппа: ИСТНб-26-1\nСпринт 6, Задание 4, Вариант 27","Справка");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelRight_FEO_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLeft_FEO_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chartFunction_FEO_Click(object sender, EventArgs e)
        {

        }

        private void textBoxResult_FEO_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStopStep_FEO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
