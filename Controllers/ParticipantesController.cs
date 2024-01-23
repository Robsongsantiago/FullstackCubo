using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullstackCubo.Models;
using Microsoft.AspNetCore.Mvc;

namespace FullstackCubo.Controllers
{
    [ApiController]
    [Route("api/participantes")]
    public class ParticipantesController : ControllerBase
    {
       public ParticipantesController(){

       }
       [HttpGet]
       public IActionResult Get(){
        var participante = new Participante();
        participante.Id = 1;
        participante.FirstName = "Robson";
        participante.LastName = "Gomes";
        participante.Participation = 5; 

        return Ok(participante);
       } 
    }
}