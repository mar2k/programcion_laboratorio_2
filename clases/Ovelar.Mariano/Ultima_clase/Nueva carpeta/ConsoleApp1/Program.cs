using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Alumnos;
using Entidades.Externa.Sellada;
namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      Persona persona = new Persona("Mariano", "Ovelar", 20,ESexo.Masculino);
      PersonaExternaSellada a = new PersonaExternaSellada("Mariano", "Ovelar", 20, Entidades.Externa.Sellada.ESexo.Masculino);
      
    }
  }
}
