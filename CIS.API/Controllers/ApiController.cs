using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace CIS.API.Controllers
{
    public abstract class ApiController : Controller
    {
        protected readonly IMapper Mapper;

        protected ApiController(IMapper mapper)
        {
            Mapper = mapper;
        }
    }
}