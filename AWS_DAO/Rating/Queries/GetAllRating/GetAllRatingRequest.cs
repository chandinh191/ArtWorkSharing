using AutoMapper;
using AWS_BusinessObjects.Common.Interfaces;
using AWS_BusinessObjects.Common.Models;
using AWS_DAO.PaymentMethod.Queries.GetAllPaymentMethod;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.Rating.Queries.GetAllRating
{
    public class GetAllRatingRequest : IRequest<PaginatedList<RatingModel>>
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }

    public class GetAllRatingRequestHandler : IRequestHandler<GetAllRatingRequest, PaginatedList<RatingModel>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetAllRatingRequestHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PaginatedList<RatingModel>> Handle(GetAllRatingRequest request, CancellationToken cancellationToken)
        {
            var ratings = _context.Get<AWS_BusinessObjects.Entities.Rating>()
                .OrderBy(x => x.OrderID)
                .AsNoTracking();

            var map = _mapper.ProjectTo<RatingModel>(ratings);

            var page = await PaginatedList<RatingModel>.CreateAsync(map, request.PageIndex, request.PageSize);

            return page;
        }
    }
}
