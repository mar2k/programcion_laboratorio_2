using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excepciones
{
  class clase_excepciones
  {

    public clase_excepciones()
    {
      try
      {
        dividir(10, 0);
      }
      catch (Exception e)
      {
        string texto = e.Message + "\ncostructor_1";
        throw new Exception(texto);
      }
    }
    

    public static void dividir(int x,int y)
    {
      try
      {
        int z = x / y;
      }
      catch (DivideByZeroException e)
      {
        string texto = e.Message+ "\nmetodo_1";
       throw new Exception(texto);
      }
    }

  }
}
