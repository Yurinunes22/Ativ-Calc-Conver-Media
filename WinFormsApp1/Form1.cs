namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal nota1, nota2, nota3, media;
            int faltas;
            faltas = Convert.ToInt32(txtQtdFaltas.Text);
            nota1 = Convert.ToDecimal(txtNota1.Text);
            nota2 = Convert.ToDecimal(txtNota2.Text);
            nota3 = Convert.ToDecimal(txtNota3.Text);
            media = (nota1 + nota2 + nota3) / 3;
            if (txtNota1.Text == string.Empty || txtNota2.Text == string.Empty || txtNota3.Text == string.Empty || txtQtdFaltas.Text == string.Empty)
            {
                lblSituação.Text = "Compreencha Todos os campos!";

            }
            else if (faltas > 12)
            {
                lblSituação.Text = "Aluno Reprovado por faltas!";
                lblMedia.Text = media.ToString("n2");
            }
            else if (media < 4)
            {
                lblSituação.Text = "Aluno Reprovado!";
                lblMedia.Text = media.ToString("n2");
            }
            else if (media > 4 && media < 5.5m)
            {
                lblSituação.Text = "Aluno de Recuperação!";
                lblMedia.Text = media.ToString("n2");
            }
            else
            {
                lblSituação.Text = "Aluno Aprovado!";
                lblMedia.Text = media.ToString("n2");
            }

            txtNota1.Focus();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtQtdFaltas.Clear();   










        }

        private void lblNota3_Click(object sender, EventArgs e)
        {

        }

        private void lblSituação_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNota1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}