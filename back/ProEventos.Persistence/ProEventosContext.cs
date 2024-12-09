using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence
{
    public class ProEventosContext : DbContext
    {
        public DbSet<Evento> Eventos  { get; set; }
        public DbSet<Lote> Lotes  { get; set; }
        public DbSet<Palestrante> Palestrantes  { get; set; }
        public DbSet<PalestranteEvento> PalestrantesEventos  { get; set; }
        public DbSet<RedeSocial> RedeSocials  { get; set; }

        public ProEventosContext(DbContextOptions<ProEventosContext> options) : base(options){}

       protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.Entity<PalestranteEvento>().HasKey(PE => new {
            PE.EventoId, PE.PalestranteId
        });
       }    
        
    }
}