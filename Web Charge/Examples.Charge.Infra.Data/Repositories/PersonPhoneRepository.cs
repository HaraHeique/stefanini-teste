using Examples.Charge.Domain.Aggregates.PersonAggregate.Entities;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces.Repositories;
using Examples.Charge.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Infra.Data.Repositories
{
    public class PersonPhoneRepository : BaseRepository<PersonPhone>, IPersonPhoneRepository
    {
        public PersonPhoneRepository(ExampleContext context) : base(context) { }

        public async Task<List<PersonPhone>> GetPersonPhonesWithTypes()
        {
            return await DbSet.AsNoTracking()
                .Include(pp => pp.PhoneNumberType)
                .Include(pp => pp.Person)
                .ToListAsync();
        }

        public async Task<PersonPhone> GetPersonPhoneWithType(string phoneNumber)
        {
            return await DbSet.AsNoTracking()
                .Include(pp => pp.PhoneNumberType)
                .Include(pp => pp.Person)
                .FirstOrDefaultAsync(pp => pp.PhoneNumber == phoneNumber);
        }
    }
}
