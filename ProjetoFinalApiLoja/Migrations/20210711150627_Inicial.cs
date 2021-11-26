using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoFinalApiLoja.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lojas",
                columns: table => new
                {
                    LojaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RazaoSocial = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Cnpj = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Endereco = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lojas", x => x.LojaId);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeCliente = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CpfCliente = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    EnderecoCliente = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Telefone = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Email = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    LojaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                    table.ForeignKey(
                        name: "FK_Clientes_Lojas_LojaId",
                        column: x => x.LojaId,
                        principalTable: "Lojas",
                        principalColumn: "LojaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    FuncionarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeFunc = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CpfFunc = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    EnderecoFunc = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Cargo = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Salario = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    LojaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.FuncionarioId);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Lojas_LojaId",
                        column: x => x.LojaId,
                        principalTable: "Lojas",
                        principalColumn: "LojaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Categoria = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Preco = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Estoque = table.Column<int>(type: "int", nullable: false),
                    LojaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.ProdutoId);
                    table.ForeignKey(
                        name: "FK_Produtos_Lojas_LojaId",
                        column: x => x.LojaId,
                        principalTable: "Lojas",
                        principalColumn: "LojaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Lojas",
                columns: new[] { "LojaId", "Cnpj", "Endereco", "RazaoSocial" },
                values: new object[,]
                {
                    { 1, "01.001.001/0001-01", "Avenida Douradinho, 779", "Loja MLP Records - Matriz" },
                    { 2, "01.001.001/0002-02", "Rua da Mata, 541", "Loja MLP Records II" },
                    { 3, "01.001.001/0003-03", "Avenida Xavier, 872", "Loja MLP Records III" },
                    { 4, "01.001.001/0004-04", "Rua Deputado Martinho, 651", "Loja MLP Records IV" }
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "CpfCliente", "Email", "EnderecoCliente", "LojaId", "NomeCliente", "Telefone" },
                values: new object[,]
                {
                    { 1, "009.009.009-09", "alfred@alfred.com.br", "Rua Azevedo, 900", 1, "Alfredo", "99999-9999" },
                    { 2, "010.010.010-10", "ataulfo@ataulfo.com.br", "Rua Miraí, 33", 1, "Ataulfo", "98888-8888" },
                    { 8, "016.016.016-16", "marcos@marcos.com.br", "Rua Pereira, 586", 4, "Marcos", "92222-2222" },
                    { 7, "015.015.015-15", "betania@betania.com.br", "Rua Machado, 78", 4, "Betânia", "93333-3333" },
                    { 6, "014.014.014-14", "maria@maria.com.br", "Rua Malaquias, 22", 3, "Maria", "94444-4444" },
                    { 5, "013.013.013-13", "joaquim@joaquim.com.br", "Rua Paixão, 10", 3, "Joaquim", "95555-5555" },
                    { 4, "012.012.012-12", "jorge@jorge.com.br", "Rua Floriano, 741", 2, "Jorge", "96666-6666" },
                    { 3, "011.011.011-11", "geraldo@geraldo.com.br", "Rua Peixoto, 477", 2, "Geraldo", "97777-7777" }
                });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "FuncionarioId", "Cargo", "CpfFunc", "EnderecoFunc", "LojaId", "NomeFunc", "Salario" },
                values: new object[,]
                {
                    { 8, "Técnico Manutenção", "008.008.008-08", "Rua Branquinha, 713", 4, "Augusto", 2000m },
                    { 7, "Caixa", "007.007.007-07", "Rua Laranjinha, 195", 4, "Joana", 1500m },
                    { 6, "Vendedor", "006.006.006-06", "Rua Marronzinha, 95", 3, "Flávia", 1100m },
                    { 5, "Caixa", "005.005.005-05", "Rua Roxinha, 485", 3, "Matias", 1500m },
                    { 3, "Vendedor", "003.003.003-03", "Rua Amarelhinha, 220", 2, "Daniel", 1100m },
                    { 4, "Gerente", "004.004.004-04", "Rua Vermelhinha, 110", 2, "Paulo", 4000m },
                    { 1, "Vendedor", "001.001.001-01", "Rua Verdinha, 10", 1, "João Paulo", 1100m },
                    { 2, "Técnico Manutenção", "002.002.002-02", "Rua Azulzinha, 320", 1, "José Aleixo", 2000m }
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "Categoria", "Descricao", "Estoque", "LojaId", "Preco" },
                values: new object[,]
                {
                    { 13, "Eletrônico", "Microfone Philips", 15, 1, 120m },
                    { 15, "Fita K7", "Chitãozinho & Xororó", 14, 4, 15m },
                    { 4, "Eletrônico", "Toca Disco Garrard", 5, 1, 590m },
                    { 5, "Eletrônico", "Received Gradient", 5, 1, 700m },
                    { 14, "CD", "Elis Regina", 10, 3, 40m },
                    { 11, "CD", "The Beatles", 20, 3, 55m },
                    { 10, "CD", "Nelson Sargento", 10, 3, 35m },
                    { 6, "Eletrônico", "Caixa de Som Gradient", 20, 1, 100m },
                    { 7, "Eletrônico", "Equalizador Gradient", 4, 1, 800m },
                    { 8, "Eletrônico", "Amplificador Gradient", 2, 1, 650m },
                    { 9, "Eletrônico", "Toca Fita Gradient", 2, 1, 390m },
                    { 3, "Disco", "Martinho da Vila", 9, 2, 210m },
                    { 2, "Disco", "Mamonas Assassinas", 5, 2, 90m },
                    { 1, "Disco", "Tropicalia", 8, 2, 151m },
                    { 16, "Fita K7", "Leandro & Leonardo", 12, 4, 16m },
                    { 12, "Eletrônico", "Gramofone", 2, 1, 1189m },
                    { 18, "Eletrônico", "Discman", 3, 1, 100m },
                    { 17, "Fita K7", "Bruno & Marrone", 12, 4, 15m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_LojaId",
                table: "Clientes",
                column: "LojaId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_LojaId",
                table: "Funcionarios",
                column: "LojaId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_LojaId",
                table: "Produtos",
                column: "LojaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Lojas");
        }
    }
}
