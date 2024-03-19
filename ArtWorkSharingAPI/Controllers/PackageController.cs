using AWS_BusinessObjects.Entities;
using AWS_Services.Interface;
using AWS_Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArtWorkSharingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageController : ControllerBase
    {
        private IPackageService packageService;

        public PackageController(IPackageService packageService)
        {
            this.packageService = packageService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var packages = packageService.GetAll();
            return Ok(packages);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(Guid id)
        {
            var package = packageService.GetById(id);
            if (package == null)
            {
                return NotFound($"Không tìm thấy gói của bạn!, Id: {id}");
            }
            else
            {
                return Ok(package);
            }
        }
        [HttpPost("Add")]
        public IActionResult Add(Package package)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                packageService.Add(package);
                return Ok("Thêm thành công");
            }
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(Guid id)
        {
            if (ModelState.IsValid)
            {
                var packageCheck = packageService.GetById(id);
                if (packageCheck == null)
                {
                    ModelState.AddModelError($"Id", $"Không tìm thấy gói của bạn!, Id: {id}");
                    return NotFound(ModelState);
                }
                else
                {
                    packageService.Delete(id);
                    return Ok("Xóa thành công");
                }
            }
            else
            {
                return BadRequest($"Số Lỗi: {ModelState.ErrorCount}, Lỗi: {ModelState}");
            }
        }
        [HttpPut("Update")]
        public IActionResult Update(Package package)
        {
            if (ModelState.IsValid)
            {
                var packageCheck = packageService.GetById(package.Id);
                if (packageCheck == null)
                {
                    ModelState.AddModelError($"Id", $"Không tìm thấy gói của bạn!, Id: {package.Id}");
                    return NotFound(ModelState);
                }
                else
                {
                    packageService.Update(package);
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
