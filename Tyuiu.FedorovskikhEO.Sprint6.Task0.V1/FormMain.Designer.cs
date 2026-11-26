namespace Tyuiu.FedorovskikhEO.Sprint6.Task0.V1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            labelCondition_FEO = new Label();
            labelTask_FEO = new Label();
            pictureBoxFormula_FEO = new PictureBox();
            groupBoxInput_FEO = new GroupBox();
            textBoxVarX_FEO = new TextBox();
            labelVarX_FEO = new Label();
            groupBoxOutput_FEO = new GroupBox();
            textBoxResult_FEO = new TextBox();
            labelResult_FEO = new Label();
            buttonExecute_FEO = new Button();
            buttonHelp_FEO = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_FEO).BeginInit();
            groupBoxInput_FEO.SuspendLayout();
            groupBoxOutput_FEO.SuspendLayout();
            SuspendLayout();
            // 
            // labelCondition_FEO
            // 
            labelCondition_FEO.AutoSize = true;
            labelCondition_FEO.Location = new Point(59, 22);
            labelCondition_FEO.Name = "labelCondition_FEO";
            labelCondition_FEO.Size = new Size(67, 20);
            labelCondition_FEO.TabIndex = 0;
            labelCondition_FEO.Text = "Условие";
            labelCondition_FEO.Click += labelCondition_FEO_Click;
            // 
            // labelTask_FEO
            // 
            labelTask_FEO.AutoSize = true;
            labelTask_FEO.Location = new Point(59, 59);
            labelTask_FEO.Name = "labelTask_FEO";
            labelTask_FEO.Size = new Size(257, 20);
            labelTask_FEO.TabIndex = 1;
            labelTask_FEO.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFormula_FEO
            // 
            pictureBoxFormula_FEO.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxFormula_FEO.Image = (Image)resources.GetObject("pictureBoxFormula_FEO.Image");
            pictureBoxFormula_FEO.Location = new Point(595, 38);
            pictureBoxFormula_FEO.Name = "pictureBoxFormula_FEO";
            pictureBoxFormula_FEO.Size = new Size(150, 85);
            pictureBoxFormula_FEO.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFormula_FEO.TabIndex = 2;
            pictureBoxFormula_FEO.TabStop = false;
            pictureBoxFormula_FEO.Click += pictureBox1_Click;
            // 
            // groupBoxInput_FEO
            // 
            groupBoxInput_FEO.Controls.Add(textBoxVarX_FEO);
            groupBoxInput_FEO.Controls.Add(labelVarX_FEO);
            groupBoxInput_FEO.Location = new Point(12, 238);
            groupBoxInput_FEO.Name = "groupBoxInput_FEO";
            groupBoxInput_FEO.Size = new Size(510, 125);
            groupBoxInput_FEO.TabIndex = 3;
            groupBoxInput_FEO.TabStop = false;
            groupBoxInput_FEO.Text = "Ввод данных";
            groupBoxInput_FEO.Enter += groupBoxInput_FEO_Enter;
            // 
            // textBoxVarX_FEO
            // 
            textBoxVarX_FEO.Location = new Point(30, 65);
            textBoxVarX_FEO.Name = "textBoxVarX_FEO";
            textBoxVarX_FEO.Size = new Size(100, 27);
            textBoxVarX_FEO.TabIndex = 1;
            textBoxVarX_FEO.TextChanged += textBoxVarX_FEO_TextChanged;
            textBoxVarX_FEO.KeyPress += textBoxVarX_FEO_KeyPress;
            // 
            // labelVarX_FEO
            // 
            labelVarX_FEO.AutoSize = true;
            labelVarX_FEO.Location = new Point(30, 42);
            labelVarX_FEO.Name = "labelVarX_FEO";
            labelVarX_FEO.Size = new Size(111, 20);
            labelVarX_FEO.TabIndex = 0;
            labelVarX_FEO.Text = "Переменная Х";
            labelVarX_FEO.Click += labelVarX_FEO_Click;
            // 
            // groupBoxOutput_FEO
            // 
            groupBoxOutput_FEO.Controls.Add(textBoxResult_FEO);
            groupBoxOutput_FEO.Controls.Add(labelResult_FEO);
            groupBoxOutput_FEO.Location = new Point(558, 238);
            groupBoxOutput_FEO.Name = "groupBoxOutput_FEO";
            groupBoxOutput_FEO.Size = new Size(230, 125);
            groupBoxOutput_FEO.TabIndex = 4;
            groupBoxOutput_FEO.TabStop = false;
            groupBoxOutput_FEO.Text = "Вывод данных";
            groupBoxOutput_FEO.Enter += groupBoxOutput_FEO_Enter;
            // 
            // textBoxResult_FEO
            // 
            textBoxResult_FEO.Location = new Point(37, 65);
            textBoxResult_FEO.Name = "textBoxResult_FEO";
            textBoxResult_FEO.ReadOnly = true;
            textBoxResult_FEO.Size = new Size(100, 27);
            textBoxResult_FEO.TabIndex = 1;
            // 
            // labelResult_FEO
            // 
            labelResult_FEO.AutoSize = true;
            labelResult_FEO.Location = new Point(37, 42);
            labelResult_FEO.Name = "labelResult_FEO";
            labelResult_FEO.Size = new Size(78, 20);
            labelResult_FEO.TabIndex = 0;
            labelResult_FEO.Text = "Результат:";
            // 
            // buttonExecute_FEO
            // 
            buttonExecute_FEO.Location = new Point(558, 398);
            buttonExecute_FEO.Name = "buttonExecute_FEO";
            buttonExecute_FEO.Size = new Size(100, 30);
            buttonExecute_FEO.TabIndex = 5;
            buttonExecute_FEO.Text = "Выполнить";
            buttonExecute_FEO.UseVisualStyleBackColor = true;
            buttonExecute_FEO.Click += buttonExecute_FEO_Click;
            // 
            // buttonHelp_FEO
            // 
            buttonHelp_FEO.Location = new Point(678, 398);
            buttonHelp_FEO.Name = "buttonHelp_FEO";
            buttonHelp_FEO.Size = new Size(100, 30);
            buttonHelp_FEO.TabIndex = 6;
            buttonHelp_FEO.Text = "Справка";
            buttonHelp_FEO.UseVisualStyleBackColor = true;
            buttonHelp_FEO.Click += buttonHelp_FEO_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_FEO);
            Controls.Add(buttonExecute_FEO);
            Controls.Add(groupBoxOutput_FEO);
            Controls.Add(groupBoxInput_FEO);
            Controls.Add(pictureBoxFormula_FEO);
            Controls.Add(labelTask_FEO);
            Controls.Add(labelCondition_FEO);
            Name = "FormMain";
            Text = "FormMain";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_FEO).EndInit();
            groupBoxInput_FEO.ResumeLayout(false);
            groupBoxInput_FEO.PerformLayout();
            groupBoxOutput_FEO.ResumeLayout(false);
            groupBoxOutput_FEO.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCondition_FEO;
        private Label labelTask_FEO;
        private PictureBox pictureBoxFormula_FEO;
        private GroupBox groupBoxInput_FEO;
        private GroupBox groupBoxOutput_FEO;
        private TextBox textBoxVarX_FEO;
        private Label labelVarX_FEO;
        private TextBox textBoxResult_FEO;
        private Label labelResult_FEO;
        private Button buttonExecute_FEO;
        private Button buttonHelp_FEO;
    }
}
