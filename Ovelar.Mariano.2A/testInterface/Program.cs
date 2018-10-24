using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Interface;

namespace testInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Privado avionprivado = new Privado(200000,15000,180);
/*
            Console.WriteLine("AVION PRIVADO\n");
            Console.Write("PRECIO: ");
            avionprivado.MostrarPrecio();
            Console.WriteLine("\nAFIP: {0}",avionprivado.calculaImpuesto());

            Comercial avionComercial = new Comercial(100000, 10000, 350);

            Console.WriteLine("\n-----------------");

            Console.WriteLine("\nAVION COMERCIAL\n");
            Console.Write("PRECIO: ");
            avionComercial.MostrarPrecio();
            Console.WriteLine("\nAFIP: {0}", avionComercial.calculaImpuesto());

            Console.WriteLine("\n-----------------");
            
             */

            Console.WriteLine(Gestion.MostrarImpuestoNacional(avionprivado));
            Console.WriteLine(Gestion.MostrarImpuestoProvincial(avionprivado));

            Console.ReadKey();
        }
    }
}
