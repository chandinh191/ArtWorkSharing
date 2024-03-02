using AWS_DAO.Common.Exceptions;
using AWS_DAO.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.PaymentMethod.Commands.DeletePaymentMethod
{
    public class DeletePaymentMethodCommands : IRequest<bool>
    {
        public Guid Id { get; set; }
    }

    public class DeletePaymentMethodCommandsHandler : IRequestHandler<DeletePaymentMethodCommands, bool>
    {
        private readonly IApplicationDbContext _context;

        public DeletePaymentMethodCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<bool> Handle(DeletePaymentMethodCommands request, CancellationToken cancellationToken)
        {
            var paymentMethod = _context.Get<AWS_BusinessObjects.Entities.PaymentMethod>().FirstOrDefault(x => x.Id == request.Id);

            if (paymentMethod == null)
            {
                throw new NotFoundException(nameof(AWS_BusinessObjects.Entities.PaymentMethod), request.Id);    
            }
            paymentMethod.IsDeleted = true;  

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
