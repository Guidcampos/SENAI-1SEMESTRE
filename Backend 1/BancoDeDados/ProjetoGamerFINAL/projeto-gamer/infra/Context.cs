// classe para conectar o projeto com o banco de dados

using Microsoft.EntityFrameworkCore;
using projeto_gamer.Models;

namespace projeto_gamer.infra
{
    public class Context : DbContext
    {
        public Context()
        {
            
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }
        // Criando string de conexao 
                //Data Source : o nome do servidor do gerenciador do banco
                //initial catalog : nome do banco de dados

                //Autenticação pelo Windows
                //Integrated Security : Autenticação pelo Windows
                //TrustServerCertificate : Autenticação pelo Windows

                //Autenticação pelo SqlServer
                //user Id = "nome do seu usuario de login"
                //pwd = "senha do seu usuario"

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = NOTE20-S15; initial catalog = gamerTarde; User Id = sa; pwd = Senai@134; TrustServerCertificate = true");
            }
        }

        public DbSet<Jogador> Jogador { get; set; }
        public DbSet<Equipe> Equipe { get; set; }

    }
}