using AWS_DAO.Common.Exceptions;
using AWS_DAO.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.Package.Commands.DeletePackage
{
    public class DeletePackageCommands : IRequest<bool>
    {
        public Guid Id { get; set; }
    }

    public class DeletePackageCommandsHandler : IRequestHandler<DeletePackageCommands, bool>
    {
        private readonly IApplicationDbContext _context;

        public DeletePackageCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeletePackageCommands request, CancellationToken cancellationToken)
        {
            var package = _context.Get<AWS_BusinessObjects.Entities.Package>().FirstOrDefault(x => x.Id == request.Id);

            if (package == null)
            {
                throw new NotFoundException(nameof(AWS_BusinessObjects.Entities.Package), request.Id);  
            }
            package.IsDeleted = true;

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
