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
            decimal valorbruto = 0, valorliquido, calc=0, sla;

            valorbruto = Convert.ToDecimal(TxtSalarioBruto.Text);

            if (decimal.TryParse(TxtSalarioBruto.Text, out decimal res) == true)
            {
                MessageBox.Show("Digite O Valor Do Salário Bruto");
            }
            else if (TxtSalarioBruto.Text == string.Empty)
            {
                MessageBox.Show("Digite O Valor Do Salário Bruto");
            }
            else if (chkValeTransporte.Checked == true)
            {
                calc = valorbruto * 0.06m;
                
            }   
            else if (chkConvenio.Checked == true)
            {
                calc = (valorbruto - 20);

            }
            
            

            



        }   
    }
}