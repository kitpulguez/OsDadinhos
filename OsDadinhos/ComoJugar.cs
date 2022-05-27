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
    public partial class ComoJugar : Form
    {
        Color instruccionesColor;

        public ComoJugar()
        {
            InitializeComponent();
        }

        private void ComoJugar_Load(object sender, EventArgs e)
        {
            instruccionesColor = Color.FromArgb(100, Color.Black);
            lbInstrucciones.BackColor = instruccionesColor;
            instruccionesColor = Color.FromArgb(100, Color.LightGray);
            lbInstruccionesTitulo.BackColor = instruccionesColor;
        }

        private void BtSalirInstrucciones(object sender, EventArgs e)
        {
            Close();
        }
    }
}
