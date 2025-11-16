using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caso_de_estudio
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Handles the click event of the "Agregar" button to add a new node to the tree view.
        /// </summary>
        /// <remarks>If a node is selected in the tree view, this method adds a child node with the text
        /// from the textbox. If no nodes exist in the tree view, it creates a root node with the text from the textbox.
        /// If a root node already exists, a warning message is displayed to prevent adding multiple root nodes. The
        /// tree view is expanded after the operation to display all nodes.</remarks>
        /// <param name="sender">The source of the event, typically the "Agregar" button.</param>
        /// <param name="e">The event data associated with the click event.</param>
        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            //Agrega un nodo hijo a la raiz (es la que se selecciona)
            if(tvPuestos.SelectedNode != null)
            {
                tvPuestos.SelectedNode.Nodes.Add(tbPuesto.Text);
            }
            //Crea un nodo raiz
            if (tvPuestos.Nodes.Count == 0)
            {
                //Agrega nodo con el nombre / puesto escrito en el textbox
                tvPuestos.Nodes.Add(tbPuesto.Text);

            }
            else
            {
                //Manda una alerta cuando el usuario quiere crear otra raíz
                MessageBox.Show("Solo puede agregar una raíz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            //Expande el arbol para poder mostrar todos los elementos
            tvPuestos.ExpandAll();



        }

        /// <summary>
        /// Handles the click event of the "Eliminar" button, removing the selected node from the tree view.
        /// </summary>
        /// <remarks>This method ensures that the root node cannot be deleted. If the selected node is a
        /// root node, a warning message is displayed, and no action is taken. If the selected node has child nodes,
        /// they are also removed along with the selected node.</remarks>
        /// <param name="sender">The source of the event, typically the "Eliminar" button.</param>
        /// <param name="e">An <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            //
            if(tvPuestos.SelectedNode  != null)
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


        /// <summary>
        /// Handles the click event of the "Buscar" button, searching for a node in the tree view that matches the text
        /// entered in the associated text box.
        /// </summary>
        /// <remarks>If a matching node is found, it is selected in the tree view, and a message box is
        /// displayed indicating the node's text. If no matching node is found, a message box notifies the
        /// user.</remarks>
        /// <param name="sender">The source of the event, typically the "Buscar" button.</param>
        /// <param name="e">An <see cref="EventArgs"/> instance containing the event data.</param>
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


        /// <summary>
        /// Searches for a <see cref="TreeNode"/> with the specified text within the given collection of nodes,
        /// including their child nodes, using a case-insensitive comparison.
        /// </summary>
        /// <remarks>This method performs a recursive search, traversing the child nodes of each node in
        /// the collection.</remarks>
        /// <param name="nodos">The collection of <see cref="TreeNode"/> objects to search.</param>
        /// <param name="texto">The text to search for within the nodes.</param>
        /// <returns>The first <see cref="TreeNode"/> that matches the specified text, or <see langword="null"/> if no matching
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

        private void btnNiveles_Click(object sender, EventArgs e)
        {



        }
    }





}
