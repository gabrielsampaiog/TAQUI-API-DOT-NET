using Microsoft.AspNetCore.Mvc;
using System.Net;
using Taqui.Models;
using Taqui.Models.DTO;
using Taqui.Repository;
using Taqui.Service;

namespace Taqui.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly Repository<Cliente> _repository;

        private readonly ClienteService _service = new ClienteService();


        public ClienteController(Repository<Cliente> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        // GET: api/cliente/{id}
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ClienteDTOResponse), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.NotFound)]
        public ActionResult<ClienteDTOResponse> Get(int id)
        {
            var cliente = _repository.GetById(id);
            if (cliente == null)
            {
                return NotFound();
            }

            //Retorna o cliente sem seus dados sensíveis.
            return Ok(_service.clienteToResponse(cliente));
        }

        // GET ALL: api/cliente
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ClienteDTOResponse>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)] 
        public ActionResult<IEnumerable<ClienteDTOResponse>> GetAll()
        {
            IEnumerable<Cliente> clientes = _repository.GetAll();

            //Retorna um enumerable de clientes sem os dados sensíveis.
            return Ok(_service.clientesToResponseIEnumerable(clientes));
        }

        // POST: api/cliente
        [HttpPost]
        [ProducesResponseType(typeof(ClienteDTOResponse), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType(typeof(ErrorResponse),(int)HttpStatusCode.BadRequest)]
        public ActionResult<ClienteDTOResponse> Post([FromBody] ClienteDTORequest clienteDtoRequest)
        {
            Cliente cliente = new Cliente();
            ClienteDTOResponse clienteDtoResponse = new ClienteDTOResponse();

            cliente = _service.requestToCliente(clienteDtoRequest);

            if (cliente == null)
            {
                return BadRequest();
            }

            _repository.Add(cliente);
            clienteDtoResponse = _service.clienteToResponse(cliente);

            // Retorna o cliente sem seus dados sensíveis.
            return Ok(clienteDtoResponse);
        }

        // PUT: api/cliente/{id}
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(ClienteDTOResponse),(int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType(typeof(ErrorResponse),(int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.BadRequest)]
        public IActionResult Put(int id, [FromBody] ClienteDTORequest clienteDtoRequest)
        {
            Cliente cliente = new Cliente();
            ClienteDTOResponse clienteDTOResponse = new ClienteDTOResponse();

            cliente = _service.requestToCliente(clienteDtoRequest);
            cliente.IdUsuario = id;

            Cliente existingCliente = _repository.GetById(id);
            if (existingCliente == null)
            {
                return NotFound();
            }

            _repository.Update(existingCliente,cliente);
            clienteDTOResponse = _service.clienteToResponse(cliente);

            // Retorna o cliente com seus dados alterados, sem seus dados sensíveis.
            return Ok(clienteDTOResponse);
        }

        // DELETE: api/cliente/{id}
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.NotFound)]
        public IActionResult Delete(int id)
        {
            var cliente = _repository.GetById(id);
            if (cliente == null)
            {
                return NotFound();
            }

            _repository.Delete(id);

            //Retorna nada.
            return Ok();
        }
    }
}
