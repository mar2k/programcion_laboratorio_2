using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;

        public Producto this[Guid codigo]
        {
            get
            {
                Producto producto = null;
                foreach (Producto item in this.productos)
                {
                    if (codigo == (Guid)item)
                    {
                        producto = item;
                        break;
                    }
                }
                return producto;
            }
        }

        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }

        public Dictionary<Guid, string> ListarProductos()
        {
            Dictionary<Guid, string> dicDeProductos=new Dictionary<Guid, string>();
            
            foreach (Producto item in this.productos)
            {
                dicDeProductos.Add(((Guid)item), item.Descripcion);
            }

            return dicDeProductos;

        }
        public string ListarVentas()
        {
            StringBuilder retorno = new StringBuilder();

            foreach (Venta item in this.ventas)
            {
                retorno.AppendLine(item.ObtenerDescripcionBreve());
            }

            return retorno.ToString();
        }

        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            bool retorno = false;
            if (!(comiqueria is null) && !(producto is null))
            {
                foreach (Producto item in comiqueria.productos)
                {
                    if (item.Descripcion == producto.Descripcion)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }
        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }
        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if (!(comiqueria is null) && !(producto is null))
            {
                if (comiqueria != producto)
                {
                    comiqueria.productos.Add(producto);
                }
            }
            return comiqueria;
        }
        public void Vender(Producto producto)
        {
            this.Vender(producto, 1);
        }
        public void Vender(Producto producto, int cantidad)
        {
            if (!(producto is null) && cantidad >= 0)
            {
                this.ventas.Add(new Venta(producto, cantidad));
            }
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
