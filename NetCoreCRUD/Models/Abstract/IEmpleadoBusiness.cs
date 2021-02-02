using NetCoreCRUD.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreCRUD.Models.Abstract
{
    public interface IEmpleadoBusiness
    {
        Task<IEnumerable<EmpleadoDetalle>> ObtenerEmpleadoDetalles();
    }
}
