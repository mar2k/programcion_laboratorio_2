using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase05
{
  class Program
  {
    static void Main(string[] args)
    {
            Tinta miTinta = new Tinta();
            Pluma miPluma = new Pluma(98,"sasa",miTinta);

            miPluma += miTinta;
            

            Console.WriteLine(Pluma.Mostrar(miPluma));



            Console.ReadKey();


    }
  }
}
