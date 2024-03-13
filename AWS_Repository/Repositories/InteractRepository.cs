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
        private InteractDAO interactDAO = null;
        public InteractRepository()
        {
            interactDAO = new InteractDAO();
        }

        public void Add(Interact interact)
        => interactDAO.Add(interact);

        public void Delete(Guid id)
        => interactDAO.Delete(id);

        public List<Interact> GetAll()
        => interactDAO.GetAll();

        public Interact GetById(Guid id)
        => interactDAO.GetById(id);

        public void Update(Interact interact)
        => interactDAO.Update(interact);    
    }
}
