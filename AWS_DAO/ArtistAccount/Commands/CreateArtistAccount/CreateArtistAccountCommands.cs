using AWS_DAO.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.ArtistAccount.Commands.CreateArtistAccount
{
    public class CreateArtistAccountCommands : IRequest<string>
    {
        public string UserAccountId { get; set; }
    }

    public class CreateArtistAccountCommandsHandler : IRequestHandler<CreateArtistAccountCommands, string>
    {
        private readonly IApplicationDbContext _context;

        public CreateArtistAccountCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(CreateArtistAccountCommands request, System.Threading.CancellationToken cancellationToken)
        {
            var artistAccount = new AWS_BusinessObjects.Entities.ArtistAccount
            {
                UserAccountId = request.UserAccountId
            };

            _context.Get<AWS_BusinessObjects.Entities.ArtistAccount>().Add(artistAccount);
            await _context.SaveChangesAsync(cancellationToken);

            return artistAccount.Id.ToString();
        }
    }
}
