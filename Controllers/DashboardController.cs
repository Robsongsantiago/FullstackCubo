using FullstackCubo.Data;
using FullstackCubo.Models;
using Microsoft.AspNetCore.Mvc;

namespace FullstackCubo.Controllers
{
    [ApiController]
    [Route("api/dashboard")]
    public class DashboardController : ControllerBase
    {
        public readonly DashboardContext _dashboardContext;
        public DashboardController(DashboardContext dashboardContext)
        {
            _dashboardContext = dashboardContext;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var participantes = _dashboardContext.Participantes.ToList();
            return Ok(participantes);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Participante participante)
        {
            _dashboardContext.Participantes.Add(participante);
            _dashboardContext.SaveChanges();
            return Ok();
        }
    }
}