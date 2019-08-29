using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_05.Entidades;

namespace clase05
{
  class Program
  {
    static void Main(string[] args)
    {

      Tinta tinta1 = new Tinta();
      Tinta tinta2 = new Tinta(ConsoleColor.Blue);
      Tinta tinta3= new Tinta(ConsoleColor.Red,ETipoTinta.ConBrillo);

      Console.WriteLine("{0}\n{1}\n{2}",Tinta.Mostrar(tinta1), Tinta.Mostrar(tinta2), Tinta.Mostrar(tinta3));

      Tinta tinta4 = new Tinta();

      if(tinta1.Equals(tinta4))
      {
        Console.WriteLine("son iguales");
      }
      else
      {
        Console.WriteLine("no son iguales");
      }

      Tinta tinta5 = tinta1;

      if (tinta1.Equals(tinta5))
      {
        Console.WriteLine("son iguales");
      }
      else
      {
        Console.WriteLine("no son iguales");
      }
      Pluma pluma1 = new Pluma(tinta3,20,"Bic");

      Console.WriteLine(pluma1);

      Console.WriteLine(pluma1==tinta1);

      Console.ReadKey();
    }
  }
}
