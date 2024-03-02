using AWS_DAO.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.PackageDetail.Commands.CreatePackageDetail
{
    public class CreatePackageDetailCommands : IRequest<Guid>
    {
        public string? NamePacked { get; set; }
        public string? Description { get; set; }
        public int Status { get; set; }
    }

    public class CreatePackageDetailCommandsHandler : IRequestHandler<CreatePackageDetailCommands, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreatePackageDetailCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreatePackageDetailCommands request, CancellationToken cancellationToken)
        {
            var package = new AWS_BusinessObjects.Entities.Package
            {
                NamePacked = request.NamePacked,
                Description = request.Description,
                PackageStatus = (AWS_BusinessObjects.Enums.PackageStatus)request.Status
            };

            _context.Get<AWS_BusinessObjects.Entities.Package>().Add(package);
            await _context.SaveChangesAsync(cancellationToken);

            return package.Id;
        }
    }
}
