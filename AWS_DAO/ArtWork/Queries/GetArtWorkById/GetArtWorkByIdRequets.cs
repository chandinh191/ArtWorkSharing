using AutoMapper;
using AWS_BusinessObjects.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.ArtWork.Queries.GetArtWorkById
{
    public class GetArtWorkByIdRequets : IRequest<ArtWorkModel>
    {
        public Guid Id { get; set; }
    }
    
    public class GetArtWorkByIdRequetsHandler : IRequestHandler<GetArtWorkByIdRequets, ArtWorkModel>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        
        public GetArtWorkByIdRequetsHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<ArtWorkModel> Handle(GetArtWorkByIdRequets request, System.Threading.CancellationToken cancellationToken)
        {
            var artWork = _context.Get<AWS_BusinessObjects.Entities.ArtWork>()
                .Include(x => x.ApplicationUser)
                .Include(x => x.Orders)
                .Include(x => x.Interacts)
                .Where(x => x.Id == request.Id).AsNoTracking().FirstOrDefault();

            var map = _mapper.Map<ArtWorkModel>(artWork);
            return Task.FromResult(map);
        }
    }
}
