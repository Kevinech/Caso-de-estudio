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


        public class Grafo
        {
            public List<Nodo> Nodos = new List<Nodo>();

            // Añadir nodo
            public Nodo GetAgregarNodo(string nombre)
            {
                var existe = Nodos.FirstOrDefault(n => n.Nombre == nombre);
                if (existe != null) return existe;

                var nuevo = new Nodo(nombre);
                Nodos.Add(nuevo);
                return nuevo;
            }

            // Conectar dos nodos
            public void GetConectar(string nombre1, string nombre2)
            {
                var nodoA = GetAgregarNodo(nombre1);
                var nodoB = GetAgregarNodo(nombre2);

                if (!nodoA.Conexiones.Contains(nodoB)) nodoA.Conexiones.Add(nodoB);
                if (!nodoB.Conexiones.Contains(nodoA)) nodoB.Conexiones.Add(nodoA);
            }



        }

    }



}
