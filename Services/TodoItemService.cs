using AspNetCoreGeneratedDocument;
using Creacion_de_DB_dentro_del_proyecto_con_Sql_Lite.Data;
using Creacion_de_DB_dentro_del_proyecto_con_Sql_Lite.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace Creacion_de_DB_dentro_del_proyecto_con_Sql_Lite.Services
{
    public class TodoItemService:ITodoItemService
    {
        private readonly AppDbContext _context;

        public TodoItemService(AppDbContext dbContext)
        {
               _context = dbContext;
        }

        public async Task<TodoItem[]> GetIncompleteItemsAsync()
        {
            var item = await _context.TodoItems.Where(x=>x.IsDone == false).ToArrayAsync();
            return item;
        }

        public async Task<bool> AddItemAsync(TodoItem item)
        {

            item.Id = Guid.NewGuid();
            item.IsDone = false;
            item.DueAt = DateTimeOffset.Now.AddDays(3);
            _context.TodoItems.Add(item);
            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1;
        }

    }
}
