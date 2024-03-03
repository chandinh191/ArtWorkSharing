using AWS_BusinessObjects.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.AdminAccount.Commands.CreateAdminAccount
{
    public class CreateAdminAccountCommands : IRequest<string>
    {
        public string UserAccountId { get; set; }
    }

    public class CreateAdminAccountCommandsHandler : IRequestHandler<CreateAdminAccountCommands, string>
    {
        private readonly IApplicationDbContext _context;

        public CreateAdminAccountCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(CreateAdminAccountCommands request, System.Threading.CancellationToken cancellationToken)
        {
            var adminAccount = new AWS_BusinessObjects.Entities.AdminAccount
            {
                UserAccountId = request.UserAccountId
            };

            _context.Get<AWS_BusinessObjects.Entities.AdminAccount>().Add(adminAccount);
            await _context.SaveChangesAsync(cancellationToken);

            return adminAccount.Id.ToString();
        }
    }
}
