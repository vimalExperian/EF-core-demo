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

        [HttpPost]
        [Route("review")]
        public IActionResult AddReview(CreateRatingRequest request)
        {
            bool success = _reviewService.AddReview(request);
            return Ok(success);
        }
        
    }
}
