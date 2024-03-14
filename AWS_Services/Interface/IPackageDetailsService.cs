using AWS_BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Services.Interface
{
    public interface IPackageDetailsService
    {
        public List<PackageDetail> GetAll();
        public PackageDetail GetById(Guid id);
        public void Add(PackageDetail packageDetails);
        public void Update(PackageDetail packageDetails);
        public void Delete(Guid id);
    }
}
