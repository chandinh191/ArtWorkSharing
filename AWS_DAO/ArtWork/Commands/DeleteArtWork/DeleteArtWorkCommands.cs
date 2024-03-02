using AWS_DAO.Common.Exceptions;
using AWS_DAO.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.ArtWork.Commands.DeleteArtWork
{
    public class DeleteArtWorkCommands : IRequest<bool>
    {
        public Guid Id { get; set; }
    }

    public class DeleteArtWorkCommandsHandler : IRequestHandler<DeleteArtWorkCommands, bool>
    {
        private readonly IApplicationDbContext _context;

        public DeleteArtWorkCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteArtWorkCommands request, System.Threading.CancellationToken cancellationToken)
        {
            var artWork = _context.Get<AWS_BusinessObjects.Entities.ArtWork>().Where(x => x.Id == request.Id).FirstOrDefault();

            if (artWork== null)
            {
                throw new NotFoundException(nameof(AWS_BusinessObjects.Entities.ArtWork), request.Id);
            }
            artWork.IsDeleted = true;

            await _context.SaveChangesAsync(cancellationToken);

            return false;
        }
    }
}
