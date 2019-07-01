using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Login.CapaDatos;

namespace Login.CapaPRESE
{
    public partial class medidad : Form
    {
        clsmedidad objProducto = new clsmedidad();
        public medidad()
        {
            InitializeComponent();
        }
        string Operacion = "Insertar";
        string id;
        private void medidad_Load(object sender, EventArgs e)
        {
            ListarCategorias();
            listar();
        }
        private void ListarCategorias()
        {
            clsmedidad objProd = new clsmedidad();
            cmbcategoria.DataSource = objProd.ListarCategorias();
            cmbcategoria.DisplayMember = "nombre";
            cmbcategoria.ValueMember = "id";

        }
      
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (Operacion == "Insertar")
            {
                objProducto.Insertar(Convert.ToInt16(cmbcategoria.SelectedValue), txthombros.Text, txtbusto.Text, txtcintura.Text);
                MessageBox.Show("insertado correctamente");
            }
            else if (Operacion == "editar")
            {
                objProducto.editar(Convert.ToInt32(cmbcategoria.SelectedValue), txthombros.Text, txtbusto.Text, txtbusto.Text);
              //  Operacion = "Insertar";
                MessageBox.Show("se edito correctamente");
            }
               listar();
        }
        private void listar()
        {
            clsmedidad objPro = new clsmedidad();
            dataGridView1.DataSource = objPro.ListarProductos();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Operacion = "Editar";
                cmbcategoria.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                txthombros.Text = dataGridView1.CurrentRow.Cells["hombros"].Value.ToString();
                txtbusto.Text = dataGridView1.CurrentRow.Cells["busto"].Value.ToString();
                txtcintura.Text = dataGridView1.CurrentRow.Cells["cintura"].Value.ToString();
                id = dataGridView1.CurrentRow.Cells["id_fraterno"].Value.ToString();
            }
            else
                MessageBox.Show("debe seleccionar una fila");
        }
    }
}
