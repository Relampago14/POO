using System;

class ContaBancaria{
    protected int NumeroConta;
    protected string Titular;
    protected double Saldo;

    public ContaBancaria(int numeroconta, string titular){
        NumeroConta = numeroconta;
        Titular = titular;
        Saldo = 0;
    }

    public void Depositar(double valor){
        this.Saldo += valor;

        Console.WriteLine($"\nOperação concluída. Saldo atual = R$ {this.Saldo:0.00}");
    }

    public void Sacar(double valor){
        if (this.Saldo >= valor){
            this.Saldo -= valor;
            Console.WriteLine($"\nOperação concluída. Saldo atual = R$ {this.Saldo:0.00}");
        }

        else{
            Console.WriteLine($"A operação não foi concluída. Saldo de R$ {this.Saldo:0.00} insuficiente");
        }
    }
}

class ContaPremium:ContaBancaria{
    public ContaPremium(int numeroconta, string titular) 
        : base(numeroconta, titular){
        Saldo = 0;
    }

    public void AplicarCashBack(double percentual){
        Console.Write("Digite o valor da compra: ");
        double compra = double.Parse(Console.ReadLine());

        this.Saldo += (percentual / 100) * compra;

        Console.WriteLine($"\nOperação concluída. Saldo atual = R$ {this.Saldo:0.00}");
    }
}

sealed class Auditoria{
    private List<string> Operacoes = new List<string>();

    public void RegistrarOperacao(string operacao){
        Operacoes.Add(operacao);
    }

    public void ExibirLogs(){
        foreach (string operacao in Operacoes){
            Console.WriteLine(operacao);
        }
    }
}

class Program{
    public static void Main(){
        ContaPremium conta = new ContaPremium(1 , "João Marcos Moreira Laudares");
        Auditoria auditoria = new Auditoria();

        conta.Depositar(200);
        auditoria.RegistrarOperacao($"Depósito - R$ 200,00");


        conta.Sacar(100);
        auditoria.RegistrarOperacao($"Saque - R$ 100,00");


        Console.Write("Digite o percentual do cashback: ");
        double percentual = double.Parse(Console.ReadLine());
        conta.AplicarCashBack(percentual);
        auditoria.RegistrarOperacao($"CashBack - {percentual}%");

        auditoria.ExibirLogs();
    }
}