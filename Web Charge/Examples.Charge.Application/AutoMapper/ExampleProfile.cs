using AutoMapper;
using Examples.Charge.Application.Dtos;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Domain.Aggregates.ExampleAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Entities;

namespace Examples.Charge.Application.AutoMapper
{
    public class ExampleProfile : Profile
    {
        public ExampleProfile()
        {
            // DTO's
            CreateMap<Example, ExampleDto>().ReverseMap();

            CreateMap<Person, PersonDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.BusinessEntityID))
                .ReverseMap();

            CreateMap<PersonPhone, PersonPhoneDto>()
                .ForMember(dest => dest.PhoneNumberTypeName, opt => opt.MapFrom(src => src.PhoneNumberType.Name));

            // Requests
            CreateMap<PersonCreateRequest, Person>();

            CreateMap<PersonUpdateRequest, Person>()
                .ForMember(dest => dest.BusinessEntityID, opt => opt.MapFrom(src => src.Id));

            CreateMap<PersonPhoneRequest, PersonPhone>()
                .ForMember(dest => dest.PhoneNumberTypeID, opt => opt.MapFrom(src => src.PhoneNumberTypeId))
                .ForMember(dest => dest.BusinessEntityID, opt => opt.MapFrom(src => src.PersonId));
        }
    }
}
