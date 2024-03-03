using AWS_BusinessObjects.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.Report.Commands.CreateReport
{
    public class CreateReportCommands : IRequest<Guid>
    {
        public Guid UserAccountID { get; set; }
        public Guid UserAccountIDReport { get; set; }
        public string? Description { get; set; }
    }

    public class CreateReportCommandsHandler : IRequestHandler<CreateReportCommands, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateReportCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateReportCommands request, CancellationToken cancellationToken)
        {
            var entity = new AWS_BusinessObjects.Entities.Report
            {
                UserAccountID = request.UserAccountID,
                UserAccountIDReport = request.UserAccountIDReport,
                Description = request.Description
            };

            _context.Get<AWS_BusinessObjects.Entities.Report>().Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
