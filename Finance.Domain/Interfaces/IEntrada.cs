using Finance.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Domain.Interfaces
{
    public interface IEntrada
    {
        public Task<IEnumerable<Entrada>> GetAllEntradaAsync();
        public Task<Entrada> GetEntradaByIdAsync(int id);
        public Task<Entrada> AddEntradaAsync (Entrada entrada);
        public Task<Entrada> DeleteEntradaByIdAsync (int id);

    }
}
