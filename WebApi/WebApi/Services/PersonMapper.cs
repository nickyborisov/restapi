using Domain;
using System;
using WebApi.Models;
using WebApi.Services.Interfaces;

namespace WebApi.Services
{
    public class PersonMapper : IMapper<PersonDto, Person>
    {
        public Person MapDto(PersonDto model)
        {
            return new Person
            {
                First = model.First,
                Id = model.Id,
                Last = model.Last,
                Phone = model.Phone,
                Version = BitConverter.GetBytes(model.Version)
            };
        }

        public PersonDto MapEntity(Person entity)
        {
            return new PersonDto
            {
                First = entity.First,
                Id = entity.Id,
                Last = entity.Last,
                Phone = entity.Phone,
                Version = BitConverter.ToInt64(entity.Version, 0)
            };
        }
    }
}
