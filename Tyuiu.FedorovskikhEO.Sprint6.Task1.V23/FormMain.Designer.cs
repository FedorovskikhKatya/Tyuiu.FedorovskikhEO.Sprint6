namespace Tyuiu.FedorovskikhEO.Sprint6.Task1.V23
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
            textBoxCondition_FEO = new TextBox();
            labelOutPut_FEO = new Label();
            labelResult_FEO = new Label();
            textBoxResult_FEO = new TextBox();
            labelInput_FEO = new Label();
            labelStartStep_FEO = new Label();
            labelStopStep_FEO = new Label();
            textBoxStartStep_FEO = new TextBox();
            textBoxStopStep_FEO = new TextBox();
            buttonHelp_FEO = new Button();
            buttonCalculate_FEO = new Button();
            labelCondition__FEO = new Label();
            SuspendLayout();
            // 
            // labelCondition_FEO
            // 
            labelCondition_FEO.AutoSize = true;
            labelCondition_FEO.Location = new Point(48, 24);
            labelCondition_FEO.Name = "labelCondition_FEO";
            labelCondition_FEO.Size = new Size(13, 20);
            labelCondition_FEO.TabIndex = 0;
            labelCondition_FEO.Text = " ";
            // 
            // textBoxCondition_FEO
            // 
            textBoxCondition_FEO.Location = new Point(21, 61);
            textBoxCondition_FEO.Multiline = true;
            textBoxCondition_FEO.Name = "textBoxCondition_FEO";
            textBoxCondition_FEO.ReadOnly = true;
            textBoxCondition_FEO.Size = new Size(527, 236);
            textBoxCondition_FEO.TabIndex = 1;
            textBoxCondition_FEO.Text = "Вычислить значение функции F(x) = sin(x) + 2x/3 - cos(x) * 4x на отрезке [-5; 5] с шагом 1. Результаты округлить до двух знаков после запятой.";
            textBoxCondition_FEO.TextChanged += textBoxCondition_FEO_TextChanged;
            // 
            // labelOutPut_FEO
            // 
            labelOutPut_FEO.AutoSize = true;
            labelOutPut_FEO.Location = new Point(545, 9);
            labelOutPut_FEO.Name = "labelOutPut_FEO";
            labelOutPut_FEO.Size = new Size(114, 20);
            labelOutPut_FEO.TabIndex = 2;
            labelOutPut_FEO.Text = " Вывод данных";
            // 
            // labelResult_FEO
            // 
            labelResult_FEO.AutoSize = true;
            labelResult_FEO.Location = new Point(554, 38);
            labelResult_FEO.Name = "labelResult_FEO";
            labelResult_FEO.Size = new Size(82, 20);
            labelResult_FEO.TabIndex = 3;
            labelResult_FEO.Text = "Результат :";
            labelResult_FEO.Click += label1_Click;
            // 
            // textBoxResult_FEO
            // 
            textBoxResult_FEO.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_FEO.Location = new Point(568, 61);
            textBoxResult_FEO.Multiline = true;
            textBoxResult_FEO.Name = "textBoxResult_FEO";
            textBoxResult_FEO.ScrollBars = ScrollBars.Vertical;
            textBoxResult_FEO.Size = new Size(188, 226);
            textBoxResult_FEO.TabIndex = 4;
            textBoxResult_FEO.TextChanged += textBoxResult_FEO_TextChanged;
            // 
            // labelInput_FEO
            // 
            labelInput_FEO.AutoSize = true;
            labelInput_FEO.Location = new Point(27, 313);
            labelInput_FEO.Name = "labelInput_FEO";
            labelInput_FEO.Size = new Size(99, 20);
            labelInput_FEO.TabIndex = 5;
            labelInput_FEO.Text = "Ввод данных";
            // 
            // labelStartStep_FEO
            // 
            labelStartStep_FEO.AutoSize = true;
            labelStartStep_FEO.Location = new Point(27, 333);
            labelStartStep_FEO.Name = "labelStartStep_FEO";
            labelStartStep_FEO.Size = new Size(88, 20);
            labelStartStep_FEO.TabIndex = 6;
            labelStartStep_FEO.Text = "Старт шага:";
            // 
            // labelStopStep_FEO
            // 
            labelStopStep_FEO.AutoSize = true;
            labelStopStep_FEO.Location = new Point(182, 333);
            labelStopStep_FEO.Name = "labelStopStep_FEO";
            labelStopStep_FEO.Size = new Size(94, 20);
            labelStopStep_FEO.TabIndex = 7;
            labelStopStep_FEO.Text = "Конец шага:";
            labelStopStep_FEO.Click += labelStopStep_FEO_Click;
            // 
            // textBoxStartStep_FEO
            // 
            textBoxStartStep_FEO.Location = new Point(27, 356);
            textBoxStartStep_FEO.Name = "textBoxStartStep_FEO";
            textBoxStartStep_FEO.Size = new Size(125, 27);
            textBoxStartStep_FEO.TabIndex = 8;
            textBoxStartStep_FEO.Text = "-5";
            // 
            // textBoxStopStep_FEO
            // 
            textBoxStopStep_FEO.Location = new Point(182, 356);
            textBoxStopStep_FEO.Name = "textBoxStopStep_FEO";
            textBoxStopStep_FEO.Size = new Size(125, 27);
            textBoxStopStep_FEO.TabIndex = 9;
            textBoxStopStep_FEO.Text = "5";
            // 
            // buttonHelp_FEO
            // 
            buttonHelp_FEO.BackColor = SystemColors.HotTrack;
            buttonHelp_FEO.Location = new Point(325, 313);
            buttonHelp_FEO.Name = "buttonHelp_FEO";
            buttonHelp_FEO.Size = new Size(115, 80);
            buttonHelp_FEO.TabIndex = 10;
            buttonHelp_FEO.Text = "Справка";
            buttonHelp_FEO.UseVisualStyleBackColor = false;
            buttonHelp_FEO.Click += buttonHelp_FEO_Click;
            // 
            // buttonCalculate_FEO
            // 
            buttonCalculate_FEO.BackColor = Color.ForestGreen;
            buttonCalculate_FEO.Location = new Point(466, 313);
            buttonCalculate_FEO.Name = "buttonCalculate_FEO";
            buttonCalculate_FEO.Size = new Size(170, 80);
            buttonCalculate_FEO.TabIndex = 11;
            buttonCalculate_FEO.Text = "Выполнить";
            buttonCalculate_FEO.UseVisualStyleBackColor = false;
            buttonCalculate_FEO.Click += buttonCalculate_FEO_Click;
            // 
            // labelCondition__FEO
            // 
            labelCondition__FEO.AutoSize = true;
            labelCondition__FEO.Location = new Point(27, 24);
            labelCondition__FEO.Name = "labelCondition__FEO";
            labelCondition__FEO.Size = new Size(67, 20);
            labelCondition__FEO.TabIndex = 14;
            labelCondition__FEO.Text = "Условие";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 403);
            Controls.Add(labelCondition__FEO);
            Controls.Add(buttonCalculate_FEO);
            Controls.Add(buttonHelp_FEO);
            Controls.Add(textBoxStopStep_FEO);
            Controls.Add(textBoxStartStep_FEO);
            Controls.Add(labelStopStep_FEO);
            Controls.Add(labelStartStep_FEO);
            Controls.Add(labelInput_FEO);
            Controls.Add(textBoxResult_FEO);
            Controls.Add(labelResult_FEO);
            Controls.Add(labelOutPut_FEO);
            Controls.Add(textBoxCondition_FEO);
            Controls.Add(labelCondition_FEO);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 23 | Федоровских Е.О";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCondition_FEO;
        private TextBox textBoxCondition_FEO;
        private Label labelOutPut_FEO;
        private Label labelResult_FEO;
        private TextBox textBoxResult_FEO;
        private Label labelInput_FEO;
        private Label labelStartStep_FEO;
        private Label labelStopStep_FEO;
        private TextBox textBoxStartStep_FEO;
        private TextBox textBoxStopStep_FEO;
        private Button buttonHelp_FEO;
        private Button buttonCalculate_FEO;
        private Label labelCondition__FEO;
    }
}
