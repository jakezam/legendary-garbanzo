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
        public ActionResult<IEnumerable<ReviewRead>> GetReviews(Guid userId, string receivedReviews)
        {
            var reviews = _data.GetReviews(userId, receivedReviews);

            if (reviews != null)
                return Ok(_mapper.Map<IEnumerable<ReviewRead>>(reviews));

            return NotFound();
        }

        // GET api/reviews/{id}
        [HttpGet("{reviewId}", Name = nameof(GetReviewById))]
        public ActionResult<ReviewRead> GetReviewById(Guid reviewId)
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

            var toUser = _data.GetUserInbox(reviewCreate.ReceivingUserId);
            var negOrPos = "positive";

            if (!reviewCreate.WouldRecommend) negOrPos = "negative";

            var reviewMessage = new PrivateMessage
            {
                From = reviewCreate.UserId,
                To = reviewCreate.ReceivingUserId,
                Subject = "New Review From: " + reviewCreate.Username,
                Message = "A " + negOrPos + " review has been posted on your profile by " + reviewCreate.Username
                          + " with a rating of " + reviewCreate.Rating
                          + ". \"" + reviewCreate.Description + "\"."
            };
            _data.SendMessage(reviewMessage);
            var reviewRead = _mapper.Map<Review>(reviewModel);
            _data.SaveChanges();
            return CreatedAtRoute(nameof(GetReviewById), new {reviewRead.ReviewId}, reviewRead);
        }
    }
}