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

namespace AWS_DAO.PackageDetail.Queries.GetAllPackageDetail
{
    public class GetAllPackageDetailRequest : IRequest<PaginatedList<PackageDetailModel>>
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }

    public class GetAllPackageDetailRequestHandler : IRequestHandler<GetAllPackageDetailRequest, PaginatedList<PackageDetailModel>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetAllPackageDetailRequestHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PaginatedList<PackageDetailModel>> Handle(GetAllPackageDetailRequest request, CancellationToken cancellationToken)
        {
            var packageDetails = _context.Get<AWS_BusinessObjects.Entities.PackageDetail>()
                .OrderBy(x => x.StartDate)
                .AsNoTracking();

            var map = _mapper.ProjectTo<PackageDetailModel>(packageDetails);

            var page = await PaginatedList<PackageDetailModel>.CreateAsync(map, request.PageIndex, request.PageSize);

            return page;
        }
    }
}
