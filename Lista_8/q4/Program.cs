using System;

class Livro{
    public string Titulo;
    public string Autor;

    public Livro(string titulo, string autor){
        Titulo = titulo;
        Autor = autor;
    }

    public class Publicacao{
        public string Editora;
        public int Ano;

        public Publicacao(string editora, int ano){
            Editora = editora;
            Ano = ano;
        }
    }
}

class Program{
    public static void Main(){
        Livro livro = new Livro("The Last of Us", "Neil Druckman");

        Livro.Publicacao publicacao = new Livro.Publicacao("Naugthy Dog", 2013);

        Console.WriteLine($"Livro {livro.Titulo} - Autor {livro.Autor}");
        Console.WriteLine($"Publicação {publicacao.Editora} - Ano {publicacao.Ano}");
    }
}