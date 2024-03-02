using AutoMapper;
using AWS_DAO.Common.Exceptions;
using AWS_DAO.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.Interact.Queries.GetInteractById
{
    public class GetInteractByIdRequest : IRequest<InteractModel>
    {
        public Guid Id { get; set; }
    }

    public class GetInteractByIdRequestHandler : IRequestHandler<GetInteractByIdRequest, InteractModel>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        
        public GetInteractByIdRequestHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<InteractModel> Handle(GetInteractByIdRequest request, System.Threading.CancellationToken cancellationToken)
        {
            var interact = _context.Get<AWS_BusinessObjects.Entities.Interact>()
                .Where(x => x.Id == request.Id).FirstOrDefault();

            if (interact == null)
            {
                throw new NotFoundException(nameof(AWS_BusinessObjects.Entities.Interact), request.Id); 
            }

            var map = _mapper.Map<InteractModel>(interact);
            return Task.FromResult(map);
        }
    }
}
