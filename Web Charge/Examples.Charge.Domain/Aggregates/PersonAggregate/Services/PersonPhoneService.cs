using Examples.Charge.Domain.Aggregates.Common.Services;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Entities;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces.Repositories;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Services
{
    public class PersonPhoneService : BaseService<PersonPhone>, IPersonPhoneService
    {
        private readonly IPersonPhoneRepository _personPhoneRepository;

        public PersonPhoneService(IPersonPhoneRepository personPhoneRepository) : base(personPhoneRepository)
        {
            _personPhoneRepository = personPhoneRepository;
        }

        public async Task<List<PersonPhone>> GetPersonPhonesWithTypes() => await _personPhoneRepository.GetPersonPhonesWithTypes();

        public async Task<PersonPhone> GetPersonPhoneWithType(string phoneNumber) => await _personPhoneRepository.GetPersonPhoneWithType(phoneNumber);

        public override async Task Update(PersonPhone obj)
        {
            // OBS.: Como ambas as três chaves da tabela são PK's então vou deletar o registro e adicionar novamente como se estivesse atualizando
            var removeObj = await _personPhoneRepository.Get(pp => pp.PhoneNumber == obj.PhoneNumber);

            await base.Delete(removeObj);
            await base.Create(obj);
        }

        public override async Task Delete(PersonPhone obj)
        {
            var removeObj = await _personPhoneRepository.Get(pp => pp.PhoneNumber == obj.PhoneNumber);

            await base.Delete(removeObj);
        }
    }
}
