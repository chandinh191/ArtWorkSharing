using AWS_BusinessObjects.Entities;
using AWS_Services.Interface;
using AWS_Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArtWorkSharingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageDetailController : ControllerBase
    {
        private IPackageDetailsService packageDetailsService;

        public PackageDetailController(IPackageDetailsService packageDetailsService)
        {
            this.packageDetailsService = packageDetailsService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var packageDetails = packageDetailsService.GetAll();
            return Ok(packageDetails);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(Guid id)
        {
            var packageDetail = packageDetailsService.GetById(id);
            if (packageDetail == null)
            {
                return NotFound($"Không tìm thấy chi tiết gói của bạn!, Id: {id}");
            }
            else
            {
                return Ok(packageDetail);
            }       
            
        }
        [HttpPost("Add")]
        public IActionResult Add(PackageDetail packageDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                packageDetailsService.Add(packageDetail);
                return Ok("Thêm thành công");
            }
            
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(Guid id)
        {
            if (ModelState.IsValid)
            {
                var packageDetailCheck = packageDetailsService.GetById(id);
                if (packageDetailCheck == null)
                {
                    ModelState.AddModelError($"Id", $"Không tìm thấy chi tiết gói của bạn!, Id: {id}");
                    return NotFound(ModelState);
                }
                else
                {
                    packageDetailsService.Delete(id);
                    return Ok("Xóa thành công");
                }
            }
            else
            {
                return BadRequest($"Số Lỗi: {ModelState.ErrorCount}, Lỗi: {ModelState}");
            }
            
        }
        [HttpPut("Update")]
        public IActionResult Update(PackageDetail packageDetail)
        {
            if (ModelState.IsValid)
            {
                var packageDetailCheck = packageDetailsService.GetById(packageDetail.Id);
                if (packageDetailCheck == null)
                {
                    ModelState.AddModelError($"Id", $"Không tìm thấy chi tiết gói của bạn!, Id: {packageDetail.Id}");
                    return NotFound(ModelState);
                }
                else
                {
                    packageDetailsService.Update(packageDetail);
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
