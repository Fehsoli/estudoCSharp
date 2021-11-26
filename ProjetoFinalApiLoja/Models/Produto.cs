using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinalApiLoja.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; } // eletrônicos, CD's, Discos, etc...
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public int LojaId { get; set; }
        public Loja Loja { get; set; }
    }
}
