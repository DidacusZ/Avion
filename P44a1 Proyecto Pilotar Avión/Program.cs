using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P44a1_Proyecto_Pilotar_Avión
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utils utils = new Utils();

            Avion avion = new Avion("AAP", "007", "CSI-2019",1000,0,0, false);

            //avion.AumentarVelocidad(121);
            //Console.WriteLine(avion.Velocidad);

            utils.MostarMenu();



            Console.WriteLine();
            
            Console.ReadKey();

        }
    }
}
