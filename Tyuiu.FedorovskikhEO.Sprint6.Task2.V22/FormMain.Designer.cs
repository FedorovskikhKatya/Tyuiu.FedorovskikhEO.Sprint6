namespace Tyuiu.FedorovskikhEO.Sprint6.Task2.V22
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            labelCondition_FEO = new Label();
            labelTask_FEO = new Label();
            labelOutput_FEO = new Label();
            labelResult_FEO = new Label();
            dataGridViewFunction_FEO = new DataGridView();
            ColumnX = new DataGridViewTextBoxColumn();
            ColumnF = new DataGridViewTextBoxColumn();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonHelp = new Button();
            buttonDone_FEO = new Button();
            labelStart_FEO = new Label();
            labelStop_FEO = new Label();
            labelInPut_FEO = new Label();
            textBoxStart_FEO = new TextBox();
            textBoxStop_FEO = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_FEO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // labelCondition_FEO
            // 
            labelCondition_FEO.AutoSize = true;
            labelCondition_FEO.Location = new Point(39, 22);
            labelCondition_FEO.Name = "labelCondition_FEO";
            labelCondition_FEO.Size = new Size(67, 20);
            labelCondition_FEO.TabIndex = 0;
            labelCondition_FEO.Text = "Условие";
            // 
            // labelTask_FEO
            // 
            labelTask_FEO.AutoSize = true;
            labelTask_FEO.Location = new Point(39, 42);
            labelTask_FEO.Name = "labelTask_FEO";
            labelTask_FEO.Size = new Size(453, 60);
            labelTask_FEO.TabIndex = 1;
            labelTask_FEO.Text = "\nПротабулировать функцию F(x) на заданном диапазоне.\nРезультат вывести в DataGridView и построить график функции.\n";
            // 
            // labelOutput_FEO
            // 
            labelOutput_FEO.AutoSize = true;
            labelOutput_FEO.Location = new Point(660, 32);
            labelOutput_FEO.Name = "labelOutput_FEO";
            labelOutput_FEO.Size = new Size(110, 20);
            labelOutput_FEO.TabIndex = 2;
            labelOutput_FEO.Text = "Вывод данных";
            // 
            // labelResult_FEO
            // 
            labelResult_FEO.AutoSize = true;
            labelResult_FEO.Location = new Point(660, 52);
            labelResult_FEO.Name = "labelResult_FEO";
            labelResult_FEO.Size = new Size(78, 20);
            labelResult_FEO.TabIndex = 3;
            labelResult_FEO.Text = "Результат:";
            // 
            // dataGridViewFunction_FEO
            // 
            dataGridViewFunction_FEO.AllowUserToAddRows = false;
            dataGridViewFunction_FEO.AllowUserToDeleteRows = false;
            dataGridViewFunction_FEO.AllowUserToResizeColumns = false;
            dataGridViewFunction_FEO.AllowUserToResizeRows = false;
            dataGridViewFunction_FEO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFunction_FEO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_FEO.Columns.AddRange(new DataGridViewColumn[] { ColumnX, ColumnF });
            dataGridViewFunction_FEO.Location = new Point(660, 87);
            dataGridViewFunction_FEO.Name = "dataGridViewFunction_FEO";
            dataGridViewFunction_FEO.ReadOnly = true;
            dataGridViewFunction_FEO.RowHeadersVisible = false;
            dataGridViewFunction_FEO.RowHeadersWidth = 51;
            dataGridViewFunction_FEO.Size = new Size(149, 325);
            dataGridViewFunction_FEO.TabIndex = 5;
            dataGridViewFunction_FEO.CellContentClick += dataGridViewFunction_FEO_CellContentClick;
            dataGridViewFunction_FEO.CellEndEdit += dataGridViewFunction_FEO_CellEndEdit;
            // 
            // ColumnX
            // 
            ColumnX.HeaderText = "X";
            ColumnX.MinimumWidth = 6;
            ColumnX.Name = "ColumnX";
            ColumnX.ReadOnly = true;
            // 
            // ColumnF
            // 
            ColumnF.HeaderText = "F(X)";
            ColumnF.MinimumWidth = 6;
            ColumnF.Name = "ColumnF";
            ColumnF.ReadOnly = true;
            // 
            // chartFunction
            // 
            chartArea3.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            chartFunction.Legends.Add(legend3);
            chartFunction.Location = new Point(825, 87);
            chartFunction.Name = "chartFunction";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartFunction.Series.Add(series3);
            chartFunction.Size = new Size(290, 240);
            chartFunction.TabIndex = 6;
            chartFunction.Text = "chart1";
            chartFunction.Click += chartFunction_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.Blue;
            buttonHelp.Location = new Point(341, 363);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(95, 57);
            buttonHelp.TabIndex = 7;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone_FEO
            // 
            buttonDone_FEO.BackColor = Color.Lime;
            buttonDone_FEO.Location = new Point(472, 363);
            buttonDone_FEO.Name = "buttonDone_FEO";
            buttonDone_FEO.Size = new Size(120, 57);
            buttonDone_FEO.TabIndex = 8;
            buttonDone_FEO.Text = "Выполнить";
            buttonDone_FEO.UseVisualStyleBackColor = false;
            buttonDone_FEO.Click += buttonDone_FEO_Click;
            buttonDone_FEO.MouseDown += buttonDone_FEO_MouseDown;
            buttonDone_FEO.MouseEnter += buttonDone_FEO_MouseEnter;
            buttonDone_FEO.MouseLeave += buttonDone_FEO_MouseLeave;
            // 
            // labelStart_FEO
            // 
            labelStart_FEO.AutoSize = true;
            labelStart_FEO.Location = new Point(50, 365);
            labelStart_FEO.Name = "labelStart_FEO";
            labelStart_FEO.Size = new Size(88, 20);
            labelStart_FEO.TabIndex = 9;
            labelStart_FEO.Text = "Старт шага:";
            labelStart_FEO.Click += labelStart_FEO_Click;
            // 
            // labelStop_FEO
            // 
            labelStop_FEO.AutoSize = true;
            labelStop_FEO.Location = new Point(193, 365);
            labelStop_FEO.Name = "labelStop_FEO";
            labelStop_FEO.Size = new Size(94, 20);
            labelStop_FEO.TabIndex = 10;
            labelStop_FEO.Text = "Конец шага:";
            // 
            // labelInPut_FEO
            // 
            labelInPut_FEO.AutoSize = true;
            labelInPut_FEO.Location = new Point(39, 332);
            labelInPut_FEO.Name = "labelInPut_FEO";
            labelInPut_FEO.Size = new Size(99, 20);
            labelInPut_FEO.TabIndex = 11;
            labelInPut_FEO.Text = "Ввод данных";
            // 
            // textBoxStart_FEO
            // 
            textBoxStart_FEO.Location = new Point(39, 403);
            textBoxStart_FEO.Name = "textBoxStart_FEO";
            textBoxStart_FEO.Size = new Size(99, 27);
            textBoxStart_FEO.TabIndex = 12;
            textBoxStart_FEO.Text = "-5";
            textBoxStart_FEO.TextChanged += textBox1_TextChanged;
            // 
            // textBoxStop_FEO
            // 
            textBoxStop_FEO.Location = new Point(188, 403);
            textBoxStop_FEO.Name = "textBoxStop_FEO";
            textBoxStop_FEO.Size = new Size(99, 27);
            textBoxStop_FEO.TabIndex = 13;
            textBoxStop_FEO.Text = "5";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 442);
            Controls.Add(textBoxStop_FEO);
            Controls.Add(textBoxStart_FEO);
            Controls.Add(labelInPut_FEO);
            Controls.Add(labelStop_FEO);
            Controls.Add(labelStart_FEO);
            Controls.Add(buttonDone_FEO);
            Controls.Add(buttonHelp);
            Controls.Add(chartFunction);
            Controls.Add(dataGridViewFunction_FEO);
            Controls.Add(labelResult_FEO);
            Controls.Add(labelOutput_FEO);
            Controls.Add(labelTask_FEO);
            Controls.Add(labelCondition_FEO);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 22 | Федоровских Е.О";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_FEO).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCondition_FEO;
        private Label labelTask_FEO;
        private Label labelOutput_FEO;
        private Label labelResult_FEO;
        private DataGridView dataGridViewFunction_FEO;
        private DataGridViewTextBoxColumn ColumnX;
        private DataGridViewTextBoxColumn ColumnF;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private Button buttonHelp;
        private Button buttonDone_FEO;
        private Label labelStart_FEO;
        private Label labelStop_FEO;
        private Label labelInPut_FEO;
        private TextBox textBoxStart_FEO;
        private TextBox textBoxStop_FEO;
    }
}
