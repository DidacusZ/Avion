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
            
            set => altitud = value; 
        
        }
        public int Velocidad 
        {
            
            get => velocidad;
            
            set => velocidad = value; 
        
        }
        public bool Aire { get => aire; set => aire = value; }
    }
}
