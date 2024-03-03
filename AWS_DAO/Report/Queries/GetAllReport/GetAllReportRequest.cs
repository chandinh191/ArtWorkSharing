using AutoMapper;
using AWS_BusinessObjects.Common.Interfaces;
using AWS_BusinessObjects.Common.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.Report.Queries.GetAllReport
{
    public class GetAllReportRequest : IRequest<PaginatedList<ReportModel>>
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }

    public class GetAllReportRequestHandler : IRequestHandler<GetAllReportRequest, PaginatedList<ReportModel>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetAllReportRequestHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PaginatedList<ReportModel>> Handle(GetAllReportRequest request, CancellationToken cancellationToken)
        {
            var reports = _context.Get<AWS_BusinessObjects.Entities.Report>()
                .OrderBy(x => x.UserAccountID)
                .AsNoTracking();

            var map = _mapper.ProjectTo<ReportModel>(reports);

            var page = await PaginatedList<ReportModel>.CreateAsync(map, request.PageIndex, request.PageSize);

            return page;
        }
    }
}
