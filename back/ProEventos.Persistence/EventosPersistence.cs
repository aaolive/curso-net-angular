using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;

namespace ProEventos.Persistence
{
    public class EventosPersistence : IEventosPersistence
    {
        private readonly ProEventosContext _context;

        public EventosPersistence(ProEventosContext context)
        {
            this._context = context;
            this._context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;// corrige erro de update de objeto
            
        }
        public Task<Evento[]> GetAllEventosAsync(bool includePalestrante)
        {
            throw new NotImplementedException();
        }

        public Task<Evento> GetAlleventosByIdAsync(int EventoId, bool includePalestrante)
        {
            throw new NotImplementedException();
        }

        public Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrante)
        {
            throw new NotImplementedException();
        }
    }
}