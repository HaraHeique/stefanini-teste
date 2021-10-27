using Examples.Charge.Domain.Aggregates.PersonAggregate.Entities;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces.Repositories;
using Examples.Charge.Infra.Data.Context;

namespace Examples.Charge.Infra.Data.Repositories
{
    public class PhoneNumberTypeRepository : BaseRepository<PhoneNumberType>, IPhoneNumberTypeRepository
    {
        public PhoneNumberTypeRepository(ExampleContext context) : base(context) { }
    }
}
