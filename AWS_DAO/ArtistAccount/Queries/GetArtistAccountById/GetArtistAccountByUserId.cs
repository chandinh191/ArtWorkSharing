using AutoMapper;
using AWS_BusinessObjects.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.ArtistAccount.Queries.GetArtistAccountById
{
    public class GetArtistAccountByUserId : IRequest<ArtistAccountModel>
    {
        public Guid Id { get; set; }
        public string UserAccountId { get; set; }
    }

    public class GetArtistAccountByUserIdHandler : IRequestHandler<GetArtistAccountByUserId, ArtistAccountModel>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        
        public GetArtistAccountByUserIdHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<ArtistAccountModel> Handle(GetArtistAccountByUserId request, System.Threading.CancellationToken cancellationToken)
        {
            var artistAccount = _context.Get<AWS_BusinessObjects.Entities.ArtistAccount>()
                .Include(x => x.ApplicationUser)
                .Where(x => x.UserAccountId == request.UserAccountId)
                .Select(x => new ArtistAccountModel
                {
                    Id = x.Id,
                    UserAccountId = x.UserAccountId,
                    ApplicationUser = x.ApplicationUser
                }).AsNoTracking().FirstOrDefault();

            var map = _mapper.Map<ArtistAccountModel>(artistAccount);
            return Task.FromResult(map);
        }
    }
}
