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
using System.Threading;

namespace OsDadinhos
{
    public partial class Partida : Form
    {
        ListaDeDados listaDeDadosJugador;
        ListaDeDados listaDeDadosCPU;
        Dado d;
        Jugador j1, j2, cpu;
        bool turnoTerminado, partidaTerminada, dadoQueNoPuntuaSeleccionado;
        int puntosTemporales, puntosTemporalesAcumulados, objetivoPuntos;

        public Partida()
        {
            InitializeComponent();
            listaDeDadosJugador = new ListaDeDados();
            listaDeDadosCPU = new ListaDeDados();
            turnoTerminado = false;
            partidaTerminada = false;
            j1 = new Humano();
            j2 = new Humano();
            cpu = new CPU();
            puntosTemporales = 0;
            puntosTemporalesAcumulados = 0;
            objetivoPuntos = 2400;
            dadoQueNoPuntuaSeleccionado = false;
            lbMalaSuerte.Text = "";
        }

        private void Partida_Load(object sender, EventArgs e)
        {
            RellenarListaDados();
            lbObjetivoPuntuacionPuntos.Text = objetivoPuntos.ToString();
            lbRivalPuntosTotales.Text = 0.ToString();
            lbTusPuntosTotales.Text = 0.ToString();
            lbTuPuntuacionTemporal.Text = 0.ToString();
            lbRivalPuntuacionTemporal.Text = 0.ToString();
            foreach (Dado dado in j1.GetListaDeDados())
            {
                dado.GetImagen().Enabled = false;
            }
        }

        private void player1Dice1_Click(object sender, EventArgs e)
        {
            Seleccionar(listaDeDadosJugador.GetListaDeDados()[0]);
        }

        private void player1Dice2_Click(object sender, EventArgs e)
        {
            Seleccionar(listaDeDadosJugador.GetListaDeDados()[1]);
        }

        private void player1Dice3_Click(object sender, EventArgs e)
        {
            Seleccionar(listaDeDadosJugador.GetListaDeDados()[2]);
        }

        private void player1Dice4_Click(object sender, EventArgs e)
        {
            Seleccionar(listaDeDadosJugador.GetListaDeDados()[3]);
        }

        private void player1Dice5_Click(object sender, EventArgs e)
        {
            Seleccionar(listaDeDadosJugador.GetListaDeDados()[4]);
        }

        private void player1Dice6_Click(object sender, EventArgs e)
        {
            Seleccionar(listaDeDadosJugador.GetListaDeDados()[5]);
        }

        private void BtClickTirar(object sender, EventArgs e)
        {
            j1.TirarDados();

            if (AveriguarSiNingunDadoPuntua(j1))
            {
                BtTirar.Enabled = false;
                BtPuntuarYPasar.Enabled = false;
                MalaSuerte();
                TurnoCPU();
            }
            else
            {
                BtTirar.Enabled = false;
                BtPuntuarYPasar.Enabled = false;
                foreach (Dado dado in j1.GetListaDeDados())
                {
                    dado.GetImagen().Enabled = true;                    
                }
            }
        }

        public void PartidaTerminada()
        {
            if (Convert.ToInt32(lbRivalPuntosTotales.Text) >= objetivoPuntos || Convert.ToInt32(lbTusPuntosTotales.Text) >= objetivoPuntos)
            {
                Close();
            }
        }

        private void BtPuntuarYPasar_Click(object sender, EventArgs e)
        {
            ApartarDados();
            puntosTemporalesAcumulados = puntosTemporales;
            ActualizarPuntosJugador();
            PartidaTerminada();
            BtPuntuarYPasar.Enabled = false;
            BtPuntuarYTirar.Enabled = false;

            TurnoCPU();
        }

        public void ActualizarPuntosJugador()
        {
            j1.SumarPuntos(puntosTemporalesAcumulados);
            puntosTemporalesAcumulados = 0;
            puntosTemporales = 0;
            lbTusPuntosTotales.Text = j1.GetPuntos().ToString();
            lbTuPuntuacionTemporal.Text = 0.ToString();
        }

        private void BtPuntuarYTirar_Click(object sender, EventArgs e)
        {
            ApartarDados();

            j1.TirarDados();

            puntosTemporalesAcumulados = puntosTemporales;
            BtPuntuarYTirar.Enabled = false;
            BtPuntuarYPasar.Enabled = false;

            if (AveriguarSiNingunDadoPuntua(j1))
            {
                MalaSuerte();

                TurnoCPU();
            }
        }

        public void ApartarDados()
        {
            int x = 1350, y = 800, counter = 0;

            foreach (Dado dado in listaDeDadosJugador.GetListaDeDados())
            {
                if (dado.GetSeleccionado())
                {
                    dado.Recoger();
                    dado.SetSeleccionado(false);
                }

                if (dado.GetRecogido())
                {
                    dado.GetImagen().Enabled = false;
                    dado.GetImagen().SetBounds(x + counter, y, dado.GetImagen().Size.Width, dado.GetImagen().Size.Height);
                    dado.GetImagen().BorderStyle = BorderStyle.None;
                    counter += 81;
                }
            }
        }

        public void Seleccionar(Dado dado)
        {
            dado.Seleccionar();

            if (CalcularPuntosTemporales(j1) > 0 && !dadoQueNoPuntuaSeleccionado)
            {
                BtPuntuarYTirar.Enabled = true;
                BtPuntuarYPasar.Enabled = true;
            }
            else
            {
                BtPuntuarYTirar.Enabled = false;
                BtPuntuarYPasar.Enabled = false;
            }

            lbTuPuntuacionTemporal.Text = puntosTemporales.ToString();
        }

        public void TurnoCPU()
        {
            ReposicionamientoDados(cpu);
            turnoTerminado = false;

            TurnoCPUParte2();

            lbRivalPuntosTotales.Text = (Convert.ToInt32(lbRivalPuntosTotales.Text) + Convert.ToInt32(puntosTemporales)).ToString();
            puntosTemporales = 0;
            PartidaTerminada();

            ReposicionamientoDados(j1);
            BtTirar.Enabled = true;
            
        }

        public void TurnoCPUParte2()
        {
            do
            {
                int numeros1 = 0, numeros2 = 0, numeros3 = 0, numeros4 = 0, numeros5 = 0, numeros6 = 0;
                cpu.TirarDados();
                Thread.Sleep(1300);

                if (!AveriguarSiNingunDadoPuntua(cpu, ref numeros1, ref numeros2, ref numeros3, ref numeros4, ref numeros5, ref numeros6))
                {
                    ((CPU)cpu).SeleccionarDado(numeros1, numeros2, numeros3, numeros4, numeros5, numeros6);

                    puntosTemporales += CalcularPuntosTemporales(cpu);
                    lbRivalPuntuacionTemporal.Text = puntosTemporales.ToString();
                    Thread.Sleep(1300);

                    ((CPU)cpu).RecogerDadosSeleccionados();
                    Thread.Sleep(500);

                    if (((CPU)cpu).TirarOtraVez())
                    {
                        turnoTerminado = false;
                    }
                    else
                        turnoTerminado = true;
                }
                else
                {
                    MalaSuerte();
                    turnoTerminado = true;
                }
            }
            while (!turnoTerminado);
        }

        public void ReposicionamientoDados(Jugador player)
        {
            foreach (Dado dado in player.GetListaDeDados())
            {
                dado.SetPosicionInicial();
                dado.GetImagen().Enabled = false;
                dado.SetRecogido(false);
            }
        }

        public void MalaSuerte()
        {
            lbMalaSuerte.Text = "¡Mala suerte!";
            Thread.Sleep(2500);
            lbMalaSuerte.Text = "";
            puntosTemporales = 0;
            puntosTemporalesAcumulados = 0;
            lbTuPuntuacionTemporal.Text = 0.ToString();
            lbRivalPuntuacionTemporal.Text = 0.ToString();
        }        

        public bool AveriguarSiNingunDadoPuntua(Jugador player)
        {
            int numeros1 = 0, numeros2 = 0, numeros3 = 0, numeros4 = 0, numeros5 = 0, numeros6 = 0;

            foreach (Dado dado in player.GetListaDeDados())
            {
                if (!dado.GetRecogido())
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

            return AveriguarSiNingunDadoPuntuaParte2(numeros1, numeros2, numeros3, numeros4, numeros5, numeros6);
        }

        public bool AveriguarSiNingunDadoPuntua(Jugador player, ref int numeros1, ref int numeros2, ref int numeros3, ref int numeros4, ref int numeros5, ref int numeros6)
        {
            foreach (Dado dado in player.GetListaDeDados())
            {
                if (!dado.GetRecogido())
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

            return AveriguarSiNingunDadoPuntuaParte2(numeros1, numeros2, numeros3, numeros4, numeros5, numeros6);
        }

        public bool AveriguarSiNingunDadoPuntuaParte2(int numeros1, int numeros2, int numeros3, int numeros4, int numeros5, int numeros6)
        {
            int counter = 0;
            bool dadoQueNoPuntua = false;
           
            if (AveriguarNumeros1(numeros1, dadoQueNoPuntua))
                counter++;
            if (AveriguarNumeros2(numeros2, dadoQueNoPuntua))
                counter++;
            if (AveriguarNumeros3(numeros3, dadoQueNoPuntua))
                counter++;
            if (AveriguarNumeros4(numeros4, dadoQueNoPuntua))
                counter++;
            if (AveriguarNumeros5(numeros5, dadoQueNoPuntua))
                counter++;
            if (AveriguarNumeros6(numeros6, dadoQueNoPuntua))
                counter++;

            return counter == 6 ? true : false;
        }


        // AVERIGUACIONES DE NUMEROS
        // --------------------------------------------
        public bool AveriguarNumeros1(int numeros1, bool dadoQueNoPuntua)
        {
            if (numeros1 < 1)
                dadoQueNoPuntua = true;

            return dadoQueNoPuntua;
        }

        public bool AveriguarNumeros2(int numeros2, bool dadoQueNoPuntua)
        {
            if (numeros2 < 3)
                dadoQueNoPuntua = true;

            return dadoQueNoPuntua;
        }

        public bool AveriguarNumeros3(int numeros3, bool dadoQueNoPuntua)
        {
            if (numeros3 < 3)
                dadoQueNoPuntua = true;

            return dadoQueNoPuntua;
        }

        public bool AveriguarNumeros4(int numeros4, bool dadoQueNoPuntua)
        {
            if (numeros4 < 3)
                dadoQueNoPuntua = true;

            return dadoQueNoPuntua;
        }

        public bool AveriguarNumeros5(int numeros5, bool dadoQueNoPuntua)
        {
            if (numeros5 < 1)
                dadoQueNoPuntua = true;

            return dadoQueNoPuntua;
        }

        public bool AveriguarNumeros6(int numeros6, bool dadoQueNoPuntua)
        {
            if (numeros6 < 3)
                dadoQueNoPuntua = true;

            return dadoQueNoPuntua;
        }
        // ------------------------------------------

        public int CalcularPuntosTemporales(Jugador player)
        {
            int puntos = 0, numeros1 = 0, numeros2 = 0, numeros3 = 0, numeros4 = 0, numeros5 = 0, numeros6 = 0;
            puntos += puntosTemporalesAcumulados;

            foreach (Dado dado in player.GetListaDeDados())
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
            int counter = 0;
            CalcularNumeros1(numeros1, ref puntos, ref dadoQueNoPuntuaSeleccionado);
            if (dadoQueNoPuntuaSeleccionado)
                counter++;
            CalcularNumeros2(numeros2, ref puntos, ref dadoQueNoPuntuaSeleccionado);
            if (dadoQueNoPuntuaSeleccionado)
                counter++;
            CalcularNumeros3(numeros3, ref puntos, ref dadoQueNoPuntuaSeleccionado);
            if (dadoQueNoPuntuaSeleccionado)
                counter++;
            CalcularNumeros4(numeros4, ref puntos, ref dadoQueNoPuntuaSeleccionado);
            if (dadoQueNoPuntuaSeleccionado)
                counter++;
            CalcularNumeros5(numeros5, ref puntos, ref dadoQueNoPuntuaSeleccionado);
            if (dadoQueNoPuntuaSeleccionado)
                counter++;
            CalcularNumeros6(numeros6, ref puntos, ref dadoQueNoPuntuaSeleccionado);
            if (dadoQueNoPuntuaSeleccionado)
                counter++;

            if (counter > 0)
                dadoQueNoPuntuaSeleccionado = true;

            return puntos;
        }

        


        // PARA CALCULAR PUNTUACION ------------------------------
        // NUMEROS 1
        public void CalcularNumeros1(int numeros1, ref int puntos, ref bool dadoQueNoPuntuaSeleccionado)
        {
            dadoQueNoPuntuaSeleccionado = false;

            if (numeros1 == 6)
                puntos += 4000;
            else if (numeros1 == 5)
                puntos += 3000;
            else if (numeros1 == 4)
                puntos += 2000;
            else if (numeros1 == 3)
                puntos += 1000;
            else if (numeros1 == 2)
                puntos += 200;
            else if (numeros1 == 1)
                puntos += 100;
        }

        // NUMEROS 2
        public void CalcularNumeros2(int numeros2, ref int puntos, ref bool dadoQueNoPuntuaSeleccionado)
        {
            dadoQueNoPuntuaSeleccionado = false;

            if (numeros2 == 6)
                puntos += 800;
            else if (numeros2 == 5)
                puntos += 600;
            else if (numeros2 == 4)
                puntos += 400;
            else if (numeros2 == 3)
                puntos += 200;
            else if (numeros2 == 0);
            else
                dadoQueNoPuntuaSeleccionado = true;

        }

        // NUMEROS 3
        public void CalcularNumeros3(int numeros3, ref int puntos, ref bool dadoQueNoPuntuaSeleccionado)
        {
            dadoQueNoPuntuaSeleccionado = false;

            if (numeros3 == 6)
                puntos += 1200;
            else if (numeros3 == 5)
                puntos += 900;
            else if (numeros3 == 4)
                puntos += 600;
            else if (numeros3 == 3)
                puntos += 300;
            else if (numeros3 == 0) ;
            else
                dadoQueNoPuntuaSeleccionado = true;
        }

        // NUMEROS 4
        public void CalcularNumeros4(int numeros4, ref int puntos, ref bool dadoQueNoPuntuaSeleccionado)
        {
            dadoQueNoPuntuaSeleccionado = false;

            if (numeros4 == 6)
                puntos += 1600;
            else if (numeros4 == 5)
                puntos += 1200;
            else if (numeros4 == 4)
                puntos += 800;
            else if (numeros4 == 3)
                puntos += 400;
            else if (numeros4 == 0) ;
            else
                dadoQueNoPuntuaSeleccionado = true;
        }

        // NUMEROS 5
        public void CalcularNumeros5(int numeros5, ref int puntos, ref bool dadoQueNoPuntuaSeleccionado)
        {
            dadoQueNoPuntuaSeleccionado = false;

            if (numeros5 == 6)
                puntos += 2000;
            else if (numeros5 == 5)
                puntos += 1500;
            else if (numeros5 == 4)
                puntos += 1000;
            else if (numeros5 == 3)
                puntos += 500;
            else if (numeros5 == 2)
                puntos += 100;
            else if (numeros5 == 1)
                puntos += 50;
        }

        // NUMEROS 6
        public void CalcularNumeros6(int numeros6, ref int puntos, ref bool dadoQueNoPuntuaSeleccionado)
        {
            dadoQueNoPuntuaSeleccionado = false;

            if (numeros6 == 6)
                puntos += 2400;
            else if (numeros6 == 5)
                puntos += 1800;
            else if (numeros6 == 4)
                puntos += 1200;
            else if (numeros6 == 3)
                puntos += 600;
            else if (numeros6 == 0) ;
            else
                dadoQueNoPuntuaSeleccionado = true;

        }
        // --------------------------------------------------

        public void RellenarListaDados()    // AÑADIR MAS EXCEPCIONES Y CONTEMPLAR POSIBLE AMPLIACION DE FICHERO MAS ADELANTE
        {
            try
            {
                // Y DE PASO CREAR LOS PERFILES
                j1 = new Humano(lbPlayerNombreAclarador.Text, listaDeDadosJugador.GetListaDeDados());
                cpu = new CPU("cpu", listaDeDadosCPU.GetListaDeDados());

                string nombresDados = File.ReadAllText("../../../../../Ficheros/dados.txt");
                string[] nombresDadosString = nombresDados.Split(";");
                PictureBox[] pbDados = {player1Dice1, player1Dice2, player1Dice3, player1Dice4, player1Dice5, player1Dice6,
                    cpuDice1, cpuDice2 , cpuDice3 , cpuDice4 , cpuDice5 , cpuDice6};

                for (int i = 0; i < nombresDadosString.Length; i++)
                {
                    d = new Dado(nombresDadosString[i], pbDados[i]);

                    if (i <= 5)
                        listaDeDadosJugador.GetListaDeDados().Add(d);
                    else
                        listaDeDadosCPU.GetListaDeDados().Add(d);
                }                
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("No se encontro el fichero.");
                Close();
            }
            catch (PathTooLongException e)
            {
                Console.WriteLine("La longitud de la ruta del fichero es demasiado larga.");
                Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e);
                Close();
            }
        }
    }
}
