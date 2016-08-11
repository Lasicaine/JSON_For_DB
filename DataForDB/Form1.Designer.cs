namespace DataForDB
{
    partial class DataForm
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
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.labelNumberRec = new System.Windows.Forms.Label();
            this.numericUpDownNumRec = new System.Windows.Forms.NumericUpDown();
            this.progressBarGeneration = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumRec)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultTextBox.Location = new System.Drawing.Point(12, 45);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultTextBox.Size = new System.Drawing.Size(640, 495);
            this.ResultTextBox.TabIndex = 0;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerate.Location = new System.Drawing.Point(577, 11);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 1;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // labelNumberRec
            // 
            this.labelNumberRec.AutoSize = true;
            this.labelNumberRec.Location = new System.Drawing.Point(9, 16);
            this.labelNumberRec.Name = "labelNumberRec";
            this.labelNumberRec.Size = new System.Drawing.Size(97, 13);
            this.labelNumberRec.TabIndex = 2;
            this.labelNumberRec.Text = "Number of records:";
            // 
            // numericUpDownNumRec
            // 
            this.numericUpDownNumRec.Location = new System.Drawing.Point(112, 14);
            this.numericUpDownNumRec.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownNumRec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumRec.Name = "numericUpDownNumRec";
            this.numericUpDownNumRec.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownNumRec.TabIndex = 3;
            this.numericUpDownNumRec.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumRec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDownNumRec_KeyPress);
            // 
            // progressBarGeneration
            // 
            this.progressBarGeneration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarGeneration.Location = new System.Drawing.Point(12, 553);
            this.progressBarGeneration.Name = "progressBarGeneration";
            this.progressBarGeneration.Size = new System.Drawing.Size(640, 19);
            this.progressBarGeneration.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarGeneration.TabIndex = 4;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 584);
            this.Controls.Add(this.progressBarGeneration);
            this.Controls.Add(this.numericUpDownNumRec);
            this.Controls.Add(this.labelNumberRec);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.ResultTextBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "DataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataForDB";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumRec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label labelNumberRec;
        private System.Windows.Forms.NumericUpDown numericUpDownNumRec;
        private System.Windows.Forms.ProgressBar progressBarGeneration;
    }
}

