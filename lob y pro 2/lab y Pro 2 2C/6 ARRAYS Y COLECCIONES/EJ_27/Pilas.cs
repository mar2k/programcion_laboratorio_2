using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_27
{
  class Pilas
  {
    private Random random;
    public Stack<int> pilasNumeros;

    public Pilas()
    {
      this.pilasNumeros = new Stack<int>();
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
        this.pilasNumeros.Push(this.GeneraNumeroRamdon());
      }
    }

    public bool OrdenarLista(int orden)
    {
      List<int> aux = new List<int>();

      if (orden == 1)
      {
        while (this.pilasNumeros.Count > 0)
        {
          aux.Add(this.pilasNumeros.Pop());
        }
        aux.Sort();
        aux.Reverse();
        foreach (int item in aux)
        {
          this.pilasNumeros.Push(item);
        }
      }
      else
      {
        while (this.pilasNumeros.Count > 0)
        {
          aux.Add(this.pilasNumeros.Pop());
        }
        aux.Sort();
        
        foreach (int item in aux)
        {
          this.pilasNumeros.Push(item);
        }
      }
      return true;
    }
  }
}
