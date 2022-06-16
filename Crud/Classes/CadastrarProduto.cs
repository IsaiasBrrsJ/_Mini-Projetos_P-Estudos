using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaCrud
{
    static class  CadastrarProduto
    {

        private static List<ModeloProduto> _adcionarProduto;

        static CadastrarProduto()
        {
            _adcionarProduto = new List<ModeloProduto>();
        }

        public static void CadastrarProdutos(ModeloProduto produto)
        {
            _adcionarProduto.Add(produto);
        }

        public static List<ModeloProduto> exibirProdutos
        {
            get => _adcionarProduto;
        }
    }
}
