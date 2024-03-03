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

namespace AWS_DAO.AudienceAccount.Queries.GetAllAudienceAccount
{
    public class GetAllAudienceAccountRequest : IRequest<PaginatedList<AudienceAccountModel>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }

    public class GetAllAudienceAccountRequestHandler : IRequestHandler<GetAllAudienceAccountRequest, PaginatedList<AudienceAccountModel>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetAllAudienceAccountRequestHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PaginatedList<AudienceAccountModel>> Handle(GetAllAudienceAccountRequest request, System.Threading.CancellationToken cancellationToken)
        {
            var audienceAccounts = _context.Get<AWS_BusinessObjects.Entities.AudienceAccount>()
                .Include(x => x.ApplicationUser)
                .OrderBy(x => x.Created).AsNoTracking();

            var map = _mapper.ProjectTo<AudienceAccountModel>(audienceAccounts);

            var page = await PaginatedList<AudienceAccountModel>.CreateAsync(map, request.PageNumber, request.PageSize);
            return page;
        }
    }
}
