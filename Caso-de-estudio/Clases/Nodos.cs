using System;
using System.Collections.Generic;
using System.Linq;

namespace Caso_de_estudio.Clases
{
    public class Nodo
    {
        public string Nombre;
        public List<Conexion> Conexiones;
        public Nodo(string nombre)
        {
            Nombre = nombre;
            Conexiones = new List<Conexion>();
        }
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
    }

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

        // Conectar dos nodos con distancia (bidireccional)
        public void GetConectar(string nombre1, string nombre2, int distancia)
        {
            var nodoA = GetAgregarNodo(nombre1);
            var nodoB = GetAgregarNodo(nombre2);

            if (!nodoA.Conexiones.Any(c => c.Vecino == nodoB))
                nodoA.Conexiones.Add(new Conexion(nodoB, distancia));
            if (!nodoB.Conexiones.Any(c => c.Vecino == nodoA))
                nodoB.Conexiones.Add(new Conexion(nodoA, distancia));
        }

        // Buscar nodo por nombre
        public Nodo GetBuscar(string nombre)
        {
            return Nodos.FirstOrDefault(n => n.Nombre == nombre);
        }

        // Mostrar conexiones de un edificio con distancia
        public List<string> MostrarConexiones(string nombre)
        {
            var nodo = GetBuscar(nombre);
            var lista = new List<string>();
            if (nodo != null)
            {
                foreach (var conexion in nodo.Conexiones)
                    lista.Add($"{nombre} → {conexion.Vecino.Nombre} (Distancia: {conexion.Distancia})");
            }
            return lista;
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
                foreach (var conexion in actual.Conexiones)
                {
                    var vecino = conexion.Vecino;
                    if (!visitados.Contains(vecino))
                    {
                        visitados.Add(vecino);
                        cola.Enqueue(vecino);
                    }
                }
            }
            return visitados.Count == Nodos.Count;
        }

        // Recorrido BFS desde un nodo (por nombre)
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

                foreach (var conexion in actual.Conexiones)
                {
                    var vecino = conexion.Vecino;
                    if (!visitados.Contains(vecino))
                    {
                        visitados.Add(vecino);
                        cola.Enqueue(vecino);
                    }
                }
            }
            return resultado;
        }

        // Ruta más corta entre dos nodos usando Dijkstra
        public List<string> RutaMasCorta(string inicio, string destino, out int distanciaTotal)
        {
            var origen = GetBuscar(inicio);
            var destinoNodo = GetBuscar(destino);

            var distancias = Nodos.ToDictionary(n => n, n => int.MaxValue);
            var previos = Nodos.ToDictionary(n => n, n => (Nodo)null);
            var visitados = new HashSet<Nodo>();

            distancias[origen] = 0;
            var cola = new List<Nodo> { origen };

            while (cola.Count > 0)
            {
                cola = cola.OrderBy(n => distancias[n]).ToList();
                var actual = cola[0];
                cola.RemoveAt(0);

                if (actual == destinoNodo) break;
                visitados.Add(actual);

                foreach (var conexion in actual.Conexiones)
                {
                    var vecino = conexion.Vecino;
                    int nuevaDist = distancias[actual] + conexion.Distancia;
                    if (nuevaDist < distancias[vecino])
                    {
                        distancias[vecino] = nuevaDist;
                        previos[vecino] = actual;
                        if (!visitados.Contains(vecino)) cola.Add(vecino);
                    }
                }
            }

            // Reconstruir la ruta
            List<string> ruta = new List<string>();
            var nodo = destinoNodo;
            if (distancias[destinoNodo] == int.MaxValue)
            {
                distanciaTotal = -1;
                return ruta;
            }
            while (nodo != null)
            {
                ruta.Insert(0, nodo.Nombre);
                nodo = previos[nodo];
            }
            distanciaTotal = distancias[destinoNodo];
            return ruta;
        }
    }
}
