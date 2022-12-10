using Examen_Tercer_Parcial.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examen_Tercer_Parcial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatoController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public DatoController(AplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {

            try
            {
                Thread.Sleep(2000);

                var listDatos = _context.Datos.ToList();
                return Ok(listDatos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("{id}")]
        public async Task<ActionResult>Get(int id)
        {
            try
            {
                var listDatos = _context.Datos.FindAsync(id);
                if (listDatos == null)
                    return NoContent();


                return Ok(listDatos);
            }
        catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        
        }
    }
}
