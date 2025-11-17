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

        Grafo miGrafo = new Grafo();



        private void btnAgregarE_Click(object sender, EventArgs e)
        {

            miGrafo.GetAgregarNodo(tbAgregarE.Text);
            lbEdificios.Items.Add(tbAgregarE.Text);
            // Actualiza combos si usas para conexiones
            cbOrigenE.Items.Add(tbAgregarE.Text);
            cbDestinoE.Items.Add(tbAgregarE.Text);
            tbAgregarE.Clear();


        }

        private void btnAgregarD_Click(object sender, EventArgs e)
        {
            string origen = cbOrigenE.Text;
            string destino = cbDestinoE.Text;
            int distancia = int.Parse(tbDistancia.Text); // o usa TryParse!

            miGrafo.GetConectar(origen, destino, distancia);
            lbVisualización.Items.Add($"{origen} <---> {destino} : {distancia}");
            tbDistancia.Clear();
        }
    }
}

