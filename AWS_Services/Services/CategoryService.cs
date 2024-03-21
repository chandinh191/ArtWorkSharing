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
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void Add(Category category) => _categoryRepository.Add(category);
        public void Delete(Guid id) => _categoryRepository.Delete(id);
        public List<Category> GetAll() => _categoryRepository.GetAll();

        public Category GetById(Guid id) => _categoryRepository.GetById(id);

        public void Update(Category category) => _categoryRepository.Update(category);
    }
}
