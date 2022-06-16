using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaCrud
{
    class ModeloProduto
    {
        public string nomeProduto { get; set; }
        public string pesoProduto { get; set; }
        public int quantidadeProduto { get; set; } 
        public string descricaoProduto { get; set; }
        public string dataValidade { get; set; }
        public DateTime entradaNoEstoque { get; set; }
        public decimal precoProduto { get; set; }
        public int codProduot { get; set; }
    }
}
