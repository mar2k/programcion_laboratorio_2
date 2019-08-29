using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio_01";

      int numMax = 5;
      int acum = 0;
      int auxNum = 0;
      int max = 0;
      int min = 0;
      double promedio;
      int i=0;

      for(i=0;i<numMax;i++)
      {
        Console.Write("{0}_INGRESE NUMERO: ",i+1);
        auxNum = int.Parse(Console.ReadLine());
        acum += auxNum;
        if (i==0)
        {
          max = auxNum;
          min = auxNum;
        }
        else
        {
          if(max < auxNum)
          {
            max = auxNum;
          }
          else if(min > auxNum)
          {
            min = auxNum;
          }
        }
      }

      promedio = (double) acum / numMax;

      Console.Write("\nPROMEDIO: {0:N} \nMAXIMO: {1}\nMINIMO: {2}\n", promedio, max, min);

      Console.ReadKey();

    }
  }
}
