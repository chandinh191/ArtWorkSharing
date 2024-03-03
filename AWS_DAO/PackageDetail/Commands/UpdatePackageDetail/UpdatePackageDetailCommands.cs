using AWS_DAO.Common.Exceptions;
using AWS_BusinessObjects.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.PackageDetail.Commands.UpdatePackageDetail
{
    public class UpdatePackageDetailCommands : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string? NamePacked { get; set; }
        public string? Description { get; set; }
        public int Status { get; set; }
    }

    public class UpdatePackageDetailCommandsHandler : IRequestHandler<UpdatePackageDetailCommands, Guid>
    {
        private readonly IApplicationDbContext _context;

        public UpdatePackageDetailCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(UpdatePackageDetailCommands request, CancellationToken cancellationToken)
        {
            var package = _context.Get<AWS_BusinessObjects.Entities.Package>().Find(request.Id);

            if (package == null)
            {
                throw new NotFoundException(nameof(AWS_BusinessObjects.Entities.Package), request.Id);
            }

            package.NamePacked = request.NamePacked;
            package.Description = request.Description;
            package.PackageStatus = (AWS_BusinessObjects.Enums.PackageStatus)request.Status;

            await _context.SaveChangesAsync(cancellationToken);

            return package.Id;
        }
    }
}
