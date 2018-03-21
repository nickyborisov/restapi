using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.Services.Interfaces;

namespace WebApi.Controllers
{
    public class RestControllerBaseController<T> : Controller
        where T : BaseModel
    {
        public RestControllerBaseController(IRestService<T> restService)
        {
            RestService = restService;
        }

        public IRestService<T> RestService { get; }

        [HttpGet]
        public Task<List<T>> Get()
        {
            return RestService.ListAllAsync();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Task<T> Get(int id)
        {
            return RestService.GetByIdAsync(id);
        }

        // POST api/values
        [HttpPost]
        public Task Post([FromBody]T value)
        {
            return RestService.AddAsync(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public Task Put(int id, [FromBody]T value)
        {
            return RestService.UpdateAsync(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var e = await RestService.GetByIdAsync(id);
            await RestService.DeleteAsync(e);
        }
    }
}