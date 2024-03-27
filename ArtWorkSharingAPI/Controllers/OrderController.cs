using AWS_BusinessObjects.Common.Models;
using AWS_BusinessObjects.Entities;
using AWS_BusinessObjects.Enums;
using AWS_Services.Interface;
using AWS_Services.Services;
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
        [HttpGet("GetOrderByStatus")]
        public IActionResult GetOrderByStatus(OrderStatus status)
        {
            var orders = orderService.GetAll().Where(o=>o.Status == status);
            return Ok(orders);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(Guid id)
        {
            var order = orderService.GetById(id);
            if (order == null)
            {
                return NotFound($"Không tìm thấy đơn đặt hàng của bạn!, Id: {id}");
            }
            else
            {
                return Ok(order);
            }
        }
        [HttpPost("Add")]
        public IActionResult Add(OrderModel orderModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                orderService.Add(orderModel);
                return Ok("Thêm thành công");
            }
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(Guid id)
        {
            if (ModelState.IsValid)
            {
                var orderCheck = orderService.GetById(id);
                if (orderCheck == null)
                {
                    ModelState.AddModelError($"Id", $"Không tìm thấy đơn đặt hàng của bạn!, Id: {id}");
                    return NotFound(ModelState);
                }
                else
                {
                    orderService.Delete(id);
                    return Ok("Xóa thành công");
                }
            }
            else
            {
                return BadRequest($"Số Lỗi: {ModelState.ErrorCount}, Lỗi: {ModelState}");
            }
            
        }
        [HttpPut("Update")]
        public IActionResult Update(OrderModel orderModel)
        {
          
                var orderCheck = orderService.GetById(orderModel.Id);
                if (orderCheck == null)
                {
                    ModelState.AddModelError($"Id", $"Không tìm thấy đơn đặt hàng của bạn!, Id: {orderModel.Id}");
                    return NotFound(ModelState);
                }
                else
                {
                    orderService.Update(orderModel);
                    return Ok("Cập nhật thành công");
                }
            
        }
        [HttpPut("UpdateStatusCancel")]
        public IActionResult UpdateStatusCancel(Guid artworkId)
        {
            OrderModel orderModel = new OrderModel();
            var listOrder = orderService.GetAll().Where(o=>o.ArtWorkID == artworkId);
             foreach (var order in listOrder)
            {
                if(order.Status != OrderStatus.Accepted)
                {
                    order.Status = OrderStatus.Cancelled;
                    orderModel.Id = order.Id;
                    orderModel.Status = order.Status;
                    orderModel.ArtWorkID = order.ArtWorkID;
                    orderModel.BuyerAccountId = order.BuyerAccountId;
                    orderModel.OwnerAccountId = order.OwnerAccountId;
                    
                }
                orderService.Update(orderModel);
            }
             return Ok("Cập nhật thành công");

        }
    }
}
