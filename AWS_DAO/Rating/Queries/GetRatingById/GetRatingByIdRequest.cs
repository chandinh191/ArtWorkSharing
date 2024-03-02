using AutoMapper;
using AWS_DAO.Common.Exceptions;
using AWS_DAO.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.Rating.Queries.GetRatingById
{
    public class GetRatingByIdRequest : IRequest<RatingModel>
    {
        public Guid Id { get; set; }
    }

    public class GetRatingByIdRequestHandler : IRequestHandler<GetRatingByIdRequest, RatingModel>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetRatingByIdRequestHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<RatingModel> Handle(GetRatingByIdRequest request, CancellationToken cancellationToken)
        {
            var rating = _context.Get<AWS_BusinessObjects.Entities.Rating>().AsNoTracking().FirstOrDefault(x => x.Id == request.Id);

            if (rating == null)
            {
                throw new NotFoundException(nameof(AWS_BusinessObjects.Entities.Rating), request.Id);
            }

            var map = _mapper.Map<RatingModel>(rating);

            return Task.FromResult(map);
        }
    }
}
