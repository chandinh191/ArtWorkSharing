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
    public class PackageService : IPackageService
    {
        private readonly IPackageRepository packageRepository;
        public PackageService(IPackageRepository packageRepository)
        {
            this.packageRepository = packageRepository;
        }

        public void Add(Package package)
        => packageRepository.Add(package);

        public void Delete(Guid id)
        => packageRepository.Delete(id);

        public List<Package> GetAll()
        => packageRepository.GetAll();

        public Package GetById(Guid id)
        => packageRepository.GetById(id);

        public void Update(Package package)
        => packageRepository.Update(package);
    }
}
