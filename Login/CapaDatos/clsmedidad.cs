using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Login.CapaDatos
{
   public class clsmedidad
    {
        private conexionBd Conexion = new conexionBd();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader Leerfilas;
        public DataTable ListarCategorias()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            //Comando.CommandText = "Select * from fraternos";
            Comando.CommandText = "ListaCategoriasF";
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
          public void Insertar(int id_fraterno, string hombros, string busto, string cintura)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "insertar";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@id_fraterno", id_fraterno);
            Comando.Parameters.AddWithValue("@hombros", hombros);
            Comando.Parameters.AddWithValue("@busto", busto);
            Comando.Parameters.AddWithValue("@cintura", cintura);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();

        }
        public void editar(int id_fraterno, string hombros, string busto, string cintura )
          {
              Comando.Connection = Conexion.AbrirConexion();
              Comando.CommandText = "update medidads set hombros='"+ hombros +"',busto='"+busto+"',cintura='"+cintura+"' where id_fraterno="+id_fraterno;
              Comando.CommandType = CommandType.Text;
              Comando.ExecuteNonQuery();
              Conexion.CerrarConexion();
          }
          public DataTable ListarProductos()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            //Comando.CommandText = "Select * from fraternos";
            Comando.CommandText = "ListarProductos";
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

    }
}
