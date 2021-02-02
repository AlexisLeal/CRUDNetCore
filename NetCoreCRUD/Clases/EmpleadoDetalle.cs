//Creamos la carpeta clase para crear objetos que serviran como recipiente (osea objetos para unicamente para consulta)
// crear el objeto y mostralo en la vista 
namespace NetCoreCRUD.Clases
{
    public class EmpleadoDetalle
    {
       
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        
        public int Documento { get; set; }

        public string Cargo { get; set; }

        public string telefono { get; set; }

    }
}
