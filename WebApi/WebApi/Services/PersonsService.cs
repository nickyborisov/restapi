using Domain;
using Domain.Interfaces;
using WebApi.Models;
using WebApi.Services.Interfaces;

namespace WebApi.Services
{
    public class PersonsService : RestServiceBase<PersonDto, Person>, IPersonsService
    {
        public PersonsService(IMapper<PersonDto, Person> mapper, IAsyncRepository<Person> repository) : base(mapper, repository)
        {
        }
    }
}
