namespace Caso_de_estudio.Forms
{
    partial class FrmRutas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbEdificios = new System.Windows.Forms.ListBox();
            this.btnAgregarE = new System.Windows.Forms.Button();
            this.tbAgregarE = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDistancia = new System.Windows.Forms.TextBox();
            this.btnAgregarD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDestinoE = new System.Windows.Forms.ComboBox();
            this.cbOrigenE = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbVisualización = new System.Windows.Forms.ListBox();
            this.btnRutasC = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnValidarC = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMostrarC = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbEdificios);
            this.groupBox1.Controls.Add(this.btnAgregarE);
            this.groupBox1.Controls.Add(this.tbAgregarE);
            this.groupBox1.Location = new System.Drawing.Point(34, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 464);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestión de edificios";
            // 
            // lbEdificios
            // 
            this.lbEdificios.FormattingEnabled = true;
            this.lbEdificios.ItemHeight = 20;
            this.lbEdificios.Location = new System.Drawing.Point(35, 89);
            this.lbEdificios.Name = "lbEdificios";
            this.lbEdificios.Size = new System.Drawing.Size(401, 344);
            this.lbEdificios.TabIndex = 2;
            // 
            // btnAgregarE
            // 
            this.btnAgregarE.Location = new System.Drawing.Point(362, 41);
            this.btnAgregarE.Name = "btnAgregarE";
            this.btnAgregarE.Size = new System.Drawing.Size(74, 30);
            this.btnAgregarE.TabIndex = 1;
            this.btnAgregarE.Text = "Agregar";
            this.btnAgregarE.UseVisualStyleBackColor = true;
            this.btnAgregarE.Click += new System.EventHandler(this.btnAgregarE_Click);
            // 
            // tbAgregarE
            // 
            this.tbAgregarE.Location = new System.Drawing.Point(35, 41);
            this.tbAgregarE.Name = "tbAgregarE";
            this.tbAgregarE.Size = new System.Drawing.Size(306, 26);
            this.tbAgregarE.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbDistancia);
            this.groupBox2.Controls.Add(this.btnAgregarD);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbDestinoE);
            this.groupBox2.Controls.Add(this.cbOrigenE);
            this.groupBox2.Location = new System.Drawing.Point(510, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 464);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conexiones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ingrese la distancia entre los edificios";
            // 
            // tbDistancia
            // 
            this.tbDistancia.Location = new System.Drawing.Point(55, 262);
            this.tbDistancia.Name = "tbDistancia";
            this.tbDistancia.Size = new System.Drawing.Size(197, 26);
            this.tbDistancia.TabIndex = 8;
            // 
            // btnAgregarD
            // 
            this.btnAgregarD.Location = new System.Drawing.Point(66, 304);
            this.btnAgregarD.Name = "btnAgregarD";
            this.btnAgregarD.Size = new System.Drawing.Size(163, 52);
            this.btnAgregarD.TabIndex = 9;
            this.btnAgregarD.Text = "Agregar conexion";
            this.btnAgregarD.UseVisualStyleBackColor = true;
            this.btnAgregarD.Click += new System.EventHandler(this.btnAgregarD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "seleccionar edificio destino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "seleccionar edificio origen";
            // 
            // cbDestinoE
            // 
            this.cbDestinoE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestinoE.FormattingEnabled = true;
            this.cbDestinoE.Location = new System.Drawing.Point(29, 156);
            this.cbDestinoE.Name = "cbDestinoE";
            this.cbDestinoE.Size = new System.Drawing.Size(249, 28);
            this.cbDestinoE.TabIndex = 6;
            // 
            // cbOrigenE
            // 
            this.cbOrigenE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrigenE.FormattingEnabled = true;
            this.cbOrigenE.Location = new System.Drawing.Point(29, 63);
            this.cbOrigenE.Name = "cbOrigenE";
            this.cbOrigenE.Size = new System.Drawing.Size(249, 28);
            this.cbOrigenE.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.lbVisualización);
            this.groupBox3.Controls.Add(this.btnRutasC);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnValidarC);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnMostrarC);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(844, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 464);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaciones";
            // 
            // lbVisualización
            // 
            this.lbVisualización.FormattingEnabled = true;
            this.lbVisualización.ItemHeight = 20;
            this.lbVisualización.Location = new System.Drawing.Point(6, 250);
            this.lbVisualización.Name = "lbVisualización";
            this.lbVisualización.Size = new System.Drawing.Size(324, 204);
            this.lbVisualización.TabIndex = 17;
            // 
            // btnRutasC
            // 
            this.btnRutasC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRutasC.Location = new System.Drawing.Point(6, 202);
            this.btnRutasC.Name = "btnRutasC";
            this.btnRutasC.Size = new System.Drawing.Size(151, 42);
            this.btnRutasC.TabIndex = 15;
            this.btnRutasC.Text = "Mostrar rutas";
            this.btnRutasC.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mostrar rutas";
            // 
            // btnValidarC
            // 
            this.btnValidarC.Location = new System.Drawing.Point(47, 135);
            this.btnValidarC.Name = "btnValidarC";
            this.btnValidarC.Size = new System.Drawing.Size(226, 28);
            this.btnValidarC.TabIndex = 13;
            this.btnValidarC.Text = "Conexión";
            this.btnValidarC.UseVisualStyleBackColor = true;
            this.btnValidarC.Click += new System.EventHandler(this.btnValidarC_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Validar conexión";
            // 
            // btnMostrarC
            // 
            this.btnMostrarC.Location = new System.Drawing.Point(47, 57);
            this.btnMostrarC.Name = "btnMostrarC";
            this.btnMostrarC.Size = new System.Drawing.Size(226, 28);
            this.btnMostrarC.TabIndex = 11;
            this.btnMostrarC.Text = "Mostrar";
            this.btnMostrarC.UseVisualStyleBackColor = true;
            this.btnMostrarC.Click += new System.EventHandler(this.btnMostrarC_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mostrar conexiones de edificios";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(179, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 42);
            this.button1.TabIndex = 16;
            this.button1.Text = "Mostrar rutas cortas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRutas";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Text = "Sistema de rutas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAgregarE;
        private System.Windows.Forms.ListBox lbEdificios;
        private System.Windows.Forms.Button btnAgregarE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregarD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDestinoE;
        private System.Windows.Forms.ComboBox cbOrigenE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDistancia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnValidarC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMostrarC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbVisualización;
        private System.Windows.Forms.Button btnRutasC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}