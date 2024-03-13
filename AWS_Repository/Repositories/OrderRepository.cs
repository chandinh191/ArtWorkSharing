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
    public class OrderRepository : IOrderRepository
    {
        private OrderDAO orderDAO = null;
        public OrderRepository()
        {
            orderDAO = new OrderDAO();
        }

        public void Add(Order order)
        => orderDAO.Add(order);

        public void Delete(Guid id)
        => orderDAO.Delete(id);

        public List<Order> GetAll()
        => orderDAO.GetAll();

        public Order GetById(Guid id)
        => orderDAO.GetById(id);

        public void Update(Order order)
        => orderDAO.Update(order);
    }
}
