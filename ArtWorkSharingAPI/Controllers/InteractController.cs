using AWS_BusinessObjects.Entities;
using AWS_Services.Interface;
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
            return Ok(interact);
        }
        [HttpPost("Add")]
        public IActionResult Add(Interact interact)
        {
            interactService.Add(interact);
            return Ok("Thêm thành công");
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(Guid id)
        {
            interactService.Delete(id);
            return Ok("Xóa thành công");
        }
        [HttpPut("Update")]
        public IActionResult Update(Interact interact)
        {
            var Interact = interactService.GetById(interact.Id);

            if (Interact != null)
            {
                interactService.Update(interact);
                return Ok("Cập nhật thành công");
            }
            return NotFound();
        }
    }
}
