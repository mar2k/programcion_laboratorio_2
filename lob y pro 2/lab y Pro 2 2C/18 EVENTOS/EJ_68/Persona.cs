using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_68
{
    public delegate void DelegadoString(string msg);
    class Persona
    {
        private string nombre;
        private string apellido;       

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                apellido = value;
                this.EventoString(this.Mostrar());
                
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
                this.EventoString(this.Mostrar());
                
            }
        }


        public event DelegadoString EventoString;

        public Persona()
        {
        }

        public string Mostrar()
        {

            StringBuilder datos=new StringBuilder();

            datos.AppendFormat("Nombre: {0} Apellido: {1}", this.nombre,this.apellido);

            return datos.ToString();
        }

    

       
    }
}
