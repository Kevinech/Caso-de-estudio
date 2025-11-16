namespace Caso_de_estudio
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // tvPuestos
            // 
            this.tvPuestos.Location = new System.Drawing.Point(119, 133);
            this.tvPuestos.Name = "tvPuestos";
            this.tvPuestos.Size = new System.Drawing.Size(413, 355);
            this.tvPuestos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puesto:";
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Location = new System.Drawing.Point(553, 101);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(75, 41);
            this.btnAgregarP.TabIndex = 2;
            this.btnAgregarP.Text = "Agregar";
            this.btnAgregarP.UseVisualStyleBackColor = true;
            this.btnAgregarP.Click += new System.EventHandler(this.btnAgregarP_Click);
            // 
            // tbPuesto
            // 
            this.tbPuesto.Location = new System.Drawing.Point(119, 101);
            this.tbPuesto.Name = "tbPuesto";
            this.tbPuesto.Size = new System.Drawing.Size(413, 26);
            this.tbPuesto.TabIndex = 3;
            // 
            // btnBusquedaP
            // 
            this.btnBusquedaP.Location = new System.Drawing.Point(553, 191);
            this.btnBusquedaP.Name = "btnBusquedaP";
            this.btnBusquedaP.Size = new System.Drawing.Size(75, 39);
            this.btnBusquedaP.TabIndex = 4;
            this.btnBusquedaP.Text = "Busqueda";
            this.btnBusquedaP.UseVisualStyleBackColor = true;
            this.btnBusquedaP.Click += new System.EventHandler(this.btnBusquedaP_Click);
            // 
            // btnConteoP
            // 
            this.btnConteoP.Location = new System.Drawing.Point(553, 284);
            this.btnConteoP.Name = "btnConteoP";
            this.btnConteoP.Size = new System.Drawing.Size(75, 44);
            this.btnConteoP.TabIndex = 5;
            this.btnConteoP.Text = "Conteo";
            this.btnConteoP.UseVisualStyleBackColor = true;
            // 
            // btnNiveles
            // 
            this.btnNiveles.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnNiveles.Location = new System.Drawing.Point(553, 236);
            this.btnNiveles.Name = "btnNiveles";
            this.btnNiveles.Size = new System.Drawing.Size(75, 42);
            this.btnNiveles.TabIndex = 6;
            this.btnNiveles.Text = "Niveles";
            this.btnNiveles.UseVisualStyleBackColor = true;
            this.btnNiveles.Click += new System.EventHandler(this.btnNiveles_Click);
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.Location = new System.Drawing.Point(553, 148);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(75, 37);
            this.btnEliminarP.TabIndex = 7;
            this.btnEliminarP.Text = "Eliminar";
            this.btnEliminarP.UseVisualStyleBackColor = true;
            this.btnEliminarP.Click += new System.EventHandler(this.btnEliminarP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnEliminarP);
            this.Controls.Add(this.btnNiveles);
            this.Controls.Add(this.btnConteoP);
            this.Controls.Add(this.btnBusquedaP);
            this.Controls.Add(this.tbPuesto);
            this.Controls.Add(this.btnAgregarP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvPuestos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Jerarquía Organizativa";
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
    }
}

