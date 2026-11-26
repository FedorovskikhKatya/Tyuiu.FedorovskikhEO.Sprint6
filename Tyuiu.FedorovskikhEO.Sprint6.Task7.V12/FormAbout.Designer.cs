namespace Tyuiu.FedorovskikhEO.Sprint6.Task7.V12
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            labelTask_FEO = new Label();
            pictureBox_FEO = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_FEO).BeginInit();
            SuspendLayout();
            // 
            // labelTask_FEO
            // 
            labelTask_FEO.AutoSize = true;
            labelTask_FEO.Location = new Point(339, 42);
            labelTask_FEO.Name = "labelTask_FEO";
            labelTask_FEO.Size = new Size(388, 180);
            labelTask_FEO.TabIndex = 0;
            labelTask_FEO.Text = resources.GetString("labelTask_FEO.Text");
            labelTask_FEO.Click += labelTask_FEO_Click;
            // 
            // pictureBox_FEO
            // 
            pictureBox_FEO.Image = (Image)resources.GetObject("pictureBox_FEO.Image");
            pictureBox_FEO.Location = new Point(40, 42);
            pictureBox_FEO.Name = "pictureBox_FEO";
            pictureBox_FEO.Size = new Size(237, 191);
            pictureBox_FEO.TabIndex = 1;
            pictureBox_FEO.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 252);
            Controls.Add(pictureBox_FEO);
            Controls.Add(labelTask_FEO);
            Name = "FormAbout";
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBox_FEO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTask_FEO;
        private PictureBox pictureBox_FEO;
    }
}