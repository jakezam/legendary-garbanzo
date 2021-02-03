using System;
using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using legendary_garbanzo.Data;
using legendary_garbanzo.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace legendary_garbanzo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoriesController : ControllerBase
    {
        private readonly IData _data;
        private readonly IMapper _mapper;
        public SubCategoriesController(IData data, IMapper mapper)
        {
            _data = data;
            _mapper = mapper;
        }
        
        // GET api/subcategories/{id}
        [HttpGet("{providerId}", Name=nameof(GetSubCategoriesById))]
        public ActionResult<CategoryRead> GetSubCategoriesById(int providerId)
        {
            var subCategories = _data.GetCategoriesById(providerId);
            
            if (subCategories != null)
                return Ok(_mapper.Map<CategoryRead>(subCategories));
            
            return NotFound();
        }
    }
}