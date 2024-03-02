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

namespace AWS_DAO.ArtWork.Queries.GetAllArtWork
{
    public class GetAllArtWorkRequest : IRequest<PaginatedList<ArtWorkModel>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }

    public class GetAllArtWorkRequestHandler : IRequestHandler<GetAllArtWorkRequest, PaginatedList<ArtWorkModel>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetAllArtWorkRequestHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PaginatedList<ArtWorkModel>> Handle(GetAllArtWorkRequest request, System.Threading.CancellationToken cancellationToken)
        {
            var artWorks = _context.Get<AWS_BusinessObjects.Entities.ArtWork>()
                .Include(x => x.ApplicationUser)
                .Include(x => x.Orders)
                .Include(x => x.Interacts)
                .OrderBy(x => x.Created).AsNoTracking();

            var map = _mapper.ProjectTo<ArtWorkModel>(artWorks);

            var page = await PaginatedList<ArtWorkModel>.CreateAsync(map, request.PageNumber, request.PageSize);
            return page;
        }
    }
}
