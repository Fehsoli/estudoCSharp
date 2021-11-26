using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinalApiLoja.Models
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        public string NomeFunc { get; set; }
        public string CpfFunc { get; set; }
        public string EnderecoFunc { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public int LojaId { get; set; }
        public Loja Loja { get; set; }
    }
}
