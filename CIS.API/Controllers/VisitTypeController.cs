using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CIS.API.DataTransferObjects.VisitTypes.Request;
using CIS.API.DataTransferObjects.VisitTypes.Response;
using CIS.Common.Exceptions;
using CIS.ServiceContracts.ServiceObjects;
using CIS.ServiceContracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace CIS.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Produces("application/json")]

    public sealed class VisitTypeController : ApiController
    {
        private readonly IVisitTypeService _visitTypeService;

        public VisitTypeController(
            IVisitTypeService visitTypeService,
             IMapper mapper) : base(mapper)
        {
            _visitTypeService = visitTypeService;
        }

        [HttpPost]
        [ProducesResponseType(201, Type = typeof(AddVisitTypeResponseDto))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> CreateVisitTypeAsync(
            [FromBody] AddVisitTypeRequestDto addVisitTypeRequestDto,
            CancellationToken token = default)
        {
            try
            {
                var visitTypeServiceObject = Mapper.Map<VisitTypeServiceObject>(addVisitTypeRequestDto);
                var serviceResult = await _visitTypeService.CreateVisitTypeAsync(visitTypeServiceObject, token);
                return new CreatedResult(string.Empty, Mapper.Map<AddVisitTypeResponseDto>(serviceResult));
            }
            catch (BadRequestException e)
            {
                return new BadRequestObjectResult(e.Error);
            }
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(GetVisitTypeResponseDto))]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetVisitTypeListAsync(
            CancellationToken token = default)
        {
            try
            {
                var serviceResult = await _visitTypeService.GetVisitTypeListAsync(token);
                return new OkObjectResult(Mapper.Map<IEnumerable<GetVisitTypeResponseDto>>(serviceResult));
            }
            catch (Exception)
            {
                return new BadRequestResult();
            }
        }

        [HttpGet("{visitTypeId}")]
        [ProducesResponseType(200, Type = typeof(GetVisitTypeResponseDto))]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetVisitTypeByIdAsync(
            [FromRoute] int visitTypeId,
            CancellationToken token = default)
        {
            try
            {
                var serviceResult = await _visitTypeService.GetVisitTypeByIdAsync(visitTypeId, token);
                return new OkObjectResult(Mapper.Map<GetVisitTypeResponseDto>(serviceResult));
            }
            catch (Exception)
            {
                return new NotFoundResult();
            }
        }

        [HttpPut("{visitTypeId}")]
        [ProducesResponseType(200, Type = typeof(UpdateVisitTypeResponseDto))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> UpdateVisitTypeByIdAsync(
            [FromRoute] int visitTypeId,
            [FromBody] UpdateVisitTypeRequestDto updateVisitTypeRequestDto,
            CancellationToken token = default)
        {
            try
            {
                var visitTypeServiceObject = Mapper.Map<VisitTypeServiceObject>(updateVisitTypeRequestDto);
                visitTypeServiceObject.Id = visitTypeId;
                var serviceResult = await _visitTypeService.UpdateVisitTypeByIdAsync(visitTypeServiceObject, token);
                return new OkObjectResult(Mapper.Map<UpdateVisitTypeResponseDto>(serviceResult));
            }
            catch (Exception)
            {
                return new BadRequestResult();
            }
        }

        [HttpDelete("{visitTypeId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> DeleteVisitTypeByIdAsync(
            [FromRoute] int visitTypeId,
            CancellationToken token = default)
        {
            try
            {
                await _visitTypeService.DeleteVisitTypeByIdAsync(visitTypeId, token);
                return new StatusCodeResult(204);
            }
            catch (Exception)
            {
                return new NotFoundResult();
            }
        }
    }
}