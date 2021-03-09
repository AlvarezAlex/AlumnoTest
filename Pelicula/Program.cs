using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pelicula
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> enteros = new List<int>();
            int x = 1;
            enteros.Add(22);
            enteros.Add(x);
            int y = enteros[0];
            enteros[0] = 10;
            enteros[0].ToString();*/

            Actor benedict = new Actor(1000, "Benedict Cumberbatch", "London, England, Uk") ;

            Pelicula p1 = new Pelicula("El codigo enigma", 2014, new Categoria("Biografica","Biopic"), Clasificacion.PG13);
            p1.AgregaActor(benedict);
            p1.AgregaActor(1002, "Keira knightley","Teddington, England, UK");
            p1.Imprime();

            Pelicula p2 = new Pelicula("1917", 2012, new Categoria("Drama","Drama"), Clasificacion.PG);
            p2.AgregaActor(new Actor(1002,"George Mackay", "London, England, Uk"));
            p2.AgregaActor(benedict);
            p2.Imprime();

            //string actor = Console.ReadLine();

            p2.BorraActor("Benedict");
            //p2.BorrarActor(beneict);
            p2.Imprime();

            

            Console.ReadKey();


        }
    }
}
