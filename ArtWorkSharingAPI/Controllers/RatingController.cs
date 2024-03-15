using AWS_BusinessObjects.Entities;
using AWS_Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ArtWorkSharingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private IRatingService ratingService;

        public RatingController(IRatingService ratingService)
        {
            this.ratingService = ratingService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var interacts = ratingService.GetAll();
            return Ok(interacts);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(Guid id)
        {
            var ratings = ratingService.GetById(id);
            return Ok(ratings);
        }
        [HttpPost("Add")]
        public IActionResult Add(Rating rating)
        {
            ratingService.Add(rating);
            return Ok("Thêm thành công");
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(Guid id)
        {
            ratingService.Delete(id);
            return Ok("Xóa thành công");
        }
        [HttpPut("Update")]
        public IActionResult Update(Rating rating)
        {
            var Rating = ratingService.GetById(rating.Id);

            if (Rating != null)
            {
                ratingService.Update(rating);
                return Ok("Cập nhật thành công");
            }
            return NotFound();
        }
    }
}
