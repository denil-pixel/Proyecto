using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Login
{
    class Fraterno
    {
        SqlConnection con = new SqlConnection("Data Source =DESKTOP-9LD220N\\SQLEXPRESS;Initial Catalog=Capo;Integrated Security=True;");
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;
        public void conectar()
        {
            try
            {
                con.Open();
                MessageBox.Show("conectado");
            }
            catch
            {
                MessageBox.Show("error al conectar");
            }
            finally
            {
                con.Close();
            }
        }
        public void consulta(string sql, string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, con);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }
        public bool insert(string sql)
        {
            con.Open();
            comando = new SqlCommand(sql, con);
            int i = comando.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable Buscar(string nombre)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select * from fraternos where nombre like '%{0}%'", nombre), con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            con.Close();
            return ds.Tables["tabla"];
        }
        public bool eliminar(string tabla, string condicion)
        {
            con.Open();
            string elimina = "delete from " + tabla + " where " + condicion;
            comando = new SqlCommand(elimina, con);
            int i = comando.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public DataTable listar(string val)
        {
            con.Open();
            string query = val;
            DataTable tb = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(query, con);
            adaptador.Fill(tb);
            con.Close();
            return tb;
        }
        
    }
}
