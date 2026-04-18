using System.ComponentModel.DataAnnotations;

namespace TaskFlow.Models
{
    public class Tarea
    {
        [Key]
        public int IdTarea { get; set; }

        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public string? Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdUsuario { get; set; }
    }
}