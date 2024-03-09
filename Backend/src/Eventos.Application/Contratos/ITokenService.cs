using Eventos.Application.Dtos;

namespace Eventos.Application.Contratos
{
    public interface ITokenService
    {
         Task<string> CreateToken(UserUpdateDto userUpdateDto);
    }
}