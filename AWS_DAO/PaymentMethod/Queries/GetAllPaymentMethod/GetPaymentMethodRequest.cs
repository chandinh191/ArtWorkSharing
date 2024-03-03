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

namespace AWS_DAO.PaymentMethod.Queries.GetAllPaymentMethod
{
    public class GetPaymentMethodRequest : IRequest<PaginatedList<AWS_BusinessObjects.Entities.PaymentMethod>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }

    public class GetPaymentMethodRequestHandler : IRequestHandler<GetPaymentMethodRequest, PaginatedList<AWS_BusinessObjects.Entities.PaymentMethod>>
           {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetPaymentMethodRequestHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PaginatedList<AWS_BusinessObjects.Entities.PaymentMethod>> Handle(GetPaymentMethodRequest request, CancellationToken cancellationToken)
        {
            var paymentMethods = _context.Get<AWS_BusinessObjects.Entities.PaymentMethod>()
                .OrderBy(x => x.Name)
                .AsNoTracking();

            var map = _mapper.ProjectTo<AWS_BusinessObjects.Entities.PaymentMethod>(paymentMethods);    

            var page = await PaginatedList<AWS_BusinessObjects.Entities.PaymentMethod>.CreateAsync(map, request.PageNumber, request.PageSize);

            return page;
        }
    }
}
