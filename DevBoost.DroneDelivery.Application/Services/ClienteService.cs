using DevBoost.dronedelivery.Domain;
using DevBoost.DroneDelivery.Domain.Interfaces.Repositories;
using DevBoost.DroneDelivery.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevBoost.DroneDelivery.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IPedidoRepository _repositoryPedido;
        private readonly IDroneItinerarioRepository _droneItinerarioRepository;
        private readonly IDroneRepository _droneRepository;
        private const double _latitudeLoja = -23.5880684;
        private const double _longitudeLoja = -46.6564195;

        public ClienteService(IClienteRepository clienteRepository,
            IDroneItinerarioRepository droneItinerarioRepository,
            IDroneRepository droneRepository)
        {
            _clienteRepository = clienteRepository;
            _droneItinerarioRepository = droneItinerarioRepository;
            _droneRepository = droneRepository;
        }
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public async Task<bool> Delete(Cliente cliente)
        {
            return await _clienteRepository.Delete(cliente);
        }

        public async Task<IList<Cliente>> GetAll()
        {
            return await _clienteRepository.GetAll();
        }

        public async Task<Cliente> GetById(int id)
        {
            return await _clienteRepository.GetById(id);
        }

        public async Task<bool> Insert(Cliente cliente)
        {
            return await _clienteRepository.Insert(cliente);
        }

        public async Task<Cliente> Update(Cliente cliente)
        {
            return await _clienteRepository.Update(cliente);
        }
    }
}
