using AWS_BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Repository.Interface
{
    public interface ICategoryRepository
    {
        public List<Category> GetAll();
        public Category GetById(Guid id);
        public void Add(Category category);
        public void Update(Category category);
        public void Delete(Guid id);
    }
}
