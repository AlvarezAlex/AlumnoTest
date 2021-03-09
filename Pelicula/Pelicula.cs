using System;
using System.Collections.Generic;
using System.Linq;

namespace Pelicula
{
    public class Pelicula
    {
        private string titulo;
        private int año;
        private Categoria categoria;
        private Clasificacion clasificacion;
        private List<Actor> actores = new List<Actor>();

        public Pelicula(string titulo, int año, Categoria categoria, Clasificacion clasificacion)
        {         
            this.titulo = titulo;
            this.año = año;
            this.categoria = categoria;
            this.clasificacion = clasificacion;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Año { get => año; set => año = value; }
        
        public void AgregaActor(Actor actor)
        {
            actores.Add(actor);
        }
        public void AgregaActor (int id, string nombre, string nacionalidad)
        {
            actores.Add(new Actor(id, nombre, nacionalidad));
        }

        public void Imprime()
        {
            Console.WriteLine($"{Titulo} ({Año})  {categoria.Nombre} {clasificacion}");
            categoria.Imprime();
            Console.WriteLine();
            foreach (Actor a in actores)
            {
                a.Imprime();
            }
           
        }
        public void BorrarActor(Actor a)
        {
            actores.Remove(a);
        }
        public void BorraActor(string nombre)
        {
            actores.RemoveAll(a => a.Nombre.Contains(nombre));
           /* for (int i = 0; i < actores.Count; i++)
            { 
                if (actores[i].Nombre == nombre)
                    actores.RemoveAt(i);
            }
            */  
        }
    }
}
