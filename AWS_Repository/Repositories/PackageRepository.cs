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
    public class PackageRepository : IPackageRepository
    {
        private PackageDAO packageDAO = null;
        public PackageRepository()
        {
            packageDAO = new PackageDAO();
        }

        public void Add(Package package)
        => packageDAO.Add(package);

        public void Delete(Guid id)
        => packageDAO.Delete(id);

        public List<Package> GetAll()
        => packageDAO.GetAll();

        public Package GetById(Guid id)
        => packageDAO.GetById(id);

        public void Update(Package package)
        => packageDAO.Update(package);
    }
}
