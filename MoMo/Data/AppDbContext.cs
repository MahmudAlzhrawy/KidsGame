using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace MoMo.Data
{    
    internal class AppDbContext:DbContext
    {
        public DbSet <User> Users { get; set; }
        public DbSet<Alphabet> Alphabets { get; set; }
        public DbSet<Number> Numbers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Result> Results { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
           
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-KNCBQ49\\SQLEXPRESS01;Initial Catalog=MoMoGame;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Result>()
                .HasKey(RE => new { RE.QuestionId, RE.User_name });

            modelBuilder.Entity<Result>()
                .HasOne(RE => RE.Question)
                .WithMany(Q => Q.Results)
                .HasForeignKey(RE => RE.QuestionId);

            modelBuilder.Entity<Result>()
                .HasOne(RE => RE.User)
                .WithMany(U => U.Results)
                .HasForeignKey(RE => RE.User_name);
        }
    }
}

