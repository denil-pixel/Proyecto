using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Login.CapaDatos
{
   public class conexionBd
    {
        static private string CadenaConexion="Data Source =DESKTOP-9LD220N\\SQLEXPRESS;Initial Catalog=Capo;Integrated Security=True;";
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
