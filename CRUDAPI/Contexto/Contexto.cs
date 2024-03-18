using CRUDAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDAPI.Contexto
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas {get;set;}

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {
            
        }
        
    }
}