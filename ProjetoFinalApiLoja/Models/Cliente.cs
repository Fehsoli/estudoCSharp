using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinalApiLoja.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string NomeCliente { get; set; }
        public string CpfCliente { get; set; }
        public string EnderecoCliente { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int LojaId { get; set; }
        public Loja Loja { get; set; }

    }
}
