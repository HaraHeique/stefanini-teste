using Examples.Charge.Domain.Aggregates.PersonAggregate.Entities;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces.Repositories;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces.Services;
using Examples.Charge.Domain.Aggregates.Common.Services;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Services
{
    public class PhoneNumberTypeService : BaseService<PhoneNumberType>, IPhoneNumberTypeService
    {
        public PhoneNumberTypeService(IPhoneNumberTypeRepository phoneNumberTypeRepository) : base(phoneNumberTypeRepository)
        {
        }
    }
}
