using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkExample
{
    public class ApplicationDbContext:DbContext
    {
        public readonly String _connectionString;
        public ApplicationDbContext()
        {
            _connectionString = "Server=.\\SQLEXPRESS;Database=CSharpB15;User Id=csharpb15;Password=123456; Trust Server Certificate=True";

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
