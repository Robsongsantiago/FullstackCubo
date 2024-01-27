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
            return Ok("Participante criado com sucesso");
        }
        [HttpPut("{id:int}")]
        public IActionResult Put(int id)
        {
            var participante = _dashboardContext.Participantes.Where(x => x.Id == id).FirstOrDefault();
            if (participante is null)
            {
                return NotFound("Participante não encontrado");
            }
            _dashboardContext.Participantes.Update(participante);
            _dashboardContext.SaveChanges();
            return Ok("Participante editado com sucesso");
        }
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var participante = _dashboardContext.Participantes.Where(x => x.Id == id).FirstOrDefault();
            if (participante is null)
            {
                return BadRequest("Participante não existe!");
            }

            _dashboardContext.Participantes.Remove(participante);
            _dashboardContext.SaveChanges();

            return Ok("Participante excluido com sucesso");
        }
        [HttpDelete]
        public IActionResult Delete(int[] ids)
        {
            foreach (int id in ids)
            {
                Delete(id);
            }
            return Ok("Participantes excluido com sucesso");
        }

    }
}