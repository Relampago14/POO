using System;

class Livro{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Genero { get; set; }
    public int Ano { get; set; }

    public Livro(string titulo, string autor, string genero, int ano){
        Titulo = titulo;
        Autor = autor;
        Genero = genero;
        Ano = ano;
    }

    public string ObterTitulo(){
        return Titulo;
    }

    public string ObterAutor(){
        return Autor;
    }

    public string ObterGenero(){
        return Genero;
    }

    public int ObterAno(){
        return Ano;
    }

    public bool IsModernismo(){
        return Ano >= 1930 && Ano <= 1945;
    }

    public bool IsBarroco(){
        return Ano >= 1601 && Ano <= 1768;
    }

    public void ExibirLivro(){
        Console.WriteLine("\nDetalhes do Livro:");
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Ano de Publicação: {Ano}");

        if (IsModernismo())
            Console.WriteLine("Esse livro pertence ao Modernismo.");

        if (IsBarroco())
            Console.WriteLine("Esse livro pertence ao Barroco.");
    }
}

class Progra{
    public static void Main(){
        Console.WriteLine("Digite o título do livro: ");
        string titulo = Console.ReadLine();

        Console.WriteLine("Digite o autor do livro: ");
        string autor = Console.ReadLine();

        Console.WriteLine("Digite o gênero do livro: ");
        string genero = Console.ReadLine();

        Console.WriteLine("Digite o ano de publicação do livro: ");
        int ano = int.Parse(Console.ReadLine());

        Livro livro = new Livro(titulo, autor, genero, ano);

        livro.ExibirLivro();
    }
}
