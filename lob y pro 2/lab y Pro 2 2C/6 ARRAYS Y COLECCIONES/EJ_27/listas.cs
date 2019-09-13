using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_27
{
  class Listas
  {
    private Random random;
    public List<int> listaNumeros;

    public Listas()
    {
      this.listaNumeros = new List<int>();
      this.random = new Random();
    }

    private int GeneraNumeroRamdon()
    {
      return this.random.Next(-100, 100);
    }

    public void generarListaRandom(int cantidad)
    {
      for (int i = 0; i < cantidad; i++)
      {
        this.listaNumeros.Add(this.GeneraNumeroRamdon());
      }
    }

    public bool OrdenarLista(int orden)
    {
      List<int> aux = new List<int>();

      if (orden == 1)
      {
        this.listaNumeros.Sort();
      }
      else
      {
        this.listaNumeros.Sort();
        this.listaNumeros.Reverse();
      }


      return true;
    }

  }
}
