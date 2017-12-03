using Microsoft.AspNetCore.Mvc;
using Next.Repositories;
using System.Collections.Generic;
using _models = Next.Models;

namespace NextlibRestBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/clientes")]
    public class ClienteController : Controller
    {
        ClienteRepository repository;

        public ClienteController()
        {
            repository = new ClienteRepository();
        }

        // GET: api/clientes
        [HttpGet]
        public IEnumerable<_models.Cliente> Get()
        {
            return repository.Get();
        }

        // GET: api/clientes/5
        [HttpGet("{id}")]
        public _models.Cliente Get(string id)
        {
            return repository.Get(id);
        }
        
        // POST: api/clientes
        [HttpPost]
        public void Post([FromBody]_models.Cliente value)
        {
            repository.Create(value);
        }
        
        // PUT: api/clientes/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]_models.Cliente value)
        {
            repository.Update(value, id);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            repository.Delete(id);
        }
    }
}
