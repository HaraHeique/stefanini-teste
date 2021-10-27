using Examples.Charge.Domain.Aggregates.PersonAggregate.Entities;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces.Repositories;
using Examples.Charge.Infra.Data.Context;

namespace Examples.Charge.Infra.Data.Repositories
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(ExampleContext context) : base(context) { }
    }
}
