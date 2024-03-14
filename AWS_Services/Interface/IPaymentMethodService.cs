using AWS_BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Services.Interface
{
    public interface IPaymentMethodService
    {
        public List<PaymentMethod> GetAll();
        public PaymentMethod GetById(Guid id);
        public void Add(PaymentMethod paymentMethod);
        public void Update(PaymentMethod paymentMethod);
        public void Delete(Guid id);
    }
}
