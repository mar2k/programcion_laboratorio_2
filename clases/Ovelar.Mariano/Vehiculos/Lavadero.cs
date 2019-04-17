using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
  class Lavadero
  {
    private List<Vehiculo> _vehiculos;

    public List<Vehiculo> Vehiculos
    {
      get { return _vehiculos; }
      set { _vehiculos = value; }
    }

    private float _precioAuto;

    public float PrecioAuto
    {
      get { return _precioAuto; }
      set { _precioAuto = value; }
    }

    private float _precioCamion;

    public float PrecioCamion
    {
      get { return _precioCamion; }
      set { _precioCamion = value; }
    }

    private float _precioMoto;

    public float PrecioMoto
    {
      get { return _precioMoto; }
      set { _precioMoto = value; }
    }

    public Lavadero(float pAuto, float pCamion, float pMoto)
    {
      this._precioAuto = pAuto;
      this._precioMoto = pCamion;
      this._precioCamion = pMoto;
    }

    private Lavadero()
    {
      this._vehiculos = new List<Vehiculo>();
    }

    private string MostrarLavadero()
    {
      string retorno = "Precios\nAutos: " + this._precioAuto + " - " + "Camiones: " + this._precioCamion + " - " + "Motos: " + this._precioMoto;

      foreach (Vehiculo vehiculo in this._vehiculos)
      {
        if (vehiculo is Auto)
        {
          retorno += ((Auto)vehiculo).MostrarAuto();
        }
        else if (vehiculo is Moto)
        {
          retorno += ((Moto)vehiculo).MostrarMoto();
        }
        else if (vehiculo is Camion)
        {
          retorno += ((Camion)vehiculo).MostrarCamion();
        }
      }

      return retorno;
    }

    public string MiLabadero
    {
      get { return this.MostrarLavadero(); }
    }

    public static bool operator ==(Lavadero lavadero, Vehiculo vehiculo)
    {
      bool retorno = true;

      foreach(Vehiculo labVeiculo in lavadero.Vehiculos)
      {
        if(labVeiculo==vehiculo)
        {
          retorno = false;
          break;
        }
      }

      return retorno;
    }
    public static bool operator !=(Lavadero lavadero, Vehiculo vehiculo)
    {
      return !(lavadero == vehiculo);
    }
    public static Lavadero operator +(Lavadero lavadero, Vehiculo vehiculo)
    {
      if(lavadero!=vehiculo)
      {
        lavadero._vehiculos.Add(vehiculo);
      }
      return lavadero ;
    }
    public static Lavadero operator -(Lavadero lavadero, Vehiculo vehiculo)
    {
      if (lavadero == vehiculo)
      {
        lavadero._vehiculos.Remove(vehiculo);
      }
      return lavadero;
    }

    private double MostrarTotalFacturado()
    {
      double retorno=0;
      foreach (Vehiculo vehiculo in this._vehiculos)
      {
        if (vehiculo is Auto)
        {
          retorno += this._precioAuto;
        }
        /*else if (vehiculo is Moto)
        {
          retorno = ((Moto)vehiculo).MostrarMoto();
        }
        else if (vehiculo is Camion)
        {
          retorno = ((Camion)vehiculo).MostrarCamion();
        }*/
      }

      return retorno;
    }

    }
}
