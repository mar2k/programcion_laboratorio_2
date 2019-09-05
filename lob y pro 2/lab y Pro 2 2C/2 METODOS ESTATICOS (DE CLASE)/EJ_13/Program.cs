using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string Binario = "101";
            double Decimal = 5;

            Console.WriteLine("{0,-10}={1,10}", Binario,Conversor.BinarioDecimal(Binario));
            Console.WriteLine("{0,-10}={1,10}", Decimal,Conversor.DecimalBinario(Decimal));

            Console.ReadKey();
        }
    }
}
