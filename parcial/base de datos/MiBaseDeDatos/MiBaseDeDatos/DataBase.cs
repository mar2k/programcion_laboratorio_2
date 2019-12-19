using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MiBaseDeDatos
{
    public class DataBase
    {
        private string conexionDataBase;
        private SqlConnection conexion;
        private DataSet dataSet;
        private SqlCommandBuilder comandoBuilder;
        private SqlDataAdapter dataAdapter;
        private SqlCommand comando;

        public DataBase(string serverName, string dataBaseName)
        {
            this.conexionDataBase = "Data Source=" + serverName + ";Initial Catalog=" + dataBaseName + ";Integrated Security=true";
            this.conexion = new SqlConnection(conexionDataBase);
            this.dataSet = new DataSet();
        }
        private bool Abrir()
        {
            try
            {
                this.conexion.Open();
                Console.WriteLine("\nConexion abierta");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("\nError al abrir La base de datos\n" + e.Message);
                return false;
            }
        }
        private void Cerrar()
        {
            this.conexion.Close();
            Console.WriteLine("\nConexion Cerrada");
        }

        public void consulta(string sql, string tabla)
        {
            this.dataSet.Tables.Clear();
            this.dataAdapter = new SqlDataAdapter(sql, this.conexion);
            this.comandoBuilder = new SqlCommandBuilder(this.dataAdapter);
            this.dataAdapter.Fill(dataSet, tabla);
        }

        //"DELETE FROM Personas WHERE id = 1";
        public bool Eliminar(string tabla, string condicion)
        {
            bool retornar = false;
            if (this.Abrir())
            {
                string sql = "DELETE FROM " + tabla + " WHERE " + condicion;
                this.comando = new SqlCommand(sql, this.conexion);
                int i = comando.ExecuteNonQuery();
                this.Cerrar();
                if (i > 0)
                {
                    retornar = true;
                }
            }

            return retornar;
        }
        //"UPDATE Personas SET nombre = 'Fer' WHERE id = 1";
        public bool Actualizar(string tabla, string campos, string conditon)
        {
            bool retornar = false;

            if (this.Abrir())
            {
                string sql = "UPDATE " + tabla + " SET " + campos + " WHERE " + conditon;
                this.comando = new SqlCommand(sql, conexion);
                int i = comando.ExecuteNonQuery();
                this.Cerrar();
                if (i > 0)
                {
                    retornar = true;
                }
            }
            return retornar;
        }

        //SELECT TOP(1000) [patente],[tipo] FROM[patentes - sp - 2018].[dbo].[Patentes]
        public DataTable consulta(string tabla)
        {
            string sql = "SELECT * FROM" + tabla;
            this.dataAdapter = new SqlDataAdapter(sql, this.conexion);
            DataSet datos = new DataSet();
            dataAdapter.Fill(datos, tabla);
            DataTable dt = new DataTable();
            dt = datos.Tables[tabla];
            return dt;
        }

        //"INSERT INTO Personas (nombre,apellido)  VALUES('Pedro','Diaz')";
        public bool Insertar(string tabla, string campos, string valor)
        {
            bool retornar = false;
            if (this.Abrir())
            {
                string sql = "INSERT INTO " + tabla + " (" + campos + ") VALUES(" + valor + ")";
                this.comando = new SqlCommand(sql, this.conexion);
                int i = comando.ExecuteNonQuery();
                this.Cerrar();
                if (i > 0)
                {
                    retornar = true;
                }
            }
            return retornar;
        }

    }
}
