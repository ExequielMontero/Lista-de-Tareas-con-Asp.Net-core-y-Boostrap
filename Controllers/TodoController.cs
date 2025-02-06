using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Creacion_de_DB_dentro_del_proyecto_con_Sql_Lite.Services;
using Creacion_de_DB_dentro_del_proyecto_con_Sql_Lite.Models;

namespace Creacion_de_DB_dentro_del_proyecto_con_Sql_Lite.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        public async Task<IActionResult> index()
        {

            //Aca se obtienen los datos de los modelos utilizando el servicio que creamos
            var items = await _todoItemService.GetIncompleteItemsAsync();


            var model = new TodoViewModel()
            {
                Items = items
            };

            return View(model);

        }


        public async Task<IActionResult> Formulario()
        {

            return View();

        }


        [HttpPost]
        public async Task<IActionResult> CrearTarea(TodoItem item)
        {
            if (ModelState.IsValid)
            {
                var successfull = await _todoItemService.AddItemAsync(item);
                if (!successfull)
                {

                    return View("Formulario", item);
                }

                TempData["Mensaje"] = "La tarea se ha agregado correctamente.";
                TempData["TipoMensaje"] = "success";
                return RedirectToAction("Index");
            }

            return View("Formulario", item); 
        }

    }
}
