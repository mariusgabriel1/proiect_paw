using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect.Model
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
            try
            {
                Database.Migrate();
            }
            catch (Exception)
            {
                Console.WriteLine("Database already exists." +
                " No additional migration have to be applied.");
            }
        }
        public DbSet<Cheltuiala> cheltuieli { get; set; }
        public DbSet<Cont> conturi { get; set; }
        public DbSet<Venit> venituri { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=bazadate.db");
        }
    }
}
