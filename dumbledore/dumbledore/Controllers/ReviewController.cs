using dumbledore.DL.Models;
using dumbledore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace dumbledore.Controllers
{
    public class ReviewController: ControllerBase
    {
        private readonly IReviewService _reviewService;
        public ReviewController(IReviewService reviewService) {
            _reviewService = reviewService;
        }

        [HttpGet]
        [Route("reviews/{movieId}")]
        public IActionResult GetReviewsByMovieId(int movieId)
        {
            var reviews = _reviewService.GetReviewsByMovieId(movieId);
            return Ok(reviews);
        }

        [HttpPost]
        [Route("review")]
        public IActionResult AddReview(CreateRatingRequest request)
        {
            bool success = _reviewService.AddReview(request);
            return Ok(success);
        }

        [HttpPost]
        [Route("reviews")]
        public IActionResult AddReviews([FromBody] AddMultipleRatingsRequest request)
        {
            bool success = _reviewService.AddReviews(request);
            return Ok(success);
        }


        [HttpPut]
        [Route("updateReview")]
        public IActionResult EditReview(UpdateRatingRequest request)
        {
            bool success = _reviewService.UpdateReview(request);
            if (success)
            {
                return Ok("Review updated successfully.");
            }
            else
            {
                return BadRequest("Failed to update review.");
            }
        }

        

    }
}
