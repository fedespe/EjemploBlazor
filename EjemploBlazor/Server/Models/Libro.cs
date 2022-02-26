namespace EjemploBlazor.Server.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime Fecha { get; set; }
        public Autor Autor { get; set; }
    }
}
