using System;

class Veiculo{
    public virtual void Mover(){
        Console.WriteLine("O veículo está se movendo");
    }
}

class Carro : Veiculo{
    public override void Mover(){
        Console.WriteLine("O carro está dirigindo na estrada");
    }
}

class Bicicleta : Veiculo{
    public override void Mover(){
        Console.WriteLine("A bicicleta está sendo pedalada");
    }
}

class Program{
    public static void Main(){
        Veiculo veiculo = new Veiculo();
        Carro carro = new Carro();
        Bicicleta bicicleta = new Bicicleta();

        veiculo.Mover();
        carro.Mover();
        bicicleta.Mover();
    }
}