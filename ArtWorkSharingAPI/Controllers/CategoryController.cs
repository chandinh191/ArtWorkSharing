using AWS_BusinessObjects.Entities;
using AWS_Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArtWorkSharingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var categories = categoryService.GetAll();
            return Ok(categories);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(Guid id)
        {
            var category = categoryService.GetById(id);
            if (category == null)
            {
                return NotFound($"Không tìm thấy loại tranh của bạn!, Id: {id}");
            }
            else
            {
                return Ok(category);
            }
        }
        [HttpPost("Add")]
        public IActionResult Add(Category category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                categoryService.Add(category);
                return Ok("Thêm thành công");
            }
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(Guid id)
        {
            if (ModelState.IsValid)
            {
                var categoryCheck = categoryService.GetById(id);
                if (categoryCheck == null)
                {
                    ModelState.AddModelError($"Id", $"Không tìm thấy loại tranh của bạn!, Id: {id}");
                    return NotFound(ModelState);
                }
                else
                {
                    categoryService.Delete(id);
                    return Ok("Xóa thành công");
                }
            }
            else
            {
                return BadRequest($"Số Lỗi: {ModelState.ErrorCount}, Lỗi: {ModelState}");
            }

        }
        [HttpPut("Update")]
        public IActionResult Update(Category category)
        {
            if (ModelState.IsValid)
            {
                var orderCheck = categoryService.GetById(category.Id);
                if (orderCheck == null)
                {
                    ModelState.AddModelError($"Id", $"Không tìm thấy loại tranh của bạn!, Id: {category.Id}");
                    return NotFound(ModelState);
                }
                else
                {
                    categoryService.Update(category);
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
