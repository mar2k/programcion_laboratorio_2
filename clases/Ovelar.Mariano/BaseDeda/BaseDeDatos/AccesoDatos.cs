using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BaseDeDatos
{
    public class AccesoDatos
    {
        private SqlConnection _conecion;
        private SqlCommand _comando;

        public AccesoDatos()
        {
            this._conecion = new SqlConnection(Properties.Settings.Default.conecion_bd);
        }

        public List<Persona> TraerTodos()
        {
            List<Persona> listaPersona = new List<Persona>();
            this._comando = new SqlCommand();

            this._comando.Connection = this._conecion;

            this._comando.CommandType = CommandType.Text;
            this._comando.CommandText = "SELECT id  ,nombre  ,apellido  ,edad  FROM[Padron].[dbo].[Personas] ";
            try
            {
                this._conecion.Open();
                SqlDataReader dataReader = this._comando.ExecuteReader();
                while (dataReader.Read())
                {
                    listaPersona.Add(new Persona((int)dataReader["id"], dataReader["nombre"].ToString(), dataReader["apellido"].ToString(), (int)dataReader["edad"]));
                }
                this._conecion.Close();
            }
            catch (Exception)
            {

            }
            return listaPersona;
        }

        public bool AgregarPersona(Persona p)
        {
            /*INSERT INTO [Padron].[dbo].[Personas]
        (nombre, apellido, edad)
VALUES('Q','Y',12),('R','R',10)*/
            bool retorno = false;
            
            List<Persona> listaPersona = new List<Persona>();
            this._comando = new SqlCommand();

            this._comando.Connection = this._conecion;

            this._comando.CommandType = CommandType.Text;
            this._comando.CommandText = "INSERT INTO [Padron].[dbo].[Personas](nombre, apellido, edad) VALUES ('" + p.nombre + "','" + p.apellido + "'," + p.edad.ToString() + ")";

            try
            {
                this._conecion.Open();
                int aux = this._comando.ExecuteNonQuery();

                if(aux>0)
                {
                    retorno=true;
                }

                this._conecion.Close();
            }
            catch (Exception)
            {
                return retorno;
            }

            return retorno; 
        }

        public bool ModificarPersona(Persona p)
        {
            bool retorno = false;
            List<Persona> listaPersona = new List<Persona>();
            this._comando = new SqlCommand();

            this._comando.Connection = this._conecion;

            this._comando.CommandType = CommandType.Text;
            //this._comando.CommandText = "UPDATE [Padron].[dbo].[Personas] SET (nombre'" + p.nombre + "','" +",apellido'" + p.nombre + ", edad '" + p.nombre +) VALUES ('" + p.nombre + "','" + p.apellido + "'," + p.edad.ToString() + ")WHERE id =" +p.id.ToString();
            try
            {
                this._conecion.Open();
                int aux = this._comando.ExecuteNonQuery();

                if (aux > 0)
                {
                    retorno = true;
                }

                this._conecion.Close();
            }
            catch (Exception )
            {
                return retorno;
            }
            return retorno;
        }


        public DataTable TraerTablaPersonas()
        {
            DataTable dataTable = new DataTable("Personas");

            this._comando = new SqlCommand();

            this._comando.Connection = this._conecion;

            this._comando.CommandType = CommandType.Text;
            this._comando.CommandText = "SELECT id  ,nombre  ,apellido  ,edad  FROM[Padron].[dbo].[Personas] ";
            try
            {
                this._conecion.Open();
                SqlDataReader dataReader = this._comando.ExecuteReader();
                dataTable.Load(dataReader);
                
                this._conecion.Close();
            }
            catch (Exception)
            {

            }
            return dataTable;
        }


    }
}
