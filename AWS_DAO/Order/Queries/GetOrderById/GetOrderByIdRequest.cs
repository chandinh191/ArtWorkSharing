using AutoMapper;
using AWS_DAO.Common.Exceptions;
using AWS_BusinessObjects.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.Order.Queries.GetOrderById
{
    public class GetOrderByIdRequest : IRequest<OrderModel>
    {
        public Guid Id { get; set; }
    }

    public class GetOrderByIdRequestHandler : IRequestHandler<GetOrderByIdRequest, OrderModel>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetOrderByIdRequestHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<OrderModel> Handle(GetOrderByIdRequest request, CancellationToken cancellationToken)
        {
            var order = _context.Get<AWS_BusinessObjects.Entities.Order>().AsNoTracking().FirstOrDefault(x => x.Id == request.Id);

            if (order == null)
            {
                throw new NotFoundException(nameof(AWS_BusinessObjects.Entities.Order), request.Id);
            }

            var map = _mapper.Map<OrderModel>(order);   

            return Task.FromResult(map);    
        }
    }
}
