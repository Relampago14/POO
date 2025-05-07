using System;

class Program{
    public class Data{
        int Dia { get; set; }
        int Mes { get; set; }
        int Ano { get; set; }

        public Data(int dia, int mes, int ano){
            Dia = dia;
            Mes = mes;
            Ano = ano;
        }
    }
    public class Funcionario{
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Departamento { get; set; }
        public double Salario { get; set; }
        public Data DataAdmissao{ get; set; }

        public Funcionario(int matricula, string nome, string departamento, double salario, Data dataadmissao){
            Matricula = matricula;
            Nome = nome;
            Departamento = departamento;
            Salario = salario;
            DataAdmissao = dataadmissao;
        }
    }

    public class Funcionarios{
        public List<Funcionario> ListaFuncionarios;
        public int Capacidade_Maxima;

        public Funcionarios(){
            ListaFuncionarios = new List<Funcionario>();
            Capacidade_Maxima = 5;
        }

        public void CadastrarFuncionario(int matricula, string nome, string departamento, double salario, Data dataadmissao){
            Funcionario funcionario = new Funcionario(matricula, nome, departamento, salario, dataadmissao);
            ListaFuncionarios.Add(funcionario);
        }

        public void ListarFuncionarios(){
            if (ListaFuncionarios.Count == 0){
                Console.WriteLine("O cadastro está vazio.");
            }
            else{
                Console.WriteLine("Digite a opção desejada para filtrar");
                Console.Write("1 - Todos\n2 - Comercial\n3 - Administrativo");
                string op = Console.ReadLine();
                switch(op){
                    case "1":
                        foreach (Funcionario func in ListaFuncionarios){
                            Console.WriteLine($"Nome: {func.Nome}, Matrícula: {func.Matricula}, Departamento: {func.Departamento}, Salário: {func.Salario}, Admissão: {func.DataAdmissao}");
                        }
                        break;
                    case "2":
                        foreach (Funcionario func in ListaFuncionarios){
                            if (func.Departamento == "Comercial")
                                Console.WriteLine($"Nome: {func.Nome}, Matrícula: {func.Matricula}, Departamento: {func.Departamento}, Salário: {func.Salario}, Admissão: {func.DataAdmissao}");
                        }
                        break;
                    case "3":
                        foreach (Funcionario func in ListaFuncionarios){
                            if (func.Departamento == "Administrativo")
                                Console.WriteLine($"Nome: {func.Nome}, Matrícula: {func.Matricula}, Departamento: {func.Departamento}, Salário: {func.Salario}, Admissão: {func.DataAdmissao}");
                        }
                        break;
                }
            }
        }
    }

    public static void GeraFuncionario(Funcionarios funcionarios, int n_funcs){
        if (n_funcs > 0){
            int matricula = n_funcs;

            Console.Write("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.WriteLine("\nDigite o departamento do funcionário: ");
            Console.WriteLine("1 - Comercial \n2 - Administrativo");
            string departamento = Console.ReadLine();
            switch(departamento){
                case "1":
                    departamento = "Comercial";
                    break;
                case "2":
                    departamento = "Administrativo";
                    break;
                default:
                    break;
            }

            Console.Write("\nDigite o salário do funcionário: ");
            double salario = double.Parse(Console.ReadLine());

            DateTime localDate = DateTime.Now;
            Data data = new Data(localDate.Day, localDate.Month, localDate.Year);

            funcionarios.CadastrarFuncionario(matricula, nome, departamento, salario, data);
        }
        else{
            Console.WriteLine("\nNúmero de Funcionários excedido.\n");
        }
    }

    public static void Main(){
        Funcionarios funcionarios = new Funcionarios();
        int n_funcs = 50;

        bool sts = true;
        while (sts){
            Console.WriteLine("Digite uma opção");
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Cadastrar funcionário \n2 - Listar funcionários por departameto \n3 - Sair");
            string op = Console.ReadLine();
            switch(op){
                case "1":
                    GeraFuncionario(funcionarios, n_funcs);
                    n_funcs -= 1;
                    break;
                case "2":
                    funcionarios.ListarFuncionarios();
                    break;
                case "3":
                    sts = false;
                    break;
                default:
                    Console.WriteLine("\nOpção inválida\n");
                    break;
            }
        }
        
    }
}