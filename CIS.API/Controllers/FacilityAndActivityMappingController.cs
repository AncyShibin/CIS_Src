using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CIS.API.DataTransferObjects.FacilityAndActivity.Request;
using CIS.API.DataTransferObjects.FacilityAndActivity.Response;
using CIS.Common.Exceptions;
using CIS.ServiceContracts.ServiceObjects;
using CIS.ServiceContracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace CIS.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    public class FacilityAndActivityMappingController : ApiController
    {
        private readonly IFacilityAndActivityService _facilityAndActivityService;

        public FacilityAndActivityMappingController(
            IFacilityAndActivityService facilityAndActivityService,
             IMapper mapper) : base(mapper)
        {
            _facilityAndActivityService = facilityAndActivityService;
        }

        [HttpPost]
        [ProducesResponseType(201, Type = typeof(AddFacilityAndActivityResponseDto))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> CreateFacilityAndActivityAsync(
            [FromBody] AddFacilityAndActivityRequestDto addFacilityAndActivityRequestDto,
            CancellationToken token = default)
        {
            try
            {
                var facilityAndActivityServiceObject = Mapper.Map<FacilityAndActivityServiceObject>(addFacilityAndActivityRequestDto);
                var serviceResult = await _facilityAndActivityService.CreateFacilityAndActivityAsync(facilityAndActivityServiceObject, token);
                return new CreatedResult(string.Empty, Mapper.Map<AddFacilityAndActivityResponseDto>(serviceResult));
            }
            catch (BadRequestException e)
            {
                return new BadRequestObjectResult(e.Error);
            }
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(GetFacilityAndActivityResponseDto))]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetFacilityAndActivityListAsync(
            CancellationToken token = default)
        {
            try
            {
                var serviceResult = await _facilityAndActivityService.GetFacilityAndActivityListAsync(token);
                return new OkObjectResult(Mapper.Map<IEnumerable<GetFacilityAndActivityResponseDto>>(serviceResult));
            }
            catch (Exception)
            {
                return new BadRequestResult();
            }
        }

        [HttpGet("{facilityAndActivityId}")]
        [ProducesResponseType(200, Type = typeof(GetFacilityAndActivityResponseDto))]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetFacilityAndActivityByIdAsync(
            [FromRoute] int facilityAndActivityId,
            CancellationToken token = default)
        {
            try
            {
                var serviceResult = await _facilityAndActivityService.GetFacilityAndActivityByIdAsync(facilityAndActivityId, token);
                return new OkObjectResult(Mapper.Map<GetFacilityAndActivityResponseDto>(serviceResult));
            }
            catch (Exception)
            {
                return new NotFoundResult();
            }
        }

        [HttpPut("{facilityAndActivityId}")]
        [ProducesResponseType(200, Type = typeof(UpdateFacilityAndActivityResponseDto))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> UpdateFacilityAndActivityByIdAsync(
            [FromRoute] int facilityAndActivityId,
            [FromBody] UpdateFacilityAndActivityRequestDto updateFacilityAndActivityRequestDto,
            CancellationToken token = default)
        {
            try
            {
                var facilityAndActivityServiceObject = Mapper.Map<FacilityAndActivityServiceObject>(updateFacilityAndActivityRequestDto);
                facilityAndActivityServiceObject.Id = facilityAndActivityId;
                var serviceResult = await _facilityAndActivityService.UpdateFacilityAndActivityByIdAsync(facilityAndActivityServiceObject, token);
                return new OkObjectResult(Mapper.Map<UpdateFacilityAndActivityResponseDto>(serviceResult));
            }
            catch (Exception)
            {
                return new BadRequestResult();
            }
        }

        [HttpDelete("{facilityAndActivityId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> DeleteFacilityAndActivityByIdAsync(
            [FromRoute] int facilityAndActivityId,
            CancellationToken token = default)
        {
            try
            {
                await _facilityAndActivityService.DeleteFacilityAndActivityByIdAsync(facilityAndActivityId, token);
                return new StatusCodeResult(204);
            }
            catch (Exception)
            {
                return new NotFoundResult();
            }
        }
    }
}