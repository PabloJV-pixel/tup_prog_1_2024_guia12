using System.Numerics;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[] vector = new double[10];
        int contador = 0;
        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            contador++;
            for (int i = 0; i < 10; i++) {
                if(form2.ShowDialog() == DialogResult.OK)
                {
                    vector[i]=Convert.ToDouble(form2.tbValor);
                }
                else
                {
                    lsbListado.Text = $"";
                }
            }
        }
    }
}
