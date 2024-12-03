using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEventos.API.Models;

namespace ProEventos.API.Data
{
    // classe que representa o banco
    public class DataContext : DbContext
    {
        public DbSet<Evento> Eventos { get; set; } // tabela do banco


        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }
    }
}