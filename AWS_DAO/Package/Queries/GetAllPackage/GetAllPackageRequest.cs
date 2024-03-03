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

namespace AWS_DAO.Package.Queries.GetAllPackage
{
    public class GetAllPackageRequest : IRequest<PaginatedList<PackageModel>>
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }

    public class GetAllPackageRequestHandler : IRequestHandler<GetAllPackageRequest, PaginatedList<PackageModel>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetAllPackageRequestHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PaginatedList<PackageModel>> Handle(GetAllPackageRequest request, CancellationToken cancellationToken)
        {
            var packages = _context.Get<AWS_BusinessObjects.Entities.Package>()
                .Include(x => x.PackageDetails)
                .OrderBy(x => x.NamePacked)
                .AsNoTracking();

            var map = _mapper.ProjectTo<PackageModel>(packages);

            var page = await PaginatedList<PackageModel>.CreateAsync(map, request.PageIndex, request.PageSize);

            return page;
        }
    }
}
