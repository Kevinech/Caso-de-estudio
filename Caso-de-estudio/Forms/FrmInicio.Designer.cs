namespace Caso_de_estudio.Forms
{
    partial class FrmInicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnArboles = new System.Windows.Forms.Button();
            this.btnGrafos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elige una de las opciones para comenzar";
            // 
            // btnArboles
            // 
            this.btnArboles.Location = new System.Drawing.Point(57, 202);
            this.btnArboles.Name = "btnArboles";
            this.btnArboles.Size = new System.Drawing.Size(173, 69);
            this.btnArboles.TabIndex = 1;
            this.btnArboles.Text = "Jerarquía Organizativa";
            this.btnArboles.UseVisualStyleBackColor = true;
            this.btnArboles.Click += new System.EventHandler(this.btnArboles_Click);
            // 
            // btnGrafos
            // 
            this.btnGrafos.Location = new System.Drawing.Point(323, 202);
            this.btnGrafos.Name = "btnGrafos";
            this.btnGrafos.Size = new System.Drawing.Size(173, 69);
            this.btnGrafos.TabIndex = 2;
            this.btnGrafos.Text = "Sistema de Rutas";
            this.btnGrafos.UseVisualStyleBackColor = true;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 474);
            this.Controls.Add(this.btnGrafos);
            this.Controls.Add(this.btnArboles);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmInicio";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Text = "Welcome to InnovaTec";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnArboles;
        private System.Windows.Forms.Button btnGrafos;
    }
}