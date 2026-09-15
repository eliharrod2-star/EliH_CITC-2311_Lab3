namespace SimpleCalc
{
    partial class SimpleCalc
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
            Operand1 = new Label();
            Operator = new Label();
            Operand2 = new Label();
            Result = new Label();
            txtOperand1 = new TextBox();
            txtOperator = new TextBox();
            txtOperand2 = new TextBox();
            txtResult = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // Operand1
            // 
            Operand1.AutoSize = true;
            Operand1.Location = new Point(327, 111);
            Operand1.Name = "Operand1";
            Operand1.Size = new Size(78, 20);
            Operand1.TabIndex = 0;
            Operand1.Text = "Operand1:";
            // 
            // Operator
            // 
            Operator.AutoSize = true;
            Operator.Location = new Point(327, 154);
            Operator.Name = "Operator";
            Operator.Size = new Size(72, 20);
            Operator.TabIndex = 1;
            Operator.Text = "Operator:";
            // 
            // Operand2
            // 
            Operand2.AutoSize = true;
            Operand2.Location = new Point(327, 200);
            Operand2.Name = "Operand2";
            Operand2.Size = new Size(78, 20);
            Operand2.TabIndex = 2;
            Operand2.Text = "Operand2:";
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Location = new Point(327, 236);
            Result.Name = "Result";
            Result.Size = new Size(52, 20);
            Result.TabIndex = 3;
            Result.Text = "Result:";
            // 
            // txtOperand1
            // 
            txtOperand1.Location = new Point(411, 104);
            txtOperand1.Name = "txtOperand1";
            txtOperand1.Size = new Size(125, 27);
            txtOperand1.TabIndex = 4;
            // 
            // txtOperator
            // 
            txtOperator.Location = new Point(411, 147);
            txtOperator.Name = "txtOperator";
            txtOperator.Size = new Size(125, 27);
            txtOperator.TabIndex = 5;
            // 
            // txtOperand2
            // 
            txtOperand2.Location = new Point(411, 193);
            txtOperand2.Name = "txtOperand2";
            txtOperand2.Size = new Size(125, 27);
            txtOperand2.TabIndex = 6;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(411, 236);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(125, 27);
            txtResult.TabIndex = 7;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(327, 284);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(455, 284);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 9;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click_1;
            // 
            // SimpleCalc
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(1381, 492);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtResult);
            Controls.Add(txtOperand2);
            Controls.Add(txtOperator);
            Controls.Add(txtOperand1);
            Controls.Add(Result);
            Controls.Add(Operand2);
            Controls.Add(Operator);
            Controls.Add(Operand1);
            Name = "SimpleCalc";
            Text = "Form1";
            Load += SimpleCalc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Operand1;
        private Label Operator;
        private Label Operand2;
        private Label Result;
        private TextBox txtOperand1;
        private TextBox txtOperator;
        private TextBox txtOperand2;
        private TextBox txtResult;
        private Button btnCalculate;
        private Button btnExit;
    }
}
