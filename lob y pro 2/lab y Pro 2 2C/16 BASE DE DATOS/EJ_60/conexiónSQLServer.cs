using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EJ_60
{
    public class conexiónSQLServer
    {
        SqlConnection conexion;
        SqlCommand comando;
        

        public conexiónSQLServer(string connectionStr)
        {
            this.conexion = new SqlConnection(connectionStr);
            this.comando = new SqlCommand();
            this.comando.CommandType = System.Data.CommandType.Text;
            this.comando.Connection = conexion;
            this.comando.CommandText="SELECT TOP 10 * FROM [AdventureWorks2012].[Production].[Product]";
        }

        

        public bool Leertabla(out string datos)
        {
            try
            {
                conexion.Open();
                SqlDataReader oDr = this.comando.ExecuteReader();
                datos = "";
                while (oDr.Read())
                {
                    datos += oDr["ProductID"].ToString()+" "+ oDr["Name"].ToString() + " " + oDr["ProductNumber"].ToString() + " " + oDr["MakeFlag"].ToString() + " " + oDr["FinishedGoodsFlag"].ToString() + " " + oDr["Color"].ToString()+"\n";
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            
            return true;
        }

    }
}
