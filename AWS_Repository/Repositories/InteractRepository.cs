using AWS_BusinessObjects.Common.Interfaces;
using AWS_BusinessObjects.Entities;
using AWS_DAO;
using AWS_Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Repository.Repositories
{
    public class InteractRepository : IInteractRepository
    {
        private readonly InteractDAO _interactDAO;
        public InteractRepository(InteractDAO interactDAO)
        {
            _interactDAO = interactDAO;
        }

        public void Add(Interact interact)
        => _interactDAO.Add(interact);

        public void Delete(Guid id)
        => _interactDAO.Delete(id);

        public List<Interact> GetAll()
        => _interactDAO.GetAll();

        public Interact GetById(Guid id)
        => _interactDAO.GetById(id);

        public void Update(Interact interact)
        => _interactDAO.Update(interact);    
    }
}
