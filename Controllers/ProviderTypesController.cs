using System.Collections.Generic;
using AutoMapper;
using legendary_garbanzo.Data;
using legendary_garbanzo.Models;
using Microsoft.AspNetCore.Mvc;

#pragma warning disable 1591 /*XML Doc String Warning*/

namespace legendary_garbanzo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderTypesController : ControllerBase
    {
        private readonly IData _data;
        private readonly IMapper _mapper;

        public ProviderTypesController(IData data, IMapper mapper)
        {
            _data = data;
            _mapper = mapper;
        }

        // GET api/providertypes
        [HttpGet]
        public ActionResult<IEnumerable<ProviderTypes>> GetProviderTypes()
        {
            var providerTypes = _data.GetProviderTypes();

            if (providerTypes != null)
                return Ok(_mapper.Map<IEnumerable<ProviderTypes>>(providerTypes));

            return NotFound();
        }
    }
}