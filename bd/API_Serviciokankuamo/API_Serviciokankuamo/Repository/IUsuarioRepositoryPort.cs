using API_Serviciokankuamo.DTOs;

namespace API_Serviciokankuamo.Repository
{
    public interface IUsuarioRepositoryPort
    {
        Task<TypeResponse> GetAll();
        Task<TypeResponse> Insert(Usuario user);
    }
}
