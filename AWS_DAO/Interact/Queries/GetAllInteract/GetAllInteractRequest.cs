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

namespace AWS_DAO.Interact.Queries.GetAllInteract
{
    public class GetAllInteractRequest : IRequest<PaginatedList<InteractModel>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }

    public class GetAllInteractRequestHandler : IRequestHandler<GetAllInteractRequest, PaginatedList<InteractModel>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        
        public GetAllInteractRequestHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PaginatedList<InteractModel>> Handle(GetAllInteractRequest request, System.Threading.CancellationToken cancellationToken)
        {
            var interacts = _context.Get<AWS_BusinessObjects.Entities.Interact>()
                .OrderBy(x => x.Created).AsNoTracking();

            var map = _mapper.ProjectTo<InteractModel>(interacts);

            var page = await PaginatedList<InteractModel>.CreateAsync(map, request.PageNumber, request.PageSize);
            return page;
        }
    }
}
