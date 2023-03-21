using System;
using System.Collections.Generic;

public class Pelicula
{
    private string titulo;
    private Int16 año;
    private string pais;
    private string director;

    public void SetTitulo(string titulo)=> this.titulo = titulo;
    public string GetTitulo()=> titulo;

    public void SetAño(Int16 año)=> this.año = año;
    public Int16 GetAño()=> año;

    public void SetPais(string pais)=> this.pais = pais;
    public string GetPais()=> pais;

    public void SetDirector(string director)=> this.director = director;
    public string GetDirector()=> director;

    public Pelicula()
    {
        titulo = "";
        año = 0;
        pais = "";
        director = "";
    }

    public Pelicula(string titulo, Int16 año)
    {
        this.titulo = titulo;
        this.año = año;
        pais = "";
        director = "";
    }

    public void Imprime()
    {
        Console.WriteLine($"{titulo}\n{año}\n{pais}\n{director}");
    }
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

        List<Pelicula> peliculas = new List<Pelicula>();
        peliculas.Add(new Pelicula("El Rey León", 1999));
        peliculas.Add(new Pelicula("Kill Bill", 2003));
        peliculas.Add(new Pelicula("Mario Bros", 2023));
        peliculas.Add(new Pelicula("Volver al futuor", 1985));

        foreach(Pelicula p in peliculas)
        {
            p.Imprime();
        }
    }
 }  
