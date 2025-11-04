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
    public class SaidaRepo : ISaida
    {
        private readonly FinaDbContext _context;
        public SaidaRepo(FinaDbContext context)
        {
            _context = context; 
        }

        public async Task<Saida> AddSaida(Saida saida)
        {
            await _context.Saidas.AddAsync(saida);
            await _context.SaveChangesAsync();

            return saida;
        }

        

        public async Task<Saida> DeleteSaidaByIdAsync(int id)
        {
            var saida = await _context.Saidas
                .FirstOrDefaultAsync(s => s.Id == id);
            if (saida == null) throw new Exception($"Valor não encontrado");

            _context.Saidas.Remove(saida);
            await _context.SaveChangesAsync();

            return saida;
        }

        public async Task<IEnumerable<Saida>> GetAllSaidaAsync()
        {
            var saida = await _context.Saidas.ToListAsync();

            return saida;
            
        }

        public async Task<Saida> GetSaidaByIdAsync(int id)
        {
            var saida = await _context.Saidas.FirstOrDefaultAsync(sa => sa.Id == id);
            if (saida == null) throw new Exception($"Valor não encontrado");

            return saida;
        }
    }
}
