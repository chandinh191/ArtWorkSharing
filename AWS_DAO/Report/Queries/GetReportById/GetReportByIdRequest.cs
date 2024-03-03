using AutoMapper;
using AWS_DAO.Common.Exceptions;
using AWS_BusinessObjects.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.Report.Queries.GetReportById
{
    public class GetReportByIdRequest : IRequest<ReportModel>
    {
        public Guid Id { get; set; }
    }

    public class GetReportByIdRequestHandler : IRequestHandler<GetReportByIdRequest, ReportModel>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetReportByIdRequestHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<ReportModel> Handle(GetReportByIdRequest request, CancellationToken cancellationToken)
        {
            var report = _context.Get<AWS_BusinessObjects.Entities.Report>().AsNoTracking().FirstOrDefault(x => x.Id == request.Id);

            if (report == null)
            {
                throw new NotFoundException(nameof(AWS_BusinessObjects.Entities.Report), request.Id);
            }

            var map = _mapper.Map<ReportModel>(report);

            return Task.FromResult(map);
        }
    }
}
