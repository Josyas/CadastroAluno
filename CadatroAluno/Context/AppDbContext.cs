using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
namespace CadastroAluno.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Diciplina> Diciplinas { get; set; }

        /* public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
         {
         }
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             IConfiguration configuration = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json", false, true).Build();

             optionsBuilder.UseSqlServer(configuration.GetConnectionString("ServerConnection"));
            
            "ConnectionStrings": {
            "ServerConnection": "Data Source=DESKTOP-B5JCHEK;Integrated Security=True;Database=AlunoCadastroApi;"

                 },
            
         }*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-B5JCHEK;Integrated Security=True;Database=AlunoCadastroApi;");
        }
    }
}
