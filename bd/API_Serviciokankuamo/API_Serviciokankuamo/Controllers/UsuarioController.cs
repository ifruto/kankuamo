using API_Serviciokankuamo.DTOs;
using API_Serviciokankuamo.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Serviciokankuamo.Controllers
{
    [Route("api/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepositoryPort _usuarioRepository;

        public UsuarioController(IUsuarioRepositoryPort usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpPost("getall")]
        public async Task<TypeResponse> GetAll() => await _usuarioRepository.GetAll();

        [HttpPost("insert")]
        public async Task<TypeResponse> Insert(Usuario user) => await _usuarioRepository.Insert(user);
    }
}
