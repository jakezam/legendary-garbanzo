using System;
using System.Collections.Generic;
using AutoMapper;
using legendary_garbanzo.Data;
using legendary_garbanzo.DTOs;
using legendary_garbanzo.Models;
using Microsoft.AspNetCore.Mvc;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace legendary_garbanzo.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly IData _data;
        private readonly IMapper _mapper;
        public JobsController(IData data, IMapper mapper)
        {
            _data = data;
            _mapper = mapper;
        }

        // GET api/jobs
        [HttpGet]
        public ActionResult<IEnumerable<JobRead>> GetJobs(Guid userId)
        {
            var jobs = _data.GetJobs(userId);

            if (jobs != null)
                return Ok(_mapper.Map<IEnumerable<JobRead>>(jobs));

            return NotFound();
        }

        // GET api/jobs/{id}
        [HttpGet("{jobId}", Name = nameof(GetJobById))]

        public ActionResult<JobRead> GetJobById(Guid jobId)
        {
            var job = _data.GetJobById(jobId);

            if (job != null)
                return Ok(_mapper.Map<JobRead>(job));

            return NotFound();
        }

        // POST api/jobs
        [HttpPost]
        public ActionResult<JobCreate> CreateJob(JobCreate jobCreate)
        {
            var jobModel = _mapper.Map<Job>(jobCreate);
            _data.CreateJob(jobModel);
            _data.SaveChanges();

            var jobRead = _mapper.Map<JobRead>(jobModel);

            return CreatedAtRoute(nameof(GetJobById), new { JobId = jobRead.Id }, jobRead);
        }

        // POST api/jobs/request
        [HttpPost("request")]
        public ActionResult<ConsultationRequestCreate> CreateConsultationRequest(ConsultationRequestCreate consultationRequestCreate)
        {
            var categories = _data.GetCategoriesById(consultationRequestCreate.To);
            Category category = null;
            foreach (var cat in categories)
            {
                if (cat.ProviderCategory == consultationRequestCreate.ProviderCategory)
                {
                    category = cat;
                }
            }

            var from = _data.GetUserById(consultationRequestCreate.From);

            if (from == null)
            {
                return NotFound();
            }

            PrivateMessage consultationMessage;

            if (category == null)
            {
                consultationMessage = new PrivateMessage
                {
                    From = consultationRequestCreate.From,
                    To = consultationRequestCreate.To,
                    Message = consultationRequestCreate.Message,
                    Subject = "Consultation Request From " + from.FirstName + " " + from.LastName
                        + "For category: " + category.ProviderCategory
                        + "For hourly price: " + category.HourlyRate
                        + "For flat rate: " + category.FlatRate,
                };
            }
            else
            {
                consultationMessage = new PrivateMessage
                {
                    From = consultationRequestCreate.From,
                    To = consultationRequestCreate.To,
                    Message = consultationRequestCreate.Message,
                    Subject = "Consultation Request From " + from.FirstName + " " + from.LastName
                };
            }
            

            _data.SendMessage(consultationMessage);
            _data.SaveChanges();

            return CreatedAtRoute(nameof(consultationMessage.PrivateMessageId), new { PrivateMessageId = consultationMessage.PrivateMessageId });

        }

        // PUT api/jobs/{id}
        [HttpPut("{id}")]
        public ActionResult<JobUpdate> UpdateJob(Guid id, JobUpdate jobUpdate)
        {
            var jobModel = _data.GetJobById(id);
            if (jobModel == null)
            {
                return NotFound();
            }

            _mapper.Map(jobUpdate, jobModel);
            _data.UpdateJob(jobModel);
            _data.SaveChanges();
            return NoContent();
        }
    }
}