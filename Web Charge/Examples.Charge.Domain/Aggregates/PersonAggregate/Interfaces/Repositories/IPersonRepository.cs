using Examples.Charge.Domain.Aggregates.Common.Interfaces;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Entities;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces.Repositories
{
    public interface IPersonRepository : IBaseRepository<Person>
    {
    }
}
