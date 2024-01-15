using Eventos.Application.Dtos;

namespace Eventos.Application.Contratos
{
    public interface ILoteService
    {
        Task<LoteDto[]> SaveLotes(int eventoId, LoteDto[] model);
        Task<bool> DeleteLote(int eventoId, int loteId);
        Task<LoteDto[]> GetLotesByEventoIdAsync(int enventoId);
        Task<LoteDto> GetLoteByIdsAsync(int eventoId, int loteId);
    }
}