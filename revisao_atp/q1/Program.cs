using System;

public class Program{
    public static double CalculaMediaNota(double[] notas){
        double media = 0;
        for (int i=0; i<notas.Length; i++){
            media += notas[i];
        }
        return media/notas.Length;
    }
    public static void CriaVetor(int q_notas){
        double[] notas = new double [q_notas];
        for (int i=0; i<q_notas; i++){
            Console.WriteLine($"Escreva o valor da nota {i+1}");
            notas[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine(CalculaMediaNota(notas));

        
    }
    public static void Main(){
        int q_notas;
        
        Console.WriteLine("Digite a quantidade de notas a serem inseridas: ");
        q_notas = int.Parse(Console.ReadLine());

        CriaVetor(q_notas);
    }
}