using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Login.CapaDatos
{
   public  class clsasistencia
    {
        private conexionBd Conexion = new conexionBd();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader Leerfilas;
        public DataTable ListarCategorias()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            //Comando.CommandText = "Select * from fraternos";
            Comando.CommandText = "ListaP";
            Comando.CommandType = CommandType.StoredProcedure;
            Leerfilas = Comando.ExecuteReader();
            Tabla.Load(Leerfilas);
            Leerfilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
            Tabla.Load(Leerfilas);
            Leerfilas.Close();
            Conexion.CerrarConexion();
            return Tabla;


        }
        public void Insertar(int id_fraterno,DateTime fecha)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "insertarA";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@id_fraterno", id_fraterno);
            Comando.Parameters.AddWithValue("@fecha", fecha);
        
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();

        }
      
        public DataTable ListarProductos()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            //Comando.CommandText = "Select * from fraternos";
            Comando.CommandText = "listarAS";
            Comando.CommandType = CommandType.StoredProcedure;
            Leerfilas = Comando.ExecuteReader();
            Tabla.Load(Leerfilas);
            Leerfilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
            Tabla.Load(Leerfilas);
            Leerfilas.Close();
            Conexion.CerrarConexion();
            return Tabla;


        }
        public static Boolean EsFecha(String fecha)
        {
            try
            {
                DateTime.Parse(fecha);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
