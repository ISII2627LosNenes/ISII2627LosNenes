using AppForSEII.API.Data;
using AppForSEII.API.DTOs.LibroDTOs; 
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace AppForSEII.API.Controllers
{
[   Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
            private readonly ApplicationDbContext _context;
            private readonly ILogger<LibroController> _logger;

            public LibroController(ApplicationDbContext context, ILogger<LibroController> logger)
            {   
                _context = context;
                _logger = logger;
            }


            [HttpGet] //metodo que responde a peticiones http
            [Route("[action]")]
            [ProducesResponseType(typeof(IList<LibroParaResenarDTO>), (int)HttpStatusCode.OK)] //si tiene exito devolvemos un 200 y una lista de libros
            [ProducesResponseType(typeof(ValidationProblemDetails), (int)HttpStatusCode.BadRequest)]
            public async Task<ActionResult> GetLibrosParaResenar(string? tipoLibro, string? genero) //pongo esos atributos por que el usuario puede filtrar por tipo de libro o por genero
            {
                IList<LibroParaResenarDTO> libros = await _context.Libro
                // Hacemos JOIN con las tablas genero y editorial para poder obtener sus nombres
                .Include(l => l.Genero)
                .Include(l => l.Editorial)
                
                // Si el usuario ha decidido filtrar lo hacemos en esta parte, si no ha decidido filtrar, devolvemos todos los libros
                .Where(l => (tipoLibro == null || l.TipoLibro.Contains(tipoLibro))
                         && (genero == null || l.Genero.Nombre.Equals(genero)))

                //Ordenamos por el titulo 
                .OrderBy(l => l.Titulo)
                
                // Seleccionamos los atributos de los libros que coinciden
                .Select(l => new LibroParaResenarDTO(
                    l.Id,
                    l.Titulo,
                    l.TipoLibro,
                    l.Genero.Nombre,
                    l.Editorial.Nombre,
                    l.Autor,
                    l.CalificacionMedia,
                    l.FechaLanzamiento,
                    l.PrecioCompra
                ))
                // Ejecuta la consulta de forma asíncrona y guarda el resultado en una lista
                .ToListAsync();

            // Devuelve la lista de libros y el mensaje http de exito 200 (OK)
            return Ok(libros);
            }

            [HttpGet]
            [Route("[action]")]
            [ProducesResponseType(typeof(IList<LibroParaComprarDTO>), (int)HttpStatusCode.OK)]
            [ProducesResponseType(typeof(ValidationProblemDetails), (int)HttpStatusCode.BadRequest)]

            public async Task<ActionResult> GetLibrosParaComprar(string? titulo, string? genero)
            {
            
                IList<LibroParaComprarDTO> libros = await _context.Libro
                .Include(l => l.Genero)
                .Include(l => l.Editorial)
                .Where(l => l.Stock > 0 
                         && (titulo == null || l.Titulo.Contains(titulo))
                         && (genero == null || l.Genero.Nombre.Equals(genero)))
                .OrderBy(l => l.Titulo)
                .Select(l => new LibroParaComprarDTO(
                    l.Id,
                    l.Titulo,
                    l.Autor,
                    l.Genero.Nombre,
                    l.Editorial.Nombre,
                    l.PrecioCompra,
                    l.Stock
                ))
                .ToListAsync();

            return Ok(libros);
            }
            
    }
}