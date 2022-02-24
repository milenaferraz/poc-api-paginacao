using Microsoft.EntityFrameworkCore;
using Paginacao.Models;

namespace Paginacao.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ToDo> Todos { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder) => 
            optionsBuilder.UseSqlite(connectionString: "DataSource=AppDbContext.db;Cache=Shared");
    }
}
