using Finance.Application.Services.IService;
using Finance.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Application.Services
{
    public class SaidaService : ISaidaService
    {
        public Task<Saida> AddSaida(Saida saida)
        {
            throw new NotImplementedException();
        }

        public Task<Saida> DeleteSaidaByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Saida>> GetAllSaidaAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Saida> GetSaidaByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
