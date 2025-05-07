using System;

public class Program{
    public class Vet{
        public int Tamanho { get; set; }
        public int[] Vetor { get; set; }

        public Vet(int tamanho)
        {
            Tamanho = tamanho;
            Vetor = new int[tamanho];
        }

        public void IncluirValor(int valor, int pos){
            Vetor[pos] = valor;
        }

        public void RecuperaValor(int pos){
            Console.WriteLine($"O valor na {pos}ª posição é {Vetor[pos]}");
        }

        public void ConsultaValor(int valor){
            string msg = $"O valor {valor} não existe";
            foreach (int v in Vetor){
                if (v == valor){
                    msg = $"O valor {valor} existe";
                    break;
                }
            }

            Console.WriteLine(msg);
        }

        public void SomaElementos(int op){
            int soma = 0;
            switch (op){
                case 1:
                    foreach (int v in Vetor){
                        if (v % 2 == 0){
                            soma += v;
                        }
                    }
                    Console.WriteLine(soma);
                    break;
                case 2:
                    foreach (int v in Vetor){
                        if (v % 2 != 0){
                            soma += v;
                        }
                    }
                    Console.WriteLine(soma);
                    break;
                case 3:
                    foreach (int v in Vetor){
                        soma += v;
                    }
                    Console.WriteLine(soma);
                    break;
            }
        }

        public void ListarElementos(){
            foreach (int v in Vetor){
                Console.WriteLine(v);
            }
        }

    }
    public static void Main(){

        //Console.Write("Digite o tamanho do vetor: ");
        //int tam = int.Parse(Console.ReadLine());
        Vet vetor = new Vet(3);

        vetor.IncluirValor(3,0);
        vetor.IncluirValor(4,1);
        vetor.IncluirValor(8,2);

        vetor.RecuperaValor(1);

        vetor.ConsultaValor(3);
        vetor.ConsultaValor(4);

        vetor.SomaElementos(1);
        vetor.SomaElementos(2);
        vetor.SomaElementos(3);

        vetor.ListarElementos();
    }
}