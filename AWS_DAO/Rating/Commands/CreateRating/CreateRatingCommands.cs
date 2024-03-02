using AWS_DAO.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.Rating.Commands.CreateRating
{
    public class CreateRatingCommands : IRequest<Guid>
    {
        public Guid OrderID { get; set; }
        public string? Description { get; set; }
        public float Point { get; set; }
    }

    public class CreateRatingCommandsHandler : IRequestHandler<CreateRatingCommands, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateRatingCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateRatingCommands request, CancellationToken cancellationToken)
        {
            var entity = new AWS_BusinessObjects.Entities.Rating
            {
                OrderID = request.OrderID,
                Description = request.Description,
                Point = request.Point
            };

            _context.Get<AWS_BusinessObjects.Entities.Rating>().Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
