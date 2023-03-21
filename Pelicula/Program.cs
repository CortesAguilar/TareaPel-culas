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

        public void SetTitulo(string titulo)=> this.titulo = titulo;
        public string GetTitulo()=> titulo;

        public void SetAño(Int16 año)=> this.año = año;
        public int GetAño()=> año;

        public void SetPais(string pais)=> this.pais = pais;
        public string GetPais()=> pais;

        public void SetDirector(string director)=> this.director = director;
        public string GetDirector()=> director;
    }

    class Program
    {
        static void Main()
        {
            Pelicula p1 = new Pelicula();
            p1.SetTitulo("La forma del agua");
            p1.SetAño(2017);
            Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());

            Pelicula p2 = new Pelicula();
            p2.SetTitulo("El poder del perro");
            p2.SetAño(2021);
            Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());
        }
    }
}
