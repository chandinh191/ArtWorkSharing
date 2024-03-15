using AWS_BusinessObjects.Entities;
using AWS_Services.Interface;
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
            return Ok(packageDetail);
        }
        [HttpPost("Add")]
        public IActionResult Add(PackageDetail packageDetail)
        {
            packageDetailsService.Add(packageDetail);
            return Ok("Thêm thành công");
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(Guid id)
        {
            packageDetailsService.Delete(id);
            return Ok("Xóa thành công");
        }
        [HttpPut("Update")]
        public IActionResult Update(PackageDetail packageDetail)
        {
            var PackageDetail = packageDetailsService.GetById(packageDetail.Id);

            if (PackageDetail != null)
            {
                packageDetailsService.Update(packageDetail);
                return Ok("Cập nhật thành công");
            }
            return NotFound();
        }
    }
}
