using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;

namespace Entidades.Alumnos
{
  public class Persona : PersonaExterna
  {
    /*protected string _nombre;
    protected string _apellido;
    protected int _edad;
    protected ESexo _sexo;*/

    public Persona(string nombre, string apellido, int edad, ESexo sexo) : base(nombre, apellido, edad, ((Externa.ESexo)sexo))
    {

    }

    public string Nombre
    {
      get { return base._nombre;}
    }
    public string Apellido
    {
      get { return base._apellido; }
    }
    public int Edad
    {
      get { return base._edad; }
    }
    public Externa.ESexo Sexo
    {
      get { return base._sexo; }
    }

    public override string ToString()
    {
      return "Nombre:"+this.Nombre+ " Apellido:" + this.Apellido+ " Edad:" + this.Edad.ToString()+ " Sexo:" + this.Sexo.ToString();
    }
  }
}
