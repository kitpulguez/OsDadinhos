using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsDadinhos
{
    public partial class frmSumador : Form
    {
        public frmSumador()
        {
            InitializeComponent();
        }

        private void btCalcularSuma_Click(object sender, EventArgs e)
        {
            try
            {
                tbSuma.Text = Convert.ToString(Convert.ToDouble(txtPrimerNumero.Text) + Convert.ToDouble(txtSegundoNumero.Text));
                tbResta.Text = Convert.ToString(Convert.ToDouble(txtPrimerNumero.Text) - Convert.ToDouble(txtSegundoNumero.Text));
                tbMultiplicacion.Text = Convert.ToString(Convert.ToDouble(txtPrimerNumero.Text) * Convert.ToDouble(txtSegundoNumero.Text));
                tbDivision.Text = Convert.ToString(Convert.ToDouble(txtPrimerNumero.Text) / Convert.ToDouble(txtSegundoNumero.Text));
                tbResto.Text = Convert.ToString(Convert.ToDouble(txtPrimerNumero.Text) % Convert.ToDouble(txtSegundoNumero.Text));
            }
            catch (Exception ee)
            {
                Console.WriteLine("Error: " + ee);
                MessageBox.Show("Las casillas estan vacias o tienen caracteres no numericos", "Warning",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                tbSuma.Text = "";
                tbResta.Text = "";
                tbMultiplicacion.Text = "";
                tbDivision.Text = "";
                tbResto.Text = "";
            }
        }

        private void frmSumador_Load(object sender, EventArgs e)
        {

        }

        private void txtPrimerNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSuma_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
