using Caso_de_estudio.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caso_de_estudio.Forms
{
    public partial class FrmRutas : MetroFramework.Forms.MetroForm
    {

        public FrmRutas()
        {
            InitializeComponent();
        }

        Grafo SistemaR = new Grafo();



        private void btnAgregarE_Click(object sender, EventArgs e)
        {

            SistemaR.GetAgregarNodo(tbAgregarE.Text);
            lbEdificios.Items.Add(tbAgregarE.Text);
            
            cbOrigenE.Items.Add(tbAgregarE.Text);
            cbDestinoE.Items.Add(tbAgregarE.Text);
            tbAgregarE.Clear();


        }

        private void btnAgregarD_Click(object sender, EventArgs e)
        {
        
        
            string origen = cbOrigenE.Text;
            string destino = cbDestinoE.Text;
            string NDistancia = tbDistancia.Text;

            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(origen) || string.IsNullOrWhiteSpace(destino))
            {
                MessageBox.Show("Selecciona ambos edificios para conectar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(NDistancia))
            {
                MessageBox.Show("Ingrese la distancia entre los edificios.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int distancia;
            // Manejo de error al convertir distancia
            if (!int.TryParse(NDistancia, out distancia) || distancia < 0)
            {
                MessageBox.Show("La distancia debe ser un número entero positivo.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SistemaR.GetConectar(origen, destino, distancia);
                lbVisualización.Items.Add($"{origen} <----> {destino} :  {distancia}");
                tbDistancia.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar edificios: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void btnMostrarC_Click(object sender, EventArgs e)
        {
            var conexiones = SistemaR.MostrarConexiones(cbOrigenE.Text);
            lbVisualización.Items.Clear();
            foreach (var c in conexiones)
                lbVisualización.Items.Add(c);

        }

        private void btnValidarC_Click(object sender, EventArgs e)
        {
            bool conexo = SistemaR.EsConexo();
            lbVisualización.Items.Clear();
            lbVisualización.Items.Add(conexo ? "Los grafos estan conectados correctamente." : "los grafos no estan conectados.");
        }
    }
}

