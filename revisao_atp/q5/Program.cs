using System;

public class Program{
    public static int SomaAcimaDiagPrincip(int[,] matriz, int ordem){
        int soma=0;
        Console.Write("Itens acima da diagonal principal: ");
        for (int i=0; i<matriz.GetLength(0); i++){
            for (int j=0; j<matriz.GetLength(1); j++){
                if (i<j){
                    Console.Write($"{matriz[i, j]}, ");
                    soma+=matriz[i, j];
                }
            }
        }
        return soma;
    }
    public static void Main(){
        int ordem;
        Console.WriteLine("Digite a ordem da matriz quadrada: ");
        ordem = int.Parse(Console.ReadLine());

        int[,] matriz = new int[ordem, ordem];

        for (int i=0; i<matriz.GetLength(0); i++){
            for (int j=0; j<matriz.GetLength(1); j++){
                Console.WriteLine($"Insira um valor na posição [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("A matriz é: ");

        for (int i=0; i<matriz.GetLength(0); i++){
            for (int j=0; j<matriz.GetLength(1); j++){
                Console.Write($"{matriz[i, j]} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"\nA soma dos itens acima da diagonal principal é: {SomaAcimaDiagPrincip(matriz, ordem)}");
    }
}