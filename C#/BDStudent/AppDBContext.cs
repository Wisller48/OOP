using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

using Escola.Models;


namespace Escola.Data;

public class AppDBContext : DbContext{
    public DbSet<Student> Students => Set<Student>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=escola.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(e =>{
            e.HasKey(s=>s.Id);
            e.Property(s=>s.Name).IsRequired().HasMaxLength(120);
            e.Property(s=>s.Email).IsRequired().HasMaxLength(100);
            e.HasIndex(s=>s.Email).IsUnique();
        });
    }
}