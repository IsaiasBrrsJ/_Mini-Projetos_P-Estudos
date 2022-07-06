using System;
using System.Threading;

namespace JokenpoReaplicando
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }

        static void Menu()
        {
           
            try
            {
                int opcaoJogador = -1;
              do { 
                Console.Clear();

                
                Console.WriteLine(Linha());
                Console.WriteLine("  PEDRA | PAPEL | TESOURA");
                Console.WriteLine(Linha());
                Console.Write("\n[ 1 ] Pedra\n[ 2 ] Papel\n[ 3 ] Tesoura\n\nOpção: ");
              
                    opcaoJogador = int.Parse(Console.ReadLine());

              } while (opcaoJogador < 1 || opcaoJogador > 3);


                 StartGame(opcao: opcaoJogador);
                Console.ReadKey();

                Menu();
                

            }
            catch
            {
                Console.Write("Opcao Inválida");
                Thread.Sleep(1000);
                Menu();
            }


        }


        static void StartGame(int opcao)
        {
            var game = new Game();
           
            switch (game.jogadas(opcao))
            {
                case Game.Resultado.Ganhar:
                    Console.WriteLine($"Você ganhou... Sua Escolha: {game.jogadaUser} | Máquina: {game.jogadaMaquina}");
                    break;
                case Game.Resultado.Perder:
                    Console.WriteLine($"Você perdeu... Sua Escolha: {game.jogadaUser} | Máquina: {game.jogadaMaquina}");
                    break;
                case Game.Resultado.Empatar:
                    Console.WriteLine($"Empate... Sua Escolha: {game.jogadaUser} | Máquina: {game.jogadaMaquina}");
                    break;
            }
        }
        static string Linha()
        {
            var linha = "";
            for(int i = 0; i < 30; i++)
            {
              linha += "-";
            }

            return linha;

        }
    }
}
