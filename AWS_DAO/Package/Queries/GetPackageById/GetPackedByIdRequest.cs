using AutoMapper;
using AWS_DAO.Common.Exceptions;
using AWS_BusinessObjects.Common.Interfaces;
using AWS_DAO.Order.Queries.GetOrderById;
using AWS_DAO.Order.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AWS_DAO.Package.Queries.GetPackageById
{
    public class GetPackedByIdRequest : IRequest<PackageModel>
    {
        public Guid Id { get; set; }
    }

    public class GetPackedByIdRequestHandler : IRequestHandler<GetPackedByIdRequest, PackageModel>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetPackedByIdRequestHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<PackageModel> Handle(GetPackedByIdRequest request, CancellationToken cancellationToken)
        {
            var order = _context.Get<AWS_BusinessObjects.Entities.Package>()
                .Include(x => x.PackageDetails)
                .AsNoTracking().FirstOrDefault(x => x.Id == request.Id);

            if (order == null)
            {
                throw new NotFoundException(nameof(AWS_BusinessObjects.Entities.Package), request.Id);
            }

            var map = _mapper.Map<PackageModel>(order);

            return Task.FromResult(map);
        }
    }
}
