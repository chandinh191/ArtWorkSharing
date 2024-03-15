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
            var packages = packageService.GetAll();
            return Ok(packages);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(Guid id)
        {
            var package = packageService.GetById(id);
            return Ok(package);
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
            var Package = packageService.GetById(package.Id);

            if (Package != null)
            {
                packageService.Update(package);
                return Ok("Cập nhật thành công");
            }
            return NotFound();
        }
    }
}
