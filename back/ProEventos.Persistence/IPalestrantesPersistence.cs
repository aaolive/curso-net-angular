using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence
{
    public interface IPalestrantesPersistence
    {

        // palestrantes
        Task<Palestrante[]> GetAllPalestrantesByTemaAsync(string Nome, bool includePalestrante);
        Task<Palestrante[]> GetAllPalestrantesAsync( bool includePalestrante);
        Task<Palestrante> GetAllPalestrantesByIdAsync(int PalestranteId, bool includePalestrante);
    }
}