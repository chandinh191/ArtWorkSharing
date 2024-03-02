using AWS_DAO.Common.Exceptions;
using AWS_DAO.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.ArtistAccount.Commands.DeleteArtistAccount
{
    public class DeleteArtistAccountCommands : IRequest<bool>
    {
        public string UserAccountId { get; set; }
    }
    
    public class DeleteArtistAccountCommandsHandler : IRequestHandler<DeleteArtistAccountCommands, bool>
    {
        private readonly IApplicationDbContext _context;
        
        public DeleteArtistAccountCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteArtistAccountCommands request, System.Threading.CancellationToken cancellationToken)
        {
            var artistAccount = await _context.Get<AWS_BusinessObjects.Entities.ArtistAccount>()
                .FindAsync(new object[] {request.UserAccountId}, cancellationToken);
            
            if (artistAccount == null)
            {
                throw new NotFoundException(nameof(AWS_BusinessObjects.Entities.ArtistAccount), request.UserAccountId);
            }

            artistAccount.IsDeleted = true;

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
