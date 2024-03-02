using AutoMapper;
using AWS_DAO.Common.Exceptions;
using AWS_DAO.Common.Interfaces;
using AWS_DAO.Package.Queries.GetPackageById;
using AWS_DAO.Package.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AWS_DAO.PackageDetail.Queries.GetPackageDetailsById
{
    public class GetPackageDetailByIdRequest : IRequest<PackageDetailModel>
    {
        public Guid Id { get; set; }    
    }

    public class GetPackageDetailByIdRequestHandler : IRequestHandler<GetPackageDetailByIdRequest, PackageDetailModel>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetPackageDetailByIdRequestHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<PackageDetailModel> Handle(GetPackageDetailByIdRequest request, CancellationToken cancellationToken)
        {
            var order = _context.Get<AWS_BusinessObjects.Entities.PackageDetail>()
                .AsNoTracking().FirstOrDefault(x => x.Id == request.Id);

            if (order == null)
            {
                throw new NotFoundException(nameof(AWS_BusinessObjects.Entities.PackageDetail), request.Id);
            }

            var map = _mapper.Map<PackageDetailModel>(order);

            return Task.FromResult(map);
        }
    }
}
