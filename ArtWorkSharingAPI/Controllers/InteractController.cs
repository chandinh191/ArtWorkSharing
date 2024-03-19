using AWS_BusinessObjects.Entities;
using AWS_Services.Interface;
using AWS_Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArtWorkSharingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InteractController : ControllerBase
    {
        private IInteractService interactService;

        public InteractController(IInteractService interactService)
        {
            this.interactService = interactService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var interacts = interactService.GetAll();
            return Ok(interacts);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(Guid id)
        {
            var interact = interactService.GetById(id);
            if (interact == null)
            {
                return NotFound($"Không tìm thấy tương tác của bạn!, Id: {id}");
            } 
            else
            {
                return Ok(interact);
            }          
        }
        [HttpPost("Add")]
        public IActionResult Add(Interact interact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                interactService.Add(interact);
                return Ok("Thêm thành công");
            }
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(Guid id)
        {
            if (ModelState.IsValid)
            {
                var interactCheck = interactService.GetById(id);
                if (interactCheck == null)
                {
                    ModelState.AddModelError($"Id", $"Không tìm thấy tương tác của bạn!, Id: {id}");
                    return NotFound(ModelState);
                }
                else
                {
                    interactService.Delete(id);
                    return Ok("Xóa thành công");
                }
            }
            else
            {
                return BadRequest($"Số Lỗi: {ModelState.ErrorCount}, Lỗi: {ModelState}");
            }
        }
        [HttpPut("Update")]
        public IActionResult Update(Interact interact)
        {
            if (ModelState.IsValid)
            {
                var interactCheck = interactService.GetById(interact.Id);
                if (interactCheck == null)
                {
                    ModelState.AddModelError($"Id", $"Không tìm thấy tương tác của bạn!, Id: {interact.Id}");
                    return NotFound(ModelState);
                }
                else
                {
                    interactService.Update(interact);
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
