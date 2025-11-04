using Finance.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Domain.Interfaces
{
    public interface ISaida
    {
        public Task<IEnumerable<Saida>> GetAllSaidaAsync();
        public Task<Saida> GetSaidaByIdAsync(int id);
        public Task<Saida> AddSaida(Saida saida);
        public Task<Saida> DeleteSaidaByIdAsync(int id);
    }
}
