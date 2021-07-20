using Microsoft.EntityFrameworkCore;

namespace Turnos.Models
{
    // ctrl + shift + p --> seleccionamos nuget add package --> escribimos entityframworks --> elegimos version de enitity frameworks que corresponda con la version de .Net que tengamos
    public class TurnosContext : DbContext
    {
        public TurnosContext(DbContextOptions<TurnosContext> opciones)
        : base(opciones)
        {

        }

        public DbSet<Especialidad> Especialidad { get; set; } //DbSet establece una tabla sql y le estamos diciendo que es del tipo esoecialidad y con n
    }
}