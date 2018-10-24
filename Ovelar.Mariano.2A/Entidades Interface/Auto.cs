using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Interface
{
    public abstract class Auto : Veiculo
    {
        protected string _patente;

        public Auto(double precio,string patente) : base(precio)
        {
            this._patente = patente;
        }

        public abstract string Patente { get; }

        public void MostrarPatente()
        {
            Console.WriteLine(this._patente);
        }
        
    }
}
