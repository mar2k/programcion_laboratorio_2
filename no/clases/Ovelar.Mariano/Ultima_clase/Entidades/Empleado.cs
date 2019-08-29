using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Empleado
  {
    private float _sueldo;

    private int _legajo;

    private string _nombre;

    public string Nombre
    {
      get { return this._nombre; }
      set { this._nombre = value; }
    }

    //public event DelegadoSueldo(Empleado)

    public int Legajo
    {
      get { return this._legajo; }
      set { this._legajo = value; }
    }


    public float Sueldo
    {
      get { return this._sueldo; }
      set { this._sueldo = value; }
    }

    public Empleado(string nombre, int legajo, float sueldo)
    {
      Nombre = nombre;
      Legajo = legajo;
      Sueldo = sueldo;
    }
  }
}
