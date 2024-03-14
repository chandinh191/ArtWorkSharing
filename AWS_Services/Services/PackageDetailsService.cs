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
    public class PackageDetailsService : IPackageDetailsService
    { 
        private readonly IPackageDetailsRepository packageDetailsRepository;
        public PackageDetailsService(IPackageDetailsRepository packageDetailsRepository)
        {
            this.packageDetailsRepository = packageDetailsRepository;
        }

        public void Add(PackageDetail packageDetails)
        => packageDetailsRepository.Add(packageDetails);

        public void Delete(Guid id)
        => packageDetailsRepository.Delete(id);

        public List<PackageDetail> GetAll()
        => packageDetailsRepository.GetAll();

        public PackageDetail GetById(Guid id)
        => packageDetailsRepository.GetById(id);

        public void Update(PackageDetail packageDetails)
        => packageDetailsRepository.Update(packageDetails);
    }
}
