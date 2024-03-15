using AWS_BusinessObjects.Entities;
using AWS_Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ArtWorkSharingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var orders = orderService.GetAll();
            return Ok(orders);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(Guid id)
        {
            var order = orderService.GetById(id);
            return Ok(order);
        }
        [HttpPost("Add")]
        public IActionResult Add(Order order)
        {
            orderService.Add(order);
            return Ok("Thêm thành công");
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(Guid id)
        {
            orderService.Delete(id);
            return Ok("Xóa thành công");
        }
        [HttpPut("Update")]
        public IActionResult Update(Order order)
        {
            var Order = orderService.GetById(order.Id);

            if (Order != null)
            {
                orderService.Update(order);
                return Ok("Cập nhật thành công");
            }
            return NotFound();
        }
    }
}
