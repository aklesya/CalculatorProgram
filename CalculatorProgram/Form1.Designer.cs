namespace CalculatorProgram
{
    partial class Form1
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
            txtTotal = new TextBox();
            btn1 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btn6 = new Button();
            btnSub = new Button();
            btnMul = new Button();
            btnDiv = new Button();
            btnClear = new Button();
            btnPlus = new Button();
            btnEql = new Button();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(12, 12);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(383, 65);
            txtTotal.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(23, 98);
            btn1.Name = "btn1";
            btn1.Size = new Size(67, 61);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
           // btn1.Click += button1_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(315, 98);
            btn5.Name = "btn5";
            btn5.Size = new Size(67, 61);
            btn5.TabIndex = 2;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(242, 98);
            btn4.Name = "btn4";
            btn4.Size = new Size(67, 61);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(169, 98);
            btn3.Name = "btn3";
            btn3.Size = new Size(67, 61);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(96, 98);
            btn2.Name = "btn2";
            btn2.Size = new Size(67, 61);
            btn2.TabIndex = 5;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(96, 174);
            btn7.Name = "btn7";
            btn7.Size = new Size(67, 61);
            btn7.TabIndex = 10;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(169, 174);
            btn8.Name = "btn8";
            btn8.Size = new Size(67, 61);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(242, 174);
            btn9.Name = "btn9";
            btn9.Size = new Size(67, 61);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(318, 174);
            btn0.Name = "btn0";
            btn0.Size = new Size(67, 61);
            btn0.TabIndex = 7;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(23, 174);
            btn6.Name = "btn6";
            btn6.Size = new Size(67, 61);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSub.Location = new Point(96, 245);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(67, 61);
            btnSub.TabIndex = 15;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnMul
            // 
            btnMul.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMul.Location = new Point(169, 245);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(58, 61);
            btnMul.TabIndex = 14;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiv.Location = new Point(233, 245);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(58, 61);
            btnDiv.TabIndex = 13;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(297, 245);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(85, 61);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(23, 245);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(67, 61);
            btnPlus.TabIndex = 11;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnEql
            // 
            btnEql.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEql.Location = new Point(23, 322);
            btnEql.Name = "btnEql";
            btnEql.Size = new Size(359, 53);
            btnEql.TabIndex = 16;
            btnEql.Text = "=";
            btnEql.UseVisualStyleBackColor = true;
            btnEql.Click += btnEql_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 399);
            Controls.Add(btnEql);
            Controls.Add(btnSub);
            Controls.Add(btnMul);
            Controls.Add(btnDiv);
            Controls.Add(btnClear);
            Controls.Add(btnPlus);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn0);
            Controls.Add(btn6);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn1);
            Controls.Add(txtTotal);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Button btn1;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btn6;
        private Button btnSub;
        private Button btnMul;
        private Button btnDiv;
        private Button btnClear;
        private Button btnPlus;
        private Button btnEql;
    }
}
