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
    public class EntradaRepo : IEntrada
    {
        private readonly FinaDbContext _context;
        public EntradaRepo(FinaDbContext context)
        {
            _context = context;
        }
        public async Task<Entrada> AddEntradaAsync(Entrada entrada)
        {
            await _context.Entradas.AddAsync(entrada);
            await _context.SaveChangesAsync();

            return entrada;
        }

        public async Task<Entrada> DeleteEntradaByIdAsync(int id)
        {
            var entrada = await _context.Entradas
               .FirstOrDefaultAsync(e => e.Id == id);

            if (entrada == null) throw new Exception("Valor não encontrado");

            _context.Entradas.Remove(entrada);

            await _context.SaveChangesAsync();

            return entrada;

;
        }

        public async Task<IEnumerable<Entrada>> GetAllEntradaAsync()
        {
            var entradas = await _context.Entradas.ToListAsync();

            return entradas;
        }

        public async Task<Entrada> GetEntradaByIdAsync(int id)
        {
            var entrada = await _context.Entradas
                .FirstOrDefaultAsync( e => e.Id == id);

            if (entrada == null) throw new Exception($"VALOR NÃO ENCONTRADO..{id}");


            return entrada;

        }

        
    }
}
