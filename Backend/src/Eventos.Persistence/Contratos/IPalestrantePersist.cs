using Eventos.Domain;

namespace Eventos.Persistence.Contratos
{
    public interface IPalestrantePersist
    {
        //PALESTRANTES
        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool incluirEventos);
        Task<Palestrante[]> GetAllPalestrantesAsync(bool incluirEventos);
        Task<Palestrante> GetPalestranteByIdAsync(int palestranteId, bool incluirEventos);

    }
}