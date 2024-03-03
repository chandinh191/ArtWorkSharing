using AWS_BusinessObjects.Enums;
using AWS_BusinessObjects.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.Package.Commands.CreatePackage
{
    public class CreatePackageCommands : IRequest<Guid>
    {
        public string? NamePacked { get; set; }
        public string? Description { get; set; }
        public PackageStatus PackageStatus { get; set; }
    }

    public class CreatePackageCommandsHandler : IRequestHandler<CreatePackageCommands, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreatePackageCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreatePackageCommands request, CancellationToken cancellationToken)
        {
            var package = new AWS_BusinessObjects.Entities.Package
            {
                NamePacked = request.NamePacked,
                Description = request.Description,
                PackageStatus = request.PackageStatus
            };

            _context.Get<AWS_BusinessObjects.Entities.Package>().Add(package);
            await _context.SaveChangesAsync(cancellationToken);

            return package.Id;
        }
    }
}
