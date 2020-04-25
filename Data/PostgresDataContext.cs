using aula01.Models;
using Microsoft.EntityFrameworkCore;

namespace aula01.Data
{
    public class PostgresDataContext:DbContext
    {
        public PostgresDataContext(DbContextOptions<PostgresDataContext> options)
        :base(options)
        {
        }

        public DbSet<User> Users;
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>();
        }

    }
}