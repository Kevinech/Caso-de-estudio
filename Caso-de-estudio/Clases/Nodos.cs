using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caso_de_estudio.Clases
{
    public class Nodo
    {
        public string Nombre;
        public List<Nodo> Conexiones;

        public Nodo(string nombre)
        {
            Nombre = nombre;
            Conexiones = new List<Nodo>();
        }

        // Solo si luego se necesita agregar distancia:
        // public Dictionary<Nodo, int> ConexionesConPeso = new Dictionary<Nodo, int>();




        

    }




}
