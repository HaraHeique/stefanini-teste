using Examples.Charge.Domain.Aggregates.Common.Interfaces;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces.Repositories
{
    public interface IPersonPhoneRepository : IBaseRepository<PersonPhone>
    {
        Task<List<PersonPhone>> GetPersonPhonesWithTypes();
        Task<PersonPhone> GetPersonPhoneWithType(string phoneNumber);
    }
}
