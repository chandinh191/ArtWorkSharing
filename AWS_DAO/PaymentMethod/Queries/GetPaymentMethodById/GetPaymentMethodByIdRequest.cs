using AutoMapper;
using AWS_DAO.Common.Exceptions;
using AWS_DAO.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.PaymentMethod.Queries.GetPaymentMethodById
{
    public class GetPaymentMethodByIdRequest : IRequest<PaymentMethodModel>
    { 
        public Guid Id { get; set; }
    }
    
    public class GetPaymentMethodByIdRequestHandler : IRequestHandler<GetPaymentMethodByIdRequest, PaymentMethodModel>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetPaymentMethodByIdRequestHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<PaymentMethodModel> Handle(GetPaymentMethodByIdRequest request, CancellationToken cancellationToken)
        {
            var paymentMethod = _context.Get<AWS_BusinessObjects.Entities.PaymentMethod>().AsNoTracking().FirstOrDefault(x => x.Id == request.Id);

            if (paymentMethod == null)
            {
                throw new NotFoundException(nameof(AWS_BusinessObjects.Entities.PaymentMethod), request.Id);
            }

            var map = _mapper.Map<PaymentMethodModel>(paymentMethod);

            return Task.FromResult(map);
        }
    }
}
