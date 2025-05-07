using System;

public class Compra{
    public string Item;
    public double Valor;

    public Compra(string item, double valor){
        Item = item;
        Valor = valor;
    }
}

class Program{
    public static void Main(){
        Cliente cliente = new Cliente("João Marcos", "email@gmail.com", "(31) 9 9999-9999");
        Compra compra_1 = new Compra("Luva boxe", 99.99);
        Compra compra_2 = new Compra("Saco de Pancada", 199.99);
        cliente.Compras.Add(compra_1);
        cliente.Compras.Add(compra_2);

        Console.WriteLine($"{cliente.Nome}, {cliente.Email}, {cliente.Numero_Telefone}");
        foreach (Compra compra in cliente.Compras){
            Console.Write($"{compra.Item} ");
            Console.WriteLine(compra.Valor);
        }
    }
}