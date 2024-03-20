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
    public class CategoryRepository : ICategoryRepository
    {
        private CategoryDAO categoryDAO = null;
        public CategoryRepository(IApplicationDbContext context)
        {
            categoryDAO = new CategoryDAO(context);
        }
        public void Add(Category category)  => categoryDAO.Add(category);

        public void Delete(Guid id) => categoryDAO.Delete(id);

        public List<Category> GetAll() => categoryDAO.GetAll();
        public Category GetById(Guid id) => categoryDAO.GetById(id);

        public void Update(Category category) => categoryDAO.Update(category);
    }
}
