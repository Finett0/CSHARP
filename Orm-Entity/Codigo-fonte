using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore;


public class Genero
{
    [Key]
    public int ID { get; set; }
    public string Descricao { get; set; }

    public ICollection<Filme>Filme {  get; set; }

}

public class ApplicationContext : DbContext
{
    public DbSet<Genero> Genero { get; set; }
    public DbSet<Filme>Filme { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=orm;Integrated Security=SSPI;TrustServerCertificate=True");
    }

}
public class Filme
{
    [Key]
    public int ID { get; set; }
    public string Titulo { get; set; }
    public int GeneroId { get; set; }

    [ForeignKey("GeneroId")]
    public Genero Genero { get; set; }

}

class Progam
{
    static void Main(string[]args)
    {
        using (var context = new ApplicationContext())
        {
            var genero = new Genero()
            {
                Descricao = "Fantasia"
            };

            context.Genero.Add(genero);
            context.SaveChanges();

            var filme = new Filme()
            {
                Titulo = "De volta para o Futuro",
                GeneroId = genero.ID
            };

            context.Filme.Add(filme); 
            context.SaveChanges();

        }
    }
}
