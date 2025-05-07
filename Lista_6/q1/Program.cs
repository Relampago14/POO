using System;

class Program{
    class Veiculo{
       private string Marca;
       private string Modelo;
       private int Ano;

       public Veiculo(string marca, string modelo, int ano){
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
       }

       public void ExibirInformações(){
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}");
       }
    }

    class Carro:Veiculo{
        private int QuantidadePortas;

        public Carro(string marca, string modelo, int ano, int quantidadeportas) : base(marca, modelo, ano){
            QuantidadePortas = quantidadeportas;
        }

        public void ExibirInformações(){
            Console.WriteLine("teste");
        }
    }

    class Moto:Veiculo{
        private int Cilindrada;

        public Moto(string marca, string modelo, int ano, int cilindrada) : base(marca, modelo, ano){
            Cilindrada = cilindrada;
        }
    }

    public static void Main(){
        Carro uno = new Carro("Fiat", "Uno Mille", 2006, 4);
        Moto cg99 = new Moto("Honda", "CG", 1999, 99);

        uno.ExibirInformações();
    }
}