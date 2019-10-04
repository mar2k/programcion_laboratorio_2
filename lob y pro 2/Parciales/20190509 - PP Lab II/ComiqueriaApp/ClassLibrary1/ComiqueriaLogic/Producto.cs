using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        public string Descripcion
        {
            get
            {
                if (this.descripcion is null)
                {
                    this.descripcion = "";
                }
                return this.descripcion;
            }
        }
        public double Precio
        {
            get
            {
                if (this.precio == 0)
                {
                    this.precio = 0;
                }
                return this.precio;
            }
        }
        public int Stock
        {
            get
            { return this.stock; }
            set
            {
                if (value >= 0)
                {
                    this.stock = value;
                }
            }
        }

        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }
        protected Producto(string descripcion, int stock, double precio)
        {
            this.stock = stock;
            this.precio = precio;
            this.descripcion = descripcion;
            this.codigo = Guid.NewGuid();
        }
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append("Descripcion: ");
            retorno.AppendLine(this.Descripcion);
            retorno.Append("Código: ");
            retorno.AppendLine(this.codigo.ToString());
            retorno.Append("Precio: $");
            retorno.AppendLine(this.Descripcion);
            retorno.Append("Stock: ");
            retorno.Append(this.Descripcion);
            retorno.AppendLine(" Unidades");

            return retorno.ToString();
        }
    }
}
