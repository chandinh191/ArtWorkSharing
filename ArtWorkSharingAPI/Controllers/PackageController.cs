using AWS_BusinessObjects.Entities;
using AWS_Services.Interface;
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
            var artWorks = packageService.GetAll();
            return Ok(artWorks);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(Guid id)
        {
            var artWork = packageService.GetById(id);
            return Ok(artWork);
        }
        [HttpPost("Add")]
        public IActionResult Add(Package package)
        {
            packageService.Add(package);
            return Ok("Thêm thành công");
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(Guid id)
        {
            packageService.Delete(id);
            return Ok("Xóa thành công");
        }
        [HttpPut("Update")]
        public IActionResult Update(Package package)
        {
            var artWorkCheck = packageService.GetById(package.Id);

            if (artWorkCheck != null)
            {
                packageService.Update(package);
                return Ok("Cập nhật thành công");
            }
            return NotFound();
        }
    }
}
