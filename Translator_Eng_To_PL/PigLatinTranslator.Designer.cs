namespace Translator_Eng_To_PL
{
    partial class PigLatinTranslator
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
            lblInput = new Label();
            txtInput = new TextBox();
            lblOutput = new Label();
            txtOutput = new TextBox();
            btnTranslate = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(12, 9);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(164, 20);
            lblInput.TabIndex = 0;
            lblInput.Text = "Enter English Text Here:";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 32);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.ScrollBars = ScrollBars.Vertical;
            txtInput.Size = new Size(397, 150);
            txtInput.TabIndex = 1;
            txtInput.TextChanged += txtInput_TextChanged;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(12, 197);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(145, 20);
            lblOutput.TabIndex = 2;
            lblOutput.Text = "Pig Latin Translation:";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(12, 220);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(397, 150);
            txtOutput.TabIndex = 3;
            txtOutput.TextChanged += txtOutput_TextChanged;
            // 
            // btnTranslate
            // 
            btnTranslate.Location = new Point(12, 392);
            btnTranslate.Name = "btnTranslate";
            btnTranslate.Size = new Size(94, 29);
            btnTranslate.TabIndex = 4;
            btnTranslate.Text = "&Translate";
            btnTranslate.UseVisualStyleBackColor = true;
            btnTranslate.Click += btnTranslate_Click_1;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(147, 392);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 5;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // PigLatinTranslator
            // 
            AcceptButton = btnTranslate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 498);
            Controls.Add(btnClear);
            Controls.Add(btnTranslate);
            Controls.Add(txtOutput);
            Controls.Add(lblOutput);
            Controls.Add(txtInput);
            Controls.Add(lblInput);
            Name = "PigLatinTranslator";
            Text = "Pig Latin Translator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInput;
        private TextBox txtInput;
        private Label lblOutput;
        private TextBox txtOutput;
        private Button btnTranslate;
        private Button btnClear;
    }
}
