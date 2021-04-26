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
    public class PrivateMessageController : ControllerBase
    {
        private readonly IData _data;
        private readonly IMapper _mapper;

        public PrivateMessageController(IData data, IMapper mapper)
        {
            _data = data;
            _mapper = mapper;
        }

        // GET api/users/{id}/Inbox
        [HttpGet("{userId}/inbox", Name = nameof(GetUserInbox))]
        public ICollection<PrivateMessageRead> GetUserInbox(Guid userId)
        {
            return (ICollection<PrivateMessageRead>) _data.GetUserInbox(userId);
        }

        // GET api/users/{id}/Outbox
        [HttpGet("{userId}/outbox", Name = nameof(GetUserSent))]
        public ICollection<PrivateMessageRead> GetUserSent(Guid userId)
        {
            return (ICollection<PrivateMessageRead>) _data.GetUserSent(userId);
        }

        // Post api/users/{id}/Outbox
        [HttpPost]
        public ActionResult<PrivateMessageCreate> PostMessage(PrivateMessageCreate message)
        {
            PrivateMessage m = new PrivateMessage
            {
                From = message.From,
                To = message.To,
                Message = message.Message,
                Subject = message.Subject
            };
            _data.SendMessage(m);
            _data.SaveChanges();
            return CreatedAtRoute(nameof(m),m);
        }

        // DELETE api/reviews
        [HttpDelete("{messageId}")]
        public IActionResult CreateReview(Guid messageId)
        {
            var message = _data.GetPrivateMessage(messageId);
            if (message == null) return NotFound();
            _data.DeletePrivateMessage(message);
            _data.SaveChanges();
            return NoContent();
        }
    }
}