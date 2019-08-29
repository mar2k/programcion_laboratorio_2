using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase04.Entidades
{
    public class Cosa
    {
        public int entero;
        public string cadena;
        public DateTime fecha;

        public Cosa()
        {
            this.entero = 10;
            this.cadena = "SIN VALOR";
            this.fecha = DateTime.Now;
        }
        public Cosa(int valorInt) : this()
        {
            this.entero = valorInt;
        }
        public Cosa(int valorInt, DateTime valorFecha) : this(valorInt)
        {
            this.fecha = valorFecha;
        }
        public Cosa(int valorInt, DateTime valorFecha, string valorString) : this(valorInt, valorFecha)
        {
            this.cadena = valorString;
        }
        
        public string Mostrar()
        {
            return this.entero.ToString() + "-" + this.cadena + "-" + this.fecha.ToString();
        }

        public static string Mostrar(Cosa laCosa)
        {
            return laCosa.Mostrar();
        }

        public void Establecervalor(int valor)
        {
            this.entero = valor;
        }
        public void Establecervalor(string valor)
        {
            this.cadena = valor;
        }
        public void Establecervalor(DateTime valor)
        {
            this.fecha = valor;
        }


    }
}
