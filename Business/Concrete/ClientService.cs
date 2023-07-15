using AutoMapper;
using Business.Abstract;
using DataAccess.Abstract.IEntityFramework;
using Entities.Concrete;
using Entities.DTOs.Client;
using Entities.DTOs.Resolution;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ClientService : IClientService
    {
        private readonly IClientDal _clientDal;
        private readonly IMapper _mapper;

        public ClientService(IClientDal _clientDal, IMapper mapper)
        {
            this._clientDal = _clientDal;
            this._mapper = mapper;
        }

        public void AddClient(AddClientDTO clientDTO)
        {
            var addedClient = _mapper.Map<Client>(clientDTO);
            addedClient.Password = "";

            addedClient.CreatedAt = DateTime.Now;
            addedClient.UpdatedAt = DateTime.Now;

            _clientDal.Add(addedClient);
        }

        public void DeleteClient(int id)
        {
            var client = _clientDal.Get(a => a.Id == id);
            _clientDal.Delete(client);

        }

        public List<ClientListDTO> GetAllClients()
        {
            var clients = _clientDal.GetAll();
            var ClientDTOs = _mapper.Map<List<ClientListDTO>>(clients);
            return ClientDTOs;
        }
       


        public void UpdateClient(int id, UpdateClientDTO updatedClient)
        {
            var existingClient = _clientDal.Get(a => a.Id == id);
            var updateClient=  _mapper.Map(updatedClient, existingClient);

            _clientDal.Update(updateClient);
        }

       
    }
}
