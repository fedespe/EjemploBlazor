using System.ComponentModel.DataAnnotations;

namespace EjemploBlazor.Client.Models
{
    public class LibroVM
    {
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un Autor")]
        public int IdAutor { get; set; }
        public AutorVM Autor { get; set; }
    }
}
