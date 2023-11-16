using API_Serviciokankuamo.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Serviciokankuamo
{
    public class Serviciokankuamo_Context : DbContext
    {
        public Serviciokankuamo_Context(DbContextOptions<Serviciokankuamo_Context> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }

        public DbSet<UsuarioModel> UsuarioModels { get; private set; }
    }
}
