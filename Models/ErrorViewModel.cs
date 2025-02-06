using Creacion_de_DB_dentro_del_proyecto_con_Sql_Lite.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Creacion_de_DB_dentro_del_proyecto_con_Sql_Lite.Services;
using Creacion_de_DB_dentro_del_proyecto_con_Sql_Lite.Data;
using Creacion_de_DB_dentro_del_proyecto_con_Sql_Lite.Controllers;

namespace Creacion_de_DB_dentro_del_proyecto_con_Sql_Lite.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
