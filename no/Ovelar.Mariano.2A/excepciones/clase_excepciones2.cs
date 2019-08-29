using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excepciones
{
  class clase_excepciones2
  {
    public clase_excepciones2()
    {
      try
      {
        new clase_excepciones();
      }
      catch (Exception e)
      {
        string texto = e.Message + "\ncostructor_2";
        Exception UnaException = new Exception(texto);
        throw UnaException;
      }
    }

    public static void MetodoExcepciones()
    {
      try
      {
        new clase_excepciones2();
      }
      catch (Exception e)
      {
        string texto = e.Message + "\nmetodo_2";
        Exception MiException = new Exception(texto);
        throw MiException;
      }
    }
  }
}
