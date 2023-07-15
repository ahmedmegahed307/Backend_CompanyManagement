using Business.Abstract;
using Entities.DTOs.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.Settings
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;


        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        [Route("clients")]
        public List<ClientListDTO> GetAllClients()
        {
            return _clientService.GetAllClients();

        }

        [HttpPost]
        [Route("add")]
        public void AddClient(AddClientDTO ClientDTO)
        {
            _clientService.AddClient(ClientDTO);


        }


        // PUT /api/clients/{id}
        [HttpPut("{id}")]

        public IActionResult UpdateClient(int id, UpdateClientDTO updatedClient)
        {
            _clientService.UpdateClient(id, updatedClient);
            return Ok();

        }
        [HttpDelete("{id}")]

        public void DeleteClient(int id)
        {
            _clientService.DeleteClient(id);

        }

    }
}
