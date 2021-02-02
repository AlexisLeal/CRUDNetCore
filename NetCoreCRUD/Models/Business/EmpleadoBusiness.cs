using NetCoreCRUD.Clases;
using NetCoreCRUD.Models.Abstract;
using NetCoreCRUD.Models.DataAceessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreCRUD.Models.Business
    // estos Business vendria siendo los helper de codeignater 4 de php 
{
    public class EmpleadoBusiness: IEmpleadoBusiness
    {
        private readonly DbContextPrueba _context;

        public EmpleadoBusiness(DbContextPrueba context)
        {
            this._context = context;
        }


        public async Task<IEnumerable<EmpleadoDetalle>> ObtenerEmpleadoDetalles()
            //Este metodo lo llamamdos a un una interface en la carpeta abstract 
        {
            await using (_context)
            {
                IEnumerable<EmpleadoDetalle> listaEmpleadosDetalles =
                       (from empleado in _context.Empleados
                        join cargo in _context.CargosEmpleados
                        on empleado.Cargo equals
                        cargo.IdCargo
                        select new EmpleadoDetalle
                        {
                            IdEmpleado = empleado.IdEmpleado,
                            Nombre = empleado.Nombre,
                            Cargo = cargo.Cargo,
                            telefono = empleado.telefono,
                            Documento = empleado.Documento
                        }).ToList();

                return listaEmpleadosDetalles;
            }
        }
    }
}
