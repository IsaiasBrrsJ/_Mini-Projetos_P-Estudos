using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SistemaCrud
{
    static class AtualizarProduto
    {

        public static bool AtualizarProdutos(int codProduto)
        {
            
            int opcaEscolhida = 0;
            int indiceDoProduto = -1;

            foreach (var item in CadastrarProduto.exibirProdutos)
            {
                if (codProduto.Equals(item.codProduot))
                {
                    indiceDoProduto = CadastrarProduto.exibirProdutos.IndexOf(item);
                    escolhaUmaOpcao:
                    do
                    {
                        Console.Clear();
                        Console.Write("\n[ 1 ] Nome\n[ 2 ] Peso\n[ 3 ] Quantidade\n[ 4 ] Descrição\n[ 5 ]Data de Validade\n[ 6 ] Preço\n[ 7 ] Código do produto\n[ 8 ] MENU\n\nOpção: ");
                        opcaEscolhida = int.Parse(Console.ReadLine());

                    } while (opcaEscolhida < 0 || opcaEscolhida > 8);


                    switch (opcaEscolhida)
                    {
                        case 1:
                            AlterarNome(indiceDoProduto);
                        break;
                        case 2:
                            AlterarPeso(indiceDoProduto);
                        break;
                        case 3:
                            AlterarQuantidade(indiceDoProduto);
                            break;
                        case 4:
                            AlterarDescricao(indiceDoProduto);
                            break;
                        case 5:
                            AlterarDataValidade(indiceDoProduto);
                            break;
                        case 6:
                            AlterarPreco(indiceDoProduto);
                            break;
                        case 7:
                            AlterarCodProduto(indiceDoProduto);
                            break;
                        case 8:
                            return true;
                        default:
                            goto escolhaUmaOpcao; 
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Produto Atualizado com sucesso");
                    Thread.Sleep(1000);
                    Console.ResetColor();
                    AtualizarProdutos(codProduto);
                }
            }


            return false;
        }
        static void AlterarNome(int indice)
        {
            Console.Write("Novo Nome: ");
            var novoNome = Console.ReadLine();

            CadastrarProduto.exibirProdutos[indice].nomeProduto = novoNome;
            
        }
        static void AlterarPeso(int indice)
        {
            Console.Write("Novo Peso: ");
            var novoPeso = Console.ReadLine();

            CadastrarProduto.exibirProdutos[indice].pesoProduto = novoPeso;
           
        }
        static void AlterarQuantidade(int indice)
        {
            Console.Write("Nova Quantidade: ");
            var novaQuantidade =int.Parse(Console.ReadLine());

            CadastrarProduto.exibirProdutos[indice].quantidadeProduto = novaQuantidade;
            
        }
        static void AlterarDescricao(int indice)
        {
            Console.Write("Nova Descrição: ");
            var novaDescricao = Console.ReadLine();

            CadastrarProduto.exibirProdutos[indice].descricaoProduto = novaDescricao;
            
        }
        static void AlterarDataValidade(int indice)
        {
            Console.Write("Nova Data De Validade: ");
            var novaDataDeValidade = Console.ReadLine();

            CadastrarProduto.exibirProdutos[indice].dataValidade = novaDataDeValidade;
           
        }
        static void AlterarPreco(int indice)
        {
            Console.Write("Novo Preço: ");
            var novaPrec= decimal.Parse(Console.ReadLine());

            CadastrarProduto.exibirProdutos[indice].precoProduto = novaPrec;
        }

        static void AlterarCodProduto(int indice)
        {
            Console.Write("Nova Código do produto: ");
            var novaCodProduto =int.Parse(Console.ReadLine());

            CadastrarProduto.exibirProdutos[indice].codProduot = novaCodProduto;
        }


    }
}
