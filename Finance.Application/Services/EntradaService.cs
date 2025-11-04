using Finance.Application.Services.IService;
using Finance.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Application.Services
{
    public class EntradaService : IEntradaService
    {
        public Task<Entrada> AddEntradaAsync(Entrada entrada)
        {
            throw new NotImplementedException();
        }

        public Task<Entrada> DeleteEntradaByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Entrada>> GetAllEntradaAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Entrada> GetEntradaByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
