using System;
using System.Collections;
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
        public ActionResult<ProviderRead> GetProviderById(int providerId)
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

            return CreatedAtRoute(nameof(GetProviderById), new { ProviderId = providerRead.ProviderId }, providerRead);
        }

        // PUT api/providers/{id}
        [HttpPut("{id}")]
        public ActionResult<ProviderUpdate> UpdateProvider(int id, ProviderUpdate providerUpdate)
        {
            var providerModel = _data.GetProviderById(id);
            if (providerModel == null)
            {
                return NotFound();
            }

            _mapper.Map(providerUpdate, providerModel);
            _data.UpdateProvider(providerModel);
            _data.SaveChanges();
            return NoContent();
        }
    }
}