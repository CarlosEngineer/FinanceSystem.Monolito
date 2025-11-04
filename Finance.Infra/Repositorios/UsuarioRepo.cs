using Finance.Domain.Interfaces;
using Finance.Domain.Models;
using Finance.Infra.FinanceDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Infra.Repositorios
{
    public class UsuarioRepo : IUsuario
    {
        private readonly FinaDbContext _context;

        public UsuarioRepo(FinaDbContext context)
        {
            _context = context;
        }

        public async Task<Usuario> AddUsuarioAsync(Usuario usuario)
        {
            await _context.Usuarios.AddAsync(usuario);
            await _context.SaveChangesAsync();

            return usuario;
            
        }

        public async Task<Usuario> DeleteUsuarioAsync(int id)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Id == id);
            if (usuario == null) throw new Exception($"Valor não encontrado");

            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();

            return usuario;
        }

        public async Task<IEnumerable<Usuario>> GetAllUsuarios()
        {
            await _context.Usuarios.ToListAsync();

            return _context.Usuarios;
        }

        public async Task<Usuario> GetUsuarioById(int id)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Id == id);
            if (usuario == null) throw new Exception($"Valor não encontrado");
            return usuario;
        }

       }

        
    
}
