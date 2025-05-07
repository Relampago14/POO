using System;
using System.Drawing;

abstract class Shape{
    private Color Color;

    public abstract double Area();
}

class Rectangle:Shape{
    private double Width;
    private double Height;

    public Rectangle(double width, double height){
        Width = width;
        Height = height;
    }

    public override double Area(){
        return Width * Height;
    }
}

class Circle:Shape{
    private double Radius;

    public Circle(double radius){
        Radius = radius;
    }

    public override double Area(){
        return Math.PI * Math.Pow(Radius, 2);
    }
}

class Program{
    public static void Main(){
        List<Shape> shapes = new List<Shape>();

        Console.Write("Digite a quantidade de figuras: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++){        
            while (true){
                Console.WriteLine("\nA figura é um retângulo ou círculo? \n1 - Retângulo\n2 - Círculo");

                switch (Console.ReadLine()){
                    case "1":
                        Console.Write("\nDigite a largura: ");
                        double width = double.Parse(Console.ReadLine());
                        Console.Write("\nDigite a altura: ");
                        double height = double.Parse(Console.ReadLine());

                        Rectangle rectangle = new Rectangle(width, height);
                        shapes.Add(rectangle);

                        break;

                    case "2":
                        Console.Write("\nDigite o raio: ");
                        double radius = double.Parse(Console.ReadLine());

                        Circle circle = new Circle(radius);
                        shapes.Add(circle);

                        break;

                    default:
                        Console.WriteLine("Selecione as opções válidas.");

                    break;       
                }

                break;
            }
        }

        foreach (Shape shape in shapes){
            Console.Write($"{shape} ");
            Console.WriteLine($"{shape.Area():0.00}");
        }
    }
}