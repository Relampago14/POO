using System;

class Animal{
    public virtual void FazerSom(){
        Console.WriteLine("O animal está fazendo um som");
    }
}

class Cachorro : Animal{
    public override void FazerSom(){
        base.FazerSom();
        Console.WriteLine("O cachorro late: Au Au!");
    }
}

class Program{
    Cachorro cachorro = new Cachorro();
}