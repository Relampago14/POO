using System;

public class Program{
    public static bool VerificaPalindromo(string texto){
        string compara="";
        for (int i=texto.Length; i>0; i--){
            compara+=texto[i-1];
        }
        
        if (texto == compara){
            return true;
        }

        return false;
    }
    public static void Main(){
        Console.Write("Digite uma palavra qualquer: ");
        bool result = VerificaPalindromo(Console.ReadLine());

        if (result){
            Console.WriteLine("\nA palavra é um palíndromo.");
        }

        else{
            Console.WriteLine("\nA palavra não é um palíndromo.");
        }
    }
}