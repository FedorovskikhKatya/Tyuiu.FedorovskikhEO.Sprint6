namespace Tyuiu.FedorovskikhEO.Sprint6.Task5.V22
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTop_FEO = new Panel();
            buttonHelp_FEO = new Button();
            buttonOpen_FEO = new Button();
            buttonDone_FEO = new Button();
            labelCondition_FEO = new Label();
            helpProvider1 = new HelpProvider();
            panelLeft_FEO = new Panel();
            chartDiag_FEO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelRight_FEO = new Panel();
            groupBoxOutPut_FEO = new GroupBox();
            dataGridViewNums_FEO = new DataGridView();
            panelTop_FEO.SuspendLayout();
            panelLeft_FEO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiag_FEO).BeginInit();
            panelRight_FEO.SuspendLayout();
            groupBoxOutPut_FEO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_FEO).BeginInit();
            SuspendLayout();
            // 
            // panelTop_FEO
            // 
            panelTop_FEO.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTop_FEO.Controls.Add(buttonHelp_FEO);
            panelTop_FEO.Controls.Add(buttonOpen_FEO);
            panelTop_FEO.Controls.Add(buttonDone_FEO);
            panelTop_FEO.Controls.Add(labelCondition_FEO);
            panelTop_FEO.Location = new Point(0, 0);
            panelTop_FEO.Name = "panelTop_FEO";
            panelTop_FEO.Size = new Size(900, 125);
            panelTop_FEO.TabIndex = 0;
            panelTop_FEO.Paint += panelTop_FEO_Paint;
            // 
            // buttonHelp_FEO
            // 
            buttonHelp_FEO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_FEO.BackColor = Color.Cyan;
            buttonHelp_FEO.Location = new Point(761, 17);
            buttonHelp_FEO.Name = "buttonHelp_FEO";
            buttonHelp_FEO.Size = new Size(115, 68);
            buttonHelp_FEO.TabIndex = 3;
            buttonHelp_FEO.Text = "Справка";
            buttonHelp_FEO.UseVisualStyleBackColor = false;
            buttonHelp_FEO.Click += button2_Click;
            // 
            // buttonOpen_FEO
            // 
            buttonOpen_FEO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpen_FEO.BackColor = Color.FromArgb(0, 0, 192);
            buttonOpen_FEO.Location = new Point(639, 17);
            buttonOpen_FEO.Name = "buttonOpen_FEO";
            buttonOpen_FEO.Size = new Size(116, 68);
            buttonOpen_FEO.TabIndex = 2;
            buttonOpen_FEO.Text = "Открыть файл";
            buttonOpen_FEO.UseVisualStyleBackColor = false;
            buttonOpen_FEO.Click += buttonOpen_FEO_Click;
            // 
            // buttonDone_FEO
            // 
            buttonDone_FEO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone_FEO.BackColor = Color.Green;
            buttonDone_FEO.Location = new Point(526, 12);
            buttonDone_FEO.Name = "buttonDone_FEO";
            buttonDone_FEO.Size = new Size(107, 73);
            buttonDone_FEO.TabIndex = 1;
            buttonDone_FEO.Text = "Выполнить";
            buttonDone_FEO.UseVisualStyleBackColor = false;
            buttonDone_FEO.Click += buttonDone_FEO_Click;
            // 
            // labelCondition_FEO
            // 
            labelCondition_FEO.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelCondition_FEO.Location = new Point(12, 9);
            labelCondition_FEO.Name = "labelCondition_FEO";
            labelCondition_FEO.Size = new Size(299, 87);
            labelCondition_FEO.TabIndex = 0;
            labelCondition_FEO.Text = "Условие: Прочитать данные из файла. Вывести все числа больше 5. Построить диаграмму по этим числам";
            labelCondition_FEO.Click += label1_Click;
            // 
            // panelLeft_FEO
            // 
            panelLeft_FEO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelLeft_FEO.Controls.Add(chartDiag_FEO);
            panelLeft_FEO.Location = new Point(325, 123);
            panelLeft_FEO.Name = "panelLeft_FEO";
            panelLeft_FEO.Size = new Size(572, 430);
            panelLeft_FEO.TabIndex = 1;
            panelLeft_FEO.Paint += panelLeft_FEO_Paint;
            // 
            // chartDiag_FEO
            // 
            chartDiag_FEO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartDiag_FEO.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDiag_FEO.Legends.Add(legend1);
            chartDiag_FEO.Location = new Point(74, 17);
            chartDiag_FEO.Name = "chartDiag_FEO";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiag_FEO.Series.Add(series1);
            chartDiag_FEO.Size = new Size(439, 375);
            chartDiag_FEO.TabIndex = 0;
            chartDiag_FEO.Text = "chart1";
            chartDiag_FEO.Click += chartDiag_FEO_Click;
            // 
            // panelRight_FEO
            // 
            panelRight_FEO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelRight_FEO.Controls.Add(groupBoxOutPut_FEO);
            panelRight_FEO.Location = new Point(0, 123);
            panelRight_FEO.Name = "panelRight_FEO";
            panelRight_FEO.Size = new Size(326, 410);
            panelRight_FEO.TabIndex = 2;
            panelRight_FEO.Paint += panelRight_FEO_Paint;
            // 
            // groupBoxOutPut_FEO
            // 
            groupBoxOutPut_FEO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxOutPut_FEO.Controls.Add(dataGridViewNums_FEO);
            groupBoxOutPut_FEO.Location = new Point(24, 17);
            groupBoxOutPut_FEO.Name = "groupBoxOutPut_FEO";
            groupBoxOutPut_FEO.Size = new Size(277, 378);
            groupBoxOutPut_FEO.TabIndex = 1;
            groupBoxOutPut_FEO.TabStop = false;
            groupBoxOutPut_FEO.Text = "Вывод данных";
            groupBoxOutPut_FEO.Enter += groupBox1_Enter;
            // 
            // dataGridViewNums_FEO
            // 
            dataGridViewNums_FEO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewNums_FEO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums_FEO.Location = new Point(6, 26);
            dataGridViewNums_FEO.Name = "dataGridViewNums_FEO";
            dataGridViewNums_FEO.RowHeadersWidth = 51;
            dataGridViewNums_FEO.Size = new Size(234, 333);
            dataGridViewNums_FEO.TabIndex = 0;
            dataGridViewNums_FEO.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 530);
            Controls.Add(panelRight_FEO);
            Controls.Add(panelLeft_FEO);
            Controls.Add(panelTop_FEO);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 22 | Федоровских Е.О";
            Load += FormMain_Load;
            panelTop_FEO.ResumeLayout(false);
            panelLeft_FEO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDiag_FEO).EndInit();
            panelRight_FEO.ResumeLayout(false);
            groupBoxOutPut_FEO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_FEO).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_FEO;
        private Label labelCondition_FEO;
        private HelpProvider helpProvider1;
        private Button buttonDone_FEO;
        private Button buttonHelp_FEO;
        private Button buttonOpen_FEO;
        private Panel panelLeft_FEO;
        private Panel panelRight_FEO;
        private GroupBox groupBoxOutPut_FEO;
        private DataGridView dataGridViewNums_FEO;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_FEO;
    }
}
