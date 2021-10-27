using AutoMapper;
using Examples.Charge.Application.Dtos;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Entities;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Facade
{
    public class PersonPhoneFacade : IPersonPhoneFacade
    {
        private readonly IPersonPhoneService _personPhoneService;
        private readonly IMapper _mapper;

        public PersonPhoneFacade(IPersonPhoneService personPhoneService, IMapper mapper)
        {
            _personPhoneService = personPhoneService;
            _mapper = mapper;
        }

        public async Task<PersonPhoneListResponse> GetAll()
        {
            var result = await _personPhoneService.GetPersonPhonesWithTypes();

            var response = new PersonPhoneListResponse
            {
                PersonPhoneObjects = _mapper.Map<List<PersonPhoneDto>>(result)
            };

            return response;
        }

        public async Task<PersonPhoneResponse> Get(string phoneNumber)
        {
            var result = await _personPhoneService.GetPersonPhoneWithType(phoneNumber);

            var response = new PersonPhoneResponse()
            {
                PersonPhoneObject = _mapper.Map<PersonPhoneDto>(result)
            };

            return response;
        }

        public async Task Create(PersonPhoneRequest request)
        {
            var entity = _mapper.Map<PersonPhone>(request);
            await _personPhoneService.Create(entity);
        }

        public async Task Update(PersonPhoneRequest request)
        {
            var entity = _mapper.Map<PersonPhone>(request);
            await _personPhoneService.Update(entity);
        }

        public async Task Delete(string phoneNumber)
        {
            var entity = new PersonPhone(phoneNumber);
            await _personPhoneService.Delete(entity);
        }
    }
}
