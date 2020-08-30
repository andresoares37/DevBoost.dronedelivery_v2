using DevBoost.dronedelivery.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevBoost.DroneDelivery.Domain.Interfaces.Repositories
{
    public interface IClienteRepository
    {
        Task<IList<Cliente>> GetAll();
        Task<Cliente> GetById(int id);
        Task<bool> Insert(Cliente cliente);
        Task<Cliente> Update(Cliente cliente);
        Task<bool> Delete(Cliente cliente);
    }
}