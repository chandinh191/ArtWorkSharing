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
        //[Authorize]
        [HttpGet("GetById")]
        public IActionResult GetById(Guid id)
        {
            var artWork = _artWorkService.GetById(id);
            if (artWork == null)
            {
                return NotFound($"Không tìm thấy tranh của bạn!, Id: {id}");
            }
            return Ok(artWork);
        }
        //[Authorize Roles = ("1, 2, 3")]
        [HttpPost("Add")]
        public IActionResult Add(ArtWork artWork)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
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
            if (ModelState.IsValid)
            {
                var artWorkCheck = _artWorkService.GetById(id);
                if (artWorkCheck == null)
                {
                    ModelState.AddModelError($"Id", $"Không tìm thấy tranh của bạn!, Id: {id}");
                    return NotFound(ModelState);
                }
                else
                {
                    _artWorkService.Delete(id);
                    return Ok("Xóa thành công");
                }
            }
            else
            {
                return BadRequest($"Số Lỗi: {ModelState.ErrorCount}, Lỗi: {ModelState}");
            }
        }
        //[Authorize Roles = ("1, 2, 3")]
        [HttpPut("Update")]
        public IActionResult Update(ArtWork artWork)
        {            
            if (ModelState.IsValid)
            {
                var artWorkCheck = _artWorkService.GetById(artWork.Id);
                if (artWorkCheck == null)
                {
                    ModelState.AddModelError($"Id", $"Không tìm thấy tranh của bạn!, Id: {artWork.Id}, Name: {artWork.Name}");
                    return NotFound(ModelState);
                } 
                else
                {
                    _artWorkService.Update(artWork);
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
