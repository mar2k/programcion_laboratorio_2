using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente(44, "juan");
            Cliente cliente2 = new Cliente(48, "pedro");

            Negocio negocio1 = new Negocio("");


            if (negocio1 + cliente1 && negocio1 + cliente2)
            {
                Console.WriteLine("ingresaron los clientes");
            }

            Console.WriteLine("Clientes:"+negocio1.ClientesPendientes.ToString());
            if (!~negocio1)
            {
                Console.WriteLine("no hay clientes");
            }
            else
            {
                Console.WriteLine("atendido!!!!");
            }


            Console.WriteLine("Clientes:" + negocio1.ClientesPendientes.ToString());
            if (!~negocio1)
            {
                Console.WriteLine("no hay clientes");
            }
            else
            {
                Console.WriteLine("atendido!!!!");
            }

            if (!~negocio1)
            {
                Console.WriteLine("no hay clientes");
            }
            else
            {
                Console.WriteLine("atendido!!!!");
            }

            Console.ReadKey();
        }
    }
}
