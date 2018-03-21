using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services.Interfaces;

namespace WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Persons")]
    public class PersonsController : RestControllerBaseController<PersonDto>
    {
        public PersonsController(IPersonsService restService) : base(restService)
        {
        }
    }
}