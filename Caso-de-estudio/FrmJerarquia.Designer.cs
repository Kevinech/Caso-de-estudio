namespace Caso_de_estudio
{
    partial class FrmJerarquia
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tvPuestos = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.tbPuesto = new System.Windows.Forms.TextBox();
            this.btnBusquedaP = new System.Windows.Forms.Button();
            this.btnConteoP = new System.Windows.Forms.Button();
            this.btnNiveles = new System.Windows.Forms.Button();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.lbOrden = new System.Windows.Forms.ListBox();
            this.btnRecorridoP = new System.Windows.Forms.Button();
            this.btnRecorridoO = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvPuestos
            // 
            this.tvPuestos.Location = new System.Drawing.Point(75, 148);
            this.tvPuestos.Name = "tvPuestos";
            this.tvPuestos.Size = new System.Drawing.Size(413, 355);
            this.tvPuestos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puesto:";
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Location = new System.Drawing.Point(6, 14);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(88, 41);
            this.btnAgregarP.TabIndex = 2;
            this.btnAgregarP.Text = "Agregar";
            this.btnAgregarP.UseVisualStyleBackColor = true;
            this.btnAgregarP.Click += new System.EventHandler(this.btnAgregarP_Click);
            // 
            // tbPuesto
            // 
            this.tbPuesto.Location = new System.Drawing.Point(75, 116);
            this.tbPuesto.Name = "tbPuesto";
            this.tbPuesto.Size = new System.Drawing.Size(413, 26);
            this.tbPuesto.TabIndex = 3;
            // 
            // btnBusquedaP
            // 
            this.btnBusquedaP.Location = new System.Drawing.Point(6, 104);
            this.btnBusquedaP.Name = "btnBusquedaP";
            this.btnBusquedaP.Size = new System.Drawing.Size(88, 39);
            this.btnBusquedaP.TabIndex = 4;
            this.btnBusquedaP.Text = "Buscar";
            this.btnBusquedaP.UseVisualStyleBackColor = true;
            this.btnBusquedaP.Click += new System.EventHandler(this.btnBusquedaP_Click);
            // 
            // btnConteoP
            // 
            this.btnConteoP.Location = new System.Drawing.Point(6, 197);
            this.btnConteoP.Name = "btnConteoP";
            this.btnConteoP.Size = new System.Drawing.Size(88, 44);
            this.btnConteoP.TabIndex = 5;
            this.btnConteoP.Text = "Conteo";
            this.btnConteoP.UseVisualStyleBackColor = true;
            this.btnConteoP.Click += new System.EventHandler(this.btnConteoP_Click);
            // 
            // btnNiveles
            // 
            this.btnNiveles.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnNiveles.Location = new System.Drawing.Point(6, 149);
            this.btnNiveles.Name = "btnNiveles";
            this.btnNiveles.Size = new System.Drawing.Size(88, 42);
            this.btnNiveles.TabIndex = 6;
            this.btnNiveles.Text = "Niveles";
            this.btnNiveles.UseVisualStyleBackColor = true;
            this.btnNiveles.Click += new System.EventHandler(this.btnNiveles_Click);
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.Location = new System.Drawing.Point(6, 61);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(88, 37);
            this.btnEliminarP.TabIndex = 7;
            this.btnEliminarP.Text = "Eliminar";
            this.btnEliminarP.UseVisualStyleBackColor = true;
            this.btnEliminarP.Click += new System.EventHandler(this.btnEliminarP_Click);
            // 
            // lbOrden
            // 
            this.lbOrden.FormattingEnabled = true;
            this.lbOrden.ItemHeight = 20;
            this.lbOrden.Location = new System.Drawing.Point(734, 116);
            this.lbOrden.Name = "lbOrden";
            this.lbOrden.Size = new System.Drawing.Size(377, 344);
            this.lbOrden.TabIndex = 9;
            // 
            // btnRecorridoP
            // 
            this.btnRecorridoP.Location = new System.Drawing.Point(4, 25);
            this.btnRecorridoP.Name = "btnRecorridoP";
            this.btnRecorridoP.Size = new System.Drawing.Size(97, 40);
            this.btnRecorridoP.TabIndex = 10;
            this.btnRecorridoP.Text = "Preorden";
            this.btnRecorridoP.UseVisualStyleBackColor = true;
            this.btnRecorridoP.Click += new System.EventHandler(this.btnRecorridoP_Click);
            // 
            // btnRecorridoO
            // 
            this.btnRecorridoO.Location = new System.Drawing.Point(6, 77);
            this.btnRecorridoO.Name = "btnRecorridoO";
            this.btnRecorridoO.Size = new System.Drawing.Size(95, 39);
            this.btnRecorridoO.TabIndex = 12;
            this.btnRecorridoO.Text = "Postorden";
            this.btnRecorridoO.UseVisualStyleBackColor = true;
            this.btnRecorridoO.Click += new System.EventHandler(this.btnRecorridoO_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConteoP);
            this.groupBox1.Controls.Add(this.btnAgregarP);
            this.groupBox1.Controls.Add(this.btnBusquedaP);
            this.groupBox1.Controls.Add(this.btnNiveles);
            this.groupBox1.Controls.Add(this.btnEliminarP);
            this.groupBox1.Location = new System.Drawing.Point(494, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 250);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRecorridoP);
            this.groupBox2.Controls.Add(this.btnRecorridoO);
            this.groupBox2.Location = new System.Drawing.Point(625, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(103, 122);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbOrden);
            this.Controls.Add(this.tbPuesto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvPuestos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Jerarquía Organizativa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvPuestos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.TextBox tbPuesto;
        private System.Windows.Forms.Button btnBusquedaP;
        private System.Windows.Forms.Button btnConteoP;
        private System.Windows.Forms.Button btnNiveles;
        private System.Windows.Forms.Button btnEliminarP;
        private System.Windows.Forms.ListBox lbOrden;
        private System.Windows.Forms.Button btnRecorridoP;
        private System.Windows.Forms.Button btnRecorridoO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

