using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_16
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;


        public void CalcularFinal()
        {
            Random numRandom = new Random();
            if (nota1 >= 4 && nota2 >= 4)
            {
                this.notaFinal = numRandom.Next(1, 10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }
        public string Mostrar()
        {
            string info="";

            info = "Legajo: " + this.legajo.ToString() + " Nombre: " + this.nombre + " Apellido: " + this.apellido + " Nota Uno: " + this.nota1.ToString() + " Nota Dos: " + this.nota2.ToString();
            if(this.notaFinal!=-1)
            {
                info = info + "\nNota Final: " + this.notaFinal.ToString();
            }
            else
            {
                info = info + "\nAlumno Desaprobado";
            }
            return info;
        }
    }
}
