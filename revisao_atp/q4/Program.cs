using System;

public class Program{
    public static int Fatorial(int n){
        if (n==0){
            return 1;
        }

        int fatorial=n;
        do{
            fatorial*=n-1;
            n-=1;
        } while (n>1);
        return fatorial;
    }
    public static int VerifNum(int n){
        while (true){
            if(n<0){
                Console.WriteLine("Digite um valor maior ou igual a zero: ");
                n = int.Parse(Console.ReadLine());
            }
            else{
                break;
            }
        }
        return n;
    }
    public static void Main(){
        Console.WriteLine("Digite um valor para calcular o fatorial: ");
        Console.Write($"O fatorial é: {Fatorial(VerifNum(int.Parse(Console.ReadLine())))}");
    }
}