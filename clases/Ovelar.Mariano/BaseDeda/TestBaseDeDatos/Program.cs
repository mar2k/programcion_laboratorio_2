using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDeDatos;
using System.Data.SqlClient;
using System.Data;

namespace TestBaseDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            AccesoDatos a = new AccesoDatos();
            DataTable dataTable = new DataTable();
            List<Persona> lp = new List<Persona>();

            /* lp = a.TraerTodos();

             //Persona p1 = new Persona(1, "jaja", "aaa", 20);
             //a.AgregarPersona(p1);
             //lp = a.TraerTodos();
             /*Persona p1 = new Persona(6, "martines", "rodrigez", 25);
             a.ModificarPersona(p1);
             lp = a.TraerTodos();*/
            /*
                        foreach (Persona item in lp)
                        {
                            Console.WriteLine(item.ToString());
                        }

                        dataTable = a.TraerTablaPersonas();

                        foreach (DataRow item in dataTable.Rows)
                        {
                            Console.WriteLine(item[0].ToString()+"/"+item[1].ToString() + "/" + item[2].ToString() + "/" + item[3].ToString());
                        }
                        dataTable.WriteXmlSchema(@"./personas esquema.xml");//escitura esquema

                        dataTable.WriteXml(@"./personas datos.xml");//escitura datos
                        */

            dataTable.ReadXmlSchema(@"./personas esquema.xml");
            dataTable.ReadXml(@"./personas datos.xml");
            Console.ReadKey();

        }
    }
}
