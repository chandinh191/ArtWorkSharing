using AWS_DAO.Common.Exceptions;
using AWS_DAO.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.AudienceAccount.Commands.UpdateAudienceAccount
{
    public class UpdateAudienceAccountCommands : IRequest<string>
    {
        public string Id { get; set; }
        public string UserAccountId { get; set; }
    }

    public class UpdateAudienceAccountCommandsHandler : IRequestHandler<UpdateAudienceAccountCommands, string>
    {
        private readonly IApplicationDbContext _context;

        public UpdateAudienceAccountCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(UpdateAudienceAccountCommands request, System.Threading.CancellationToken cancellationToken)
        {
            var audienceAccount = await _context.Get<AWS_BusinessObjects.Entities.AudienceAccount>()
                .FindAsync(new object[] { request.Id }, cancellationToken);

            if (audienceAccount == null)
            {
                throw new NotFoundException(nameof(AWS_BusinessObjects.Entities.AudienceAccount), request.Id);
            }

            audienceAccount.UserAccountId = request.UserAccountId;

            await _context.SaveChangesAsync(cancellationToken);

            return audienceAccount.Id.ToString();
        }
    }
}
