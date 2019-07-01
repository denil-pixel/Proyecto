using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Login.CapaPRESE;

namespace Login
{
    public partial class Form2 : Form
    {
        public Form2(string nombre)
        {
            InitializeComponent();
          //  lblmensaje.Text = nombre;
        }
        private void AbrirFor(object form)
        {
            if (this.panelcontainer.Controls.Count > 0)
                this.panelcontainer.Controls.RemoveAt(0);
            Form3 fh = form as Form3;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontainer.Controls.Add(fh);
            this.panelcontainer.Tag = fh;
            fh.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
          //  Form3 fr = new Form3();
            AbrirFor(new Form3());
            //fr.Show();

        }
         //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(64, 64, 64));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            //base.OnPaint(e);
            //ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent , sizeGripRectangle);
        }



  //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



 //METODO PARA ABRIR FORM DENTRO DE PANEL-----------------------------------------------------
         private void AbrirFormEnPanel<Forms>()where Forms  : Form,new ()
        {
            Form formulario;
            formulario = panelContenedor.Controls.OfType<Forms>().FirstOrDefault();

            //si el formulario/instancia no existe, creamos nueva instancia y mostramos
            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                //formulario.FormBorderStyle = FormBorderStyle.None;
                //formulario.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();

                formulario.BringToFront();
                // formulario.FormClosed += new FormClosedEventHandler(CloseForms);               
            }
            else {
             
                //si la Formulario/instancia existe, lo traemos a frente
                formulario.BringToFront();

                //Si la instancia esta minimizada mostramos
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }
               
            }
        }

   private void CloseForms(object sender,FormClosedEventArgs e) {
            if (Application.OpenForms["Form1"] == null)
                button1.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form2"] == null)
                button2.BackColor = Color.FromArgb(4, 41, 68);
           // if (Application.OpenForms["Form3"] == null)
               // button3.BackColor = Color.FromArgb(4, 41, 68);
        }

   private void AbrirFori(object form)
   {
       if (this.panelcontainer.Controls.Count > 0)
           this.panelcontainer.Controls.RemoveAt(0);
       medidad fh = new medidad();
       fh.TopLevel = false;
       fh.Dock = DockStyle.Fill;
       this.panelcontainer.Controls.Add(fh);
       this.panelcontainer.Tag = fh;
       fh.Show();
   }
        private void button2_Click(object sender, EventArgs e)
        {
          // medidad frt = new medidad();
          //  frt.ShowDialog();
            AbrirFori(new medidad());
        }
        private void AbrirForit(object form)
        {
            if (this.panelcontainer.Controls.Count > 0)
                this.panelcontainer.Controls.RemoveAt(0);
            asistencia fhi = new asistencia();
            fhi.TopLevel = false;
            fhi.Dock = DockStyle.Fill;
            this.panelcontainer.Controls.Add(fhi);
            this.panelcontainer.Tag = fhi;
            fhi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // asistencia fru = new asistencia();
          //  fru.ShowDialog();
            AbrirForit(new asistencia());
        }
    }
}
