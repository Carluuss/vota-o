namespace votacao
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

        private void lblPorcenulo_Click(object sender, EventArgs e)
        {

        }

        private void btlCalcular_Click(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(txtTotal.Text);
            double branco = Convert.ToDouble(txtBranco.Text);
            double nulo = Convert.ToDouble(txtNulo.Text);
            double validos = Convert.ToDouble(txtValidos.Text);

            double calculo1 = (branco * 100)/total; 
            double calculo2 = (nulo * 100)/total;
            double calculo3 = (validos * 100)/total;

            lblBranco.Text = Convert.ToString(calculo1) + "%";
            lblNulo.Text = Convert.ToString(calculo2) + "%";
            lblValidos.Text = Convert.ToString(calculo3) + "%";
        }
    }
}