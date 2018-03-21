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
                Version = Parse(model.Version)
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
                Version = ToString(entity.Version)
            };
        }

        public static string ToString(byte[] rowversionArr)
        {
            return string.Format("0x{0}", BitConverter.ToInt64(rowversionArr, 0).ToString("X16"));
        }

        public static byte[] Parse(string rowversionStr)
        {
            return BitConverter.GetBytes(Convert.ToInt64(rowversionStr, 16));
        }
    }
}
