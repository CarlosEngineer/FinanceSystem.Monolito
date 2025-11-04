using Finance.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Application.Services.IService
{
    public interface IUsuarioService
    {
        public Task<IEnumerable<Usuario>> GetUsuarios();
        public Task<Usuario> GetUsuario(int id);
        public Task AddUsuarioAsync(Usuario usuario);
        public Task DeleteUsuarioAsync(int id);
    }
}
