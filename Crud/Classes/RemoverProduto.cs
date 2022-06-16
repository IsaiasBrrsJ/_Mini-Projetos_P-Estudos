using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SistemaCrud
{
    static class RemoverProduto
    {

       public static bool RemoverProdutos(int codProduto)
        {
            int opcaEscolhida = 0;
            int indiceDoProduto = -1;


            foreach (var item in CadastrarProduto.exibirProdutos)
            {

                if (codProduto.Equals(item.codProduot))
                {
                    indiceDoProduto = CadastrarProduto.exibirProdutos.IndexOf(item);
                    try
                    {
                        do
                        {
                            string certezaQueDesejaRemover = String.Format($"\n\nCerteza que deseja remover\nNome: {item.nomeProduto}\nCódigo:{item.codProduot}\n\n(1-Sim) (2-Não): ");
                            Console.Write(certezaQueDesejaRemover);
                            opcaEscolhida = int.Parse(Console.ReadLine());

                            if (opcaEscolhida.Equals(1))
                            {
                                CadastrarProduto.exibirProdutos.RemoveAt(indiceDoProduto);

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("Produto removido com sucesso");
                                Thread.Sleep(1000);
                                Console.ResetColor();
                                return true;
                            }

                        } while (opcaEscolhida < 0 || opcaEscolhida > 2);
                    }
                    catch
                    {
                        Console.Write("Escolha uma opão válida");
                        Console.Clear();
                        Console.ReadKey();
                        RemoverProdutos(codProduto);
                    }
                }
                else
                {
                    Console.Write("Produto não encontrado");
                }

             

            }

            return false;
        }
    }
}
