namespace calculadoraprj
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
            txtValor1 = new TextBox();
            lblOper1 = new Label();
            txtValor2 = new TextBox();
            lblOper2 = new Label();
            rdbSoma = new RadioButton();
            rdbSub = new RadioButton();
            rdbMult = new RadioButton();
            rdbDivi = new RadioButton();
            btnCalcular = new Button();
            txtResultado = new TextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtValor1
            // 
            txtValor1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtValor1.Location = new Point(393, 51);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(166, 34);
            txtValor1.TabIndex = 0;
            txtValor1.TextChanged += txtValor1_TextChanged;
            // 
            // lblOper1
            // 
            lblOper1.AutoSize = true;
            lblOper1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblOper1.Location = new Point(134, 51);
            lblOper1.Name = "lblOper1";
            lblOper1.Size = new Size(176, 28);
            lblOper1.TabIndex = 1;
            lblOper1.Text = "Primeiro Operador";
            lblOper1.Click += lblValor1_Click;
            // 
            // txtValor2
            // 
            txtValor2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtValor2.Location = new Point(393, 128);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(166, 34);
            txtValor2.TabIndex = 2;
            // 
            // lblOper2
            // 
            lblOper2.AutoSize = true;
            lblOper2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblOper2.Location = new Point(134, 128);
            lblOper2.Name = "lblOper2";
            lblOper2.Size = new Size(176, 28);
            lblOper2.TabIndex = 3;
            lblOper2.Text = "Primeiro Operador";
            lblOper2.Click += label1_Click;
            // 
            // rdbSoma
            // 
            rdbSoma.AutoSize = true;
            rdbSoma.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            rdbSoma.Location = new Point(97, 211);
            rdbSoma.Name = "rdbSoma";
            rdbSoma.Size = new Size(48, 35);
            rdbSoma.TabIndex = 4;
            rdbSoma.Text = "+";
            rdbSoma.UseVisualStyleBackColor = true;
            // 
            // rdbSub
            // 
            rdbSub.AutoSize = true;
            rdbSub.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            rdbSub.Location = new Point(269, 211);
            rdbSub.Name = "rdbSub";
            rdbSub.Size = new Size(41, 35);
            rdbSub.TabIndex = 5;
            rdbSub.Text = "-";
            rdbSub.UseVisualStyleBackColor = true;
            // 
            // rdbMult
            // 
            rdbMult.AutoSize = true;
            rdbMult.Checked = true;
            rdbMult.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            rdbMult.Location = new Point(444, 211);
            rdbMult.Name = "rdbMult";
            rdbMult.Size = new Size(43, 35);
            rdbMult.TabIndex = 6;
            rdbMult.TabStop = true;
            rdbMult.Text = "x";
            rdbMult.UseVisualStyleBackColor = true;
            // 
            // rdbDivi
            // 
            rdbDivi.AutoSize = true;
            rdbDivi.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            rdbDivi.Location = new Point(628, 211);
            rdbDivi.Name = "rdbDivi";
            rdbDivi.Size = new Size(41, 35);
            rdbDivi.TabIndex = 7;
            rdbDivi.Text = "/";
            rdbDivi.UseVisualStyleBackColor = true;
            rdbDivi.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(324, 281);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(116, 48);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtResultado.Location = new Point(393, 375);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(166, 34);
            txtResultado.TabIndex = 9;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(134, 378);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(98, 28);
            lblResultado.TabIndex = 10;
            lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(txtResultado);
            Controls.Add(btnCalcular);
            Controls.Add(rdbDivi);
            Controls.Add(rdbMult);
            Controls.Add(rdbSub);
            Controls.Add(rdbSoma);
            Controls.Add(lblOper2);
            Controls.Add(txtValor2);
            Controls.Add(lblOper1);
            Controls.Add(txtValor1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValor1;
        private Label lblOper1;
        private TextBox txtValor2;
        private Label lblOper2;
        private RadioButton rdbSoma;
        private RadioButton rdbSub;
        private RadioButton rdbMult;
        private RadioButton rdbDivi;
        private Button btnCalcular;
        private TextBox txtResultado;
        private Label lblResultado;
    }
}