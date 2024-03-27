using AWS_BusinessObjects.Common.Models;
using AWS_BusinessObjects.Entities;
using AWS_Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArtWorkSharingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WishListController : ControllerBase
    {
        private IWishListService wishListService;

        public WishListController(IWishListService wishListService)
        {
            this.wishListService = wishListService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var categories = wishListService.GetAll();
            return Ok(categories);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(Guid id)
        {
            var wishList = wishListService.GetById(id);
            if (wishList == null)
            {
                return NotFound($"Không tìm thấy tranh mong muốn của bạn!, Id: {id}");
            }
            else
            {
                return Ok(wishList);
            }
        }

        [HttpPost("Add")]
        public IActionResult Add(WistListModel wishListModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                wishListService.Add(wishListModel);
                return Ok("Thêm thành công");
            }
        }

        [HttpDelete("Delete")]
        public IActionResult Delete(Guid id)
        {
            if (ModelState.IsValid)
            {
                var wishListCheck = wishListService.GetById(id);
                if (wishListCheck == null)
                {
                    ModelState.AddModelError($"Id", $"Không tìm thấy tranh mong muốn của bạn!, Id: {id}");
                    return NotFound(ModelState);
                }
                else
                {
                    wishListService.Delete(id);
                    return Ok("Xóa thành công");
                }
            }
            else
            {
                return BadRequest($"Số Lỗi: {ModelState.ErrorCount}, Lỗi: {ModelState}");
            }
        }

        [HttpPut("Update")]
        public IActionResult Update(WistListModel wishListModel)
        {
            if (ModelState.IsValid)
            {
                var wishListCheck = wishListService.GetById(wishListModel.Id);
                if (wishListCheck == null)
                {
                    ModelState.AddModelError($"Id", $"Không tìm thấy tranh mong muốn của bạn!, Id: {wishListModel.Id}");
                    return NotFound(ModelState);
                }
                else
                {
                    wishListService.Update(wishListModel);
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
