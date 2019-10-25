using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_47
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFutbol;
            Torneo<EquipoBasquet> torneoBasquet;

            torneoBasquet = new Torneo<EquipoBasquet>("Basquet 2019");
            torneoFutbol = new Torneo<EquipoFutbol>("Futbol 2019");

            EquipoBasquet E1 = new EquipoBasquet();
            EquipoBasquet E2 = new EquipoBasquet();
            EquipoBasquet E3 = new EquipoBasquet();
            EquipoFutbol E4 = new EquipoFutbol();
            EquipoFutbol E5 = new EquipoFutbol();
            EquipoFutbol E6 = new EquipoFutbol();

            E1.nombre = "E1";
            E2.nombre = "E2";
            E3.nombre = "E3";
            E4.nombre = "E4";
            E5.nombre = "E5";
            E6.nombre = "E6";

            
            torneoFutbol.equipos.Add(E4);
            torneoFutbol.equipos.Add(E5);
            torneoFutbol.equipos.Add(E6);
            
            torneoBasquet.equipos.Add(E1);
            torneoBasquet.equipos.Add(E2);
            torneoBasquet.equipos.Add(E3);

            Console.WriteLine(torneoBasquet.Mostrar());
            Console.WriteLine(torneoFutbol.Mostrar());

            Console.WriteLine(torneoBasquet.nombre);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine();

            Console.WriteLine(torneoFutbol.nombre);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);

            Console.ReadKey();
        }
    }
}
