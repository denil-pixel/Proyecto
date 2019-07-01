using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Login
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
           
        }
       Fraterno con = new Fraterno();
       public void mostrarDatos()
       {
           con.consulta("select * from fraternos", "fraternos");
           dataGridView1.DataSource = con.ds.Tables["fraternos"];
       }

       private void Form3_Load(object sender, EventArgs e)
       {
           mostrarDatos();
       }

       private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
       {
           DataGridViewRow dgv = dataGridView1.Rows[e.RowIndex];
           txtnombre.Text = dgv.Cells[0].Value.ToString();
           txtapellidop.Text = dgv.Cells[1].Value.ToString();
           txtapellidom.Text = dgv.Cells[2].Value.ToString();
           txtcelular.Text = dgv.Cells[3].Value.ToString();
          // txtprecio.Text = dgv.Cells[4].Value.ToString();
       }

       private void btnagregar_Click(object sender, EventArgs e)
       {
           string agregar = "insert into fraternos values ('" + txtnombre.Text + "','" + txtapellidop.Text + "','" + txtapellidom.Text + "','" + txtcelular.Text + "')";
           //string agregar = "insert into product values ('" + txtnombre.Text + "','" + txtcategoria.Text + "','" + txtcantidad.Text + "', '" + txtfecha.Text + "','" + txtprecio.Text + "')";
           //  string agregar = "insert into grupo values ( "+dataGridView1)";
           if (con.insert(agregar))
           {
               MessageBox.Show("datos agregados");
               mostrarDatos();
           }
           else
           {
               MessageBox.Show("error al agregar");
           }
       }

       private void textBox1_TextChanged(object sender, EventArgs e)
       {
           if (txtbuscar.Text != "") dataGridView1.DataSource = con.Buscar(txtbuscar.Text);
           else mostrarDatos();
       }

       private void button1_Click(object sender, EventArgs e)
       {
           dataGridView1.DataSource = con.listar("select * from fraternos");
       }

       private void txtnombre_TextChanged(object sender, EventArgs e)
       {
           this.errorProvider1.SetError(txtnombre, Regex.IsMatch(txtnombre.Text, "^[a-zA-Z]*$") ? "" : "No tiene solo letras");
       }

       private void txtapellidop_TextChanged(object sender, EventArgs e)
       {
           this.errorProvider1.SetError(txtapellidop, Regex.IsMatch(txtapellidop.Text, "^[a-zA-Z]*$") ? "" : "No tiene solo letras");
       }

       private void txtapellidom_TextChanged(object sender, EventArgs e)
       {
           this.errorProvider1.SetError(txtapellidom, Regex.IsMatch(txtapellidom.Text, "^[a-zA-Z]*$") ? "" : "No tiene solo letras");
       }

      


    }
}
