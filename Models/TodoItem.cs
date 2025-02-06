using System.ComponentModel.DataAnnotations;

namespace Creacion_de_DB_dentro_del_proyecto_con_Sql_Lite.Models
{
    public class TodoItem
    {
        [Key]
        public Guid Id { get; set; }
        public bool IsDone { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTimeOffset? DueAt { get; set; }
    }
}