using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsDadinhos
{
    public abstract class Jugador
    {
        string nombre;
        int turnos, puntos;
        List<Dado> dadosPropios;

        public Jugador() : this("", null)
        {

        }

        public Jugador(string nombre, List<Dado> dadosPropios)
        {
            this.nombre = nombre;
            turnos = 1;
            puntos = 0;
            this.dadosPropios = dadosPropios;
        }

        public void SumarTurno()
        {
            turnos++;
        }

        public void TirarDados()
        {
            foreach (Dado dado in dadosPropios)
            {
                if (!dado.GetRecogido())
                    dado.RandomNumber();
            }

            ActualizarImagenesDados();
        }

        public void ActualizarImagenesDados()
        {
            foreach (Dado dado in dadosPropios)
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

        public abstract void PuntuarYPasar();

        public void SumarPuntos(int puntazos)
        {
            puntos += puntazos;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetTurnos(int turnos)
        {
            this.turnos = turnos;
        }

        public int GetTurnos()
        {
            return turnos;
        }

        public void SetPuntos(int puntos)
        {
            this.puntos = puntos;
        }

        public int GetPuntos()
        {
            return puntos;
        }

        public void SetListaDeDados(List<Dado> listaDeDados)
        {
            dadosPropios = listaDeDados;
        }

        public List<Dado> GetListaDeDados()
        {
            return dadosPropios;
        }
    }
}
