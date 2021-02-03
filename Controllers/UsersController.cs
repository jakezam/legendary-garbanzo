using System;
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
    public class UsersController : ControllerBase
    {
        private readonly IData _data;
        private readonly IMapper _mapper;

        public UsersController(IData data, IMapper mapper)
        {
            _data = data;
            _mapper = mapper;
        }

        // GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<UserRead>> GetUsers()
        {
            var users = _data.GetAllUsers();

            if (users != null)
                return Ok(_mapper.Map<IEnumerable<UserRead>>(users));

            return NotFound();
        }

        // GET api/users/{id}
        [HttpGet("{userId}", Name = nameof(GetUserById))]
        public ActionResult<UserRead> GetUserById(Guid userId)
        {
            var user = _data.GetUserById(userId);

            if (user != null)
                return Ok(_mapper.Map<UserRead>(user));

            return NotFound();
        }

        // POST api/users
        [HttpPost]
        public ActionResult<UserCreate> CreateUser(UserCreate userCreate)
        {
            var userModel = _mapper.Map<User>(userCreate);
            _data.CreateUser(userModel);
            _data.SaveChanges();

            var userRead = _mapper.Map<UserRead>(userModel);

            return CreatedAtRoute(nameof(GetUserById), new {userRead.UserId}, userRead);
        }

        // PUT api/users/{id}
        /// <remarks>
        ///     Note that to update a user you MUST provide all the user properties. This
        ///     may change in a future version of the application.
        /// </remarks>
        [HttpPut("{id}")]
        public ActionResult<UserUpdate> UpdateUser(Guid id, UserUpdate userUpdate)
        {
            var oldUser = _data.GetUserById(id);
            if (oldUser == null)
                return NotFound();

            _mapper.Map(userUpdate, oldUser);
            _data.UpdateUser(oldUser);
            _data.SaveChanges();
            return Ok();
        }
    }
}