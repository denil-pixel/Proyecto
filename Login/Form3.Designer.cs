namespace Login
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellidop = new System.Windows.Forms.TextBox();
            this.txtapellidom = new System.Windows.Forms.TextBox();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(12, 228);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(157, 20);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // txtapellidop
            // 
            this.txtapellidop.Location = new System.Drawing.Point(221, 228);
            this.txtapellidop.Name = "txtapellidop";
            this.txtapellidop.Size = new System.Drawing.Size(146, 20);
            this.txtapellidop.TabIndex = 2;
            this.txtapellidop.TextChanged += new System.EventHandler(this.txtapellidop_TextChanged);
            // 
            // txtapellidom
            // 
            this.txtapellidom.Location = new System.Drawing.Point(425, 228);
            this.txtapellidom.Name = "txtapellidom";
            this.txtapellidom.Size = new System.Drawing.Size(143, 20);
            this.txtapellidom.TabIndex = 3;
            this.txtapellidom.TextChanged += new System.EventHandler(this.txtapellidom_TextChanged);
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(12, 302);
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(100, 20);
            this.txtcelular.TabIndex = 4;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnagregar.Image = ((System.Drawing.Image)(resources.GetObject("btnagregar.Image")));
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnagregar.Location = new System.Drawing.Point(207, 302);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(155, 53);
            this.btnagregar.TabIndex = 5;
            this.btnagregar.Text = "Insertar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(589, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(12, 182);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(229, 20);
            this.txtbuscar.TabIndex = 7;
            this.txtbuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(396, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 53);
            this.button1.TabIndex = 8;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Apellido Paterno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Apellido Materno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(129, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "C.I";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(247, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 54);
            this.button2.TabIndex = 15;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(613, 367);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtcelular);
            this.Controls.Add(this.txtapellidom);
            this.Controls.Add(this.txtapellidop);
            this.Controls.Add(this.txtnombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellidop;
        private System.Windows.Forms.TextBox txtapellidom;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button2;

    }
}