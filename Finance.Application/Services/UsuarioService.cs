using Finance.Application.Services.IService;
using Finance.Domain.Interfaces;
using Finance.Domain.Models;
using Finance.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly UsuarioRepo _repo;

        public UsuarioService(UsuarioRepo repo)
        {
            _repo = repo;
        }

        public async Task AddUsuarioAsync(Usuario usuario)
        {

            await _repo.AddUsuarioAsync(usuario);

        }

        public async Task DeleteUsuarioAsync(int id)
        {
           await _repo.DeleteUsuarioAsync(id);
        }

        public async Task<Usuario> GetUsuario(int id)
        {
            return await _repo.GetUsuarioById(id);
        }

        public async Task<IEnumerable<Usuario>> GetUsuarios()
        {
            return await _repo.GetAllUsuarios();
        }
    }
}
