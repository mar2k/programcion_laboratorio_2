using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.SP
{
  class CajonLlenoException:Exception
  {
    public CajonLlenoException() : base("Cajon Lleno!!!")
    { }
  }
}
