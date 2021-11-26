using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinalApiLoja.Models
{
    public class Loja
    {
        public int LojaId { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }
        public List<Produto> Produtos { get; set; }
        public List <Funcionario> Funcionarios { get; set; }
        public List <Cliente> Clientes { get; set; }
    }
}
