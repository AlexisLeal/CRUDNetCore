
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreCRUD.Models.Entity
{
    public class CargoEmpleado
    {
        [Key]
        public int IdCargo { get; set; }

        [DisplayName("Nombre de cargo")]
        [Column("NombreCargo", TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Cargo { get; set; }
    }
}
