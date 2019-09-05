using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_17
{
  class Program
  {
    static void Main(string[] args)
    {
      Bolígrafo bolígrafo1 = new Bolígrafo(100, ConsoleColor.Blue);
      Bolígrafo bolígrafo2 = new Bolígrafo(5, ConsoleColor.Red);
      string dibujo1;
      string dibujo2;
      short tintaParaDibujar1 = 10;
      short tintaParaDibujar2 = 8;

      bolígrafo1.Pintar(tintaParaDibujar1, out dibujo1);
      bolígrafo2.Pintar(tintaParaDibujar2, out dibujo2);

      Console.WriteLine("GetColor \nBoloigrado1: {0} \nBoloigrado2: {1}", bolígrafo1.GetColor(), bolígrafo2.GetColor());
      Console.WriteLine("\n----------------------------------\n");

      Console.WriteLine("GetTinta \nBoloigrado1: {0} \nBoloigrado2: {1}", bolígrafo1.GetTinta(), bolígrafo2.GetTinta());
      Console.WriteLine("\n----------------------------------\n");

      Console.WriteLine("Pintar \nBoloigrado1: \nTinta que se quiere usar:{1} dibujo:{0}  \nBoloigrado2: \nTinta que se quiere usar:{3} dibujo:{2} ", dibujo1, tintaParaDibujar1, dibujo2, tintaParaDibujar2);
      Console.WriteLine("\n----------------------------------\n");

      bolígrafo1.Recargar();

      Console.WriteLine("Recargar Boligrafo1 \nBoloigrado1: {0} \nBoloigrado2: {1}", bolígrafo1.GetTinta(), bolígrafo2.GetTinta());
      Console.WriteLine("\n----------------------------------\n");

      Console.ReadKey();
    }
  }
}
