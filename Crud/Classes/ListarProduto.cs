using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaCrud
{
    static class ListarProduto
    {
       
        public static void ListarProdutos()
        {
            Console.Clear();
            var resultado = "Não existe produtos Cadastrados";
            var produtosCadastrados = CadastrarProduto.exibirProdutos.Count;
            if (produtosCadastrados > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                foreach (var it in CadastrarProduto.exibirProdutos)
                {

                    resultado = String.Format($"\n\n\nNome: {it.nomeProduto}\nPeso: {it.pesoProduto}\nQuantidade: {it.quantidadeProduto}\nDescrição: {it.descricaoProduto}\nData de Validade: {it.dataValidade}" +
                        $"\nPreço: {it.precoProduto.ToString("C")}\nCódigo do Produto: {it.codProduot}\nEntrada no estoque: {it.entradaNoEstoque}");

                    Console.WriteLine(resultado);
                    Console.WriteLine("===============================================");
                }

                Console.ResetColor();
            }
            else
            {

                Console.WriteLine(resultado);

            }

        }
    }
}
