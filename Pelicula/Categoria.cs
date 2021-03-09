using System;

namespace Pelicula
{
    public class Categoria
    {
        private string nombre;
        private string nombreCorto;

        public string Nombre { get => nombre; set => nombre = value; }
        public string NombreCorto { get => nombreCorto; set => nombreCorto = value; }

        public Categoria(String nombre, string nombreCorto)
        {
            Nombre = nombre;
            NombreCorto = nombreCorto;
            
        }
        public void Imprime()
        {
            Console.WriteLine(nombre);
        }
        public void ImprimeCorto()
        {
            Console.WriteLine(nombreCorto);
        }
    }
}
