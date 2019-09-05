using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_5
{
    class Estante
    {
        private Producto[] productos;
        private int ubicacionesEstantes;


        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionesEstantes = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder retorno = new StringBuilder();

            for (int i = 0; i < e.productos.Length; i++)
            {
                retorno.AppendLine(Producto.MostrarProducto(e.productos[i]));
            }

            return retorno.ToString();
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

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }
        public static bool operator ==(Estante e, Producto p)
        {
            bool retorno = false;
            if (!Equals(e, null) && !Equals(p, null))
            {
                foreach (Producto item in e.productos)
                {
                    if (item == p)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            Producto[] listaDeProductos;
            if (!Equals(e, null) && !Equals(p, null))
            {
                if (e == p)
                {
                    listaDeProductos = new Producto[e.productos.Length - 1];
                    int j = 0;
                    for (int i = 0; i < e.productos.Length; i++)
                    {
                        if (e.productos[i] != p)
                        {
                            listaDeProductos[j] = e.productos[i];
                            j++;
                        }
                    }
                    e.productos = listaDeProductos;
                }
            }
            return e;
        }
        public static bool operator +(Estante e, Producto p)
        {
            bool retorno = false;
            if (!(e is null) && !(p is null))
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        retorno = true;
                        break;
                    }
                }

            }
            return retorno;
        }


    }
}
