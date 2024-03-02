using AWS_DAO.Common.Exceptions;
using AWS_DAO.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.Report.Commands.DeleteReport
{
    public class DeleteReportCommands : IRequest<bool>
    {
        public Guid Id { get; set; }
    }

    public class DeleteReportCommandsHandler : IRequestHandler<DeleteReportCommands, bool>
    {
        private readonly IApplicationDbContext _context;

        public DeleteReportCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteReportCommands request, CancellationToken cancellationToken)
        {
            var entity = _context.Get<AWS_BusinessObjects.Entities.Report>().FirstOrDefault(x => x.Id == request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(AWS_BusinessObjects.Entities.Report), request.Id);
            }
            entity.IsDeleted = true;

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
