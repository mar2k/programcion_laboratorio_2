using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_42
{
    class Program
    {
        static void Main(string[] args)
        {
            MiClase miClase=new MiClase();
            
            try
            {
                miClase.Metodo();
            }
            catch (Exception e)
            {
                if (!object.ReferenceEquals(e.InnerException, null))
                {
                    Exception ex = e;
                    do
                    {
                        Console.WriteLine(ex.Message);
                        ex = ex.InnerException;
                    } while (!object.ReferenceEquals(ex, null));
                }

            }
            Console.ReadKey();
        }
    }
}
