using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OsDadinhos
{
    public partial class TablaPuntuaciones : Form
    {
        public TablaPuntuaciones()
        {
            InitializeComponent();
        }

        public void RellenarLabel()
        {
            try
            {
                string[] lines = File.ReadAllLines("../../../../../Ficheros/puntuacion.txt");
                string finalText = "", name = "";
                string[] splitter = null;

                for (int i = 0; i < lines.Length; i++)
                {
                    splitter = lines[i].Split(";");

                    name = splitter[0] + new string(' ', 20 - splitter[0].Length);

                    finalText += name + " " + splitter[1] + "       " + splitter[2] + "     " + splitter[3] + "\n\n";
                }

                label1.Text = finalText;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No se encontro el fichero.");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("La longitud de la ruta del fichero es demasiado larga.");
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e);
            }
        }

        private void TablaPuntuaciones_Load(object sender, EventArgs e)
        {
            RellenarLabel();
        }

        private void BtSalirRanking_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
