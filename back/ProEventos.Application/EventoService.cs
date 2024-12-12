using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;
using ProEventos.Persistence;

namespace ProEventos.Application
{
    public class EventoService:IEventoService
    {
        private readonly IGeralPersistence geralPersistence;
        private readonly IEventoService eventoService;

        public EventoService(IGeralPersistence geralPersistence, IEventoService eventoService)
        {
            this.geralPersistence = geralPersistence;
            this.eventoService = eventoService;
        }

        public async Task<Evento> AddEvento(Evento evento)
        {
            try
            {
                geralPersistence.Add<Evento>(evento);

                if (await geralPersistence.SaveChangesAsync())
                {
                    return await eventoService.GetAlleventosByIdAsync(evento.Id);
                }

                return null;
            }
            catch (System.Exception e)
            {
                
                throw new Exception(e.Message);
            }
            
        }

        public Task<bool> AddEventos(int eventoId)
        {
            throw new NotImplementedException();
        }
        public async Task<Evento> UpdateEvento(int eventoId, Evento evento)
        {
            try
            {
                var eventop = await eventoService.GetAlleventosByIdAsync(eventoId);

                if (eventop == null)
                {
                    return null;
                }

                evento.Id = eventop.Id;

                geralPersistence.Update(evento);
                if (await geralPersistence.SaveChangesAsync())
                {
                    return await eventoService.GetAlleventosByIdAsync(evento.Id);
                }

                return null;
                
            }
            catch (System.Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        public Task<Evento[]> GetAllEventosAsync(bool includePalestrante = false)
        {
            throw new NotImplementedException();
        }

        public Task<Evento> GetAlleventosByIdAsync(int EventoId, bool includePalestrante = false)
        {
            throw new NotImplementedException();
        }

        public Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrante = false)
        {
            throw new NotImplementedException();
        }

    }
}