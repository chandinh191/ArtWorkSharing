using AWS_DAO.Common.Exceptions;
using AWS_DAO.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.Rating.Commands.UpdateRating
{
    public class UpdateRatingCommands : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public Guid OrderID { get; set; }
        public string? Description { get; set; }
        public float Point { get; set; }
    }

    public class UpdateRatingCommandsHandler : IRequestHandler<UpdateRatingCommands, Guid>
    {
        private readonly IApplicationDbContext _context;

        public UpdateRatingCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(UpdateRatingCommands request, CancellationToken cancellationToken)
        {
            var entity = _context.Get<AWS_BusinessObjects.Entities.Rating>().FirstOrDefault(x => x.Id == request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(AWS_BusinessObjects.Entities.Rating), request.Id);
            }

            entity.OrderID = request.OrderID;
            entity.Description = request.Description;
            entity.Point = request.Point;

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
