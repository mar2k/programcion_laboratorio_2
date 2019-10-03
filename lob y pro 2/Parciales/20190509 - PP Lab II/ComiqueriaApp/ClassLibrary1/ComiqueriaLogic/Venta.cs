using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        private DateTime fecha;
        private static int pocentajeIva;
        private double precioFinal;
        private Producto producto;

        internal DateTime Fecha
        {
            get { return this.fecha; }
        }
        static Venta()
        {
            Venta.pocentajeIva = 21;
        }
        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.Vender(cantidad);
        }
        private void Vender(int cantidad)
        {
            this.producto.Stock = this.producto.Stock - cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = Venta.CalcularPrecioFinal(producto.Precio,cantidad);
        }
        public string ObtenerDescripcionBreve()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append("Fecha: ");
            retorno.Append(this.Fecha.ToString());
            retorno.Append(" Descripción: ");
            retorno.Append(this.producto.Descripcion);
            retorno.Append(" Precio Final: ");
            retorno.AppendFormat("{0:#,###.00}", this.precioFinal);


            return retorno.ToString();
        }
        public static double CalcularPrecioFinal(double PrecioUnidad, int cantidad)
        {
            double retorno=0;
            retorno = (PrecioUnidad * cantidad);
            retorno = retorno+(retorno*(Venta.pocentajeIva/100.0));
            return retorno;
        }
    }
}
