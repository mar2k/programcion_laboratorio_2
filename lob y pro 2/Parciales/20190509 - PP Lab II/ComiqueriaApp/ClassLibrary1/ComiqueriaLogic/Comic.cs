using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic : Producto
    {
        private string autor;
        private  TipoComic tipoComic;

        public Comic(string descripcion, int stock, double precio,string autor,TipoComic tipoComic) : base(descripcion, stock, precio)
        {
            this.tipoComic = tipoComic;
            this.autor = autor;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append(base.ToString());
            retorno.Append("Autor: ");
            retorno.AppendLine(this.autor);
            retorno.Append("Tipo Comic: ");
            retorno.AppendLine(this.tipoComic.ToString());

            return retorno.ToString();
        }

        public enum TipoComic
        {
            Occidental,
            Oriental
        }

    }
}
