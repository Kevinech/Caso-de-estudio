using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Caso_de_estudio
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();

        }

        
        private void btnAgregarP_Click(object sender, EventArgs e)
        {

            // Si hay un nodo seleccionado, se agrega como hijo
            if (tvPuestos.SelectedNode != null)
            {
                tvPuestos.SelectedNode.Nodes.Add(tbPuesto.Text);
            }
            else
            {
                // Si NO hay nodo seleccionado Y ya hay un nodo raíz, muestra la alerta
                if (tvPuestos.Nodes.Count > 0)
                {
                    MessageBox.Show("No se puede agregar más de una raíz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Si NO hay nodo raíz, lo agrega normalmente
                    tvPuestos.Nodes.Add(tbPuesto.Text);
                }
            }
            //Expande el arbol para poder mostrar todos los elementos
            tvPuestos.ExpandAll();
        }


        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            //
            if (tvPuestos.SelectedNode != null)
            {
                //
                if (tvPuestos.Nodes.Count > 0)
                {
                    //se crea una variable donde especifica que los nodos padres no se pueden eliminar o dejar de existir
                    var nodo = tvPuestos.SelectedNode;
                    if (nodo.Parent == null)
                    {

                        MessageBox.Show("No puedes eliminar la raíz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }
                    //elimina los nodos hijos
                    nodo.Remove();

                }

            }



        }


       
        private void btnBusquedaP_Click(object sender, EventArgs e)
        {
            //especifica que la variable "buscar" es el texto puesto en el textbox
            string buscar = tbPuesto.Text.ToString();

            //Llama el metodo de buscar nodo
            TreeNode encontrado = GetBuscar(tvPuestos.Nodes, buscar);

            //
            if (encontrado != null)
            {
                tvPuestos.SelectedNode = encontrado;
                MessageBox.Show("Puesto encontrado: " + encontrado.Text + ".", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            //
            else
            {
                MessageBox.Show("Puesto no encontrado.");
            }

        }



        /// node is found.</returns>
        TreeNode GetBuscar(TreeNodeCollection nodos, string texto)
        {

            foreach (TreeNode nodo in nodos)
            {
                //Ignora mayúsculas y minúsculas
                if (nodo.Text.Equals(texto, StringComparison.OrdinalIgnoreCase))
                    return nodo;  //Detiene la busqueda si encuentra el nodo

                //Busca recursivamente en los hijos
                TreeNode encontrado = GetBuscar(nodo.Nodes, texto);
                if (encontrado != null)
                    return encontrado;


            }
            //Si no encuentra ningun nodo con el mismo nombre del tbNodo
            return null;




        }


        private void btnRecorridoP_Click(object sender, EventArgs e)
        {

            lbOrden.Items.Clear(); // Borra el contenido anterior
            if (tvPuestos.Nodes.Count > 0)
            {
                List<string> resultado = new List<string>();
                RecorridoPreorden(tvPuestos.Nodes[0], resultado);

                // Ahora pasas el resultado al ListBox
                foreach (string item in resultado)
                {
                    lbOrden.Items.Add(item);
                }
            }
        }

        public void RecorridoPreorden(TreeNode nodo, List<string> resultado)
        {
            if (nodo == null) return;
            resultado.Add(nodo.Text); // visitar nodo actual
            foreach (TreeNode hijo in nodo.Nodes) // recorrer hijos
            {
                RecorridoPreorden(hijo, resultado);
            }
        }



        private void btnRecorridoI_Click(object sender, EventArgs e)
        {

            lbOrden.Items.Clear(); // Borra el contenido anterior
            if (tvPuestos.Nodes.Count > 0)
            {
                List<string> resultado = new List<string>();
                RecorridoPreorden(tvPuestos.Nodes[0], resultado);

                // Ahora pasas el resultado al ListBox
                foreach (string item in resultado)
                {
                    lbOrden.Items.Add(item);
                }


            }


        }

        public void RecorridoInorden(TreeNode nodo, List<string> resultado)
        {
            if (nodo == null) return;
            if (nodo.Nodes.Count > 0)
                RecorridoInorden(nodo.Nodes[0], resultado); // primer hijo
            resultado.Add(nodo.Text); // visitar nodo actual
            for (int i = 1; i < nodo.Nodes.Count; i++) // demás hijos
            {
                RecorridoInorden(nodo.Nodes[i], resultado);
            }
        }



        private void btnRecorridoO_Click(object sender, EventArgs e)
        {

            lbOrden.Items.Clear(); // Borra el contenido anterior
            if (tvPuestos.Nodes.Count > 0)
            {
                List<string> resultado = new List<string>();
                RecorridoPreorden(tvPuestos.Nodes[0], resultado);

                // Ahora pasas el resultado al ListBox
                foreach (string item in resultado)
                {
                    lbOrden.Items.Add(item);
                }


            }

        }

        public void RecorridoPostorden(TreeNode nodo, List<string> resultado)
        {
            if (nodo == null) return;
            foreach (TreeNode hijo in nodo.Nodes)
            {
                RecorridoPostorden(hijo, resultado);
            }
            resultado.Add(nodo.Text); // visitar nodo actual al final
        }


        private void btnNiveles_Click(object sender, EventArgs e)
        {

            



        }

        


        private void btnConteoP_Click(object sender, EventArgs e)
        {
           
        }

        
    }
}
