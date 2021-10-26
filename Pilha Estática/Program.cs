using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaEstaticaC
{
    class Program
    {   

        struct Livros
        {
            public string Titulo;
            public string Editora;
            public int Cod_Livro;

        }
        const int qtdMaxima = 2;
        static Livros[] adcioarLivro = new Livros[qtdMaxima];
        static int contador = 0;

        enum Menu{ Empilhar = 1, Desempilhar, Listar, Sair}

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.Write("\n1- Empilhar\n2- Desempilhar\n3- Listar\n4- Sair\n\nOpção: ");
                int opc = int.Parse(Console.ReadLine());

                Menu opcSelecionada = (Menu)opc;

                if(opc > 0 && opc < 5)
                {
                    switch (opcSelecionada)
                    {
                        case Menu.Empilhar:
                            Empilhar();
                            break;
                        case Menu.Desempilhar:
                            Desempilhar();
                            break;
                        case Menu.Listar:
                            Listar();
                            break;
                        case Menu.Sair:
                            return;
                    }
                }
            }
        }
        static void Empilhar()
        {
            int contadorEmpilhar = contador;

            if (contador < qtdMaxima)
            {
                for (int i = contadorEmpilhar; i < qtdMaxima; i++)
                {
                    Console.Write("\nTitulo: ");
                    adcioarLivro[i].Titulo = Console.ReadLine();

                    Console.Write("\nEditora: ");
                    adcioarLivro[i].Editora = Console.ReadLine();

                    Console.Write("\nCodigo Livro: ");
                    adcioarLivro[i].Cod_Livro = int.Parse(Console.ReadLine());

                  

                    Console.Write("Empilhar mais (1- Sim / 2- Não)? ");
                    int emp = int.Parse(Console.ReadLine());

                    if (emp == 1)
                        contador++;
                    else
                    {
                        contador++;
                        return;
                        
                    }
                    
                }
            }
            else
            {
                Console.Write("\nPilha Cheia...");
                Console.ReadKey();
            }
        }

        static void Listar()
        {
            if(contador != 0)
            {   
                for(int i = contador-1; i >= 0; i--)
                {
                    if (adcioarLivro[i].Titulo != null)
                    {
                        Console.WriteLine($"\nTitulo: {adcioarLivro[i].Titulo}\n" +
                            $"Editora: {adcioarLivro[i].Editora}\nCodLivro: {adcioarLivro[i].Cod_Livro}\n");
                    }
                }
            }
            else
            {
                Console.Write("\nPILHA ESTÁ VAZIA...");
            }

            Console.ReadKey();
        }

        static void Desempilhar()
        {
            if(contador != 0)
            {
                if (adcioarLivro[contador-1].Titulo != null)
                {
                    Console.WriteLine($"\nTitulo: {adcioarLivro[contador-1].Titulo}\n" +
                        $"Editora: {adcioarLivro[contador-1].Editora}\nCodLivro: {adcioarLivro[contador-1].Cod_Livro}\n");

                    Console.Write("\nConfirma o desempilhamento  (1- sim / 2 - não )? ");
                    int desempilhar = int.Parse(Console.ReadLine());
                    if (desempilhar == 1)
                    {
                        contador--;

                        Console.WriteLine("\nDesempilhado com sucesso...");
                    }
                    else
                        return;
                }
            }
            else
            {
                Console.WriteLine("\nPILHA VAZIA...");
            }
            Console.ReadKey();
        }
    }
}
