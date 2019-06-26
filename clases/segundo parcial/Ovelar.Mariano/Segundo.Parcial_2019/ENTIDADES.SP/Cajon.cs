using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ENTIDADES.SP
{
  public class Cajon<T> : ISerializar, IDeserializar
  {
    protected int _capacidad;
    protected static List<T> _elementos;
    protected double _precioUnitario;

    static List<T> Elementos
    {
      get { return Cajon<T>._elementos; }
    }

    public double PrecioTotal
    {
      get
      {
        return Cajon<T>._elementos.Count * this._precioUnitario;
      }
    }


    public Cajon()
    {
      Cajon<T>._elementos = new List<T>();
    }

    public Cajon(int capacidad) : this()
    {
      this._capacidad = capacidad;
    }

    public Cajon(double precioUnitario, int capacidad) : this(capacidad)
    {
      this._precioUnitario = precioUnitario;
    }

    public override string ToString()
    {
      string retorno = "cantidad total de elementos: " + Cajon<T>._elementos.Count.ToString() + " capacidad: " + this._capacidad + " precio total: " + this.PrecioTotal.ToString() + "\nlistado de todos los elementos:\n";

      foreach (T item in Cajon<T>._elementos)
      {
        retorno += item.ToString() + "\n";
      }
      return retorno;
    }

    public bool Xml(string archivo)
    {
      bool retorno = true;
      try
      {
        StreamWriter sw = new StreamWriter(archivo);
        sw.WriteLine(Cajon<T>._elementos);
        sw.Close();
      }
      catch (Exception e)
      {
        retorno = false;
        throw e;
      }
      return retorno;
    }

    public bool Xml(string archivo, out Fruta fruta)
    {
      throw new NotImplementedException();
    }

    public static Cajon<T> operator +(Cajon<T> cajon, T elemento)
    {
      try
      {
        if (cajon._capacidad > Cajon<T>._elementos.Count)
        {
          Cajon<T>._elementos.Add(elemento);
        }
        else
        {
          throw new CajonLlenoException();
        }
         
      }
      catch (CajonLlenoException e)
      {
        Console.WriteLine(e.Message);
      }

      return cajon;
    }


  }
}
