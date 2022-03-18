using System.Threading.Tasks;
using ProEventos.Application.Contratos;
using ProEventos.Domain;

namespace ProEventos.Application
{
    public class EventoService : IEventoService
    {
        public Task<Evento> AddEventos(Evento model)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteEvento(int eventoId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Evento> GetAllEventoByIdAsync(int EventoId, bool includePalestrantes = false)
        {
            throw new System.NotImplementedException();
        }

        public Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false)
        {
            throw new System.NotImplementedException();
        }

        public Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false)
        {
            throw new System.NotImplementedException();
        }

        public Task<Evento> UpdateEvento(int eventoId, Evento model)
        {
            throw new System.NotImplementedException();
        }
    }
}