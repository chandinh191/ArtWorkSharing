using AWS_BusinessObjects.Entities;
using AWS_Repository.Interface;
using AWS_Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Services.Services
{
    public class InteractService : IInteractService
    {
        private readonly IInteractRepository interactRepository;
        public InteractService(IInteractRepository interactRepository)
        {
            this.interactRepository = interactRepository;
        }

        public void Add(Interact interact)
        => interactRepository.Add(interact);

        public void Delete(Guid id)
        => interactRepository.Delete(id);

        public List<Interact> GetAll()
        => interactRepository.GetAll();

        public Interact GetById(Guid id)
        => interactRepository.GetById(id);

        public void Update(Interact interact)
        => interactRepository.Update(interact);
    }
}
