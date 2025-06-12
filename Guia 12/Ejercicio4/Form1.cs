using System.Configuration;
using Ejercicio4;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        double[] valor = new double[20];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            lsbListado.Items.Clear();
            Form2 form2 = new Form2();
             int contador = 0;
            while (form2.ShowDialog()== DialogResult.OK)
            {
                valor[contador] = Convert.ToDouble(form2.tbValor.Text);
                    contador++;
                form2.tbValor.Clear();
                
             }
            lbCantidad.Text = $"{contador}";
            for (int i = 0; i < contador; i++)
            {
                lsbListado.Items.Add(valor[i]);
            }

        }
    }
}
