using System;

public class Program{
    public static int QuantidadePares(int[,] matriz){
        int q_pares=0;
        for (int i=0; i<matriz.GetLength(0); i++){
            for (int j=0; j<matriz.GetLength(1); j++){
                if (matriz[i, j] % 2 == 0){
                    q_pares++;
                }
            }
        }
        return q_pares;
    }
    public static void Main(){
        int[,] matriz = new int[3, 3];

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

        Console.WriteLine($"A quantidade de pares na matriz é: {QuantidadePares(matriz)}");
    }
}