using AWS_BusinessObjects.Entities;
using AWS_Services.Interface;
using AWS_Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArtWorkSharingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentMethodController : ControllerBase
    {
        private IPaymentMethodService paymentMethodService;

        public PaymentMethodController(IPaymentMethodService paymentMethodService)
        {
            this.paymentMethodService = paymentMethodService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var paymentMethods = paymentMethodService.GetAll();
            return Ok(paymentMethods);
        }
        //[Authorize Roles = ("1, 2, 3")]
        [HttpGet("GetById")]
        public IActionResult GetById(Guid id)
        {
            var paymentMethod = paymentMethodService.GetById(id);
            if (paymentMethod == null)
            {
                return NotFound($"Không tìm thấy phương thức thanh toán của bạn!, Id: {id}");
            }
            else
            {
                return Ok(paymentMethod);
            }
        }
        //[Authorize Roles = ("1, 2")]
        [HttpPost("Add")]
        public IActionResult Add(PaymentMethod paymentMethod)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                paymentMethodService.Add(paymentMethod);
                return Ok("Thêm thành công");
            }            
        }
        //[Authorize Roles = ("1, 2, 3")]
        [HttpDelete("Delete")]
        public IActionResult Delete(Guid id)
        {
            if (ModelState.IsValid)
            {
                var paymentMethodCheck = paymentMethodService.GetById(id);
                if (paymentMethodCheck == null)
                {
                    ModelState.AddModelError($"Id", $"Không tìm thấy phương thức thanh toán của bạn!, Id: {id}");
                    return NotFound(ModelState);
                }
                else
                {
                    paymentMethodService.Delete(id);
                    return Ok("Xóa thành công");
                }
            }
            else
            {
                return BadRequest($"Số Lỗi: {ModelState.ErrorCount}, Lỗi: {ModelState}");
            }            
        }
        [HttpPut("Update")]
        public IActionResult Update(PaymentMethod paymentMethod)
        {
            if (ModelState.IsValid)
            {
                var paymentMethodCheck = paymentMethodService.GetById(paymentMethod.Id);
                if (paymentMethodCheck == null)
                {
                    ModelState.AddModelError($"Id", $"Không tìm thấy phương thức thanh toán của bạn!, Id: {paymentMethod.Id}");
                    return NotFound(ModelState);
                }
                else
                {
                    paymentMethodService.Update(paymentMethod);
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
