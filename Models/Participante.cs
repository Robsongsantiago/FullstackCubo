using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace FullstackCubo.Models
{
    public class Participante
    {
        public int Id {get; set;}
        public string FirstName { get; set; } = string.Empty;
        public string LastName {get; set;} = string.Empty;
        public int Participation {get; set;}
    }
}