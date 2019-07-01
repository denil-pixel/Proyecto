using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source =DESKTOP-9LD220N\\SQLEXPRESS;Initial Catalog=Capo;Integrated Security=True;");
    
       public void logear (string usuario , string contraseña){
           try{
               con.Open();
               SqlCommand cmd = new SqlCommand("SELECT nombre,tipo_usuario FROM usuarios WHERE login = @login AND password = @password ",con);
               cmd.Parameters.AddWithValue("login",usuario);
               cmd.Parameters.AddWithValue("password",contraseña);
               SqlDataAdapter sda = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
               sda.Fill(dt);
               if( dt.Rows.Count ==1){
                   this.Hide();
                   if(dt.Rows[0][1].ToString() == "admin"){
                       new Form2(dt.Rows[0][0].ToString()).Show();

                   }
                  // else if(dt.Rows[0].ToString() == "usuario"){
                    //   new Form3(dt.Rows[0][0].ToString()).Show();
                   }
               else{
                   MessageBox.Show("usuario/contraseña correcta");
               }


           }
           catch(Exception e)
           {
               MessageBox.Show(e.Message);
           }
           finally
           {
               con.Close();
       }
       }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            logear(this.textBox2.Text, this.textBox3.Text);
        }

      


    }
}
