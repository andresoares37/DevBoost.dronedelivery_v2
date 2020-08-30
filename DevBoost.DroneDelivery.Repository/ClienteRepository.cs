using DevBoost.dronedelivery.Domain;
using DevBoost.DroneDelivery.Domain.Interfaces.Repositories;
using DevBoost.DroneDelivery.Domain.Interfaces.Services;
using DevBoost.DroneDelivery.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevBoost.DroneDelivery.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DCDroneDelivery _context;
        public Task<bool> Delete(Cliente cliente)
        {
            throw new NotImplementedException();
        }
        public ClienteRepository(DCDroneDelivery context)
        {
            this._context = context;
        }

        public Task<IList<Cliente>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Insert(Cliente cliente)
        {
            _context.Cliente.Add(cliente);
            return await _context.SaveChangesAsync() > 0;
        }

        public Task<Cliente> Update(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
