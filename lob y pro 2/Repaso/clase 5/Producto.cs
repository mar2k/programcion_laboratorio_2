using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_5
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            return "Codigo De Barra: " + p.codigoDeBarra + " Marca: " + p.marca + " Precio: " + p.precio.ToString();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Producto p, string marca)
        {
            bool retorno = false;
            if (!Equals(p, null) && !Equals(marca, null))
            {
                if (p.marca == marca)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            bool retorno = false;
            if (!Equals(p1, null) && !Equals(p2, null))
            {
                if (p1.codigoDeBarra == p2.codigoDeBarra && p1.marca == p2.marca)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.precio = precio;
            this.codigoDeBarra = codigo;
        }


    
    }
}
