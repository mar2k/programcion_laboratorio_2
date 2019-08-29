using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase04
{
    class Cosa
    {
        #region ATRIBUTOS

        public String cadena;
        public Double numero;
        public DateTime fecha;
        
        #endregion

        
        #region COSTRUCTOR


        public Cosa()
        {
            this.cadena = "SIN VALOR";
            this.numero = 1.9;
            this.fecha = DateTime.Now;
        }
        public Cosa(String x) : this()
        {
            this.cadena = x;
            //this.numero = 1.9;
            //this.fecha = DateTime.Now;
        }
        public Cosa(String x, DateTime y) : this(x)
        {
            //this.cadena = x;
            //this.numero = 1.9;
            this.fecha = y;
        }
        public Cosa(String x, DateTime y, Double z) : this(x, y)
        {
            //this.cadena = x;
            this.numero = z;
            //this.fecha = y;
        }


        #endregion

        
        #region METODOS


        static public String mostrar(Cosa miCosa)
        {
            return miCosa.mostrar();
        }
        private String mostrar()
        {
            return this.cadena + "\n" + this.numero.ToString() + "\n" + this.fecha.ToLongDateString();
        }


        #endregion
    }
}
