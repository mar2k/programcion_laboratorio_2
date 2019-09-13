using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_27
{
  class Colas
  {
    private Random random;
    public Queue<int> colasNumeros;

    public Colas()
    {
      this.colasNumeros = new Queue<int>();
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
        this.colasNumeros.Enqueue(this.GeneraNumeroRamdon());
      }
    }

    public bool OrdenarLista(int orden)
    {
      List<int> aux = new List<int>();

      if (orden == 1)
      {
        while (this.colasNumeros.Count > 0)
        {
          aux.Add(this.colasNumeros.Dequeue());
        }
        aux.Sort();
        foreach (int item in aux)
        {
          this.colasNumeros.Enqueue(item);
        }
      }
      else
      {
        while (this.colasNumeros.Count > 0)
        {
          aux.Add(this.colasNumeros.Dequeue());
        }
        aux.Sort();
        aux.Reverse();
        foreach (int item in aux)
        {
          this.colasNumeros.Enqueue(item);
        }
      }
      return true;
    }
  }
}
