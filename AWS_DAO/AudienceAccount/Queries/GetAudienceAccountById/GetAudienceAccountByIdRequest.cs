using AutoMapper;
using AWS_BusinessObjects.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.AudienceAccount.Queries.GetAudienceAccountById
{
    public class GetAudienceAccountByIdRequest : IRequest<AudienceAccountModel>
    {
        public Guid Id { get; set; }
    }
    
    public class GetAudienceAccountByIdRequestHandler : IRequestHandler<GetAudienceAccountByIdRequest, AudienceAccountModel>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        
        public GetAudienceAccountByIdRequestHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<AudienceAccountModel> Handle(GetAudienceAccountByIdRequest request, System.Threading.CancellationToken cancellationToken)
        {
            var audienceAccount = _context.Get<AWS_BusinessObjects.Entities.AudienceAccount>()
                .Include(x => x.ApplicationUser)
                .Where(x => x.Id == request.Id).AsNoTracking().FirstOrDefault();

            var map = _mapper.Map<AudienceAccountModel>(audienceAccount);
            return Task.FromResult(map);
        }
    }
}
