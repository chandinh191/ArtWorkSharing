using AutoMapper;
using AWS_BusinessObjects.Common.Interfaces;
using AWS_BusinessObjects.Common.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.Order.Queries.GetAlllOrder
{
    public class GetAllOrderRequest : IRequest<PaginatedList<OrderModel>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }

    public class GetAllOrderRequestHandler : IRequestHandler<GetAllOrderRequest, PaginatedList<OrderModel>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetAllOrderRequestHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PaginatedList<OrderModel>> Handle(GetAllOrderRequest request, CancellationToken cancellationToken)
        {
            var orders = _context.Get<AWS_BusinessObjects.Entities.Order>()
                .Include(x => x.Rating)
                .OrderByDescending(x => x.Created)
                .AsNoTracking();

            var map = _mapper.ProjectTo<OrderModel>(orders);

            var page = await PaginatedList<OrderModel>.CreateAsync(map, request.PageNumber, request.PageSize);

            return page;
        }
    }
}
