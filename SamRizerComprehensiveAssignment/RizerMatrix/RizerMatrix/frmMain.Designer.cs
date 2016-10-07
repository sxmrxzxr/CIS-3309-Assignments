namespace RizerMatrix
{
    partial class frmMain
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
            this.txtMatrixA = new System.Windows.Forms.TextBox();
            this.txtMatrixB = new System.Windows.Forms.TextBox();
            this.txtMatrixC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMakeMatrixA = new System.Windows.Forms.Button();
            this.btnMakeMatrixB = new System.Windows.Forms.Button();
            this.txtMatrixARows = new System.Windows.Forms.TextBox();
            this.txtMatrixBRows = new System.Windows.Forms.TextBox();
            this.txtMatrixACols = new System.Windows.Forms.TextBox();
            this.txtMatrixBCols = new System.Windows.Forms.TextBox();
            this.btnMakeBIdentity = new System.Windows.Forms.Button();
            this.gbxSelectOperation = new System.Windows.Forms.GroupBox();
            this.rbnMultiply = new System.Windows.Forms.RadioButton();
            this.rbnAdd = new System.Windows.Forms.RadioButton();
            this.rbnSubtract = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxSelectOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMatrixA
            // 
            this.txtMatrixA.Location = new System.Drawing.Point(10, 35);
            this.txtMatrixA.Multiline = true;
            this.txtMatrixA.Name = "txtMatrixA";
            this.txtMatrixA.ReadOnly = true;
            this.txtMatrixA.Size = new System.Drawing.Size(159, 142);
            this.txtMatrixA.TabIndex = 0;
            // 
            // txtMatrixB
            // 
            this.txtMatrixB.Location = new System.Drawing.Point(175, 35);
            this.txtMatrixB.Multiline = true;
            this.txtMatrixB.Name = "txtMatrixB";
            this.txtMatrixB.ReadOnly = true;
            this.txtMatrixB.Size = new System.Drawing.Size(159, 142);
            this.txtMatrixB.TabIndex = 1;
            // 
            // txtMatrixC
            // 
            this.txtMatrixC.Location = new System.Drawing.Point(340, 35);
            this.txtMatrixC.Multiline = true;
            this.txtMatrixC.Name = "txtMatrixC";
            this.txtMatrixC.ReadOnly = true;
            this.txtMatrixC.Size = new System.Drawing.Size(159, 142);
            this.txtMatrixC.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Matrix A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matrix B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Matrix C";
            // 
            // btnMakeMatrixA
            // 
            this.btnMakeMatrixA.Location = new System.Drawing.Point(12, 205);
            this.btnMakeMatrixA.Name = "btnMakeMatrixA";
            this.btnMakeMatrixA.Size = new System.Drawing.Size(98, 23);
            this.btnMakeMatrixA.TabIndex = 6;
            this.btnMakeMatrixA.Text = "Make Matrix A";
            this.btnMakeMatrixA.UseVisualStyleBackColor = true;
            this.btnMakeMatrixA.Click += new System.EventHandler(this.btnMakeMatrixA_Click);
            // 
            // btnMakeMatrixB
            // 
            this.btnMakeMatrixB.Location = new System.Drawing.Point(12, 234);
            this.btnMakeMatrixB.Name = "btnMakeMatrixB";
            this.btnMakeMatrixB.Size = new System.Drawing.Size(98, 23);
            this.btnMakeMatrixB.TabIndex = 7;
            this.btnMakeMatrixB.Text = "Make Matrix B";
            this.btnMakeMatrixB.UseVisualStyleBackColor = true;
            this.btnMakeMatrixB.Click += new System.EventHandler(this.btnMakeMatrixB_Click);
            // 
            // txtMatrixARows
            // 
            this.txtMatrixARows.Location = new System.Drawing.Point(116, 207);
            this.txtMatrixARows.Name = "txtMatrixARows";
            this.txtMatrixARows.Size = new System.Drawing.Size(100, 20);
            this.txtMatrixARows.TabIndex = 8;
            // 
            // txtMatrixBRows
            // 
            this.txtMatrixBRows.Location = new System.Drawing.Point(116, 236);
            this.txtMatrixBRows.Name = "txtMatrixBRows";
            this.txtMatrixBRows.Size = new System.Drawing.Size(100, 20);
            this.txtMatrixBRows.TabIndex = 9;
            // 
            // txtMatrixACols
            // 
            this.txtMatrixACols.Location = new System.Drawing.Point(222, 207);
            this.txtMatrixACols.Name = "txtMatrixACols";
            this.txtMatrixACols.Size = new System.Drawing.Size(100, 20);
            this.txtMatrixACols.TabIndex = 10;
            // 
            // txtMatrixBCols
            // 
            this.txtMatrixBCols.Location = new System.Drawing.Point(222, 236);
            this.txtMatrixBCols.Name = "txtMatrixBCols";
            this.txtMatrixBCols.Size = new System.Drawing.Size(100, 20);
            this.txtMatrixBCols.TabIndex = 11;
            // 
            // btnMakeBIdentity
            // 
            this.btnMakeBIdentity.Location = new System.Drawing.Point(328, 234);
            this.btnMakeBIdentity.Name = "btnMakeBIdentity";
            this.btnMakeBIdentity.Size = new System.Drawing.Size(98, 23);
            this.btnMakeBIdentity.TabIndex = 12;
            this.btnMakeBIdentity.Text = "Make B Identity";
            this.btnMakeBIdentity.UseVisualStyleBackColor = true;
            // 
            // gbxSelectOperation
            // 
            this.gbxSelectOperation.Controls.Add(this.rbnSubtract);
            this.gbxSelectOperation.Controls.Add(this.rbnAdd);
            this.gbxSelectOperation.Controls.Add(this.rbnMultiply);
            this.gbxSelectOperation.Location = new System.Drawing.Point(10, 263);
            this.gbxSelectOperation.Name = "gbxSelectOperation";
            this.gbxSelectOperation.Size = new System.Drawing.Size(200, 49);
            this.gbxSelectOperation.TabIndex = 13;
            this.gbxSelectOperation.TabStop = false;
            this.gbxSelectOperation.Text = "Select Operation";
            // 
            // rbnMultiply
            // 
            this.rbnMultiply.AutoSize = true;
            this.rbnMultiply.Location = new System.Drawing.Point(7, 20);
            this.rbnMultiply.Name = "rbnMultiply";
            this.rbnMultiply.Size = new System.Drawing.Size(60, 17);
            this.rbnMultiply.TabIndex = 0;
            this.rbnMultiply.TabStop = true;
            this.rbnMultiply.Text = "Multiply";
            this.rbnMultiply.UseVisualStyleBackColor = true;
            // 
            // rbnAdd
            // 
            this.rbnAdd.AutoSize = true;
            this.rbnAdd.Location = new System.Drawing.Point(73, 20);
            this.rbnAdd.Name = "rbnAdd";
            this.rbnAdd.Size = new System.Drawing.Size(44, 17);
            this.rbnAdd.TabIndex = 1;
            this.rbnAdd.TabStop = true;
            this.rbnAdd.Text = "Add";
            this.rbnAdd.UseVisualStyleBackColor = true;
            // 
            // rbnSubtract
            // 
            this.rbnSubtract.AutoSize = true;
            this.rbnSubtract.Location = new System.Drawing.Point(124, 20);
            this.rbnSubtract.Name = "rbnSubtract";
            this.rbnSubtract.Size = new System.Drawing.Size(65, 17);
            this.rbnSubtract.TabIndex = 2;
            this.rbnSubtract.TabStop = true;
            this.rbnSubtract.Text = "Subtract";
            this.rbnSubtract.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(216, 277);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(297, 277);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear Matricies";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(395, 277);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 407);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.gbxSelectOperation);
            this.Controls.Add(this.btnMakeBIdentity);
            this.Controls.Add(this.txtMatrixBCols);
            this.Controls.Add(this.txtMatrixACols);
            this.Controls.Add(this.txtMatrixBRows);
            this.Controls.Add(this.txtMatrixARows);
            this.Controls.Add(this.btnMakeMatrixB);
            this.Controls.Add(this.btnMakeMatrixA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatrixC);
            this.Controls.Add(this.txtMatrixB);
            this.Controls.Add(this.txtMatrixA);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.gbxSelectOperation.ResumeLayout(false);
            this.gbxSelectOperation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatrixA;
        private System.Windows.Forms.TextBox txtMatrixB;
        private System.Windows.Forms.TextBox txtMatrixC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMakeMatrixA;
        private System.Windows.Forms.Button btnMakeMatrixB;
        private System.Windows.Forms.TextBox txtMatrixARows;
        private System.Windows.Forms.TextBox txtMatrixBRows;
        private System.Windows.Forms.TextBox txtMatrixACols;
        private System.Windows.Forms.TextBox txtMatrixBCols;
        private System.Windows.Forms.Button btnMakeBIdentity;
        private System.Windows.Forms.GroupBox gbxSelectOperation;
        private System.Windows.Forms.RadioButton rbnSubtract;
        private System.Windows.Forms.RadioButton rbnAdd;
        private System.Windows.Forms.RadioButton rbnMultiply;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

