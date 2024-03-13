using AWS_BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Repository.Interface
{
    public interface IInteractRepository
    {
        public List<Interact> GetAll();
        public Interact GetById(Guid id);
        public void Add(Interact interact);
        public void Update(Interact interact);
        public void Delete(Guid id);
    }
}
