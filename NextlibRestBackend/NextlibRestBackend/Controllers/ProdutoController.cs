using Microsoft.AspNetCore.Mvc;
using Next.Repositories;
using System.Collections.Generic;
using _models = Next.Models;

namespace NextlibRestBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/produtos")]
    public class ProdutoController : Controller
    {
        ProdutoRepository repository;

        public ProdutoController()
        {
            repository = new ProdutoRepository();
        }

        // GET: api/Produto
        [HttpGet]
        public IEnumerable<_models.Produto> Get()
        {
            return repository.Get();
        }

        // GET: api/Produto/5
        [HttpGet("{id}")]
        public _models.Produto Get(string id)
        {
            return repository.Get(id);
        }
        
        // POST: api/Produto
        [HttpPost]
        public void Post([FromBody]_models.Produto value)
        {
            repository.Create(value);
        }
        
        // PUT: api/Produto/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]_models.Produto value)
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
