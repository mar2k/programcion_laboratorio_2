using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Clase07;

namespace Ejercicio_clase_07
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.Title = "Ejercicio clase 07";
      Tempera tempera = new Tempera(10, ConsoleColor.Blue, "Vic ");
      Tempera tempera4 = new Tempera(7, ConsoleColor.Blue, "Vic ");
      Tempera tempera2 = new Tempera(50, ConsoleColor.Red, "Vic ");
      Tempera tempera3 = new Tempera(50, ConsoleColor.Red, "Vic ");

      Paleta paleta = 2;
      paleta += tempera;
      paleta -= tempera4;
      
      Console.WriteLine((string)paleta);
      Console.ReadLine();
    }
  }
}
