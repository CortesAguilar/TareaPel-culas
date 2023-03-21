using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        public string titulo;
        public Int16 año;
        public string pais;
        public string director;
    }

    class Program
    {
        static void Main()
        {
            Pelicula p1 = new Pelicula();
            p1.titulo = "La forma del agua";
            p1.año = 2017;
            p1.pais = "México";
            p1.director = "Guillermo del Toro";


            Pelicula p2 = new Pelicula();
            p2.titulo = "El poder del perro";
            p2.año = 2021;
            p2.pais = "Austraila";
            p2.director = "Jane Campion";
        }
    }
}
