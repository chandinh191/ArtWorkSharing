using AWS_BusinessObjects.Entities;
using AWS_Repository.Identity;
using AWS_Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;




namespace ArtWorkSharingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtWorkController : ControllerBase
    {
        private IArtWorkService _artWorkService;

        public ArtWorkController(IArtWorkService artWorkService)
        {
            _artWorkService = artWorkService;
        }
        //[Authorize Roles = ("1, 2, 3")]
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var artWorks = _artWorkService.GetAll();           
            return Ok(artWorks);
        }
        //[Authorize Roles = ("1, 2, 3")]
        [HttpGet("GetById")]
        public IActionResult GetById(Guid id)
        {
            var artWork = _artWorkService.GetById(id);
            return Ok(artWork);
        }
        //[Authorize Roles = ("1, 2, 3")]
        [HttpPost("Add")]
        public IActionResult Add(ArtWork artWork)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(artWork);
            }
            else
            {
                _artWorkService.Add(artWork);
                return Ok("Thêm thành công");
            }            
        }
        //[Authorize Roles = ("1, 2, 3")]
        [HttpDelete("Delete")]
        public IActionResult Delete(Guid id)
        {
            _artWorkService.Delete(id);
            return Ok("Xóa thành công");
        }
        //[Authorize Roles = ("1, 2, 3")]
        [HttpPut("Update")]
        public IActionResult Update(ArtWork artWork)
        {
            var artWorkCheck = _artWorkService.GetById(artWork.Id);

            if (artWorkCheck != null)
            {
                _artWorkService.Update(artWork);
                return Ok("Cập nhật thành công");
            }
            return NotFound();
        }
    }
}
