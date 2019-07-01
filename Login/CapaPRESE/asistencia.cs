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
   
    public partial class asistencia : Form
    {
        clsasistencia objProducto = new clsasistencia();
        public asistencia()
        {
            InitializeComponent();
        }

        private void asistencia_Load(object sender, EventArgs e)
        {
            ListarCategorias();
            listar();
            
        }
        private void ListarCategorias()
        {
            clsasistencia objProd = new clsasistencia();
            cmbcategoria.DataSource = objProd.ListarCategorias();
            cmbcategoria.DisplayMember = "nombre";
            cmbcategoria.ValueMember = "id";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                objProducto.Insertar(Convert.ToInt16(cmbcategoria.SelectedValue),Convert.ToDateTime(txtfecha.Text));
                MessageBox.Show("insertado correctamente");
                listar();

            }

           
         //   listar();

        public void listar()
        {
            clsasistencia objPro = new clsasistencia();
            dataGridView1.DataSource = objPro.ListarProductos();
        }

        private void txtfecha_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtfecha, "");
            if (!clsasistencia.EsFecha(txtfecha.Text))
            {
                errorProvider1.SetError(txtfecha, "Ingresar formato correcto");
            }
        }
      
        }
    }

