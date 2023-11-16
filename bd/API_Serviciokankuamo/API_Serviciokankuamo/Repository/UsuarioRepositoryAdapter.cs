using API_Serviciokankuamo.DTOs;
using API_Serviciokankuamo.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace API_Serviciokankuamo.Repository
{
    public class UsuarioRepositoryAdapter : IUsuarioRepositoryPort
    {
        private readonly Serviciokankuamo_Context _ctx;

        public UsuarioRepositoryAdapter(Serviciokankuamo_Context context)
        {
            _ctx = context;
        }

        public async Task<TypeResponse> GetAll()
        {
            var ls = await _ctx.UsuarioModels.ToListAsync();
            var data = ls.Select(u => new Usuario()
            {
                IdUsuario = u.IdUsuario,
                Nombres = u.Nombres,
                Apellidos = u.Apellidos,
                Correo = u.Correo,
                DeseaHabilitarServicio = u.DeseaHabilitarServicio,
            }).ToList();

            var result = new TypeResponse
            {
                Codigo = 0,
                Mensaje = "",
                DataOutput = JsonSerializer.Serialize(data)
            };
            return result;
        }

        public async Task<TypeResponse> Insert(Usuario user)
        {
            var result = new TypeResponse() { Codigo = 99, Mensaje = "Error en el servicio" };
            if (user != null)
            {
                var ok = ValidarForm(user);
                if (ok)
                {
                    try
                    {
                        var userMapper = MapperUsuario(user);
                        await _ctx.AddAsync(userMapper);
                        await _ctx.SaveChangesAsync();

                        result.Codigo = 0;
                        result.Mensaje = "OK";
                    }
                    catch (Exception)
                    {
                        result.Codigo = 97;
                        result.Mensaje = "Formulario no válido";
                    }
                }
                else
                {
                    result.Codigo = 98;
                    result.Mensaje = "Falta información";
                }
            }

            return result;
        }


        private bool ValidarForm(Usuario user)
        {
            var ok = true;
            if (string.IsNullOrEmpty(user.Nombres))
            {
                ok = false;
            }
            else if (ok && string.IsNullOrEmpty(user.Apellidos))
            {
                ok = false;
            }

            return ok;
        }
        private UsuarioModel MapperUsuario(Usuario user)
        {
            return new UsuarioModel
            {
                IdUsuario = user.IdUsuario,
                Nombres = user.Nombres,
                Apellidos = user.Apellidos,
                Correo = user.Correo,
                DeseaHabilitarServicio = user.DeseaHabilitarServicio
            };
        }
    }
}
