namespace PrjDescontoSalario
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal aux1, aux2 = 0, aux3 = 0;
            if (decimal.TryParse(TxtSalarioBruto.Text, out decimal res) == false)
            {
                TxtSalarioLiquido.Text = "Digite o seu salário!";
            }
            else
            {
                decimal salbruto = Convert.ToDecimal(TxtSalarioBruto.Text);

                if (chkValeTransporte.Checked == true && chkConvenio.Checked == false)
                {
                    aux2 = salbruto * 0.94m;




                }
                if (chkConvenio.Checked == true && chkValeTransporte.Checked == false)
                {
                    aux2 = salbruto - 20;
                }
                if (chkConvenio.Checked == true && chkValeTransporte.Checked == true)
                {



                    aux1 = salbruto * 0.94m;
                    aux2 = aux1 - 20;

                }



                if (salbruto < 980)
                {
                    aux3 = salbruto * 0.08m;
                    aux3 = aux2 - aux3;
               
 }
                else if (salbruto >= 980 && salbruto < 1450)
                {
                    salbruto = salbruto * 0.09m;
                    aux3 = aux2 - aux3;
                }
                else if (salbruto >= 1450 && salbruto < 2200)
                {
                    salbruto = salbruto * 0.0m;
                    aux3 = aux2 - aux3;
                }
                else
                {
                    salbruto = salbruto * 0.89m;
                    aux3 = aux2 - aux3
                }









                txtResult.Text = aux3.ToString();
            }

















        }   
    }
}