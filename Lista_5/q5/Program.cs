using System;

class Program{
    class Livro{
        private string Titulo { get; set; }

        public Livro(string titulo){
            Titulo = titulo;
        }

        public string GetTitulo(){
            return Titulo;
        }

        public void SetTitulo(string titulo){
            Titulo = titulo;
        }

        public void ExibirTitulo(){
            Console.WriteLine($"O título desse livro é: {this.Titulo}");
        }
    }

    class BibliotecaDependencia{
        public void ExibirTitulo(Livro livro){
            Console.WriteLine($"Título dependência: {livro.GetTitulo()}");
        }
    }

    class BibliotecaAssociacao{
        private Livro Livro;

        public BibliotecaAssociacao(Livro livro){
            Livro = livro;
        }

        public void ExibirLivro(){
            Console.WriteLine($"Título associação: {this.Livro.GetTitulo()}.");
        }
    }

    class BibliotecaAgregacao{
        private List<Livro> Livros = new List<Livro>();

        public void AdicionarLivro(Livro livro){
            Livros.Add(livro);
        }

        public void ExibirLivros(){
            Console.WriteLine("Títulos Agregação: ");
            foreach (Livro livro in Livros){
                Console.WriteLine(livro.GetTitulo());
            }
        }
    }

    class BibliotecaComposicao{
        private List<Livro> Livros = new List<Livro>();

        public void AdicionarLivro(string titulo){
            Livro livro = new Livro(titulo);
            Livros.Add(livro);
        }

        public void ExibirLivros(){
            Console.WriteLine("Títulos Composição: ");
            foreach (Livro livro in Livros){
                Console.WriteLine(livro.GetTitulo());
            }
        }
    }

    public static void Main(){
        BibliotecaDependencia biblioteca_dependencia = new BibliotecaDependencia();
        Livro livro_1 = new Livro("Helena");

        BibliotecaAssociacao biblioteca_associacao = new BibliotecaAssociacao(livro_1);

        BibliotecaAgregacao biblioteca_agregacao = new BibliotecaAgregacao();
        Livro livro_2 = new Livro("Dom Casmurro");
        Livro livro_3 = new Livro("O Alienista");
        biblioteca_agregacao.AdicionarLivro(livro_1);
        biblioteca_agregacao.AdicionarLivro(livro_2);
        biblioteca_agregacao.AdicionarLivro(livro_3);

        BibliotecaComposicao biblioteca_composicao = new BibliotecaComposicao();
    
        // livro.ExibirTitulo();
        // biblioteca_dependencia.ExibirTitulo(livro);

        // biblioteca_associacao.ExibirLivro();

        // biblioteca_agregacao.ExibirLivros();

        // biblioteca_composicao.AdicionarLivro("Memórias Póstumas de Brás Cubas");
        // biblioteca_composicao.ExibirLivros();
    }
}