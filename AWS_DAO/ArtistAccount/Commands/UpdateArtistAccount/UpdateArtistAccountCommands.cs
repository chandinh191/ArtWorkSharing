using AWS_DAO.Common.Exceptions;
using AWS_DAO.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.ArtistAccount.Commands.UpdateArtistAccount
{
    public class UpdateArtistAccountCommands : IRequest<string>
    {
        public string Id { get; set; }
        public string UserAccountId { get; set; }
    }

    public class UpdateArtistAccountCommandsHandler : IRequestHandler<UpdateArtistAccountCommands, string>
    {
        private readonly IApplicationDbContext _context;

        public UpdateArtistAccountCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(UpdateArtistAccountCommands request, System.Threading.CancellationToken cancellationToken)
        {
            var artistAccount = await _context.Get<AWS_BusinessObjects.Entities.ArtistAccount>()
                .FindAsync(new object[] { request.Id }, cancellationToken);

            if (artistAccount == null)
            {
                throw new NotFoundException(nameof(AWS_BusinessObjects.Entities.ArtistAccount), request.Id);
            }

            artistAccount.UserAccountId = request.UserAccountId;

            await _context.SaveChangesAsync(cancellationToken);

            return artistAccount.Id.ToString();
        }
    }
}
