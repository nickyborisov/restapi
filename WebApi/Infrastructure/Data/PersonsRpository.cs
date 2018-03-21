using Domain;
using Domain.Interfaces;

namespace Infrastructure.Data
{
    public class PersonsRpository : EfRepository<Person>, IPersonsRepository
    {
        public PersonsRpository(DataCtx dbContext)
            : base(dbContext)
        {
        }
    }
}
