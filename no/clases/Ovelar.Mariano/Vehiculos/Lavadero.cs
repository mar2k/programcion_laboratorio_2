using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Lavadero
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
                retorno += vehiculo.ToString();
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

            foreach (Vehiculo labVeiculo in lavadero.Vehiculos)
            {
                if (labVeiculo == vehiculo)
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
            if (lavadero != vehiculo)
            {
                lavadero._vehiculos.Add(vehiculo);
            }
            return lavadero;
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
            double total = 0;
            double totalAuto = 0;
            double totalCamion = 0;
            double totalMoto = 0;

            totalAuto += this.MostrarTotalFacturado(EVehiculos.Auto);
            totalMoto += this.MostrarTotalFacturado(EVehiculos.Moto);
            totalCamion += this.MostrarTotalFacturado(EVehiculos.Camion);

            total = totalAuto + totalCamion + totalMoto;

            return total;
        }
        private double MostrarTotalFacturado(EVehiculos vehiculo)
        {
            double total = 0;

            foreach (Vehiculo item in this.Vehiculos)
            {
                if (EVehiculos.Auto == vehiculo)
                {

                    if (item is Auto)
                    {
                        total += this._precioAuto;
                    }

                }
                else if (EVehiculos.Moto == vehiculo)
                {
                    if (item is Moto)
                    {
                        total += this._precioMoto;
                    }
                }
                else if (EVehiculos.Camion == vehiculo)
                {
                    if (item is Camion)
                    {
                        total += this._precioCamion;
                    }
                }


            }
            return total;

        }
        public static int OrdenarVehiculosPorPatente(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return string.Compare(vehiculo1.Patente, vehiculo2.Patente);
        }
        public int OrdenarVehiculosPorMarca(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return string.Compare(vehiculo1.Marca.ToString(), vehiculo2.Marca.ToString());
        }

    }
}
