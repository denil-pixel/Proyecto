namespace Login.CapaPRESE
{
    partial class medidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(medidad));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbcategoria = new System.Windows.Forms.ComboBox();
            this.txthombros = new System.Windows.Forms.TextBox();
            this.txtbusto = new System.Windows.Forms.TextBox();
            this.txtcintura = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(593, 174);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.FormattingEnabled = true;
            this.cmbcategoria.Location = new System.Drawing.Point(103, 200);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Size = new System.Drawing.Size(153, 21);
            this.cmbcategoria.TabIndex = 1;
            // 
            // txthombros
            // 
            this.txthombros.Location = new System.Drawing.Point(16, 247);
            this.txthombros.Name = "txthombros";
            this.txthombros.Size = new System.Drawing.Size(179, 20);
            this.txthombros.TabIndex = 1;
            // 
            // txtbusto
            // 
            this.txtbusto.Location = new System.Drawing.Point(201, 247);
            this.txtbusto.Name = "txtbusto";
            this.txtbusto.Size = new System.Drawing.Size(185, 20);
            this.txtbusto.TabIndex = 2;
            // 
            // txtcintura
            // 
            this.txtcintura.Location = new System.Drawing.Point(403, 247);
            this.txtcintura.Name = "txtcintura";
            this.txtcintura.Size = new System.Drawing.Size(198, 20);
            this.txtcintura.TabIndex = 3;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnagregar.Image = ((System.Drawing.Image)(resources.GetObject("btnagregar.Image")));
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnagregar.Location = new System.Drawing.Point(120, 305);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(157, 59);
            this.btnagregar.TabIndex = 4;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.OrangeRed;
            this.btneditar.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.Image")));
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditar.Location = new System.Drawing.Point(310, 305);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(151, 59);
            this.btneditar.TabIndex = 6;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fraterno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hombros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Busto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(453, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cintura";
            // 
            // medidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(613, 367);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtcintura);
            this.Controls.Add(this.txtbusto);
            this.Controls.Add(this.txthombros);
            this.Controls.Add(this.cmbcategoria);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "medidad";
            this.Text = "medidad";
            this.Load += new System.EventHandler(this.medidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbcategoria;
        private System.Windows.Forms.TextBox txthombros;
        private System.Windows.Forms.TextBox txtbusto;
        private System.Windows.Forms.TextBox txtcintura;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}