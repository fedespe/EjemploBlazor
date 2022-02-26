using EjemploBlazor.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjemploBlazor.Server.Controllers
{
    [ApiController]
    public class AutorController : Controller
    {
        // GET: AutorController
        [HttpGet, Route("api/Servicio/obtenerAutores")]
        public List<Autor> Get()
        {
            return datos();
        }
        //Datos
        private List<Autor> datos()
        {
            List<Autor> list = new List<Autor>();
            list.Add(new Autor
            {
                Id = 1,
                Nombre = "Autor 1"
            });
            list.Add(new Autor
            {
                Id = 2,
                Nombre = "Autor 2"
            });
            list.Add(new Autor
            {
                Id = 3,
                Nombre = "Autor 3"
            });
            list.Add(new Autor
            {
                Id = 4,
                Nombre = "Autor 4"
            });
            return list;
        }
    }
}
