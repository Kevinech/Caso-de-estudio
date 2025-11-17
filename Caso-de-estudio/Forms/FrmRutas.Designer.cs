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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAgregarE = new System.Windows.Forms.Button();
            this.lbEdificios = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarD = new System.Windows.Forms.Button();
            this.tbDistancia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMostrarC = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnValidarC = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRutasC = new System.Windows.Forms.Button();
            this.lbVisualización = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbEdificios);
            this.groupBox1.Controls.Add(this.btnAgregarE);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(34, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 464);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestión de edificios";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 26);
            this.textBox1.TabIndex = 0;
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
            // lbEdificios
            // 
            this.lbEdificios.FormattingEnabled = true;
            this.lbEdificios.ItemHeight = 20;
            this.lbEdificios.Location = new System.Drawing.Point(35, 89);
            this.lbEdificios.Name = "lbEdificios";
            this.lbEdificios.Size = new System.Drawing.Size(401, 344);
            this.lbEdificios.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbDistancia);
            this.groupBox2.Controls.Add(this.btnAgregarD);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(510, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 464);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conexiones";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(29, 156);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(249, 28);
            this.comboBox2.TabIndex = 6;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "seleccionar edificio destino";
            // 
            // btnAgregarD
            // 
            this.btnAgregarD.Location = new System.Drawing.Point(66, 304);
            this.btnAgregarD.Name = "btnAgregarD";
            this.btnAgregarD.Size = new System.Drawing.Size(163, 52);
            this.btnAgregarD.TabIndex = 9;
            this.btnAgregarD.Text = "Agregar conexion";
            this.btnAgregarD.UseVisualStyleBackColor = true;
            // 
            // tbDistancia
            // 
            this.tbDistancia.Location = new System.Drawing.Point(55, 262);
            this.tbDistancia.Name = "tbDistancia";
            this.tbDistancia.Size = new System.Drawing.Size(197, 26);
            this.tbDistancia.TabIndex = 8;
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
            // groupBox3
            // 
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mostrar conexiones de edificios";
            // 
            // btnMostrarC
            // 
            this.btnMostrarC.Location = new System.Drawing.Point(47, 57);
            this.btnMostrarC.Name = "btnMostrarC";
            this.btnMostrarC.Size = new System.Drawing.Size(226, 28);
            this.btnMostrarC.TabIndex = 11;
            this.btnMostrarC.Text = "Mostrar";
            this.btnMostrarC.UseVisualStyleBackColor = true;
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
            // btnValidarC
            // 
            this.btnValidarC.Location = new System.Drawing.Point(47, 135);
            this.btnValidarC.Name = "btnValidarC";
            this.btnValidarC.Size = new System.Drawing.Size(226, 28);
            this.btnValidarC.TabIndex = 13;
            this.btnValidarC.Text = "Conexión";
            this.btnValidarC.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mostrar rutas más cortas";
            // 
            // btnRutasC
            // 
            this.btnRutasC.Location = new System.Drawing.Point(47, 218);
            this.btnRutasC.Name = "btnRutasC";
            this.btnRutasC.Size = new System.Drawing.Size(226, 26);
            this.btnRutasC.TabIndex = 15;
            this.btnRutasC.Text = "Mostrar rutas";
            this.btnRutasC.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lbEdificios;
        private System.Windows.Forms.Button btnAgregarE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregarD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
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
    }
}