namespace WinFormsApp1
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
            lblNota1 = new Label();
            lblNota2 = new Label();
            lblNota3 = new Label();
            lblQtdFaltas = new Label();
            txtNota1 = new TextBox();
            txtNota3 = new TextBox();
            txtNota2 = new TextBox();
            txtQtdFaltas = new TextBox();
            bntVerificar = new Button();
            lblSituação = new Label();
            lblMedia = new Label();
            SuspendLayout();
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblNota1.ForeColor = Color.Gold;
            lblNota1.Location = new Point(88, 51);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(181, 21);
            lblNota1.TabIndex = 0;
            lblNota1.Text = "Nota da Primeira Prova";
            lblNota1.Click += label1_Click;
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblNota2.ForeColor = Color.Gold;
            lblNota2.Location = new Point(88, 116);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(195, 25);
            lblNota2.TabIndex = 1;
            lblNota2.Text = "Nota da Segunda Nota";
            // 
            // lblNota3
            // 
            lblNota3.AutoSize = true;
            lblNota3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblNota3.ForeColor = Color.Gold;
            lblNota3.Location = new Point(88, 188);
            lblNota3.Name = "lblNota3";
            lblNota3.Size = new Size(199, 25);
            lblNota3.TabIndex = 2;
            lblNota3.Text = "Nota da Terceira Prova";
            lblNota3.Click += lblNota3_Click;
            // 
            // lblQtdFaltas
            // 
            lblQtdFaltas.AutoSize = true;
            lblQtdFaltas.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblQtdFaltas.ForeColor = Color.Gold;
            lblQtdFaltas.Location = new Point(88, 261);
            lblQtdFaltas.Name = "lblQtdFaltas";
            lblQtdFaltas.Size = new Size(183, 25);
            lblQtdFaltas.TabIndex = 3;
            lblQtdFaltas.Text = "Quantidade de Faltas";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(314, 49);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(147, 23);
            txtNota1.TabIndex = 0;
            txtNota1.TextChanged += txtNota1_TextChanged;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(314, 190);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(147, 23);
            txtNota3.TabIndex = 2;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(314, 118);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(147, 23);
            txtNota2.TabIndex = 1;
            // 
            // txtQtdFaltas
            // 
            txtQtdFaltas.Location = new Point(314, 263);
            txtQtdFaltas.Name = "txtQtdFaltas";
            txtQtdFaltas.Size = new Size(147, 23);
            txtQtdFaltas.TabIndex = 3;
            // 
            // bntVerificar
            // 
            bntVerificar.BackColor = SystemColors.ButtonFace;
            bntVerificar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bntVerificar.ForeColor = Color.Black;
            bntVerificar.Location = new Point(88, 353);
            bntVerificar.Name = "bntVerificar";
            bntVerificar.Size = new Size(278, 42);
            bntVerificar.TabIndex = 8;
            bntVerificar.Text = "Verificar Situação do Aluno";
            bntVerificar.UseVisualStyleBackColor = false;
            bntVerificar.Click += button1_Click;
            // 
            // lblSituação
            // 
            lblSituação.AutoSize = true;
            lblSituação.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblSituação.ForeColor = Color.Gold;
            lblSituação.Location = new Point(522, 337);
            lblSituação.Name = "lblSituação";
            lblSituação.Size = new Size(103, 31);
            lblSituação.TabIndex = 9;
            lblSituação.Text = "Situação";
            lblSituação.Click += lblSituação_Click;
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblMedia.ForeColor = Color.Gold;
            lblMedia.Location = new Point(522, 394);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(78, 31);
            lblMedia.TabIndex = 10;
            lblMedia.Text = "Media";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMedia);
            Controls.Add(lblSituação);
            Controls.Add(bntVerificar);
            Controls.Add(txtQtdFaltas);
            Controls.Add(txtNota2);
            Controls.Add(txtNota3);
            Controls.Add(txtNota1);
            Controls.Add(lblQtdFaltas);
            Controls.Add(lblNota3);
            Controls.Add(lblNota2);
            Controls.Add(lblNota1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNota1;
        private Label lblNota2;
        private Label lblNota3;
        private Label lblQtdFaltas;
        private TextBox txtNota1;
        private TextBox txtNota3;
        private TextBox txtNota2;
        private TextBox txtQtdFaltas;
        private Button bntVerificar;
        private Label lblSituação;
        private Label lblMedia;
    }
}