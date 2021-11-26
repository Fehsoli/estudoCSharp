using Microsoft.EntityFrameworkCore;
using ProjetoFinalApiLoja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinalApiLoja.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Loja> Lojas { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .Property(p => p.Preco)
                    .HasPrecision(10, 2);

            modelBuilder.Entity<Funcionario>()
                .Property(s => s.Salario)
                    .HasPrecision(10, 2);

            modelBuilder.Entity<Loja>()
                .HasData(
                    new Loja
                    {
                        LojaId = 1,
                        RazaoSocial = "Loja MLP Records - Matriz",
                        Cnpj = "01.001.001/0001-01",
                        Endereco = "Avenida Douradinho, 779"
                    },
                    new Loja
                    {
                        LojaId = 2,
                        RazaoSocial = "Loja MLP Records II",
                        Cnpj = "01.001.001/0002-02",
                        Endereco = "Rua da Mata, 541",
                    },
                    new Loja
                    {
                        LojaId = 3,
                        RazaoSocial = "Loja MLP Records III",
                        Cnpj = "01.001.001/0003-03",
                        Endereco = "Avenida Xavier, 872",
                    },
                    new Loja
                    {
                        LojaId = 4,
                        RazaoSocial = "Loja MLP Records IV",
                        Cnpj = "01.001.001/0004-04",
                        Endereco = "Rua Deputado Martinho, 651",
                    });

            modelBuilder.Entity<Funcionario>()
                .HasData(
                    new Funcionario
                    {
                        FuncionarioId = 1,
                        NomeFunc = "João Paulo",
                        CpfFunc = "001.001.001-01",
                        EnderecoFunc = "Rua Verdinha, 10",
                        Cargo = "Vendedor",
                        Salario = 1100,
                        LojaId = 1
                    },
                    new Funcionario
                    {
                        FuncionarioId = 2,
                        NomeFunc = "José Aleixo",
                        CpfFunc = "002.002.002-02",
                        EnderecoFunc = "Rua Azulzinha, 320",
                        Cargo = "Técnico Manutenção",
                        Salario = 2000,
                        LojaId = 1
                    },
                    new Funcionario
                    {
                        FuncionarioId = 3,
                        NomeFunc = "Daniel",
                        CpfFunc = "003.003.003-03",
                        EnderecoFunc = "Rua Amarelhinha, 220",
                        Cargo = "Vendedor",
                        Salario = 1100,
                        LojaId = 2
                    },
                    new Funcionario
                    {
                        FuncionarioId = 4,
                        NomeFunc = "Paulo",
                        CpfFunc = "004.004.004-04",
                        EnderecoFunc = "Rua Vermelhinha, 110",
                        Cargo = "Gerente",
                        Salario = 4000,
                        LojaId = 2
                    },
                    new Funcionario
                    {
                        FuncionarioId = 5,
                        NomeFunc = "Matias",
                        CpfFunc = "005.005.005-05",
                        EnderecoFunc = "Rua Roxinha, 485",
                        Cargo = "Caixa",
                        Salario = 1500,
                        LojaId = 3
                    },
                    new Funcionario
                    {
                        FuncionarioId = 6,
                        NomeFunc = "Flávia",
                        CpfFunc = "006.006.006-06",
                        EnderecoFunc = "Rua Marronzinha, 95",
                        Cargo = "Vendedor",
                        Salario = 1100,
                        LojaId = 3
                    },
                    new Funcionario
                    {
                        FuncionarioId = 7,
                        NomeFunc = "Joana",
                        CpfFunc = "007.007.007-07",
                        EnderecoFunc = "Rua Laranjinha, 195",
                        Cargo = "Caixa",
                        Salario = 1500,
                        LojaId = 4
                    },
                    new Funcionario
                    {
                        FuncionarioId = 8,
                        NomeFunc = "Augusto",
                        CpfFunc = "008.008.008-08",
                        EnderecoFunc = "Rua Branquinha, 713",
                        Cargo = "Técnico Manutenção",
                        Salario = 2000,
                        LojaId = 4
                    }
                );

            modelBuilder.Entity<Cliente>()
                .HasData(
                new Cliente
                {
                    ClienteId = 1,
                    NomeCliente = "Alfredo",
                    CpfCliente = "009.009.009-09",
                    EnderecoCliente = "Rua Azevedo, 900",
                    Telefone = "99999-9999",
                    Email = "alfred@alfred.com.br",
                    LojaId = 1
                },
                new Cliente
                {
                    ClienteId = 2,
                    NomeCliente = "Ataulfo",
                    CpfCliente = "010.010.010-10",
                    EnderecoCliente = "Rua Miraí, 33",
                    Telefone = "98888-8888",
                    Email = "ataulfo@ataulfo.com.br",
                    LojaId = 1
                },
                new Cliente
                {
                    ClienteId = 3,
                    NomeCliente = "Geraldo",
                    CpfCliente = "011.011.011-11",
                    EnderecoCliente = "Rua Peixoto, 477",
                    Telefone = "97777-7777",
                    Email = "geraldo@geraldo.com.br",
                    LojaId = 2
                },
                new Cliente
                {
                    ClienteId = 4,
                    NomeCliente = "Jorge",
                    CpfCliente = "012.012.012-12",
                    EnderecoCliente = "Rua Floriano, 741",
                    Telefone = "96666-6666",
                    Email = "jorge@jorge.com.br",
                    LojaId = 2
                },
                new Cliente
                {
                    ClienteId = 5,
                    NomeCliente = "Joaquim",
                    CpfCliente = "013.013.013-13",
                    EnderecoCliente = "Rua Paixão, 10",
                    Telefone = "95555-5555",
                    Email = "joaquim@joaquim.com.br",
                    LojaId = 3
                },
                new Cliente
                {
                    ClienteId = 6,
                    NomeCliente = "Maria",
                    CpfCliente = "014.014.014-14",
                    EnderecoCliente = "Rua Malaquias, 22",
                    Telefone = "94444-4444",
                    Email = "maria@maria.com.br",
                    LojaId = 3
                },
                new Cliente
                {
                    ClienteId = 7,
                    NomeCliente = "Betânia",
                    CpfCliente = "015.015.015-15",
                    EnderecoCliente = "Rua Machado, 78",
                    Telefone = "93333-3333",
                    Email = "betania@betania.com.br",
                    LojaId = 4
                },
                new Cliente
                {
                    ClienteId = 8,
                    NomeCliente = "Marcos",
                    CpfCliente = "016.016.016-16",
                    EnderecoCliente = "Rua Pereira, 586",
                    Telefone = "92222-2222",
                    Email = "marcos@marcos.com.br",
                    LojaId = 4
                });

            modelBuilder.Entity<Produto>()
                .HasData(
                new Produto { ProdutoId = 1, Descricao = "Tropicalia", Categoria = "Disco", Preco = 151, Estoque = 8, LojaId = 2 },
                new Produto { ProdutoId = 2, Descricao = "Mamonas Assassinas", Categoria = "Disco", Preco = 90, Estoque = 5, LojaId = 2 },
                new Produto { ProdutoId = 3, Descricao = "Martinho da Vila", Categoria = "Disco", Preco = 210, Estoque = 9, LojaId = 2 },
                new Produto { ProdutoId = 4, Descricao = "Toca Disco Garrard", Categoria = "Eletrônico", Preco = 590, Estoque = 5, LojaId = 1 },
                new Produto { ProdutoId = 5, Descricao = "Received Gradient", Categoria = "Eletrônico", Preco = 700, Estoque = 5, LojaId = 1 },
                new Produto { ProdutoId = 6, Descricao = "Caixa de Som Gradient", Categoria = "Eletrônico", Preco = 100, Estoque = 20, LojaId = 1 },
                new Produto { ProdutoId = 7, Descricao = "Equalizador Gradient", Categoria = "Eletrônico", Preco = 800, Estoque = 4, LojaId = 1 },
                new Produto { ProdutoId = 8, Descricao = "Amplificador Gradient", Categoria = "Eletrônico", Preco = 650, Estoque = 2, LojaId = 1 },
                new Produto { ProdutoId = 9, Descricao = "Toca Fita Gradient", Categoria = "Eletrônico", Preco = 390, Estoque = 2, LojaId = 1 },
                new Produto { ProdutoId = 10, Descricao = "Nelson Sargento", Categoria = "CD", Preco = 35, Estoque = 10, LojaId = 3 },
                new Produto { ProdutoId = 11, Descricao = "The Beatles", Categoria = "CD", Preco = 55, Estoque = 20, LojaId = 3 },
                new Produto { ProdutoId = 12, Descricao = "Gramofone", Categoria = "Eletrônico", Preco = 1189, Estoque = 2, LojaId = 1 },
                new Produto { ProdutoId = 13, Descricao = "Microfone Philips", Categoria = "Eletrônico", Preco = 120, Estoque = 15, LojaId = 1 },
                new Produto { ProdutoId = 14, Descricao = "Elis Regina", Categoria = "CD", Preco = 40, Estoque = 10, LojaId = 3 },
                new Produto { ProdutoId = 15, Descricao = "Chitãozinho & Xororó", Categoria = "Fita K7", Preco = 15, Estoque = 14, LojaId = 4 },
                new Produto { ProdutoId = 16, Descricao = "Leandro & Leonardo", Categoria = "Fita K7", Preco = 16, Estoque = 12, LojaId = 4 },
                new Produto { ProdutoId = 17, Descricao = "Bruno & Marrone", Categoria = "Fita K7", Preco = 15, Estoque = 12, LojaId = 4 },
                new Produto { ProdutoId = 18, Descricao = "Discman", Categoria = "Eletrônico", Preco = 100, Estoque = 3, LojaId = 1 }
        );
        }
    }
}
