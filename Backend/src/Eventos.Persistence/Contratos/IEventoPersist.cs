using Eventos.Domain;

namespace Eventos.Persistence.Contratos
{
    public interface IEventoPersist
    {
        //EVENTOS
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool incluirPalestrantes = false);
        Task<Evento[]> GetAllEventosAsync(bool incluirPalestrantes = false);
        Task<Evento> GetEventoByIdAsync(int eventoId, bool incluirPalestrantes = false);
    }
}