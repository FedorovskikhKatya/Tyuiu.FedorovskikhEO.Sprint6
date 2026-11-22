namespace Tyuiu.FedorovskikhEO.Sprint6.Task4.V27
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTop_FEO = new Panel();
            buttonHelp_FEO = new Button();
            buttonSave_FEO = new Button();
            buttonDone_FEO = new Button();
            labelInPut_FEO = new Label();
            textBoxStopStep_FEO = new TextBox();
            labelStop_FEO = new Label();
            textBoxStartStep_FEO = new TextBox();
            labelStart_FEO = new Label();
            labelCondition_FEO = new Label();
            panelRight_FEO = new Panel();
            textBoxResult_FEO = new TextBox();
            labelOutPut_FEO = new Label();
            panelLeft_FEO = new Panel();
            chartFunction_FEO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelTop_FEO.SuspendLayout();
            panelRight_FEO.SuspendLayout();
            panelLeft_FEO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_FEO).BeginInit();
            SuspendLayout();
            // 
            // panelTop_FEO
            // 
            panelTop_FEO.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTop_FEO.Controls.Add(buttonHelp_FEO);
            panelTop_FEO.Controls.Add(buttonSave_FEO);
            panelTop_FEO.Controls.Add(buttonDone_FEO);
            panelTop_FEO.Controls.Add(labelInPut_FEO);
            panelTop_FEO.Controls.Add(textBoxStopStep_FEO);
            panelTop_FEO.Controls.Add(labelStop_FEO);
            panelTop_FEO.Controls.Add(textBoxStartStep_FEO);
            panelTop_FEO.Controls.Add(labelStart_FEO);
            panelTop_FEO.Controls.Add(labelCondition_FEO);
            panelTop_FEO.Location = new Point(0, 0);
            panelTop_FEO.Name = "panelTop_FEO";
            panelTop_FEO.Size = new Size(1014, 125);
            panelTop_FEO.TabIndex = 0;
            // 
            // buttonHelp_FEO
            // 
            buttonHelp_FEO.BackColor = Color.FromArgb(128, 128, 255);
            buttonHelp_FEO.Location = new Point(879, 41);
            buttonHelp_FEO.Name = "buttonHelp_FEO";
            buttonHelp_FEO.Size = new Size(94, 67);
            buttonHelp_FEO.TabIndex = 4;
            buttonHelp_FEO.Text = "Справка";
            buttonHelp_FEO.UseVisualStyleBackColor = false;
            buttonHelp_FEO.Click += buttonHelp_FEO_Click;
            // 
            // buttonSave_FEO
            // 
            buttonSave_FEO.BackColor = Color.FromArgb(0, 0, 192);
            buttonSave_FEO.Location = new Point(779, 41);
            buttonSave_FEO.Name = "buttonSave_FEO";
            buttonSave_FEO.Size = new Size(94, 67);
            buttonSave_FEO.TabIndex = 3;
            buttonSave_FEO.Text = "Сохранить";
            buttonSave_FEO.UseVisualStyleBackColor = false;
            buttonSave_FEO.Click += buttonSave_FEO_Click;
            // 
            // buttonDone_FEO
            // 
            buttonDone_FEO.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone_FEO.Location = new Point(671, 41);
            buttonDone_FEO.Name = "buttonDone_FEO";
            buttonDone_FEO.Size = new Size(102, 67);
            buttonDone_FEO.TabIndex = 0;
            buttonDone_FEO.Tag = "";
            buttonDone_FEO.Text = "Выполнить";
            buttonDone_FEO.UseVisualStyleBackColor = false;
            buttonDone_FEO.Click += buttonDone_FEO_Click;
            // 
            // labelInPut_FEO
            // 
            labelInPut_FEO.AutoSize = true;
            labelInPut_FEO.Location = new Point(448, 9);
            labelInPut_FEO.Name = "labelInPut_FEO";
            labelInPut_FEO.Size = new Size(99, 20);
            labelInPut_FEO.TabIndex = 1;
            labelInPut_FEO.Text = "Ввод данных";
            // 
            // textBoxStopStep_FEO
            // 
            textBoxStopStep_FEO.Location = new Point(558, 64);
            textBoxStopStep_FEO.Name = "textBoxStopStep_FEO";
            textBoxStopStep_FEO.Size = new Size(78, 27);
            textBoxStopStep_FEO.TabIndex = 2;
            textBoxStopStep_FEO.Text = "5";
            textBoxStopStep_FEO.TextChanged += textBoxStopStep_FEO_TextChanged;
            // 
            // labelStop_FEO
            // 
            labelStop_FEO.AutoSize = true;
            labelStop_FEO.Location = new Point(542, 41);
            labelStop_FEO.Name = "labelStop_FEO";
            labelStop_FEO.Size = new Size(94, 20);
            labelStop_FEO.TabIndex = 0;
            labelStop_FEO.Text = "Конец шага:";
            // 
            // textBoxStartStep_FEO
            // 
            textBoxStartStep_FEO.AcceptsReturn = true;
            textBoxStartStep_FEO.Location = new Point(448, 64);
            textBoxStartStep_FEO.Name = "textBoxStartStep_FEO";
            textBoxStartStep_FEO.Size = new Size(70, 27);
            textBoxStartStep_FEO.TabIndex = 0;
            textBoxStartStep_FEO.Text = "-5";
            textBoxStartStep_FEO.TextChanged += textBoxStartStep_FEO_TextChanged;
            // 
            // labelStart_FEO
            // 
            labelStart_FEO.AutoSize = true;
            labelStart_FEO.Location = new Point(448, 41);
            labelStart_FEO.Name = "labelStart_FEO";
            labelStart_FEO.Size = new Size(88, 20);
            labelStart_FEO.TabIndex = 1;
            labelStart_FEO.Text = "Старт шага:";
            labelStart_FEO.Click += labelStart_FEO_Click;
            // 
            // labelCondition_FEO
            // 
            labelCondition_FEO.AutoSize = true;
            labelCondition_FEO.Location = new Point(37, 27);
            labelCondition_FEO.Name = "labelCondition_FEO";
            labelCondition_FEO.Size = new Size(67, 20);
            labelCondition_FEO.TabIndex = 0;
            labelCondition_FEO.Text = "Условие";
            labelCondition_FEO.Click += label1_Click;
            // 
            // panelRight_FEO
            // 
            panelRight_FEO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelRight_FEO.Controls.Add(textBoxResult_FEO);
            panelRight_FEO.Controls.Add(labelOutPut_FEO);
            panelRight_FEO.Location = new Point(0, 125);
            panelRight_FEO.Name = "panelRight_FEO";
            panelRight_FEO.Size = new Size(453, 443);
            panelRight_FEO.TabIndex = 1;
            panelRight_FEO.Paint += panelRight_FEO_Paint;
            // 
            // textBoxResult_FEO
            // 
            textBoxResult_FEO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxResult_FEO.Location = new Point(27, 41);
            textBoxResult_FEO.Multiline = true;
            textBoxResult_FEO.Name = "textBoxResult_FEO";
            textBoxResult_FEO.ReadOnly = true;
            textBoxResult_FEO.ScrollBars = ScrollBars.Vertical;
            textBoxResult_FEO.Size = new Size(297, 359);
            textBoxResult_FEO.TabIndex = 1;
            textBoxResult_FEO.TextChanged += textBoxResult_FEO_TextChanged;
            // 
            // labelOutPut_FEO
            // 
            labelOutPut_FEO.AutoSize = true;
            labelOutPut_FEO.Location = new Point(37, 15);
            labelOutPut_FEO.Name = "labelOutPut_FEO";
            labelOutPut_FEO.Size = new Size(54, 20);
            labelOutPut_FEO.TabIndex = 0;
            labelOutPut_FEO.Text = "Вывод";
            // 
            // panelLeft_FEO
            // 
            panelLeft_FEO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelLeft_FEO.Controls.Add(chartFunction_FEO);
            panelLeft_FEO.Location = new Point(448, 125);
            panelLeft_FEO.Name = "panelLeft_FEO";
            panelLeft_FEO.Size = new Size(566, 443);
            panelLeft_FEO.TabIndex = 2;
            panelLeft_FEO.Paint += panelLeft_FEO_Paint;
            // 
            // chartFunction_FEO
            // 
            chartFunction_FEO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea2.Name = "ChartArea1";
            chartFunction_FEO.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartFunction_FEO.Legends.Add(legend2);
            chartFunction_FEO.Location = new Point(110, 25);
            chartFunction_FEO.Name = "chartFunction_FEO";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunction_FEO.Series.Add(series2);
            chartFunction_FEO.Size = new Size(375, 375);
            chartFunction_FEO.TabIndex = 4;
            chartFunction_FEO.Text = "chart2";
            chartFunction_FEO.Click += chartFunction_FEO_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 568);
            Controls.Add(panelLeft_FEO);
            Controls.Add(panelRight_FEO);
            Controls.Add(panelTop_FEO);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 27 | Федоровских Е.О";
            Load += FormMain_Load;
            panelTop_FEO.ResumeLayout(false);
            panelTop_FEO.PerformLayout();
            panelRight_FEO.ResumeLayout(false);
            panelRight_FEO.PerformLayout();
            panelLeft_FEO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_FEO).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_FEO;
        private Label labelCondition_FEO;
        private Panel panelRight_FEO;
        private Panel panelLeft_FEO;
        private Label labelInPut_FEO;
        private Label labelStart_FEO;
        private TextBox textBoxStartStep_FEO;
        private Label labelStop_FEO;
        private TextBox textBoxStopStep_FEO;
        private Button buttonDone_FEO;
        private Button buttonHelp_FEO;
        private Button buttonSave_FEO;
        private Label labelOutPut_FEO;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_FEO;
        private TextBox textBoxResult_FEO;
    }
}
