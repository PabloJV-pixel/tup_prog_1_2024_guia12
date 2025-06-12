namespace Ejercicio2
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
            FormModal form2 = new FormModal();
            
            form2.lbMostrarValor.Text = tbValor.Text;
            
            form2.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbValor_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
