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
    public class PersonController : BaseController
    {
        private readonly IPersonFacade _facade;

        public PersonController(IPersonFacade facade)
        {
            _facade = facade;
        }

        [HttpGet]
        public async Task<ActionResult<PersonListResponse>> Get()
        {
            return Response(await _facade.GetAll());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<PersonResponse>> Get([FromRoute] int id)
        {
            return Response(await _facade.Get(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PersonCreateRequest request)
        {
            await _facade.Create(request);

            return Response(null);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update([FromBody] PersonUpdateRequest request, [FromRoute] int id)
        {
            await _facade.Update(request);

            return Response(null);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await _facade.Delete(id);

            return Response(null);
        }
    }
}
