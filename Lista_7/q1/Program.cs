using System;

class Matematica{
    public static int Multiplicar(int n1, int n2){
        return n1 * n2;
    }

    public static int Multiplicar(int n1, int n2, int n3){
        return n1 * n2 * n3;
    }

    public static double Multiplicar(double n1, double n2){
        return n1 * n2;
    }
}

class Program{
    public static void Main(){
        int n1 = 2, n2 = 3, n3 = 4;
        double n4 = 5, n5 = 6;

        Console.WriteLine(Matematica.Multiplicar(n1, n2));
        Console.WriteLine(Matematica.Multiplicar(n1, n2, n3));
        Console.WriteLine(Matematica.Multiplicar(n4, n5));
    }
}