using Finance.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Domain.Interfaces
{
    public interface IUsuario
    {
        public Task<IEnumerable<Usuario>> GetAllUsuarios();
        public Task<Usuario> GetUsuarioById(int id);
        public Task<Usuario> AddUsuarioAsync (Usuario usuario);
        public Task<Usuario> DeleteUsuarioAsync (int id);
    }
}
