using Microsoft.AspNetCore.Mvc;
using System.Net;
using Taqui.Models;
using Taqui.Repository;

namespace Taqui.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly Repository<Cliente> _repository;

        public ClienteController(Repository<Cliente> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        // GET: api/cliente/{id}
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Cliente), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public ActionResult<Cliente> Get(int id)
        {
            var cliente = _repository.GetById(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

        // GET: api/cliente
        [HttpGet]
        [ProducesResponseType(typeof(List<Cliente>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public ActionResult<IEnumerable<Cliente>> GetAll()
        {
            var clientes = _repository.GetAll();
            return Ok(clientes);
        }

        // POST: api/cliente
        [HttpPost]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public ActionResult<int> Post([FromBody] Cliente cliente)
        {
            if (cliente == null)
            {
                return BadRequest("Cliente não pode ser nulo.");
            }

            _repository.Add(cliente);

            // Retorna o ID do cliente recém-criado com o status 201 Created
            return CreatedAtAction(nameof(Get), new { id = cliente.IdUsuario }, cliente.IdUsuario);
        }

        // PUT: api/cliente/{id}
        [HttpPut("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public IActionResult Put(int id, [FromBody] Cliente cliente)
        {
            if (cliente == null || id != cliente.IdUsuario)
            {
                return BadRequest();
            }

            var existingCliente = _repository.GetById(id);
            if (existingCliente == null)
            {
                return NotFound();
            }

            _repository.Update(cliente);
            return NoContent();
        }

        // DELETE: api/cliente/{id}
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public IActionResult Delete(int id)
        {
            var cliente = _repository.GetById(id);
            if (cliente == null)
            {
                return NotFound();
            }

            _repository.Delete(id);
            return NoContent();
        }
    }
}
