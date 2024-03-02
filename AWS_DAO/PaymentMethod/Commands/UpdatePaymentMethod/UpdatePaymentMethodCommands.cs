using AWS_BusinessObjects.Enums;
using AWS_DAO.Common.Exceptions;
using AWS_DAO.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.PaymentMethod.Commands.UpdatePaymentMethod
{
    public class UpdatePaymentMethodCommands : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public PaymentMethodStatus PaymentMethodStatus { get; set; }    
    }

    public class UpdatePaymentMethodCommandsHandler : IRequestHandler<UpdatePaymentMethodCommands, Guid>
    {
        private readonly IApplicationDbContext _context;

        public UpdatePaymentMethodCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(UpdatePaymentMethodCommands request, CancellationToken cancellationToken)
        {
            var paymentMethod = _context.Get<AWS_BusinessObjects.Entities.PaymentMethod>().FirstOrDefault(x => x.Id == request.Id);
            if (paymentMethod == null)
            {
                throw new NotFoundException(nameof(AWS_BusinessObjects.Entities.PaymentMethod), request.Id);
            }

            paymentMethod.Name = request.Name;
            paymentMethod.PaymentMethodStatus = request.PaymentMethodStatus;

            await _context.SaveChangesAsync(cancellationToken);

            return paymentMethod.Id;
        }
    }
}
