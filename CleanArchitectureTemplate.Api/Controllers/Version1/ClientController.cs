using AutoMapper;
using CleanArchitectureTemplate.Api.Contracts.Version1.Requests;
using CleanArchitectureTemplate.Api.Routes.Version1;
using CleanArchitectureTemplate.Application.Clients.Commands.CreateClient;
using CleanArchitectureTemplate.Application.Clients.Queries.GetClientDetails;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CleanArchitectureTemplate.Api.Controllers.Version1
{
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;

        public ClientController(IMediator mediator, IMapper mapper)
        {
            this.mediator = mediator;
            this.mapper = mapper;
        }

        /// <summary>
        /// Creates a New Client
        /// </summary>
        /// <response code="201">Creates a New Client</response>
        /// <response code="400">Unable to create Client due to validation error</response>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost(ApiRoutes.Client.Create)]
        public async Task<IActionResult> CreateClient([FromBody] ClientRequest clientRequest)
        {
            var clientViewModel = mapper.Map<ClientViewModel>(clientRequest);

            var command = new CreateClientCommand(clientViewModel);
            var result = await mediator.Send(command);

            return CreatedAtAction("CreateClient", result);
        }

        /// <summary>
        /// Returns a Client specified by an Id
        /// </summary>
        /// <response code="200">Returns a Client specified by an Id</response>
        /// <response code="400">Unable to return Client due to invalid Id</response>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPost(ApiRoutes.Client.Get)]
        public async Task<IActionResult> GetClient(long clientId)
        {
            var query = new GetClientByIdQuery(clientId);
            var result = await mediator.Send(query);

            return result != null ? (IActionResult)Ok(result) : NotFound();
        }
    }
}