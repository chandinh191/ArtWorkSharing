using AWS_BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Services.Interface
{
    public interface IOrderService
    {
        public List<Order> GetAll();
        public Order GetById(Guid id);
        public void Add(Order order);
        public void Update(Order order);
        public void Delete(Guid id);
    }
}
