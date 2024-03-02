using AWS_DAO.Common.Exceptions;
using AWS_DAO.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.Report.Commands.UpdateReport
{
    public class UpdateReportCommands : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public Guid UserAccountID { get; set; }
        public Guid UserAccountIDReport { get; set; }
        public string? Description { get; set; }
    }

    public class UpdateReportCommandsHandler : IRequestHandler<UpdateReportCommands, Guid>
    {
        private readonly IApplicationDbContext _context;

        public UpdateReportCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(UpdateReportCommands request, CancellationToken cancellationToken)
        {
            var entity = _context.Get<AWS_BusinessObjects.Entities.Report>().Find(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(AWS_BusinessObjects.Entities.Report), request.Id);
            }

            entity.UserAccountID = request.UserAccountID;
            entity.UserAccountIDReport = request.UserAccountIDReport;
            entity.Description = request.Description;

            _context.Get<AWS_BusinessObjects.Entities.Report>().Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
