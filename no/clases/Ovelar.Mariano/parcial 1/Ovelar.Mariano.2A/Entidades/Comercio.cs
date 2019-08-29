using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comercio
    {
        protected int _cadntidadDeEmpleados;
        protected Comerciante _comerciante;
        protected static Random _generadorDeEmpleados;
        protected String _nombre;
        protected float _precioAlquiler;

        public int CantidadDeEmpleados { get { return this._cadntidadDeEmpleados; } }

        static Comercio()
        {
            Comercio._generadorDeEmpleados = new Random();
            Comercio._generadorDeEmpleados.Next(1, 100);
        }
        public Comercio(float precioAlquiler, string nombreComercio, string nombre, string apellido) : this(nombreComercio,new Comerciante(nombre,apellido),precioAlquiler)
        {

        }
        public Comercio(string nombre, Comerciante comerciante, float precioAlquiler)
        {
            this._nombre = nombre;
            this._comerciante = comerciante;
            this._precioAlquiler = precioAlquiler;
            this._cadntidadDeEmpleados = int.Parse(Comercio._generadorDeEmpleados.ToString());
        }

        public static explicit operator string(Comercio c)
        {
            return "cantidad de empleados: "+c._cadntidadDeEmpleados.ToString() + "\nNombre: "+c._nombre + "\nprecio alquiler: "+c._precioAlquiler.ToString();
        }
        private static string Mostrar(Comercio c)
        {
            return (string)c;
        }
        public static bool operator ==(Comercio a, Comercio b)
        {
            bool retorno = false;
            if (a._nombre == b._nombre && a._comerciante == b._comerciante)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Comercio a, Comercio b)
        {
            return !(a == b);
        }
    }
}
