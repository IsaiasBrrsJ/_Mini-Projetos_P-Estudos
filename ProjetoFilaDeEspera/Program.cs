using System;
using System.Collections.Generic;
using System.Threading;
namespace FilaDeEspera
{
    class Program
    {
        static int contadorSenhaVermelha = 0;
        static int contadorSenhaAmarelo = 0;
        static int contadorSenhaVerde = 0;
        static void Main(string[] args)
        {
            Menu();

        }
        static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("[1] - Novo Paciente\n[2] - Chamar senha\n\nOpção: ");
                var opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        NovoPaciente();
                        break;
                    case "2":
                        ChamarSenha();
                        break;
                    default:
                        Console.Write("Opção inválida");
                        Thread.Sleep(1000);
                        break;
                }
            }
        }
        static void ChamarSenha()
        {

            if (contadorSenhaAmarelo == 0 && contadorSenhaVerde == 0 && contadorSenhaVermelha == 0)
            {
                Console.WriteLine("Consultório vazio");
                Thread.Sleep(1000);
                return;
            }
            else
            {
                SenhaVermelha();
                SenhAmarela();
                SenhaVerde();
            }
        }
        static void NovoPaciente()
        {
                Console.Write("Nome: ");
                var nomePaciente = Console.ReadLine();
                Console.Write("Febre: ");
                var febrePaciente = float.Parse(Console.ReadLine());

            if (febrePaciente > 38.0f)
                ++contadorSenhaVermelha;
            else if (febrePaciente > 34.0f)
                ++contadorSenhaAmarelo;
            else
                ++contadorSenhaVerde;


               InserirPaciente.AdcionarPaciente(nome: nomePaciente, febre: febrePaciente);
            
        }
        static void SenhaVermelha()
        {
            var pacientesGraves = new List<Paciente>();

            if (contadorSenhaVermelha > 0)
            {
                foreach (var paciente in InserirPaciente.Paciente)
                {
                    if (paciente.grauDeUrgencia.Equals(GrauDeUrgencia.Vermelha))
                    {
                        pacientesGraves.Add(new Paciente { nome = paciente.nome, febre = paciente.febre, senha = paciente.senha, grauDeUrgencia = paciente.grauDeUrgencia });
                    }
                }

                foreach (var paciente in pacientesGraves)
                {
                    int indic = pacientesGraves.IndexOf(paciente);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Nome: {paciente.nome}\nSenha: {paciente.senha}\nUrgência: {paciente.grauDeUrgencia}\n===================");
                    Console.ResetColor();
                    Console.ReadKey();
                    --contadorSenhaVermelha;
                }

            }

            pacientesGraves.Clear();
        }

        static void SenhAmarela()
        {
            var pacientesAmarelo = new List<Paciente>();

            if (contadorSenhaAmarelo > 0)
            {
                foreach (var paciente in InserirPaciente.Paciente)
                {
                    if (paciente.grauDeUrgencia.Equals(GrauDeUrgencia.Amarelo))
                    {
                        pacientesAmarelo.Add(new Paciente { nome = paciente.nome, febre = paciente.febre, senha = paciente.senha, grauDeUrgencia = paciente.grauDeUrgencia });
                    }
                }
            

           
                foreach (var paciente in pacientesAmarelo)
                {
                    int indic = pacientesAmarelo.IndexOf(paciente);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Nome: {paciente.nome}\nSenha: {paciente.senha}\nUrgência: {paciente.grauDeUrgencia}\n===================");
                    Console.ResetColor();
                    Console.ReadKey();
                    --contadorSenhaAmarelo;
                }
            }

            pacientesAmarelo.Clear();

        }

        static void SenhaVerde()
        {
            var pacientesVerde = new List<Paciente>();

            if (contadorSenhaVerde> 0)
            {
                foreach (var paciente in InserirPaciente.Paciente)
                {
                    if (paciente.grauDeUrgencia.Equals(GrauDeUrgencia.Verde))
                    {
                        pacientesVerde.Add(new Paciente { nome = paciente.nome, febre = paciente.febre, senha = paciente.senha, grauDeUrgencia = paciente.grauDeUrgencia });
                    }
                }
          
                foreach (var paciente in pacientesVerde)
                {
                    int indic = pacientesVerde.IndexOf(paciente);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Nome: {paciente.nome}\nSenha: {paciente.senha}\nUrgência: {paciente.grauDeUrgencia}\n===================");
                    Console.ResetColor();
                    Console.ReadKey();
                    --contadorSenhaVerde;
                }
            }

            pacientesVerde.Clear();
        }

    }
}
