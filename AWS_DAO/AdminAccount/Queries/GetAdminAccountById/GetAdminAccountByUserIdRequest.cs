using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AWS_DAO.AdminAccount.Queries;
using AutoMapper;
using AWS_DAO.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AWS_DAO.AdminAccount.Queries.GetAdminAccountById
{
    public class GetAdminAccountByUserIdRequest : IRequest<AccountModel>
    {
        public Guid Id { get; set; }
        public string UserAccountId { get; set; }
    }

    public class GetAdminAccountByUserIdRequestHandler : IRequestHandler<GetAdminAccountByUserIdRequest, AccountModel>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetAdminAccountByUserIdRequestHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<AccountModel> Handle(GetAdminAccountByUserIdRequest request, System.Threading.CancellationToken cancellationToken)
        {
            var adminAccount = _context.Get<AWS_BusinessObjects.Entities.AdminAccount>()
                .Include(x => x.ApplicationUser)
                .Where(x => x.UserAccountId == request.UserAccountId)
                .Select(x => new AccountModel
                {
                    Id = x.Id,
                    UserAccountId = x.UserAccountId,
                    ApplicationUser = x.ApplicationUser
                }).AsNoTracking().FirstOrDefault();

            var map = _mapper.Map<AccountModel>(adminAccount);
            return Task.FromResult(map);
        }
    }
}
