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
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var artWorks = _artWorkService.GetAll();           
            return Ok(artWorks);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(Guid id)
        {
            var artWork = _artWorkService.GetById(id);
            return Ok(artWork);
        }
        [HttpPost("Add")]
        public IActionResult Add(ArtWork artWork)
        {
            _artWorkService.Add(artWork);
            return Ok("Thêm thành công");
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(Guid id)
        {
            _artWorkService.Delete(id);
            return Ok("Xóa thành công");
        }
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
