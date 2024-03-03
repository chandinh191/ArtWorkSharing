using AWS_BusinessObjects.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.AudienceAccount.Commands.CreateAudienceAccount
{
    public class CreateAudienceAccountCommands : IRequest<string>
    {
        public string UserAccountId { get; set; }   
    }

    public class CreateAudienceAccountCommandsHandler : IRequestHandler<CreateAudienceAccountCommands, string>
    {
        private readonly IApplicationDbContext _context;

        public CreateAudienceAccountCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(CreateAudienceAccountCommands request, System.Threading.CancellationToken cancellationToken)
        {
            var audienceAccount = new AWS_BusinessObjects.Entities.AudienceAccount
            {
                UserAccountId = request.UserAccountId
            };

            _context.Get<AWS_BusinessObjects.Entities.AudienceAccount>().Add(audienceAccount);
            await _context.SaveChangesAsync(cancellationToken);

            return audienceAccount.Id.ToString();
        }
    }
}
