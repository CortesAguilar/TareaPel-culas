using System;
using System.Collections.Generic;

public class Pelicula
{
    private List<Actor> actores; 
    
    private string titulo;
    private Int16 año;
    private string pais;
    private string director;

    public void SetTitulo(string titulo)=> this.titulo = titulo;
    public string GetTitulo()=> this.titulo;

    public void SetAño(Int16 año)=> this.año = año;
    public Int16 GetAño()=> this.año;

    public void SetPais(string pais)=> this.pais = pais;
    public string GetPais()=> this.pais;

    public void SetDirector(string director)=> this.director = director;
    public string GetDirector()=> this.director;

    public Pelicula()
    {
        this.titulo = "";
        this.año = 0;
        pais = "";
        director = "";
        actores = new List<Actor>();

    }

    public Pelicula(string titulo, Int16 año)
    {
        this.titulo = titulo;
        this.año = año;
        pais = "";
        director = "";
        actores = new List<Actor>();
    }


    public void AgregaActor(Actor actor) => actores.Add(actor);

    public void Imprime()
    {
        Console.WriteLine($"{titulo}\n{año}");
    }

    public void ImprimeActores()
    {
       foreach(Actor a in actores)
       {
          a.Imprimir();
       }
    }
}

public class Actor
{
    public string Nombre {get; set;}
    public Int16 Año {get; set;}

    public Actor(string nombre, Int16 año)
    {
        Nombre = nombre;
        Año = año;
    }

    public void Imprimir() => Console.WriteLine($"{Nombre} ({Año})");
}

class program
{
    static void Main()
    {
        Pelicula p1 = new Pelicula("La La Land", 2016);
        p1.AgregaActor(new Actor("Ryan Gosling", 1980));
        p1.AgregaActor(new Actor("Emma Stone", 1988));

        p1.ImprimeActores();
    }
}
