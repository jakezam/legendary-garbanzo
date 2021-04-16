using System;
using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using legendary_garbanzo.Data;
using legendary_garbanzo.DTOs;
using legendary_garbanzo.Models;
using Microsoft.AspNetCore.Mvc;

#pragma warning disable 1591 /*XML Doc String Warning*/

namespace legendary_garbanzo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IData _data;
        private readonly IMapper _mapper;
        public CategoriesController(IData data, IMapper mapper)
        {
            _data = data;
            _mapper = mapper;
        }
        
        // GET api/categories/{providerId}
        [HttpGet("{providerId}", Name=nameof(GetCategoriesById))]
        public ActionResult<CategoryRead> GetCategoriesById(Guid providerId)
        {
            var categories = _data.GetCategoriesById(providerId);
            
            if (categories != null)
                return Ok(_mapper.Map<IEnumerable<CategoryRead>>(categories));
            
            return NotFound();
        }
        
        // POST api/categories/{providerId}
        [HttpPost("{providerId}", Name=nameof(CreateCategory))]
        public ActionResult<CategoryCreate> CreateCategory(Guid providerId, CategoryCreate categoryCreate)
        {
            // TODO: Check if providerId exits
            // categoryCreate.ProviderId = providerId;
            
            var categoryModel = _mapper.Map<Category>(categoryCreate);

            categoryModel.ProviderId = providerId;

            _data.CreateCategory(categoryModel);
            _data.SaveChanges();

            var categoryRead = _mapper.Map<CategoryRead>(categoryModel);

            return CreatedAtRoute(nameof(GetCategoriesById), new {categoryModel.ProviderId}, categoryRead);
        }
    }
}