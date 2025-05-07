using System;

public abstract class Forma{
    public abstract double CalcularArea();
}

public class Retangulo : Forma{
    double Largura;
    double Altura;

    public Retangulo(double largura, double altura){
        Largura = largura;
        Altura = altura;
    }

    public override double CalcularArea(){
        return Largura * Altura;
    }
}

public class Circulo : Forma{
    double Raio;

    public Circulo(double raio){
        Raio = raio;
    }

    public override double CalcularArea(){
        return Math.PI * Math.Pow(Raio, 2);
    }
}

class Program{
    public static void Main(){
        List<Forma> formas = new List<Forma>();

        formas.Add(new Retangulo(2, 3));
        formas.Add(new Circulo(5));

        foreach (var forma in formas){
            Console.WriteLine($"Área da forma: {forma.CalcularArea():F2}");
        }
    }
}
