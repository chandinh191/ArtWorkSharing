using AutoMapper;
using AWS_BusinessObjects.Enums;
using AWS_BusinessObjects.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.ArtWork.Commands.CreateArtWork
{
    public class CreateArtWorkCommands : IRequest<Guid>
    {
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

    public class CreateArtWorkCommandsHandler : IRequestHandler<CreateArtWorkCommands, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateArtWorkCommandsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateArtWorkCommands request, System.Threading.CancellationToken cancellationToken)
        {
            var artWork = new AWS_BusinessObjects.Entities.ArtWork
            {
                UserAccountId = request.UserAccountId,
                UserOwnerId = request.UserOwnerId,
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
                ImageUrl = request.ImageUrl,
                ArtWorkStatus = request.ArtWorkStatus,
                IsSold = request.IsSold,
                IsPreOrder = request.IsPreOrder
            };

            _context.Get<AWS_BusinessObjects.Entities.ArtWork>().Add(artWork);
            await _context.SaveChangesAsync(cancellationToken);

            return artWork.Id;
        }
    }
}
