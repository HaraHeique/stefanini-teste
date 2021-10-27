using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;
using System.Threading.Tasks;

namespace Examples.Charge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonPhoneController : BaseController
    {
        private readonly IPersonPhoneFacade _facade;

        public PersonPhoneController(IPersonPhoneFacade facade)
        {
            _facade = facade;
        }

        [HttpGet]
        public async Task<ActionResult<PersonPhoneListResponse>> Get()
        {
            return Response(await _facade.GetAll());
        }

        [HttpGet("{phoneNumber:length(8, 22)}")]
        public async Task<ActionResult<PersonPhoneResponse>> Get([FromRoute] string phoneNumber)
        {
            return Response(await _facade.Get(phoneNumber));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PersonPhoneRequest request)
        {
            await _facade.Create(request);

            return Response(null);
        }

        [HttpPut("{phoneNumber:length(8, 22)}")]
        public async Task<IActionResult> Update([FromBody] PersonPhoneRequest request, [FromRoute] string phoneNumber)
        {
            await _facade.Update(request);

            return Response(null);
        }

        [HttpDelete("{phoneNumber:length(8, 22)}")]
        public async Task<IActionResult> Delete([FromRoute] string phoneNumber)
        {
            await _facade.Delete(phoneNumber);

            return Response(null);
        }
    }
}
