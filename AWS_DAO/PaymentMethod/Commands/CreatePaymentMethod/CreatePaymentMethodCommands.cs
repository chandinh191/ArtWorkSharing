using AWS_BusinessObjects.Enums;
using AWS_DAO.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.PaymentMethod.Commands.CreatePaymentMethod
{
    public class CreatePaymentMethodCommands : IRequest<Guid>
    {
        public string Name { get; set; }
        public PaymentMethodStatus PaymentMethodStatus { get; set; }
    }

    public class CreatePaymentMethodCommandsHandler : IRequestHandler<CreatePaymentMethodCommands, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreatePaymentMethodCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreatePaymentMethodCommands request, CancellationToken cancellationToken)
        {
            var paymentMethod = new AWS_BusinessObjects.Entities.PaymentMethod
            {
                Name = request.Name,
                PaymentMethodStatus = request.PaymentMethodStatus
            };

            _context.Get<AWS_BusinessObjects.Entities.PaymentMethod>().Add(paymentMethod);
            await _context.SaveChangesAsync(cancellationToken);

            return paymentMethod.Id;
        }
    }
}
