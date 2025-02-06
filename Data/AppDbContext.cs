using Creacion_de_DB_dentro_del_proyecto_con_Sql_Lite.Models;
using Microsoft.EntityFrameworkCore;

namespace Creacion_de_DB_dentro_del_proyecto_con_Sql_Lite.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


    }
}