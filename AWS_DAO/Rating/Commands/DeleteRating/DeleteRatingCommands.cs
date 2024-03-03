using AWS_DAO.Common.Exceptions;
using AWS_BusinessObjects.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.Rating.Commands.DeleteRating
{
    public class DeleteRatingCommands : IRequest<bool>
    {
        public Guid Id { get; set; }
    }

    public class DeleteRatingCommandsHandler : IRequestHandler<DeleteRatingCommands, bool>
    {
        private readonly IApplicationDbContext _context;

        public DeleteRatingCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteRatingCommands request, CancellationToken cancellationToken)
        {
            var entity = _context.Get<AWS_BusinessObjects.Entities.Rating>().FirstOrDefault(x => x.Id == request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(AWS_BusinessObjects.Entities.Rating), request.Id);
            }

            entity.IsDeleted = true;

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
