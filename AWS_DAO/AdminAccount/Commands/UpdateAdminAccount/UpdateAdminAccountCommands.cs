using AWS_DAO.Common.Exceptions;
using AWS_DAO.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.AdminAccount.Commands.UpdateAdminAccount
{
    public class UpdateAdminAccountCommands : IRequest<string>
    {
        public string Id { get; set; }
        public string UserAccountId { get; set; }
    }

    public class UpdateAdminAccountCommandsHandler : IRequestHandler<UpdateAdminAccountCommands, string>
    {
        private readonly IApplicationDbContext _context;

        public UpdateAdminAccountCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(UpdateAdminAccountCommands request, System.Threading.CancellationToken cancellationToken)
        {
            var adminAccount = await _context.Get<AWS_BusinessObjects.Entities.AdminAccount>()
                .FindAsync(new object[] { request.Id }, cancellationToken);

            if (adminAccount == null)
            {
                throw new NotFoundException(nameof(AWS_BusinessObjects.Entities.AdminAccount), request.Id);
            }

            adminAccount.UserAccountId = request.UserAccountId;

            await _context.SaveChangesAsync(cancellationToken);

            return adminAccount.Id.ToString();
        }
    }
}
