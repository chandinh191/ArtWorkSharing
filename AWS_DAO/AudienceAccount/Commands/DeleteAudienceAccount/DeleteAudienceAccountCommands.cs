using AWS_DAO.Common.Exceptions;
using AWS_BusinessObjects.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.AudienceAccount.Commands.DeleteAudienceAccount
{
    public class DeleteAudienceAccountCommands : IRequest<bool>
    {
        public Guid Id { get; init; }
    }
    
    public class DeleteAudienceAccountCommandsHandler : IRequestHandler<DeleteAudienceAccountCommands, bool>
    {
        public readonly IApplicationDbContext _context;
        
        public DeleteAudienceAccountCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteAudienceAccountCommands request, CancellationToken cancellationToken)
        {
            var audienceAccount = await _context.Get<AWS_BusinessObjects.Entities.AudienceAccount>()
                .FindAsync(new object[] {request.Id}, cancellationToken);
            
            if (audienceAccount == null)
            {
                throw new NotFoundException(nameof(AWS_BusinessObjects.Entities.AudienceAccount), request.Id);
            }

            audienceAccount.IsDeleted = true;

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
