using EscolaAPI.Data.Map;
using EscolaAPI.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaAPI.Data
{
    public class AppDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public AppDbContext(IConfiguration configuration, DbContextOptions<AppDbContext> options) : base(options)
        {
            _configuration = configuration;
        }
        public DbSet<AlunoModel> Aluno { get; set; }
        public DbSet<ClasseModel> Classe { get; set; }
        public DbSet<EnsinoModel> Ensino { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMap());
            modelBuilder.ApplyConfiguration(new ClasseMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
