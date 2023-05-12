namespace PrjDescontoSalario
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
            chkValeTransporte = new CheckBox();
            chkConvenio = new CheckBox();
            lblSalarioBruto = new Label();
            TxtSalarioBruto = new TextBox();
            btnCalcular = new Button();
            lblSalarioLiquido = new Label();
            TxtSalarioLiquido = new TextBox();
            SuspendLayout();
            // 
            // chkValeTransporte
            // 
            chkValeTransporte.AutoSize = true;
            chkValeTransporte.Location = new Point(154, 226);
            chkValeTransporte.Name = "chkValeTransporte";
            chkValeTransporte.Size = new Size(147, 19);
            chkValeTransporte.TabIndex = 0;
            chkValeTransporte.Text = "Recebo Vale Transporte";
            chkValeTransporte.UseVisualStyleBackColor = true;
            // 
            // chkConvenio
            // 
            chkConvenio.AutoSize = true;
            chkConvenio.Location = new Point(441, 226);
            chkConvenio.Name = "chkConvenio";
            chkConvenio.Size = new Size(162, 19);
            chkConvenio.TabIndex = 1;
            chkConvenio.Text = "Recebo Convênio Médico";
            chkConvenio.UseVisualStyleBackColor = true;
            // 
            // lblSalarioBruto
            // 
            lblSalarioBruto.AutoSize = true;
            lblSalarioBruto.Location = new Point(122, 74);
            lblSalarioBruto.Name = "lblSalarioBruto";
            lblSalarioBruto.Size = new Size(134, 15);
            lblSalarioBruto.TabIndex = 2;
            lblSalarioBruto.Text = "Digite o Salário Bruto R$";
            lblSalarioBruto.Click += label1_Click;
            // 
            // TxtSalarioBruto
            // 
            TxtSalarioBruto.Location = new Point(370, 66);
            TxtSalarioBruto.Name = "TxtSalarioBruto";
            TxtSalarioBruto.Size = new Size(100, 23);
            TxtSalarioBruto.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(347, 326);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblSalarioLiquido
            // 
            lblSalarioLiquido.AutoSize = true;
            lblSalarioLiquido.Location = new Point(64, 394);
            lblSalarioLiquido.Name = "lblSalarioLiquido";
            lblSalarioLiquido.Size = new Size(130, 15);
            lblSalarioLiquido.TabIndex = 5;
            lblSalarioLiquido.Text = "Valor Salário Liquido R$";
            // 
            // TxtSalarioLiquido
            // 
            TxtSalarioLiquido.Location = new Point(272, 386);
            TxtSalarioLiquido.Name = "TxtSalarioLiquido";
            TxtSalarioLiquido.Size = new Size(100, 23);
            TxtSalarioLiquido.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtSalarioLiquido);
            Controls.Add(lblSalarioLiquido);
            Controls.Add(btnCalcular);
            Controls.Add(TxtSalarioBruto);
            Controls.Add(lblSalarioBruto);
            Controls.Add(chkConvenio);
            Controls.Add(chkValeTransporte);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkValeTransporte;
        private CheckBox chkConvenio;
        private Label lblSalarioBruto;
        private TextBox TxtSalarioBruto;
        private Button btnCalcular;
        private Label lblSalarioLiquido;
        private TextBox TxtSalarioLiquido;
    }
}