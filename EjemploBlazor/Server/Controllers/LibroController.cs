using EjemploBlazor.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjemploBlazor.Server.Controllers
{
    [ApiController]
    public class LibroController : Controller
    {
        [HttpGet, Route("api/Servicio/obtenerLibros")]
        public List<Libro> Get()
        {
            return datos();
        }

        private List<Libro> datos()
        {
            List<Libro> libros = new List<Libro>();
            libros.Add(new Libro
            {
                Id = 1,
                Titulo = "Libro 1",
                Fecha = DateTime.Now,
                Autor = new Autor
                {
                    Id = 1,
                    Nombre = "Autor 1"
                }
            });
            libros.Add(new Libro
            {
                Id = 2,
                Titulo = "Libro 2",
                Fecha = DateTime.Now,
                Autor = new Autor
                {
                    Id = 2,
                    Nombre = "Autor 2"
                }
            });
            libros.Add(new Libro
            {
                Id = 3,
                Titulo = "Libro 3",
                Fecha = DateTime.Now,
                Autor = new Autor
                {
                    Id = 3,
                    Nombre = "Autor 3"
                }
            });
            libros.Add(new Libro
            {
                Id = 4,
                Titulo = "Libro 4",
                Fecha = DateTime.Now,
                Autor = new Autor
                {
                    Id = 4,
                    Nombre = "Autor 4"
                }
            });
            return libros;
        }
    }
}
