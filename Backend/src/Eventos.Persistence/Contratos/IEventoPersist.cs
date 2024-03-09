using Eventos.Domain;

namespace Eventos.Persistence.Contratos
{
    public interface IEventoPersist
    {
        Task<Evento[]> GetAllEventosByTemaAsync(int userId, string tema, bool incluirPalestrantes = false);
        Task<Evento[]> GetAllEventosAsync(int userId, bool incluirPalestrantes = false);
        Task<Evento> GetEventoByIdAsync(int userId, int eventoId, bool incluirPalestrantes = false);
    }
}