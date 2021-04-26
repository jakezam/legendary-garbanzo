using System;
using System.Collections.Generic;
using AutoMapper;
using legendary_garbanzo.Data;
using legendary_garbanzo.DTOs;
using legendary_garbanzo.Models;
using Microsoft.AspNetCore.Mvc;

namespace legendary_garbanzo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvidersController : ControllerBase
    {
        private readonly IData _data;
        private readonly IMapper _mapper;

        public ProvidersController(IData data, IMapper mapper)
        {
            _data = data;
            _mapper = mapper;
        }

        // GET api/providers
        [HttpGet]
        public ActionResult<IEnumerable<ProviderRead>> GetProviders(string category)
        {
            var providers = _data.GetAllProviders(category);

            if (providers != null)
                return Ok(_mapper.Map<IEnumerable<ProviderRead>>(providers));

            return NotFound();
        }

        // GET api/providers/{id}
        [HttpGet("{providerId}", Name = nameof(GetProviderById))]
        public ActionResult<ProviderRead> GetProviderById(Guid providerId)
        {
            var provider = _data.GetProviderById(providerId);

            if (provider != null)
                return Ok(_mapper.Map<ProviderRead>(provider));

            return NotFound();
        }

        // POST api/providers
        [HttpPost]
        public ActionResult<ProviderCreate> CreateProvider(ProviderCreate providerCreate)
        {
            var providerModel = _mapper.Map<Provider>(providerCreate);
            _data.CreateProvider(providerModel);
            _data.SaveChanges();

            var providerRead = _mapper.Map<ProviderRead>(providerModel);

            return CreatedAtRoute(nameof(GetProviderById), new {providerRead.ProviderId}, providerRead);
        }

        // PUT api/providers/{id}
        /// <remarks>
        ///     Note that to update a provider you MUST provide all the provider properties. This
        ///     may change in a future version of the application.
        /// </remarks>
        [HttpPut("{id}")]
        public ActionResult<ProviderUpdate> UpdateProvider(Guid id, ProviderUpdate providerUpdate)
        {
            var oldProvider = _data.GetProviderById(id);
            if (oldProvider == null) return NotFound();

            _mapper.Map(providerUpdate, oldProvider);
            _data.UpdateProvider(oldProvider);
            _data.SaveChanges();
            return Ok();
        }
    }
}