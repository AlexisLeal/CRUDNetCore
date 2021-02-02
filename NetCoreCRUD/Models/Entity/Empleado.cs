using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreCRUD.Models.Entity
{
    public class Empleado
    {
        [Key] //tiene dataannotations indica que sera una llave primaria 
        public int IdEmpleado { get; set; }

        [DisplayName("Nombre Completo")] //Esto es como se va mostrar en las vistas 
        [Column("NombreEmpleado", TypeName = "nvarchar(50)")] //En la base de datos se va llamar NombreEmpleado pero 
        // para nosotros en codigo se va a llamar nombre 
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombre { get; set; } 
        //el get y set son los metodos getter y setter

        public int Documento { get; set; }

        public int Cargo { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string telefono { get; set;  }
    }
}
