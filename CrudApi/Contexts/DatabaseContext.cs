using CrudApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudApi.Contexts
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {

        }
        public DbSet<Producto> Producto { get; set; }
    }
}
