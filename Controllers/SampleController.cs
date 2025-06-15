using Microsoft.AspNetCore.Mvc;
using PomodoroApp.Api.Data;

namespace PomodoroApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TestController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("test-connection")]
        public async Task<IActionResult> TestConnection()
        {
            try
            {
                // Prueba simple de conexión
                await _context.Database.CanConnectAsync();
                return Ok(new { message = "Conexión exitosa a PostgreSQL" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Error de conexión", error = ex.Message });
            }
        }
    }
}