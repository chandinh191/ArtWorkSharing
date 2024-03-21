using AWS_BusinessObjects.Entities;
using AWS_Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Services.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryService categoryRepository;
        public CategoryService(ICategoryService categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public void Add(Category category) => categoryRepository.Add(category);
        public void Delete(Guid id) => categoryRepository.Delete(id);
        public List<Category> GetAll() => categoryRepository.GetAll();

        public Category GetById(Guid id) => categoryRepository.GetById(id);

        public void Update(Category category) => categoryRepository.Update(category);
    }
}
