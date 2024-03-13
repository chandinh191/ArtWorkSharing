using AWS_BusinessObjects.Common.Interfaces;
using AWS_BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO
{
    public class PackageDAO
    {
        private readonly IApplicationDbContext _context;
        public PackageDAO(IApplicationDbContext context)
        {
            _context = context;
        }

        public PackageDAO()
        {
        }

        // get all Package
        public List<Package> GetAll()
        {
            try
            {
                List<Package> packages
                    = (List<Package>)_context.Get<Package>().ToList();
                return packages;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // get Package by id
        public Package GetById(Guid id)
        {
            try
            {
                return _context.Get<Package>().Where(o => o.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // add Package
        public void Add(Package package)
        {
            try
            {
                _context.Get<Package>().Add(package);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // update Package
        public void Update(Package package)
        {
            try
            {
                _context.Get<Package>().Update(package);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // delete Package, isDeleted = true
        public void Delete(Guid id)
        {
            try
            {
                var package = _context.Get<Package>().Where(o => o.Id == id).FirstOrDefault();
                package.IsDeleted = true;
                _context.Get<Package>().Update(package);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
