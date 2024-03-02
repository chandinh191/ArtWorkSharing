using AWS_DAO.Common.Exceptions;
using AWS_DAO.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.AdminAccount.Commands.DeleteAdminAccount
{
    public record DeleteAdminAccountCommands : IRequest<bool>
    {
        public Guid Id { get; init; }
    }

    public class DeleteAdminAccountCommandsHandler : IRequestHandler<DeleteAdminAccountCommands, bool>
    {
        public readonly IApplicationDbContext _context;
        
        public DeleteAdminAccountCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteAdminAccountCommands request, CancellationToken cancellationToken)
        {
            var adminAccount = await _context.Get<AWS_BusinessObjects.Entities.AdminAccount>()
                .FindAsync(new object[] {request.Id}, cancellationToken);
            
            if (adminAccount == null)
            {
                throw new NotFoundException(nameof(AWS_BusinessObjects.Entities.AdminAccount), request.Id);
            }

            adminAccount.IsDeleted = true;

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
