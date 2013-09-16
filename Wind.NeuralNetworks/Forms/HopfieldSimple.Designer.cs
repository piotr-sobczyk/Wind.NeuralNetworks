namespace neural_computing_machine.Forms
{
    partial class HopfieldSimple
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
            this.gbWeightMatrixPrev = new System.Windows.Forms.GroupBox();
            this.gbPatternInput = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnRecognize = new System.Windows.Forms.Button();
            this.nudInput4 = new System.Windows.Forms.NumericUpDown();
            this.nudInput3 = new System.Windows.Forms.NumericUpDown();
            this.nudInput2 = new System.Windows.Forms.NumericUpDown();
            this.nudInput1 = new System.Windows.Forms.NumericUpDown();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.tbResult4 = new System.Windows.Forms.TextBox();
            this.tbResult3 = new System.Windows.Forms.TextBox();
            this.tbResult2 = new System.Windows.Forms.TextBox();
            this.tbResult1 = new System.Windows.Forms.TextBox();
            this.dgvMatrixPreview = new System.Windows.Forms.DataGridView();
            this.dgvCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbWeightMatrixPrev.SuspendLayout();
            this.gbPatternInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInput4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInput3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInput1)).BeginInit();
            this.gbOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // gbWeightMatrixPrev
            // 
            this.gbWeightMatrixPrev.Controls.Add(this.dgvMatrixPreview);
            this.gbWeightMatrixPrev.Location = new System.Drawing.Point(13, 13);
            this.gbWeightMatrixPrev.Name = "gbWeightMatrixPrev";
            this.gbWeightMatrixPrev.Size = new System.Drawing.Size(282, 151);
            this.gbWeightMatrixPrev.TabIndex = 0;
            this.gbWeightMatrixPrev.TabStop = false;
            this.gbWeightMatrixPrev.Text = "Activation (weight) Matrix preview:";
            // 
            // gbPatternInput
            // 
            this.gbPatternInput.Controls.Add(this.btnClear);
            this.gbPatternInput.Controls.Add(this.btnTrain);
            this.gbPatternInput.Controls.Add(this.btnRecognize);
            this.gbPatternInput.Controls.Add(this.nudInput4);
            this.gbPatternInput.Controls.Add(this.nudInput3);
            this.gbPatternInput.Controls.Add(this.nudInput2);
            this.gbPatternInput.Controls.Add(this.nudInput1);
            this.gbPatternInput.Location = new System.Drawing.Point(13, 170);
            this.gbPatternInput.Name = "gbPatternInput";
            this.gbPatternInput.Size = new System.Drawing.Size(282, 80);
            this.gbPatternInput.TabIndex = 1;
            this.gbPatternInput.TabStop = false;
            this.gbPatternInput.Text = "Input pattern to train/recognize:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(180, 47);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(88, 47);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(86, 23);
            this.btnTrain.TabIndex = 5;
            this.btnTrain.Text = "Train Pattern";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnRecognize
            // 
            this.btnRecognize.Location = new System.Drawing.Point(7, 47);
            this.btnRecognize.Name = "btnRecognize";
            this.btnRecognize.Size = new System.Drawing.Size(75, 23);
            this.btnRecognize.TabIndex = 4;
            this.btnRecognize.Text = "Recognize";
            this.btnRecognize.UseVisualStyleBackColor = true;
            this.btnRecognize.Click += new System.EventHandler(this.btnRecognize_Click);
            // 
            // nudInput4
            // 
            this.nudInput4.Location = new System.Drawing.Point(219, 19);
            this.nudInput4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInput4.Name = "nudInput4";
            this.nudInput4.Size = new System.Drawing.Size(36, 20);
            this.nudInput4.TabIndex = 3;
            // 
            // nudInput3
            // 
            this.nudInput3.Location = new System.Drawing.Point(148, 19);
            this.nudInput3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInput3.Name = "nudInput3";
            this.nudInput3.Size = new System.Drawing.Size(36, 20);
            this.nudInput3.TabIndex = 2;
            // 
            // nudInput2
            // 
            this.nudInput2.Location = new System.Drawing.Point(75, 19);
            this.nudInput2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInput2.Name = "nudInput2";
            this.nudInput2.Size = new System.Drawing.Size(36, 20);
            this.nudInput2.TabIndex = 1;
            // 
            // nudInput1
            // 
            this.nudInput1.Location = new System.Drawing.Point(7, 20);
            this.nudInput1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInput1.Name = "nudInput1";
            this.nudInput1.Size = new System.Drawing.Size(36, 20);
            this.nudInput1.TabIndex = 0;
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.tbResult4);
            this.gbOutput.Controls.Add(this.tbResult3);
            this.gbOutput.Controls.Add(this.tbResult2);
            this.gbOutput.Controls.Add(this.tbResult1);
            this.gbOutput.Location = new System.Drawing.Point(13, 256);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(282, 58);
            this.gbOutput.TabIndex = 2;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Output:";
            // 
            // tbResult4
            // 
            this.tbResult4.Enabled = false;
            this.tbResult4.Location = new System.Drawing.Point(226, 19);
            this.tbResult4.MaxLength = 7;
            this.tbResult4.Name = "tbResult4";
            this.tbResult4.Size = new System.Drawing.Size(43, 20);
            this.tbResult4.TabIndex = 19;
            // 
            // tbResult3
            // 
            this.tbResult3.Enabled = false;
            this.tbResult3.Location = new System.Drawing.Point(155, 19);
            this.tbResult3.MaxLength = 7;
            this.tbResult3.Name = "tbResult3";
            this.tbResult3.Size = new System.Drawing.Size(43, 20);
            this.tbResult3.TabIndex = 18;
            // 
            // tbResult2
            // 
            this.tbResult2.Enabled = false;
            this.tbResult2.Location = new System.Drawing.Point(82, 19);
            this.tbResult2.MaxLength = 7;
            this.tbResult2.Name = "tbResult2";
            this.tbResult2.Size = new System.Drawing.Size(43, 20);
            this.tbResult2.TabIndex = 17;
            // 
            // tbResult1
            // 
            this.tbResult1.Enabled = false;
            this.tbResult1.Location = new System.Drawing.Point(7, 19);
            this.tbResult1.MaxLength = 7;
            this.tbResult1.Name = "tbResult1";
            this.tbResult1.Size = new System.Drawing.Size(43, 20);
            this.tbResult1.TabIndex = 16;
            // 
            // dgvMatrixPreview
            // 
            this.dgvMatrixPreview.AllowUserToDeleteRows = false;
            this.dgvMatrixPreview.AllowUserToResizeColumns = false;
            this.dgvMatrixPreview.AllowUserToResizeRows = false;
            this.dgvMatrixPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrixPreview.ColumnHeadersVisible = false;
            this.dgvMatrixPreview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCol1,
            this.dgvCol2,
            this.dgvCol3,
            this.dgvCol4});
            this.dgvMatrixPreview.Location = new System.Drawing.Point(7, 20);
            this.dgvMatrixPreview.MultiSelect = false;
            this.dgvMatrixPreview.Name = "dgvMatrixPreview";
            this.dgvMatrixPreview.RowHeadersVisible = false;
            this.dgvMatrixPreview.Size = new System.Drawing.Size(248, 115);
            this.dgvMatrixPreview.TabIndex = 0;
            // 
            // dgvCol1
            // 
            this.dgvCol1.HeaderText = "Column1";
            this.dgvCol1.Name = "dgvCol1";
            this.dgvCol1.Width = 60;
            // 
            // dgvCol2
            // 
            this.dgvCol2.HeaderText = "Column2";
            this.dgvCol2.Name = "dgvCol2";
            this.dgvCol2.Width = 60;
            // 
            // dgvCol3
            // 
            this.dgvCol3.HeaderText = "Column3";
            this.dgvCol3.Name = "dgvCol3";
            this.dgvCol3.Width = 60;
            // 
            // dgvCol4
            // 
            this.dgvCol4.HeaderText = "Column4";
            this.dgvCol4.Name = "dgvCol4";
            this.dgvCol4.Width = 60;
            // 
            // HopfieldSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 321);
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.gbPatternInput);
            this.Controls.Add(this.gbWeightMatrixPrev);
            this.Name = "HopfieldSimple";
            this.Text = "HopfieldSimple";
            this.gbWeightMatrixPrev.ResumeLayout(false);
            this.gbPatternInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudInput4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInput3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInput1)).EndInit();
            this.gbOutput.ResumeLayout(false);
            this.gbOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbWeightMatrixPrev;
        private System.Windows.Forms.GroupBox gbPatternInput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnRecognize;
        private System.Windows.Forms.NumericUpDown nudInput4;
        private System.Windows.Forms.NumericUpDown nudInput3;
        private System.Windows.Forms.NumericUpDown nudInput2;
        private System.Windows.Forms.NumericUpDown nudInput1;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.TextBox tbResult4;
        private System.Windows.Forms.TextBox tbResult3;
        private System.Windows.Forms.TextBox tbResult2;
        private System.Windows.Forms.TextBox tbResult1;
        private System.Windows.Forms.DataGridView dgvMatrixPreview;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol4;

    }
}