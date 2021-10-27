using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Interfaces
{
    public interface IPersonFacade
    {
        Task<PersonListResponse> GetAll();
        Task<PersonResponse> Get(int id);
        Task Create(PersonCreateRequest request);
        Task Update(PersonUpdateRequest request);
        Task Delete(int id);
    }
}