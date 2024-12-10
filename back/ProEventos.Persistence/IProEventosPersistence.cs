using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence
{
    public interface IProEventosPersistence
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void deleteRange<T>(T[] entity) where T : class;

        Task<bool> SaveChangesAsync();

        // evenetos
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrante);
        Task<Evento[]> GetAllEventosAsync( bool includePalestrante);
        Task<Evento> GetAlleventosByIdAsync(int EventoId, bool includePalestrante);

        // palestrantes
        Task<Palestrante[]> GetAllPalestrantesByTemaAsync(string Nome, bool includePalestrante);
        Task<Palestrante[]> GetAllPalestrantesAsync( bool includePalestrante);
        Task<Palestrante> GetAllPalestrantesByIdAsync(int PalestranteId, bool includePalestrante);
    }
}