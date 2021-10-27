using Examples.Charge.Domain.Aggregates.Common.Services;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Entities;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces.Repositories;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces.Services;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Services
{
    public class PersonService : BaseService<Person>, IPersonService
    {
        public PersonService(IPersonRepository personRepository) : base(personRepository)
        {
        }
    }
}
