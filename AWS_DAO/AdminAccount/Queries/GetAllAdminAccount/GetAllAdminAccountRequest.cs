using AutoMapper;
using AWS_BusinessObjects.Entities;
using AWS_DAO.Common.Interfaces;
using AWS_DAO.Common.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AWS_DAO.AdminAccount.Queries;

namespace AWS_DAO.AdminAccount.Queries.GetAllAdminAccount
{
    public class GetAllAdminAccountRequest : IRequest<PaginatedList<AccountModel>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }

    public class GetAllAdminAccountRequestHandler : IRequestHandler<GetAllAdminAccountRequest, PaginatedList<AdminAccount.Queries.AccountModel>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetAllAdminAccountRequestHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PaginatedList<AdminAccount.Queries.AccountModel>> Handle(GetAllAdminAccountRequest request, System.Threading.CancellationToken cancellationToken)
        {
            var adminAccounts = _context.Get<AWS_BusinessObjects.Entities.AdminAccount>()
                .Include(x => x.ApplicationUser)
                .OrderBy(x => x.Created)
                .Select(x => new AccountModel
                {
                    Id = x.Id,
                    UserAccountId = x.UserAccountId,
                    ApplicationUser = x.ApplicationUser
                }).AsNoTracking();

            var map = _mapper.ProjectTo<AdminAccount.Queries.AccountModel>(adminAccounts);

            var page = await PaginatedList<AdminAccount.Queries.AccountModel>.CreateAsync(map, request.PageNumber, request.PageSize);
            return page;
        }
    }
}
