using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Interfaces
{
    public interface IPersonPhoneFacade
    {
        Task<PersonPhoneListResponse> GetAll();
        Task<PersonPhoneResponse> Get(string phoneNumber);
        Task Create(PersonPhoneRequest request);
        Task Update(PersonPhoneRequest request);
        Task Delete(string phoneNumber);
    }
}