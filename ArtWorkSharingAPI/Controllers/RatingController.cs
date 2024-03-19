using AWS_BusinessObjects.Entities;
using AWS_Services.Interface;
using AWS_Services.Services;
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
            if (ratings == null)
            {
                return NotFound($"Không tìm thấy đánh giá của bạn!, Id: {id}");
            }
            else
            {
                return Ok(ratings);
            }
        }
        [HttpPost("Add")]
        public IActionResult Add(Rating rating)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                ratingService.Add(rating);
                return Ok("Thêm thành công");
            }
            
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(Guid id)
        {
            if (ModelState.IsValid)
            {
                var ratingCheck = ratingService.GetById(id);
                if (ratingCheck == null)
                {
                    ModelState.AddModelError($"Id", $"Không tìm thấy đánh giá của bạn!, Id: {id}");
                    return NotFound(ModelState);
                }
                else
                {
                    ratingService.Delete(id);
                    return Ok("Xóa thành công");
                }
            }
            else
            {
                return BadRequest($"Số Lỗi: {ModelState.ErrorCount}, Lỗi: {ModelState}");
            }
            
        }
        [HttpPut("Update")]
        public IActionResult Update(Rating rating)
        {
            if (ModelState.IsValid)
            {
                var ratingCheck = ratingService.GetById(rating.Id);
                if (ratingCheck == null)
                {
                    ModelState.AddModelError($"Id", $"Không tìm thấy đánh giá của bạn!, Id: {rating.Id}");
                    return NotFound(ModelState);
                }
                else
                {
                    ratingService.Update(rating);
                    return Ok("Cập nhật thành công");
                }
            }
            else
            {
                return BadRequest($"Số Lỗi: {ModelState.ErrorCount}, Lỗi: {ModelState}");
            }
        }
    }
}
