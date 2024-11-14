using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class TrainingDbContext : DbContext
    {
        private readonly string _connectionstring = "Data Source=.\\SQLEXPRESS;Initial Catalog=CSharpB18;User ID=csharpb18;Password=123456;TrustServerCertificate=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionstring);

            }



            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Student> Students{ get; set;}
       


    }
}



