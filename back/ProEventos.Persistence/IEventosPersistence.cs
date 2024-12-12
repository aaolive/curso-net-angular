using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence
{
    public interface IEventosPersistence
    {
        

        // evenetos
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrante=false);
        Task<Evento[]> GetAllEventosAsync( bool includePalestrante=false);
        Task<Evento> GetAlleventosByIdAsync(int EventoId, bool includePalestrante=false);

        
    }
}