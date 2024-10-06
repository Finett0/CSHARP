using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

public class Colaborador
{
    [Key]
    public int ID_Colaborador { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Cargo { get; set; }

    public ICollection<Equipe> Equipe { get; set; }

}

public class ApplicationContext : DbContext
{
    public DbSet<Colaborador> Colaborador { get; set; }
    public DbSet<Equipe> Equipe { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=OrmHsdDb;Integrated Security=SSPI;TrustServerCertificate=True");
    }

}


public class Equipe
{
    [Key]
    public int ID_Equipe { get; set; }
    public string Nome_Equipe { get; set; }
    public int ID_Colaborador { get; set; }

    [ForeignKey("ID_Colaborador")]

    public Colaborador Colaborador { get; set; }


}

class Progam
{
    static void Main(string[] args)
    {
        using (var context = new ApplicationContext())
        {
            var colaborador = new Colaborador()
            {
                Nome = "Gabriel",
                Email = "gabriel@gmail.com",
                Cargo = "Desenvolvedor Front-End"

            };

            context.Colaborador.Add(colaborador);
            context.SaveChanges();

            var equipe4 = new Equipe()
            {

                Nome_Equipe = "Desenvolvimento",
                ID_Colaborador = colaborador.ID_Colaborador
            };

            context.Equipe.Add(equipe4);
            context.SaveChanges();

        }
    }
}
