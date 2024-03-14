using AWS_BusinessObjects.Entities;
using AWS_Repository.Interface;
using AWS_Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Services.Services
{
    public class PaymentMethodService : IPaymentMethodService
    {
        private readonly IPaymentMethodRepository paymentMethodRepository;
        public PaymentMethodService(IPaymentMethodRepository paymentMethodRepository)
        {
            this.paymentMethodRepository = paymentMethodRepository;
        }

        public void Add(PaymentMethod paymentMethod)
        => paymentMethodRepository.Add(paymentMethod);

        public void Delete(Guid id)
        => paymentMethodRepository.Delete(id);

        public List<PaymentMethod> GetAll()
        => paymentMethodRepository.GetAll();

        public PaymentMethod GetById(Guid id)
        => paymentMethodRepository.GetById(id);

        public void Update(PaymentMethod paymentMethod)
        => paymentMethodRepository.Update(paymentMethod);
    }
}
