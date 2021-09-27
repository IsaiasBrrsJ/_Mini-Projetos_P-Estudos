using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Jokenpo
{
    class Program
    {
        enum Menu { Pedra =1, Papel, Tesoura, sair}; 
        static void Main(string[] args)
        {
            Jogabilidade();
           
        }
        static void Menujogo()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n\t\t==================");
            Console.WriteLine("\n\t\t     JOKENPÔ      ");
            Console.WriteLine("\n\t\t==================");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
        static void Jogabilidade()
        {
   
          string jog = " ";
          int opc = 0;
          Random aleatorio = new Random();
          int sorteio = 0;
          bool sair = false;

          Menujogo();
          Console.Beep();
          Console.Write("Nome do jogador: ");
          jog = Console.ReadLine();
          Console.Clear();

            try {
                while (sair != true)
                {
                    Menujogo();
                    Console.Beep();
                    Console.WriteLine("\n\t\t    1- Pedra\n\t\t    2- Papel\n\t\t    3- Tesoura\n\t\t    4- Sair");
                    Console.Write($"\n\t\tEscolha uma opção {jog}: ");
                    opc = int.Parse(Console.ReadLine());
                    if(opc > 0 && opc < 4) { Console.Beep(); }

                    Console.ResetColor();


                    sorteio = aleatorio.Next(1, 4);

                    Menu opcao = (Menu)opc;
                    Menu opc2 = (Menu)sorteio;

                    if (opc > 0 && opc <= 4)
                    {
                        switch (opcao)
                        {
                            case Menu.Pedra:

                                Pedra(opcao, opc2);

                                break;
                            case Menu.Papel:

                                Papel(opcao, opc2);
                                break;
                            case Menu.Tesoura:

                                Tesoura(opcao, opc2);
                                break;

                            case Menu.sair:
                                sair = !false;
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\t\tEscolha Uma Opção válida....");
                        Thread.Sleep(900);
                        Console.Clear();
                    }
                    if (sair != true)
                    {
                       
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.Write("\n\t\t\aAté Breve...");
                        Thread.Sleep(900);
                    }
                }
            }
            catch
            {
                Console.Write("\n\t\tPreencha as opções Corretamente...");
                Thread.Sleep(900);
                Console.Clear();

                Jogabilidade();
            }
           
            

        }
        static void Pedra(Menu opcao, Menu opc2)
        {
            MaquinaOuJogador(opcao, opc2);
        }
        static void Papel(Menu opcao, Menu opc2)
        {
            MaquinaOuJogador(opcao, opc2);
        }
        static void Tesoura(Menu opcao, Menu opc2)
        {
            MaquinaOuJogador(opcao, opc2);
        }
        static void MaquinaOuJogador(Menu opcao, Menu opc2)
        {
            Perfumaria();
            if (opcao == Menu.Pedra && opc2 != Menu.Papel && opc2 != Menu.Pedra)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n\t\tYou Win, Vencedor...");
                Console.WriteLine($"\n\t\tSua Opção: {opcao}, Opção da Maquina: {opc2}");
            }
           
           else  if(opcao == Menu.Papel && opc2 != Menu.Tesoura && opc2 != Menu.Papel)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n\t\tYou Win, Vencedor...");
                Console.WriteLine($"\n\t\tSua Opção: {opcao}, Opção da Maquina: {opc2}");
            }
           else  if(opcao == Menu.Tesoura && opc2 != Menu.Pedra && opc2 != Menu.Tesoura)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n\t\tYou Win, Vencedor...");
                Console.WriteLine($"\n\t\tSua Opção: {opcao}, Opção da Maquina: {opc2}");
              
            }
            
            else if(opcao == opc2)
            {
                Console.ResetColor();
                Console.WriteLine("\n\t\tEmpate, Não houve vencedores...");
                Console.WriteLine($"\n\t\tSua Opção: {opcao}, Opção da Maquina: {opc2}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\t\tYou Lose, Maquina Venceu...");
                Console.WriteLine($"\n\t\tSua Opção: {opcao}, Opção da Maquina: {opc2}");
                Console.ResetColor();
            }
            
        }
        static void Perfumaria()
        {

            Console.ForegroundColor = ConsoleColor.Red;

            Thread.Sleep(200);
            Console.WriteLine("\n\t\t    JO");
            Thread.Sleep(300);
            Console.WriteLine("\n\t\t      KEN");
            Thread.Sleep(900);
            Console.WriteLine("\n\t\t    PÔ");
            Thread.Sleep(1000);
            
            Console.ResetColor();
        }
   
    }
}
