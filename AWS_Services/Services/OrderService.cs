﻿using AWS_BusinessObjects.Entities;
using AWS_Repository.Interface;
using AWS_Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Services.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public void Add(Order order)
        =>  orderRepository.Add(order);

        public void Delete(Guid id)
        => orderRepository.Delete(id);

        public List<Order> GetAll()
        => orderRepository.GetAll();

        public Order GetById(Guid id)
        => orderRepository.GetById(id);

        public void Update(Order order)
        => orderRepository.Update(order);
    }
}
