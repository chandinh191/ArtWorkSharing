using AWS_BusinessObjects.Entities;
using AWS_DAO;
using AWS_Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Repository.Repositories
{
    public class PaymentMethodRepository : IPaymentMethodRepository
    {
        private PaymentMethodDAO paymentMethodDAO = null;
        public PaymentMethodRepository()
        {
            paymentMethodDAO = new PaymentMethodDAO();
        }

        public void Add(PaymentMethod paymentMethod)
        => paymentMethodDAO.Add(paymentMethod);

        public void Delete(Guid id)
        => paymentMethodDAO.Delete(id);

        public List<PaymentMethod> GetAll()
        => paymentMethodDAO.GetAll();

        public PaymentMethod GetById(Guid id)
        => paymentMethodDAO.GetById(id);

        public void Update(PaymentMethod paymentMethod)
        => paymentMethodDAO.Update(paymentMethod);
    }
}
