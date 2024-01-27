﻿using FullstackCubo.Models;
using Microsoft.EntityFrameworkCore;

namespace FullstackCubo.Data
{
    public class DashboardContext : DbContext
    {
        public DbSet<Participante> Participantes { get; set; }

        public DashboardContext(DbContextOptions<DashboardContext> options) :
            base(options)
        {
            
        }

    }
}
