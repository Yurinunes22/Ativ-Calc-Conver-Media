namespace prjAtividades
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {



        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            decimal Valor, dolar, euro, resultado;
            euro = 5.47m;
            dolar = 4.99m;
            if (rdbDolar.Checked == true)
            {
                Valor = Convert.ToDecimal(txtValor.Text);
                resultado = (Valor / dolar);
                lblResult.Text = resultado.ToString("n2");
            }
            else
            {


                Valor = Convert.ToDecimal(txtValor.Text);
                resultado = (Valor / euro);
                lblResult.Text = resultado.ToString("n2");

            }
        }

        private void lblDigitarValor_Click(object sender, EventArgs e)
        {

        }
    }
}

