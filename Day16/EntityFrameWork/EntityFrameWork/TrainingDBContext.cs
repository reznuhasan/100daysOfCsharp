using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork
{
    public class TrainingDBContext:DbContext
    {
        public readonly String _ConnectionString;
        public TrainingDBContext()
        {
            _ConnectionString="Server=DESKTOP-6P8AMML\\SQLEXPRESS;Database=Practice1;User Id=Practice1;Password=123456; Trust Server Certificate=True";
        }
        protected  override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(_ConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
       public DbSet<Student> Students { get; set; }

    }
}
