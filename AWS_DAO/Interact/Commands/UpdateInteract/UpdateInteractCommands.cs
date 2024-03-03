using AWS_DAO.Common.Exceptions;
using AWS_BusinessObjects.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.Interact.Commands.UpdateInteract
{
    public class UpdateInteractCommands : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public Guid ArtWorkID { get; set; }
        public Guid UserAccountId { get; set; }
        public string? Comment { get; set; }
        public bool IsLike { get; set; }
        public DateTime Date { get; set; }
    }

    public class UpdateInteractCommandsHandler : IRequestHandler<UpdateInteractCommands, Guid>
    {
        private readonly IApplicationDbContext _context;

        public UpdateInteractCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<Guid> Handle(UpdateInteractCommands request, CancellationToken cancellationToken)
        {
            var interact = _context.Get<AWS_BusinessObjects.Entities.Interact>().FirstOrDefault(x => x.Id == request.Id);

            if (interact == null)
            {
                throw new NotFoundException(nameof(AWS_BusinessObjects.Entities.Interact), request.Id);
            }

            interact.ArtWorkID = request.ArtWorkID;
            interact.UserAccountId = request.UserAccountId;
            interact.Comment = request.Comment;
            interact.IsLike = request.IsLike;
            interact.Date = request.Date;

            await _context.SaveChangesAsync(cancellationToken);

            return interact.Id;
        }
    }
}
