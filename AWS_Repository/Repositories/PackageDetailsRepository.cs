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
    public class PackageDetailsRepository : IPackageDetailsRepository
    {
        private PackageDetailsDAO packageDetailsDAO = null;
        public PackageDetailsRepository(IApplicationDbContext context)
        {
            packageDetailsDAO = new PackageDetailsDAO(context);
        }

        public void Add(PackageDetail packageDetails)
        => packageDetailsDAO.Add(packageDetails);

        public void Delete(Guid id)
        => packageDetailsDAO.Delete(id);

        public List<PackageDetail> GetAll()
        => packageDetailsDAO.GetAll();

        public PackageDetail GetById(Guid id)
        => packageDetailsDAO.GetById(id);

        public void Update(PackageDetail packageDetails)
        => packageDetailsDAO.Update(packageDetails);
    }
}
