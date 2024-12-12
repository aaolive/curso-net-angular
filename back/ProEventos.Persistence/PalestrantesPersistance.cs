using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence
{
    public class PalestrantesPersistance : IPalestrantesPersistence
    {
        private readonly ProEventosContext _context;
        public PalestrantesPersistance(ProEventosContext context)
        {
            this._context = context;
            
        }

        public Task<Palestrante[]> GetAllPalestrantesAsync(bool includePalestrante)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante> GetAllPalestrantesByIdAsync(int PalestranteId, bool includePalestrante)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante[]> GetAllPalestrantesByTemaAsync(string Nome, bool includePalestrante)
        {
            throw new NotImplementedException();
        }
    }
}