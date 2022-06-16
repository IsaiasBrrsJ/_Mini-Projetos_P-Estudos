using System;
using System.Threading;
namespace SistemaCrud
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
            var opcao = 0;
            Console.Clear();

            do
            {
                Console.WriteLine(Linha());
                Console.WriteLine("\t\tSistema Gerenciador");
                Console.WriteLine(Linha());

                Console.WriteLine("\n[ 1 ] Cadastrar Produto");
                Console.WriteLine("[ 2 ] Remover Produto ");
                Console.WriteLine("[ 3 ] Listar Produtos");
                Console.WriteLine("[ 4 ] Atualizar Produto");
                Console.WriteLine("[ 0 ] Sair");

                try
                {
                    Console.Write("\nEscolha Uma Opção: ");
                    opcao = int.Parse(Console.ReadLine());

                   
                }
                catch
                {
                    Menu();
                }

                Opcoes opcoes = (Opcoes)opcao;

                switch (opcoes)
                {
                    case Opcoes.CadastrarNovoProduto:
                        CadastrarNovoProduto();
                        break;
                    case Opcoes.RemoverProduto:
                        RemoverProdutos();
                        break;
                    case Opcoes.ListarProdutos:
                        ListarProduto.ListarProdutos();
                        Console.ReadKey();
                        Menu();
                        break;
                    case Opcoes.AtualizarProduto:
                        AtualizarProdutos();
                        break;
                    case Opcoes.Sair:
                        Environment.Exit(0);
                        break;
                    default:
                        Menu();
                        break;
                }
            } while (opcao.Equals(5));

        }
        static void RemoverProdutos()
        {
            Console.Clear();
            int codProduto = 0;

            int produtosCadastrados = CadastrarProduto.exibirProdutos.Count;
            if (produtosCadastrados > 0)
            {
                try
                {
                    ListarProduto.ListarProdutos();
                    Console.Write("\nInforme o código do produto que deseja remover: ");
                    codProduto = int.Parse(Console.ReadLine());

                   var resultadoDaExclusao =  RemoverProduto.RemoverProdutos(codProduto);

                    if (resultadoDaExclusao)
                    {
                        Menu();
                    }

                }
                catch
                {
                    Console.Write("Preencha as informações corretamente...");
                    Thread.Sleep(1000);

                    RemoverProdutos();

                }
            }
            else
            {
                Console.Write("Estoque vazio");
                Thread.Sleep(1000);
            }

            Menu();
             
             
        }
        static void AtualizarProdutos()
        {
            Console.Clear();
            int codProduto = 0;

            int produtosCadastrados = CadastrarProduto.exibirProdutos.Count;
            if (produtosCadastrados > 0)
            {
                try
                {
                    ListarProduto.ListarProdutos();
                    Console.Write("\nInforme o código do produto que deseja Atualizar: ");
                    codProduto = int.Parse(Console.ReadLine());

                    var resultadoProcessamento = AtualizarProduto.AtualizarProdutos(codProduto);

                    if (resultadoProcessamento)
                    {
                        Menu();
                    }
                }
                catch
                {
                    Console.Write("Preencha as informações corretamente...");
                    Thread.Sleep(1000);

                    AtualizarProdutos();

                }
            }
            else
            {
                Console.Write("Estoque vazio");
                Thread.Sleep(1000);
            }

            Menu();
        }

        static void CadastrarNovoProduto()
        {
            Console.Clear();
            Console.WriteLine(Linha());
            Console.WriteLine("\t\tCadastrar Novo Produto");
            Console.WriteLine(Linha());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n"+Linha());
            Console.Write("Nome Produto: ");
             var nomeProd = Console.ReadLine();

            Console.Write("Peso do Produto: ");
            var pesoProd = Console.ReadLine();

            Console.Write("Descrição: ");
            var decricaoProduto = Console.ReadLine();

            Console.Write("Data de Validade: ");
             var dataValidade = Console.ReadLine();

            decimal preco = 0.0m;
            int qtdProduto = -1;
            int codProduto = -1;

            CasoPreenchaAlgumaInformacaoIncorretaEleVoltaAqui:
            try
            {   
                Console.Write("Preço: ");
                 preco = decimal.Parse(Console.ReadLine());

                Console.Write("Quantidade: ");
                 qtdProduto = int.Parse(Console.ReadLine());

                Console.Write("Cod do Produto: ");
                 codProduto = int.Parse(Console.ReadLine());
                Console.WriteLine(Linha());
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Preencha as informações corretamente..");
                Console.ResetColor();
                goto CasoPreenchaAlgumaInformacaoIncorretaEleVoltaAqui;
                
            }
            Console.ResetColor();

           var retornoDaVerificacao = verificarSeContemNuloOuEmBranco(nomeProd, pesoProd, qtdProduto, decricaoProduto, dataValidade, preco, codProduto);

            if (retornoDaVerificacao.Equals(false))
            {
                SalvarProduto(nomeProd, pesoProd, qtdProduto, decricaoProduto, dataValidade, preco, codProduto);
                Console.Write("\n\nProduto Cadastrado com sucesso");

            }
            else
            {
                Console.Write("Preencha todas as informações...");
                Console.ReadKey();
                CadastrarNovoProduto();
            }

            int continuarCadastrando = -1;

            ContinuarCadastrando:
            try
            {
                Console.Write("\n\nContinuar Cadastrando Produto (1 - Sim)/(2 -Não): ");
                continuarCadastrando = int.Parse(Console.ReadLine());

                switch (continuarCadastrando)
                {
                    case 1:
                        CadastrarNovoProduto();
                        break;
                    case 2:
                         Menu();
                        break;
                    default:
                        goto ContinuarCadastrando;
                      
                }
            }
            catch
            {
                Console.WriteLine("Escolha uma opção válida...");
                goto ContinuarCadastrando;
            }


        }

        static bool verificarSeContemNuloOuEmBranco(string nomeProduto, string pesoProduto, object qtdProduto,
            string descricaoDoProduto, string dataValidade, decimal preco, int codProduto
            )
        {
           
            object[] produtos = { nomeProduto, pesoProduto, qtdProduto, descricaoDoProduto, dataValidade, preco, codProduto };

            foreach (var item in produtos)
            {
               
                if (String.IsNullOrEmpty(item.ToString()))
                {
                    return true;
                }
            }

            return false;
        }

        static void SalvarProduto(string nomeProd, string pesoProd, int qtdProduto, string decricaoProduto,
            string dataValidade, decimal preco, int codProduto)
        {
            var produtos = new ModeloProduto
            {
                nomeProduto = nomeProd,
                pesoProduto = pesoProd,
                quantidadeProduto = qtdProduto,
                descricaoProduto = decricaoProduto,
                dataValidade = dataValidade,
                precoProduto = preco,
                codProduot = codProduto,
                entradaNoEstoque = DateTime.Now

            };

            CadastrarProduto.CadastrarProdutos(produtos);
        }



        static string Linha()
        {
            var linha = "";
            while(linha.Length < 55)
            {
                linha += "-";
            }
            return linha;


            
        }
    }
}
