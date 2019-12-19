using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiBaseDeDatos;

namespace PruebaAC
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase baseDedatos=new DataBase("USER-PC\\MARIANOMSSQLSERV", "patentes-sp-2018");
            baseDedatos.Abrir();
            baseDedatos.Cerrar();
            Console.ReadKey();
        }
    }
}
