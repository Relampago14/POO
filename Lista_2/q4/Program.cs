using System;
using System.Collections.Generic;

class Program{
    public class Dependente{
        public int NumeroCota { get; set; }
        public string NomeDependente { get; set; }
        public DateTime DataNascimento { get; set; }

        public Dependente(int numeroCota, string nomeDependente, DateTime dataNascimento){
            NumeroCota = numeroCota;
            NomeDependente = nomeDependente;
            DataNascimento = dataNascimento;
        }
    }
    public class Socio{
        public int NumeroCota { get; set; }
        public string NomeSocio { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataAquisicao{ get; set; }
        public List<Dependente> Dependentes { get; set; }

        public Socio(int numeroCota, string nomeSocio, DateTime dataNascimento, DateTime dataAquisicao){
            NumeroCota = numeroCota;
            NomeSocio = nomeSocio;
            DataNascimento = dataNascimento;
            DataAquisicao = dataAquisicao;
            Dependentes = new List<Dependente>();
        }

    }
    public class Socios{
        public List<Socio> ListaSocios = new List<Socio>();

        public void CadastrarSocio(){
            Console.Write("Digite o número da cota: ");
            int numeroCota = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do sócio: ");
            string nomeSocio = Console.ReadLine();

            Console.Write("Data de Nascimento (dd/mm/aaaa): ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Data de Aquisição da Cota (dd/mm/aaaa): ");
            DateTime dataAquisicao = DateTime.Parse(Console.ReadLine());

            Socio socio = new Socio(numeroCota, nomeSocio, dataNascimento, dataAquisicao);
            ListaSocios.Add(socio);
        }

        public void CadastrarDependente(Socio socio){
            Console.Write("Digite o número da cota: ");
            int numeroCota = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do sócio: ");
            string nomeDependente = Console.ReadLine();

            Console.Write("Data de Nascimento (dd/mm/aaaa): ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
            Dependente dependente = new Dependente(numeroCota, nomeDependente, dataNascimento);

            socio.Dependentes.Add(dependente);
        }

        public void ListarSocios(){
            foreach (Socio socio in ListaSocios){
                Console.WriteLine($"{socio.NumeroCota} {socio.NomeSocio} {socio.DataNascimento} {socio.DataAquisicao}");
                foreach (Dependente dependente in socio.Dependentes){
                    Console.WriteLine($"{dependente.NumeroCota} {dependente.NomeDependente} {socio.DataNascimento}");
                }
            }
        }

        public void RemoverSocio(){
            Console.Write("Digite o número da cota do sócio a ser removido: ");
            int numeroCota = int.Parse(Console.ReadLine());

            Socio socio = ListaSocios.Find(s => s.NumeroCota == numeroCota);
            if (socio != null){
                ListaSocios.Remove(socio);
                Console.WriteLine($"Sócio {socio.NomeSocio} removido com sucesso!\n");
            }
            else{
                Console.WriteLine("Erro: Sócio não encontrado.\n");
            }
        }
    }
    public static void Main(){
        Socios socios = new Socios();
        socios.CadastrarSocio();

        socios.CadastrarDependente(socios.ListaSocios[0]);

        socios.ListarSocios();

        socios.RemoverSocio();

        socios.ListarSocios();
    }
}