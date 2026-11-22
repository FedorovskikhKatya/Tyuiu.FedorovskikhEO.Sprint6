namespace Tyuiu.FedorovskikhEO.Sprint6.Task3.V7
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelCondition_FEO = new Label();
            labelMatrix_FEO = new Label();
            labelMatrixData_FEO = new Label();
            dataGridViewMatrix_FEO = new DataGridView();
            labelOutPut_FEO = new Label();
            labelResult_FEO = new Label();
            textBoxResult_FEO = new TextBox();
            buttonDone_FEO = new Button();
            buttonHelp_FEO = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_FEO).BeginInit();
            SuspendLayout();
            // 
            // labelCondition_FEO
            // 
            labelCondition_FEO.AutoSize = true;
            labelCondition_FEO.Location = new Point(42, 24);
            labelCondition_FEO.Name = "labelCondition_FEO";
            labelCondition_FEO.Size = new Size(67, 20);
            labelCondition_FEO.TabIndex = 0;
            labelCondition_FEO.Text = "Условие";
            // 
            // labelMatrix_FEO
            // 
            labelMatrix_FEO.AutoSize = true;
            labelMatrix_FEO.Location = new Point(42, 55);
            labelMatrix_FEO.Name = "labelMatrix_FEO";
            labelMatrix_FEO.Size = new Size(153, 20);
            labelMatrix_FEO.TabIndex = 1;
            labelMatrix_FEO.Text = "Дана матрица 5 на 5";
            // 
            // labelMatrixData_FEO
            // 
            labelMatrixData_FEO.Location = new Point(42, 89);
            labelMatrixData_FEO.Name = "labelMatrixData_FEO";
            labelMatrixData_FEO.Size = new Size(300, 150);
            labelMatrixData_FEO.TabIndex = 2;
            labelMatrixData_FEO.Text = "31   25  -18   12    9\r\n 6   34   -2    2  -18\r\n-5    4   27    4   -1\r\n 4   15   34   -6  -10\r\n 0    8    5   14  -17\r\n\r\n подсчитать количество нулей\r\n";
            // 
            // dataGridViewMatrix_FEO
            // 
            dataGridViewMatrix_FEO.AllowUserToAddRows = false;
            dataGridViewMatrix_FEO.AllowUserToDeleteRows = false;
            dataGridViewMatrix_FEO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMatrix_FEO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_FEO.Location = new Point(338, 24);
            dataGridViewMatrix_FEO.Name = "dataGridViewMatrix_FEO";
            dataGridViewMatrix_FEO.ReadOnly = true;
            dataGridViewMatrix_FEO.RowHeadersVisible = false;
            dataGridViewMatrix_FEO.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewMatrix_FEO.Size = new Size(277, 215);
            dataGridViewMatrix_FEO.TabIndex = 3;
            // 
            // labelOutPut_FEO
            // 
            labelOutPut_FEO.AutoSize = true;
            labelOutPut_FEO.Location = new Point(725, 55);
            labelOutPut_FEO.Name = "labelOutPut_FEO";
            labelOutPut_FEO.Size = new Size(110, 20);
            labelOutPut_FEO.TabIndex = 4;
            labelOutPut_FEO.Text = "Вывод данных";
            labelOutPut_FEO.Click += label1_Click;
            // 
            // labelResult_FEO
            // 
            labelResult_FEO.AutoSize = true;
            labelResult_FEO.Location = new Point(725, 89);
            labelResult_FEO.Name = "labelResult_FEO";
            labelResult_FEO.Size = new Size(78, 20);
            labelResult_FEO.TabIndex = 5;
            labelResult_FEO.Text = "Результат:";
            // 
            // textBoxResult_FEO
            // 
            textBoxResult_FEO.Location = new Point(725, 112);
            textBoxResult_FEO.Name = "textBoxResult_FEO";
            textBoxResult_FEO.Size = new Size(110, 27);
            textBoxResult_FEO.TabIndex = 6;
            textBoxResult_FEO.TextChanged += textBoxResult_FEO_TextChanged;
            // 
            // buttonDone_FEO
            // 
            buttonDone_FEO.Location = new Point(803, 279);
            buttonDone_FEO.Name = "buttonDone_FEO";
            buttonDone_FEO.Size = new Size(120, 29);
            buttonDone_FEO.TabIndex = 7;
            buttonDone_FEO.Text = "Выполнить";
            buttonDone_FEO.UseVisualStyleBackColor = true;
            buttonDone_FEO.Click += buttonDone_FEO_Click;
            // 
            // buttonHelp_FEO
            // 
            buttonHelp_FEO.Location = new Point(753, 279);
            buttonHelp_FEO.Name = "buttonHelp_FEO";
            buttonHelp_FEO.Size = new Size(35, 29);
            buttonHelp_FEO.TabIndex = 8;
            buttonHelp_FEO.Text = "?";
            buttonHelp_FEO.UseVisualStyleBackColor = true;
            buttonHelp_FEO.Click += buttonHelp_FEO_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 334);
            Controls.Add(buttonHelp_FEO);
            Controls.Add(buttonDone_FEO);
            Controls.Add(textBoxResult_FEO);
            Controls.Add(labelResult_FEO);
            Controls.Add(labelOutPut_FEO);
            Controls.Add(dataGridViewMatrix_FEO);
            Controls.Add(labelMatrixData_FEO);
            Controls.Add(labelMatrix_FEO);
            Controls.Add(labelCondition_FEO);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 7 | Федоровских Е.О";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_FEO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCondition_FEO;
        private Label labelMatrix_FEO;
        private Label labelMatrixData_FEO;
        private DataGridView dataGridViewMatrix_FEO;
        private Label labelOutPut_FEO;
        private Label labelResult_FEO;
        private TextBox textBoxResult_FEO;
        private Button buttonDone_FEO;
        private Button buttonHelp_FEO;
    }
}
