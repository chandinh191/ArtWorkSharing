using AWS_BusinessObjects.Entities;
using AWS_Services.Interface;
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
        [HttpGet("GetById")]
        public IActionResult GetById(Guid id)
        {
            var paymentMethod = paymentMethodService.GetById(id);
            return Ok(paymentMethod);
        }
        [HttpPost("Add")]
        public IActionResult Add(PaymentMethod paymentMethod)
        {
            paymentMethodService.Add(paymentMethod);
            return Ok("Thêm thành công");
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(Guid id)
        {
            paymentMethodService.Delete(id);
            return Ok("Xóa thành công");
        }
        [HttpPut("Update")]
        public IActionResult Update(PaymentMethod paymentMethod)
        {
            var PaymentMethod = paymentMethodService.GetById(paymentMethod.Id);

            if (PaymentMethod != null)
            {
                paymentMethodService.Update(paymentMethod);
                return Ok("Cập nhật thành công");
            }
            return NotFound();
        }
    }
}
