using System;
using System.Threading;
using System.Threading.Tasks;

namespace LogSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            MenuLogin();

            Console.ReadKey();
        }
        static void MenuLogin()
        {

            do
            {
                Console.Clear();
                Console.WriteLine(Linha());
                Console.WriteLine("\t\t\tLogin");
                Console.WriteLine(Linha());


                var login = "";
                var senha = "";

                Console.WriteLine("\n" + Linha(menuLogin: true));
                Console.Write("Login: ");
                login = Console.ReadLine();

                Console.Write("Senha: ");
                senha = Console.ReadLine();
                Console.WriteLine(Linha(menuLogin: true));

                var resultadoProcessamentoDadosLogin = CadastrarUsuario.LoginUsuario(login, senha);

                if (resultadoProcessamentoDadosLogin.Equals(false))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("USUÁRIO OU SENHA INCORRETO");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                }
                else
                {
                    TelaDeBoasVindas();
                }
            } while (CadastrarUsuario.UsuarioLogado == null);


        }
        static void TelaDeBoasVindas()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n\n\n\n\n\n\n{Linha()}");
            Console.WriteLine("    BEM-VINDOª " + CadastrarUsuario.UsuarioLogado.Nome);
            Console.WriteLine($"{Linha()}");
            Console.ResetColor();
        }
        static string Linha(bool? menuLogin = false, bool? menu = false) // aqui verifico se as linhas foram chamadas quando for fazer login
        {
            var linha = "-";
            for(int i = 0; i < 55; i++)
            {
                if (menuLogin.Equals(true) && i.Equals(24)) // se a função menuLogin retornar true então só vai gerar 24 linhas
                {
                    
                    return linha += "-"; 
                }
                else if(menu.Equals(true) && i.Equals(32))
                {
                    return linha += "-";
                }
                else
                {
                  linha += "-";      
                }
            }

                return linha;           
        }
    }
}
