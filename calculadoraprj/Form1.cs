using System.Diagnostics.Eventing.Reader;

namespace calculadoraprj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblValor1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal operador1, operador2, operacao;
            string msg;

            if (txtValor1.Text == String.Empty || txtValor2.Text == String.Empty)
            {
                msg = "Digite um Valor";
                txtResultado.Text = msg;
            }
            else if (rdbSoma.Checked == true)
            {
                operador1 = Convert.ToDecimal(txtValor1.Text);
                operador2 = Convert.ToDecimal(txtValor2.Text);
                operacao = operador1 + operador2;
                txtResultado.Text = operacao.ToString();
            }

            else if (rdbSub.Checked == true)
            {
                operador1 = Convert.ToDecimal(txtValor1.Text);
                operador2 = Convert.ToDecimal(txtValor2.Text);
                operacao = operador1 - operador2;
                txtResultado.Text = operacao.ToString();

            }
            else if (rdbMult.Checked == true)
            {
                operador1 = Convert.ToDecimal(txtValor1.Text);
                operador2 = Convert.ToDecimal(txtValor2.Text);
                operacao = operador1 * operador2;
                txtResultado.Text = operacao.ToString();
            }
            else
            {

                operador1 = Convert.ToDecimal(txtValor1.Text);
                operador2 = Convert.ToDecimal(txtValor2.Text);
                operacao = operador1 / operador2;
                txtResultado.Text = operacao.ToString();

            }

            txtValor1.Focus();
            txtValor1.Clear();
            txtValor2.Clear();
            // txtlogin.focus();/txtlogin.Clear();

        }

    }
}