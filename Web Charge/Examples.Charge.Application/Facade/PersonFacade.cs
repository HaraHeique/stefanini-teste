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
    public class PersonFacade : IPersonFacade
    {
        private readonly IPersonService _personService;
        private readonly IMapper _mapper;

        public PersonFacade(IPersonService personService, IMapper mapper)
        {
            _personService = personService;
            _mapper = mapper;
        }

        public async Task<PersonListResponse> GetAll()
        {
            var result = await _personService.GetAll();

            var response = new PersonListResponse();
            response.PersonObjects = _mapper.Map<List<PersonDto>>(result);

            return response;
        }

        public async Task<PersonResponse> Get(int id)
        {
            var result = await _personService.GetById(id);

            var response = new PersonResponse() 
            {
                PersonObject = _mapper.Map<PersonDto>(result)
            };

            return response;
        }

        public async Task Create(PersonCreateRequest request)
        {
            var entity = _mapper.Map<Person>(request);
            await _personService.Create(entity);
        }
        
        public async Task Update(PersonUpdateRequest request)
        {
            var entity = _mapper.Map<Person>(request);
            await _personService.Update(entity);
        }

        public async Task Delete(int id)
        {
            var entity = new Person(id);
            await _personService.Delete(entity);
        }
    }
}
