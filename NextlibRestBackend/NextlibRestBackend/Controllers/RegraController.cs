using Microsoft.AspNetCore.Mvc;
using Next.Repositories;
using System.Collections.Generic;
using _models = Next.Models;

namespace NextlibRestBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/regras")]
    public class RegraController : Controller
    {
        RegraRepository repository;

        public RegraController()
        {
            repository = new RegraRepository();
        }

        // GET: api/Regra
        [HttpGet]
        public IEnumerable<_models.Regra> Get()
        {
            return repository.Get();
        }

        // GET: api/Regra/5
        [HttpGet("{id}")]
        public _models.Regra Get(string id)
        {
            return repository.Get(id);
        }
        
        // POST: api/Regra
        [HttpPost]
        public void Post([FromBody]_models.Regra value)
        {
            repository.Create(value);
        }
        
        // PUT: api/Regra/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]_models.Regra value)
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
