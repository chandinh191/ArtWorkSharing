using AWS_BusinessObjects.Common.Interfaces;
using AWS_BusinessObjects.Entities;
using AWS_Repository.Interface;
using AWS_Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Services.Services
{
    public class CategoryService : ICategoryRepository
    {
        private CategoryRepository categoryRepository = null;
        public CategoryService(IApplicationDbContext context)
        {
            categoryRepository = new CategoryRepository(context);
        }
        public void Add(Category category) => categoryRepository.Add(category);


        public void Delete(Guid id) => categoryRepository.Delete(id);
        public List<Category> GetAll() => categoryRepository.GetAll();

        public Category GetById(Guid id) => categoryRepository.GetById(id);

        public void Update(Category category) => categoryRepository.Update(category);
    }
}
