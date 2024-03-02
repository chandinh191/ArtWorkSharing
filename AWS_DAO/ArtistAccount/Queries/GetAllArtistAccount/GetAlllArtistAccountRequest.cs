using AutoMapper;
using AWS_DAO.Common.Interfaces;
using AWS_DAO.Common.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.ArtistAccount.Queries.GetAllArtistAccount
{
    public class GetAlllArtistAccountRequest : IRequest<PaginatedList<ArtistAccountModel>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }

    public class GetAlllArtistAccountRequestHandler : IRequestHandler<GetAlllArtistAccountRequest, PaginatedList<ArtistAccountModel>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetAlllArtistAccountRequestHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PaginatedList<ArtistAccountModel>> Handle(GetAlllArtistAccountRequest request, System.Threading.CancellationToken cancellationToken)
        {
            var artistAccounts = _context.Get<AWS_BusinessObjects.Entities.ArtistAccount>()
                .Include(x => x.ApplicationUser)
                .OrderBy(x => x.Created)
                .Select(x => new ArtistAccountModel
                {
                    Id = x.Id,
                    UserAccountId = x.UserAccountId,
                    ApplicationUser = x.ApplicationUser
                }).AsNoTracking();

            var map = _mapper.ProjectTo<ArtistAccountModel>(artistAccounts);

            var page = await PaginatedList<ArtistAccountModel>.CreateAsync(map, request.PageNumber, request.PageSize);
            return page;
        }
    }
}
