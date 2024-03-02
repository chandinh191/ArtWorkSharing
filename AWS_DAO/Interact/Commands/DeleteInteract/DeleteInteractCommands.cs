using AWS_DAO.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.Interact.Commands.DeleteInteract
{
    public class DeleteInteractCommands : IRequest<bool>
    {
        public Guid Id { get; set; }
    }

    public class DeleteInteractCommandsHandler : IRequestHandler<DeleteInteractCommands, bool>
    {
        private readonly IApplicationDbContext _context;

        public DeleteInteractCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<bool> Handle(DeleteInteractCommands request, CancellationToken cancellationToken)
        {
            var interact = _context.Get<AWS_BusinessObjects.Entities.Interact>().FirstOrDefault(x => x.Id == request.Id);

            if (interact == null)
            {
                return false;
            }
            interact.IsDeleted = true;  

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
