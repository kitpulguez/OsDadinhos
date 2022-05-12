using System;
using System.IO;
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
    public partial class Partida : Form
    {
        ListaDeDados listaDeDados = new ListaDeDados();
        Dado d = new Dado();
        Jugador j1, j2, cpu;
        bool turnoTerminado, partidaTerminada;
        int puntosTemporales, puntosTemporalesAcumulados;

        public Partida()
        {
            InitializeComponent();
            turnoTerminado = false;
            partidaTerminada = false;
            j1 = new Humano();
            j2 = new Humano();
            cpu = new CPU();
            puntosTemporales = 0;
            puntosTemporalesAcumulados = 0;
        }

        public void Seleccionar(Dado dado)
        {
            dado.Seleccionar();

            if (CalcularPuntosTemporales() > 0)
                BtPuntuarYTirar.Enabled = true;
            else
                BtPuntuarYTirar.Enabled = false;


            lbTuPuntuacionTemporal.Text = puntosTemporales.ToString();
        }

        public void TurnoCPU()
        {

        }

        private void player1Dice1_Click(object sender, EventArgs e)
        {
            Seleccionar(listaDeDados.GetListaDeDados()[0]);
        }

        private void player1Dice2_Click(object sender, EventArgs e)
        {
            Seleccionar(listaDeDados.GetListaDeDados()[1]);
        }

        private void player1Dice3_Click(object sender, EventArgs e)
        {
            Seleccionar(listaDeDados.GetListaDeDados()[2]);
        }

        private void player1Dice4_Click(object sender, EventArgs e)
        {
            Seleccionar(listaDeDados.GetListaDeDados()[3]);
        }

        private void player1Dice5_Click(object sender, EventArgs e)
        {
            Seleccionar(listaDeDados.GetListaDeDados()[4]);
        }

        private void player1Dice6_Click(object sender, EventArgs e)
        {
            Seleccionar(listaDeDados.GetListaDeDados()[5]);
        }

        private void BtClickTirar(object sender, EventArgs e) // PONER FUNCIONES Y PULIR LA LIMPIEZA
        {
            TirarDados();

            BtTirar.Enabled = false;
            BtPuntuarYPasar.Enabled = true;
        }

        public void TirarDados()
        {
            foreach (Dado item in listaDeDados.GetListaDeDados())
            {
                item.RandomNumber();
            }

            ActualizarImagenesDados();
        }

        public void ActualizarImagenesDados()
        {
            foreach (Dado dado in listaDeDados.GetListaDeDados())
            {
                switch (dado.GetNumero())
                {
                    case 1:
                        dado.GetImagen().Load("../../../../../imagenes/1_dot.png");
                        break;
                    case 2:
                        dado.GetImagen().Load("../../../../../imagenes/2_dots.png");
                        break;
                    case 3:
                        dado.GetImagen().Load("../../../../../imagenes/3_dots.png");
                        break;
                    case 4:
                        dado.GetImagen().Load("../../../../../imagenes/4_dots.png");
                        break;
                    case 5:
                        dado.GetImagen().Load("../../../../../imagenes/5_dots.png");
                        break;
                    case 6:
                        dado.GetImagen().Load("../../../../../imagenes/6_dots.png");
                        break;
                }
            }
        }

        private void BtPuntuarYPasar_Click(object sender, EventArgs e)
        {
            puntosTemporalesAcumulados = 0;
            puntosTemporales = 0;
        }

        private void Partida_Load(object sender, EventArgs e)
        {
            RellenarListaDados();
        }

        private void BtPuntuarYTirar_Click(object sender, EventArgs e)
        {
            int x = 1350, y = 800, counter = 0;

            foreach (Dado dado in listaDeDados.GetListaDeDados())
            {
                if (dado.GetSeleccionado())
                {
                    dado.Recoger();
                    dado.Seleccionar();
                }

                if (dado.GetRecogido())
                    dado.GetImagen().Enabled = false;
            }

            foreach (Dado dado in listaDeDados.GetListaDeDados())
            {
                if (!dado.GetRecogido())
                    dado.RandomNumber();
                else
                {
                    dado.GetImagen().SetBounds(x + counter, y, dado.GetImagen().Size.Width, dado.GetImagen().Size.Height);
                    counter += 81;
                }
            }

            ActualizarImagenesDados();

            puntosTemporalesAcumulados = puntosTemporales;
        }

        public void RellenarListaDados()    // AÑADIR MAS EXCEPCIONES Y CONTEMPLAR POSIBLE AMPLIACION DE FICHERO MAS ADELANTE
        {
            try
            {
                string nombresDados = File.ReadAllText("../../../../../Ficheros/dados.txt");
                string[] nombresDadosString = nombresDados.Split(";");
                PictureBox[] pbDados = {player1Dice1, player1Dice2, player1Dice3, player1Dice4, player1Dice5, player1Dice6};

                for (int i = 0; i < nombresDadosString.Length; i++)
                {
                    d = new Dado(nombresDadosString[i], pbDados[i]);
                    listaDeDados.GetListaDeDados().Add(d);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e);
            }
        }

        public int CalcularPuntosTemporales()
        {
            int puntos = 0, numeros1 = 0, numeros2 = 0, numeros3 = 0, numeros4 = 0, numeros5 = 0, numeros6 = 0;
            puntos += puntosTemporalesAcumulados;


            foreach (Dado dado in listaDeDados.GetListaDeDados())
            {
                if (dado.GetSeleccionado())
                {
                    switch (dado.GetNumero())
                    {
                        case 1:
                            numeros1++;
                            break;
                        case 2:
                            numeros2++;
                            break;
                        case 3:
                            numeros3++;
                            break;
                        case 4:
                            numeros4++;
                            break;
                        case 5:
                            numeros5++;
                            break;
                        case 6:
                            numeros6++;
                            break;
                    }
                }
            }

            puntosTemporales = CalcularPuntosTemporalesParte2(numeros1, numeros2, numeros3, numeros4, numeros5, numeros6, puntos);

            return puntosTemporales;
        }

        public int CalcularPuntosTemporalesParte2(int numeros1, int numeros2, int numeros3, int numeros4, int numeros5, int numeros6, int puntos)
        {
            CalcularNumeros1(numeros1, ref puntos);
            CalcularNumeros2(numeros2, ref puntos);
            CalcularNumeros3(numeros3, ref puntos);
            CalcularNumeros4(numeros4, ref puntos);
            CalcularNumeros5(numeros5, ref puntos);
            CalcularNumeros6(numeros6, ref puntos);

            return puntos;
        }


        // PARA CALCULAR PUNTUACION ------------------------------
        // NUMEROS 1
        public void CalcularNumeros1(int numeros1, ref int puntos)
        {
            if (numeros1 == 6)
                puntos += 5000;
            else if (numeros1 == 5)
                puntos += 4000;
            else if (numeros1 == 4)
                puntos += 3000;
            else if (numeros1 == 3)
                puntos += 2000;
            else if (numeros1 == 2)
                puntos += 200;
            else if (numeros1 == 1)
                puntos += 100;
        }

        // NUMEROS 2
        public void CalcularNumeros2(int numeros1, ref int puntos)
        {
            if (numeros1 == 6)
                puntos += 800;
            else if (numeros1 == 5)
                puntos += 600;
            else if (numeros1 == 4)
                puntos += 400;
            else if (numeros1 == 3)
                puntos += 200;
        }

        // NUMEROS 3
        public void CalcularNumeros3(int numeros1, ref int puntos)
        {
            if (numeros1 == 6)
                puntos += 1200;
            else if (numeros1 == 5)
                puntos += 900;
            else if (numeros1 == 4)
                puntos += 600;
            else if (numeros1 == 3)
                puntos += 300;
        }

        // NUMEROS 4
        public void CalcularNumeros4(int numeros1, ref int puntos)
        {
            if (numeros1 == 6)
                puntos += 1600;
            else if (numeros1 == 5)
                puntos += 1200;
            else if (numeros1 == 4)
                puntos += 800;
            else if (numeros1 == 3)
                puntos += 400;
        }

        // NUMEROS 5
        public void CalcularNumeros5(int numeros1, ref int puntos)
        {
            if (numeros1 == 6)
                puntos += 2000;
            else if (numeros1 == 5)
                puntos += 1500;
            else if (numeros1 == 4)
                puntos += 1000;
            else if (numeros1 == 3)
                puntos += 500;
            else if (numeros1 == 2)
                puntos += 100;
            else if (numeros1 == 1)
                puntos += 50;
        }

        // NUMEROS 6
        public void CalcularNumeros6(int numeros6, ref int puntos)
        {
            if (numeros6 == 6)
                puntos += 2400;
            else if (numeros6 == 5)
                puntos += 1800;
            else if (numeros6 == 4)
                puntos += 1200;
            else if (numeros6 == 3)
                puntos += 600;
        }
        // --------------------------------------------------
    }
}
