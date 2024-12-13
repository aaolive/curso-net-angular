using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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
            
            // para deletar evento e suas redes sociaias vinculidas do db
            modelBuilder.Entity<Evento>().HasMany(e => e.RedeSocials).WithOne(rs => rs.Evento).OnDelete(DeleteBehavior.Cascade);

            // para deletar palestrante e suas redes sociaias vinculidas do db
            modelBuilder.Entity<Palestrante>().HasMany(e => e.RedeSocials).WithOne(rs => rs.Palestrante).OnDelete(DeleteBehavior.Cascade);
          
       }    
        
    }
}