using Entities.DTOs.Client;
using Entities.DTOs.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IClientService
    {
        List<ClientListDTO> GetAllClients();
        void AddClient(AddClientDTO ClientDTO);
        void DeleteClient(int id);
        void UpdateClient(int id, UpdateClientDTO updatedClient);
    }
}
