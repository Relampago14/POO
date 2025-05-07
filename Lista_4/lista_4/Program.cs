using System;

class Pessoa{
    public string Nome;
    public int Matricula;
    private static int c_Pessoas = 0;

    public Pessoa(string nome, int matricula){
        Nome = nome;
        Matricula = matricula;
        incluirPessoa();
    }

    public static int GetContadorPessoas(){
        return c_Pessoas;
    }

    private static void incluirPessoa(){
        c_Pessoas++;
    }

    public string GetNome(){
        return Nome;
    }

    public void SetNome(string novoNome){
        Nome = novoNome;
    }

    public int GetMatricula(){
        return Matricula;
    }

    public void SetMatricula(int novaMatricula){
        Matricula = novaMatricula;
    }
}

class Program{
    public static void Main(){
        Pessoa aluno = new Pessoa("João", 1409);
        Pessoa professor = new Pessoa("Marcos", 2004);

        Console.WriteLine($"Nome do aluno: {aluno.GetNome()}");
        aluno.SetNome("Lineu");
        Console.WriteLine($"Novo nome do aluno: {aluno.GetNome()}");
        Console.WriteLine($"Quantidade de objetos Pessoa: {Pessoa.GetContadorPessoas()}");
    }
}
