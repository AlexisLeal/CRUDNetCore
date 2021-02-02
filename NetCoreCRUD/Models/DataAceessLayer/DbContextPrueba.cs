using Microsoft.EntityFrameworkCore;
using NetCoreCRUD.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreCRUD.Models.DataAceessLayer
{
    public class DbContextPrueba:DbContext
    {
        public DbContextPrueba(DbContextOptions<DbContextPrueba>options): base(options) //Pasamos la cadena de conexion 
        {

        }

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<CargoEmpleado> CargosEmpleados { get; set; }
        //Add-Migration "Se agrega la entidad cargo"
        // update-database

    }
}
