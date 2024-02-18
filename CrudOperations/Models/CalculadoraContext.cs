using Microsoft.EntityFrameworkCore;

namespace CrudOperations.Models
{
    public class CalculadoraContext : DbContext
    {

        public CalculadoraContext(DbContextOptions<CalculadoraContext> options) : base(options)
        {

        }
        public DbSet <Calculadora> Calculadoras { get; set; }
    }
}
