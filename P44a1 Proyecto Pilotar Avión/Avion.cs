using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P44a1_Proyecto_Pilotar_Avión
{
    internal class Avion
    {

        private string marca;
        private string modelo;
        private string matricula;
        private int altitudMáxima;

        private int altitud = 0;
        private int velocidad = 0;
        private bool aire = false;

        public Avion(string marca, string modelo, string matricula, int altitudMáxima, int altitud, int velocidad, bool aire)
        {
          
            this.marca = marca;
            this.modelo = modelo;
            this.matricula = matricula;
            this.altitudMáxima = altitudMáxima;
            this.altitud = altitud;
            this.velocidad = velocidad;
            this.aire = aire;
        }

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public int AltitudMáxima { get => altitudMáxima; set => altitudMáxima = value; }
        public int Altitud 
        {            
            get => altitud;

            set
            {               
                altitud = value;
            }        
        }
        public int Velocidad 
        {            
            get => velocidad;
            
            set => velocidad = value;         
        }
        public bool Aire { get => aire; set => aire = value; }


        /// <summary>
        /// Aumenta la velocidad del avion
        /// </summary>
        /// <param name="v">velocidad a aumentar</param>
        public void AumentarVelocidad(int v)
        {
            Velocidad = Velocidad + v;
        }


        /// <summary>
        /// Disminuye la velocidad del avion
        /// </summary>
        /// <param name="v">velocidad a disminuir</param>
        public void DisminuirVelocidad(int v)
        {
            Velocidad = Velocidad - v;
        }


        /// <summary>
        /// Despega el avion
        /// </summary>
        public void Despegar()
        {
            if (Velocidad > 199)
            {
                Altitud = 100;
                Aire = true;
            }
            else
                Console.WriteLine("Velocidad insuficiente. Amuente la velocidad a 200km/h");
        }


        /// <summary>
        /// Recibe la cantidad a aumentar. Esta orden sólo se admite si el avión ya ha despegado.
        /// </summary>
        /// <param name="a">altitud a aumentar</param>
        public void AumentarAltitud(int a)
        {
            if (Aire)
            {
                if ((Altitud + a) > AltitudMáxima)
                    Altitud = Altitud + a;
                else
                    Console.WriteLine("La velocidad maxima es de " + AltitudMáxima);
            }

            else
                Console.WriteLine("Antes tiene que despegar el avion");
        }



        public void DisminuirAltitud(int a)
        {
            if (Aire)
                Altitud = Altitud - a;
        }
    }
}
