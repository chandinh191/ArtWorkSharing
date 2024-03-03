using AWS_DAO.Common.Exceptions;
using AWS_BusinessObjects.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.PackageDetail.Commands.DeletePackageDetail
{
    public class DeletePackageDetailCommands : IRequest<bool>
    {
        public Guid Id { get; set; }
    }

    public class DeletePackageDetailCommandsHandler : IRequestHandler<DeletePackageDetailCommands, bool>
    {
        private readonly IApplicationDbContext _context;

        public DeletePackageDetailCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeletePackageDetailCommands request, CancellationToken cancellationToken)
        {
            var packageDetail = _context.Get<AWS_BusinessObjects.Entities.PackageDetail>().FirstOrDefault(x => x.Id == request.Id);

            if (packageDetail == null)
            {
                throw new NotFoundException(nameof(AWS_BusinessObjects.Entities.PackageDetail), request.Id);    
            }
            packageDetail.IsDeleted = true;  

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
