using System;

namespace Pelicula
{
    public class Actor
    {
        private int id;
        private string nombre;
        private string nacionalidad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public int Id { get => id; set => id = value; }

        public Actor(int id, string nombre, string nacionalidad)
        {
            this.id = id;
            Nombre = nombre;
            Nacionalidad = nacionalidad;
        }

        public void Imprime()
        {
            Console.WriteLine($" {Nombre} ({Nacionalidad})");
        }
    }
}
