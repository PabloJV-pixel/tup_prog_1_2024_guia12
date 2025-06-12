namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                lbMostrarValor.Text = $"{form2.tbValor.Text}";
            }
            else 
            {
                lbMostrarValor.Text = "Ingreso Cancelado";
            }
        }

        private void lbMostrarValor_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
