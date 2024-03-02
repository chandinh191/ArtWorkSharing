using AWS_DAO.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.Interact.Commands.CreateInteract
{
    public class CreateInteractCommands : IRequest<Guid>
    {
        public Guid ArtWorkID { get; set; }
        public Guid UserAccountId { get; set; }
        public string? Comment { get; set; }
        public bool IsLike { get; set; }
        public DateTime Date { get; set; }
    }

    public class CreateInteractCommandsHandler : IRequestHandler<CreateInteractCommands, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateInteractCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<Guid> Handle(CreateInteractCommands request, CancellationToken cancellationToken)
        {
            var interact = new AWS_BusinessObjects.Entities.Interact
            {
                ArtWorkID = request.ArtWorkID,
                UserAccountId = request.UserAccountId,
                Comment = request.Comment,
                IsLike = request.IsLike,
                Date = request.Date
            };

            _context.Get<AWS_BusinessObjects.Entities.Interact>().Add(interact);
            await _context.SaveChangesAsync(cancellationToken);

            return interact.Id;
        }
    }
}
