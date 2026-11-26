namespace Tyuiu.FedorovskikhEO.Sprint6.Task7.V12
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
            panelLeft_FEO = new Panel();
            dataGridViewInput_FEO = new DataGridView();
            labelInput_FEO = new Label();
            panelRight_FEO = new Panel();
            dataGridViewOutput_FEO = new DataGridView();
            labelOutput_FEO = new Label();
            panelTop_FEO = new Panel();
            buttonHelp_FEO = new Button();
            buttonOpenFIle_FEO = new Button();
            buttonSaveFile_FEO = new Button();
            buttonDone_FEO = new Button();
            textBoxCondition_FEO = new TextBox();
            labelCondition_FEO = new Label();
            openFileDialogTask_FEO = new OpenFileDialog();
            saveFileDialogMatrix_FEO = new SaveFileDialog();
            panelLeft_FEO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_FEO).BeginInit();
            panelRight_FEO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_FEO).BeginInit();
            panelTop_FEO.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft_FEO
            // 
            panelLeft_FEO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelLeft_FEO.Controls.Add(dataGridViewInput_FEO);
            panelLeft_FEO.Location = new Point(0, 237);
            panelLeft_FEO.Name = "panelLeft_FEO";
            panelLeft_FEO.Size = new Size(567, 670);
            panelLeft_FEO.TabIndex = 0;
            panelLeft_FEO.Paint += panelLeft_FEO_Paint;
            // 
            // dataGridViewInput_FEO
            // 
            dataGridViewInput_FEO.AllowUserToAddRows = false;
            dataGridViewInput_FEO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewInput_FEO.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewInput_FEO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_FEO.ColumnHeadersVisible = false;
            dataGridViewInput_FEO.Dock = DockStyle.Fill;
            dataGridViewInput_FEO.Location = new Point(0, 0);
            dataGridViewInput_FEO.Name = "dataGridViewInput_FEO";
            dataGridViewInput_FEO.ReadOnly = true;
            dataGridViewInput_FEO.RowHeadersVisible = false;
            dataGridViewInput_FEO.RowHeadersWidth = 51;
            dataGridViewInput_FEO.Size = new Size(567, 670);
            dataGridViewInput_FEO.TabIndex = 1;
            dataGridViewInput_FEO.CellContentClick += dataGridView1_CellContentClick;
            // 
            // labelInput_FEO
            // 
            labelInput_FEO.AutoSize = true;
            labelInput_FEO.Location = new Point(36, 221);
            labelInput_FEO.Name = "labelInput_FEO";
            labelInput_FEO.Size = new Size(43, 20);
            labelInput_FEO.TabIndex = 0;
            labelInput_FEO.Text = "Ввод";
            // 
            // panelRight_FEO
            // 
            panelRight_FEO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelRight_FEO.Controls.Add(dataGridViewOutput_FEO);
            panelRight_FEO.Location = new Point(567, 237);
            panelRight_FEO.Name = "panelRight_FEO";
            panelRight_FEO.Size = new Size(490, 646);
            panelRight_FEO.TabIndex = 1;
            panelRight_FEO.Paint += panelRight_FEO_Paint;
            // 
            // dataGridViewOutput_FEO
            // 
            dataGridViewOutput_FEO.AllowUserToAddRows = false;
            dataGridViewOutput_FEO.AllowUserToDeleteRows = false;
            dataGridViewOutput_FEO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewOutput_FEO.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewOutput_FEO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_FEO.Dock = DockStyle.Fill;
            dataGridViewOutput_FEO.Location = new Point(0, 0);
            dataGridViewOutput_FEO.Name = "dataGridViewOutput_FEO";
            dataGridViewOutput_FEO.ReadOnly = true;
            dataGridViewOutput_FEO.RowHeadersVisible = false;
            dataGridViewOutput_FEO.RowHeadersWidth = 51;
            dataGridViewOutput_FEO.Size = new Size(490, 646);
            dataGridViewOutput_FEO.TabIndex = 1;
            dataGridViewOutput_FEO.CellContentClick += dataGridViewOutput_FEO_CellContentClick;
            // 
            // labelOutput_FEO
            // 
            labelOutput_FEO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelOutput_FEO.AutoSize = true;
            labelOutput_FEO.Location = new Point(651, 221);
            labelOutput_FEO.Name = "labelOutput_FEO";
            labelOutput_FEO.Size = new Size(54, 20);
            labelOutput_FEO.TabIndex = 0;
            labelOutput_FEO.Text = "Вывод";
            // 
            // panelTop_FEO
            // 
            panelTop_FEO.Controls.Add(buttonHelp_FEO);
            panelTop_FEO.Controls.Add(labelOutput_FEO);
            panelTop_FEO.Controls.Add(labelInput_FEO);
            panelTop_FEO.Controls.Add(buttonOpenFIle_FEO);
            panelTop_FEO.Controls.Add(buttonSaveFile_FEO);
            panelTop_FEO.Controls.Add(buttonDone_FEO);
            panelTop_FEO.Controls.Add(textBoxCondition_FEO);
            panelTop_FEO.Controls.Add(labelCondition_FEO);
            panelTop_FEO.Dock = DockStyle.Top;
            panelTop_FEO.Location = new Point(0, 0);
            panelTop_FEO.Name = "panelTop_FEO";
            panelTop_FEO.Size = new Size(1059, 241);
            panelTop_FEO.TabIndex = 2;
            // 
            // buttonHelp_FEO
            // 
            buttonHelp_FEO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_FEO.Image = (Image)resources.GetObject("buttonHelp_FEO.Image");
            buttonHelp_FEO.Location = new Point(918, 13);
            buttonHelp_FEO.Name = "buttonHelp_FEO";
            buttonHelp_FEO.Size = new Size(96, 48);
            buttonHelp_FEO.TabIndex = 5;
            buttonHelp_FEO.UseVisualStyleBackColor = true;
            buttonHelp_FEO.Click += buttonHelp_FEO_Click;
            // 
            // buttonOpenFIle_FEO
            // 
            buttonOpenFIle_FEO.Image = (Image)resources.GetObject("buttonOpenFIle_FEO.Image");
            buttonOpenFIle_FEO.Location = new Point(12, 13);
            buttonOpenFIle_FEO.Name = "buttonOpenFIle_FEO";
            buttonOpenFIle_FEO.Size = new Size(106, 54);
            buttonOpenFIle_FEO.TabIndex = 4;
            buttonOpenFIle_FEO.UseVisualStyleBackColor = true;
            buttonOpenFIle_FEO.Click += buttonOpenFIle_FEO_Click;
            // 
            // buttonSaveFile_FEO
            // 
            buttonSaveFile_FEO.Image = (Image)resources.GetObject("buttonSaveFile_FEO.Image");
            buttonSaveFile_FEO.Location = new Point(287, 15);
            buttonSaveFile_FEO.Name = "buttonSaveFile_FEO";
            buttonSaveFile_FEO.Size = new Size(104, 53);
            buttonSaveFile_FEO.TabIndex = 3;
            buttonSaveFile_FEO.UseVisualStyleBackColor = true;
            buttonSaveFile_FEO.Click += buttonSaveFile_FEO_Click;
            // 
            // buttonDone_FEO
            // 
            buttonDone_FEO.Image = (Image)resources.GetObject("buttonDone_FEO.Image");
            buttonDone_FEO.Location = new Point(145, 15);
            buttonDone_FEO.Name = "buttonDone_FEO";
            buttonDone_FEO.Size = new Size(113, 52);
            buttonDone_FEO.TabIndex = 2;
            buttonDone_FEO.UseVisualStyleBackColor = true;
            buttonDone_FEO.Click += buttonDone_FEO_Click;
            // 
            // textBoxCondition_FEO
            // 
            textBoxCondition_FEO.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCondition_FEO.Location = new Point(6, 119);
            textBoxCondition_FEO.Multiline = true;
            textBoxCondition_FEO.Name = "textBoxCondition_FEO";
            textBoxCondition_FEO.ReadOnly = true;
            textBoxCondition_FEO.Size = new Size(1046, 122);
            textBoxCondition_FEO.TabIndex = 1;
            textBoxCondition_FEO.Text = resources.GetString("textBoxCondition_FEO.Text");
            textBoxCondition_FEO.TextChanged += textBox1_TextChanged;
            // 
            // labelCondition_FEO
            // 
            labelCondition_FEO.AutoSize = true;
            labelCondition_FEO.Location = new Point(12, 85);
            labelCondition_FEO.Name = "labelCondition_FEO";
            labelCondition_FEO.Size = new Size(67, 20);
            labelCondition_FEO.TabIndex = 0;
            labelCondition_FEO.Text = "Условие";
            labelCondition_FEO.Click += labelCondition_FEO_Click;
            // 
            // openFileDialogTask_FEO
            // 
            openFileDialogTask_FEO.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 719);
            Controls.Add(panelTop_FEO);
            Controls.Add(panelRight_FEO);
            Controls.Add(panelLeft_FEO);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Спринт 6 | Таск 7 | Вариант 12 | Федоровских Е.О";
            Load += FormMain_Load;
            panelLeft_FEO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_FEO).EndInit();
            panelRight_FEO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_FEO).EndInit();
            panelTop_FEO.ResumeLayout(false);
            panelTop_FEO.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft_FEO;
        private Panel panelRight_FEO;
        private Panel panelTop_FEO;
        private Label labelCondition_FEO;
        private TextBox textBoxCondition_FEO;
        private Label labelInput_FEO;
        private Label labelOutput_FEO;
        private DataGridView dataGridViewInput_FEO;
        private DataGridView dataGridViewOutput_FEO;
        private Button buttonDone_FEO;
        private Button buttonOpenFIle_FEO;
        private Button buttonSaveFile_FEO;
        private Button buttonHelp_FEO;
        private OpenFileDialog openFileDialogTask_FEO;
        private SaveFileDialog saveFileDialogMatrix_FEO;
    }
}
