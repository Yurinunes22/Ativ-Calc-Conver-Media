namespace prjAtividades
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
            label1 = new Label();
            lblDigitarValor = new Label();
            rdbDolar = new RadioButton();
            rdbEuro = new RadioButton();
            btnConverter = new Button();
            txtValor = new TextBox();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(185, 67);
            label1.Name = "label1";
            label1.Size = new Size(0, 31);
            label1.TabIndex = 1;
            label1.Click += label1_Click;
            // 
            // lblDigitarValor
            // 
            lblDigitarValor.AutoSize = true;
            lblDigitarValor.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDigitarValor.Location = new Point(69, 65);
            lblDigitarValor.Name = "lblDigitarValor";
            lblDigitarValor.Size = new Size(196, 19);
            lblDigitarValor.TabIndex = 2;
            lblDigitarValor.Text = "Digite um valor para converter";
            lblDigitarValor.Click += lblDigitarValor_Click;
            // 
            // rdbDolar
            // 
            rdbDolar.AutoSize = true;
            rdbDolar.Location = new Point(211, 193);
            rdbDolar.Name = "rdbDolar";
            rdbDolar.Size = new Size(53, 19);
            rdbDolar.TabIndex = 3;
            rdbDolar.Text = "Dolar";
            rdbDolar.UseVisualStyleBackColor = true;
            rdbDolar.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdbEuro
            // 
            rdbEuro.AutoSize = true;
            rdbEuro.Checked = true;
            rdbEuro.Location = new Point(403, 193);
            rdbEuro.Name = "rdbEuro";
            rdbEuro.Size = new Size(49, 19);
            rdbEuro.TabIndex = 4;
            rdbEuro.TabStop = true;
            rdbEuro.Text = "Euro";
            rdbEuro.UseVisualStyleBackColor = true;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(342, 312);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(75, 23);
            btnConverter.TabIndex = 5;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(303, 61);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 6;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(303, 124);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(69, 19);
            lblResult.TabIndex = 8;
            lblResult.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(txtValor);
            Controls.Add(btnConverter);
            Controls.Add(rdbEuro);
            Controls.Add(rdbDolar);
            Controls.Add(lblDigitarValor);
            Controls.Add(label1);
            Name = "Form1";
            Text = "aaa";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lblDigitarValor;
        private RadioButton rdbDolar;
        private RadioButton rdbEuro;
        private Button btnConverter;
        private TextBox txtValor;
        private Label lblResult;
    }
}