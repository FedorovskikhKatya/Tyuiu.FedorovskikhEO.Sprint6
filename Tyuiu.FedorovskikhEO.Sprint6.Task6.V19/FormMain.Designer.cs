namespace Tyuiu.FedorovskikhEO.Sprint6.Task6.V19
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelRight_FEO = new Panel();
            textBoxResult_FEO = new TextBox();
            labelOut_FEO = new Label();
            panelLeft_FEO = new Panel();
            textBoxLoadFromFile_FEO = new TextBox();
            labelInput_FEO = new Label();
            labelCondition_FEO = new Label();
            buttonOpenFile_FEO = new Button();
            panelTop_FEO = new Panel();
            buttonDone_FEO = new Button();
            buttonHelp_FEO = new Button();
            openFileDialogTask6_FEO = new OpenFileDialog();
            toolTip_FEO = new ToolTip(components);
            panelRight_FEO.SuspendLayout();
            panelLeft_FEO.SuspendLayout();
            panelTop_FEO.SuspendLayout();
            SuspendLayout();
            // 
            // panelRight_FEO
            // 
            panelRight_FEO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelRight_FEO.Controls.Add(textBoxResult_FEO);
            panelRight_FEO.Controls.Add(labelOut_FEO);
            panelRight_FEO.Location = new Point(505, 125);
            panelRight_FEO.Name = "panelRight_FEO";
            panelRight_FEO.Size = new Size(500, 461);
            panelRight_FEO.TabIndex = 1;
            panelRight_FEO.Paint += panelRight_FEO_Paint;
            // 
            // textBoxResult_FEO
            // 
            textBoxResult_FEO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxResult_FEO.Location = new Point(22, 26);
            textBoxResult_FEO.Multiline = true;
            textBoxResult_FEO.Name = "textBoxResult_FEO";
            textBoxResult_FEO.ScrollBars = ScrollBars.Vertical;
            textBoxResult_FEO.Size = new Size(466, 423);
            textBoxResult_FEO.TabIndex = 3;
            textBoxResult_FEO.TextChanged += textBoxResult_FEO_TextChanged;
            // 
            // labelOut_FEO
            // 
            labelOut_FEO.AutoSize = true;
            labelOut_FEO.Location = new Point(10, 3);
            labelOut_FEO.Name = "labelOut_FEO";
            labelOut_FEO.Size = new Size(54, 20);
            labelOut_FEO.TabIndex = 2;
            labelOut_FEO.Text = "Вывод";
            labelOut_FEO.Click += labelOut_FEO_Click;
            // 
            // panelLeft_FEO
            // 
            panelLeft_FEO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelLeft_FEO.Controls.Add(textBoxLoadFromFile_FEO);
            panelLeft_FEO.Controls.Add(labelInput_FEO);
            panelLeft_FEO.Location = new Point(0, 125);
            panelLeft_FEO.Name = "panelLeft_FEO";
            panelLeft_FEO.Size = new Size(509, 461);
            panelLeft_FEO.TabIndex = 2;
            // 
            // textBoxLoadFromFile_FEO
            // 
            textBoxLoadFromFile_FEO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxLoadFromFile_FEO.Location = new Point(12, 23);
            textBoxLoadFromFile_FEO.Multiline = true;
            textBoxLoadFromFile_FEO.Name = "textBoxLoadFromFile_FEO";
            textBoxLoadFromFile_FEO.ScrollBars = ScrollBars.Vertical;
            textBoxLoadFromFile_FEO.Size = new Size(487, 426);
            textBoxLoadFromFile_FEO.TabIndex = 2;
            textBoxLoadFromFile_FEO.TextChanged += textBoxLoadFromFile_FEO_TextChanged;
            // 
            // labelInput_FEO
            // 
            labelInput_FEO.AutoSize = true;
            labelInput_FEO.Location = new Point(12, 3);
            labelInput_FEO.Name = "labelInput_FEO";
            labelInput_FEO.Size = new Size(43, 20);
            labelInput_FEO.TabIndex = 1;
            labelInput_FEO.Text = "Ввод";
            labelInput_FEO.Click += label1_Click;
            // 
            // labelCondition_FEO
            // 
            labelCondition_FEO.AutoSize = true;
            labelCondition_FEO.Location = new Point(35, 24);
            labelCondition_FEO.Name = "labelCondition_FEO";
            labelCondition_FEO.Size = new Size(67, 20);
            labelCondition_FEO.TabIndex = 0;
            labelCondition_FEO.Text = "Условие";
            labelCondition_FEO.Click += labelCondition_FEO_Click;
            // 
            // buttonOpenFile_FEO
            // 
            buttonOpenFile_FEO.Image = (Image)resources.GetObject("buttonOpenFile_FEO.Image");
            buttonOpenFile_FEO.Location = new Point(35, 47);
            buttonOpenFile_FEO.Name = "buttonOpenFile_FEO";
            buttonOpenFile_FEO.Size = new Size(94, 62);
            buttonOpenFile_FEO.TabIndex = 1;
            buttonOpenFile_FEO.UseVisualStyleBackColor = true;
            buttonOpenFile_FEO.Click += buttonOpenFile_FEO_Click;
            // 
            // panelTop_FEO
            // 
            panelTop_FEO.Controls.Add(buttonDone_FEO);
            panelTop_FEO.Controls.Add(buttonHelp_FEO);
            panelTop_FEO.Controls.Add(buttonOpenFile_FEO);
            panelTop_FEO.Controls.Add(labelCondition_FEO);
            panelTop_FEO.Dock = DockStyle.Top;
            panelTop_FEO.Location = new Point(0, 0);
            panelTop_FEO.Name = "panelTop_FEO";
            panelTop_FEO.Size = new Size(1005, 125);
            panelTop_FEO.TabIndex = 0;
            panelTop_FEO.Paint += panelTop_FEO_Paint;
            // 
            // buttonDone_FEO
            // 
            buttonDone_FEO.Enabled = false;
            buttonDone_FEO.Location = new Point(165, 57);
            buttonDone_FEO.Name = "buttonDone_FEO";
            buttonDone_FEO.Size = new Size(94, 29);
            buttonDone_FEO.TabIndex = 3;
            buttonDone_FEO.Text = "выполнить";
            buttonDone_FEO.UseVisualStyleBackColor = true;
            buttonDone_FEO.Click += buttonDone_FEO_Click;
            // 
            // buttonHelp_FEO
            // 
            buttonHelp_FEO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_FEO.Location = new Point(870, 24);
            buttonHelp_FEO.Name = "buttonHelp_FEO";
            buttonHelp_FEO.Size = new Size(94, 29);
            buttonHelp_FEO.TabIndex = 2;
            buttonHelp_FEO.Text = "справка";
            buttonHelp_FEO.UseVisualStyleBackColor = true;
            buttonHelp_FEO.Click += buttonHelp_FEO_Click;
            // 
            // openFileDialogTask6_FEO
            // 
            openFileDialogTask6_FEO.FileName = "openFileDialog1";
            openFileDialogTask6_FEO.Filter = "Текстовые файлы (*.txt)|*.txt";
            openFileDialogTask6_FEO.Title = "Выберите текстовый файл";
            openFileDialogTask6_FEO.FileOk += openFileDialogTask6_FEO_FileOk;
            // 
            // toolTip_FEO
            // 
            toolTip_FEO.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 586);
            Controls.Add(panelLeft_FEO);
            Controls.Add(panelRight_FEO);
            Controls.Add(panelTop_FEO);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 19 | Федоровских Е.О";
            Load += FormMain_Load;
            panelRight_FEO.ResumeLayout(false);
            panelRight_FEO.PerformLayout();
            panelLeft_FEO.ResumeLayout(false);
            panelLeft_FEO.PerformLayout();
            panelTop_FEO.ResumeLayout(false);
            panelTop_FEO.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelRight_FEO;
        private Panel panelLeft_FEO;
        private Label labelInput_FEO;
        private Label labelOut_FEO;
        private TextBox textBoxLoadFromFile_FEO;
        private TextBox textBoxResult_FEO;
        private Label labelCondition_FEO;
        private Button buttonOpenFile_FEO;
        private Panel panelTop_FEO;
        private Button buttonHelp_FEO;
        private Button buttonDone_FEO;
        private OpenFileDialog openFileDialogTask6_FEO;
        private ToolTip toolTip_FEO;
    }
}
