using AWS_BusinessObjects.Enums;
using AWS_DAO.Common.Exceptions;
using AWS_BusinessObjects.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.ArtWork.Commands.UpdateArtWork
{
    public class UpdateArtWorkCommands : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string? UserAccountId { get; set; }
        public string? UserOwnerId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public float Price { get; set; }
        public string? ImageUrl { get; set; }
        public ArtWorkStatus ArtWorkStatus { get; set; }
        public bool IsSold { get; set; }
        public bool IsPreOrder { get; set; }
    }

    public class UpdateArtWorkCommandsHandler : IRequestHandler<UpdateArtWorkCommands, Guid>
    {
        private readonly IApplicationDbContext _context;

        public UpdateArtWorkCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(UpdateArtWorkCommands request, System.Threading.CancellationToken cancellationToken)
        {
            var artWork = _context.Get<AWS_BusinessObjects.Entities.ArtWork>().Where(x => x.Id == request.Id).FirstOrDefault();

            if (artWork == null)
            {
                throw new NotFoundException(nameof(AWS_BusinessObjects.Entities.ArtWork), request.Id);
            }

            artWork.UserAccountId = request.UserAccountId;
            artWork.UserOwnerId = request.UserOwnerId;
            artWork.Name = request.Name;
            artWork.Description = request.Description;
            artWork.Price = request.Price;
            artWork.ImageUrl = request.ImageUrl;
            artWork.ArtWorkStatus = request.ArtWorkStatus;
            artWork.IsSold = request.IsSold;
            artWork.IsPreOrder = request.IsPreOrder;

            await _context.SaveChangesAsync(cancellationToken);

            return artWork.Id;
        }
    }
}
