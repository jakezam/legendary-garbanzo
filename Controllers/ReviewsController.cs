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
    public class ReviewsController : ControllerBase
    {
        private readonly IData _data;
        private readonly IMapper _mapper;
        public ReviewsController(IData data, IMapper mapper)
        {
            _data = data;
            _mapper = mapper;
        }

        // GET api/reviews
        [HttpGet]
        public ActionResult<IEnumerable<ReviewRead>> GetReviews(string userId, string receivedReviews)
        {
            var reviews = _data.GetReviews(userId, receivedReviews);

            if (reviews != null)
                return Ok(_mapper.Map<IEnumerable<ReviewRead>>(reviews));

            return NotFound();

        }

        // GET api/reviews/{id}
        [HttpGet("{reviewId}", Name = nameof(GetReviewById))]
        public ActionResult<ReviewRead> GetReviewById(int reviewId)
        {
            var review = _data.GetReviewById(reviewId);

            if (review != null)
                return Ok(_mapper.Map<ReviewRead>(review));

            return NotFound();
        }

        // POST api/reviews
        [HttpPost]
        public ActionResult<ReviewCreate> CreateReview(ReviewCreate reviewCreate)
        {
            var reviewModel = _mapper.Map<Review>(reviewCreate);
            _data.CreateReview(reviewModel);
            _data.SaveChanges();

            var reviewRead = _mapper.Map<Review>(reviewModel);
            
            return CreatedAtRoute(nameof(GetReviewById), new { ReviewId = reviewRead.ReviewId }, reviewRead);
        }
    }
}