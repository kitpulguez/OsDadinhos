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
    public partial class SeleccionarNombre : Form
    {
        Partida ventanaPartida;

        public SeleccionarNombre()
        {
            InitializeComponent();
            ventanaPartida = new Partida();
        }

        private void BtConfirmarNombreJugador_Click(object sender, EventArgs e)
        {
            if (NombreCorrecto())
            {
                this.Hide();
                ventanaPartida.lbPlayerNombreAclarador.Text = GetNombre();
                ventanaPartida.ShowDialog();
                this.Close();
            }
            else
            {
                LbErrorNombre.Text = "El nombre no debe exceder los 19 caracteres ni tener \";\".";
                LbErrorNombre.ForeColor = Color.Red;
            }
        }

        public bool NombreCorrecto()
        {
            return GetNombre().Length < 20 && !GetNombre().Contains(";");
        }

        public string GetNombre()
        {
            return tbElegirNombreJugador.Text;
        }

        private void SeleccionarNombre_Load(object sender, EventArgs e)
        {
            LbErrorNombre.Text = "";
        }
    }
}
