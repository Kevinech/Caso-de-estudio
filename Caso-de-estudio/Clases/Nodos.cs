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

        public class Conexion
        {
            public Nodo Vecino;
            public int Distancia;
            public Conexion(Nodo vecino, int distancia)
            {
                Vecino = vecino;
                Distancia = distancia;
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

                // Buscar nodo por nombre
                public Nodo GetBuscar(string nombre)
                {
                    return Nodos.FirstOrDefault(n => n.Nombre == nombre);
                }

                // Mostrar conexiones de un edificio
                public List<string> MostrarConexiones(string nombre)
                {
                    var nodo = GetBuscar(nombre);
                    if (nodo != null)
                        return nodo.Conexiones.Select(c => c.Nombre).ToList();
                    return new List<string>();
                }
                // Validar si el grafo es conexo usando BFS
                public bool EsConexo()
                {
                    if (Nodos.Count == 0) return true;
                    var visitados = new HashSet<Nodo>();
                    var cola = new Queue<Nodo>();
                    cola.Enqueue(Nodos[0]);
                    visitados.Add(Nodos[0]);

                    while (cola.Count > 0)
                    {
                        var actual = cola.Dequeue();
                        foreach (var vecino in actual.Conexiones)
                        {
                            if (!visitados.Contains(vecino))
                            {
                                visitados.Add(vecino);
                                cola.Enqueue(vecino);
                            }
                        }
                    }
                    return visitados.Count == Nodos.Count;
                }

                // Recorrido BFS desde un nodo (puede mostrar ruta, pero no la más corta)
                public List<string> BFS(string inicio)
                {
                    var start = GetBuscar(inicio);
                    if (start == null) return new List<string>();

                    var resultado = new List<string>();
                    var cola = new Queue<Nodo>();
                    var visitados = new HashSet<Nodo>();

                    cola.Enqueue(start);
                    visitados.Add(start);

                    while (cola.Count > 0)
                    {
                        var actual = cola.Dequeue();
                        resultado.Add(actual.Nombre);

                        foreach (var vecino in actual.Conexiones)
                        {
                            if (!visitados.Contains(vecino))
                            {
                                visitados.Add(vecino);
                                cola.Enqueue(vecino);
                            }
                        }
                    }
                    return resultado;

                }

            }


        }

    }
}

    



