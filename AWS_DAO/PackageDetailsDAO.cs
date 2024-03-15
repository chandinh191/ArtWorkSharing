using AWS_BusinessObjects.Common.Interfaces;
using AWS_BusinessObjects.Entities;
using AWS_DAO.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO
{
    public class PackageDetailsDAO
    {
        private readonly IApplicationDbContext _context;
        public PackageDetailsDAO(IApplicationDbContext context)
        {
            _context = context;
        }


        // get all PackageDetails
        public List<PackageDetail> GetAll()
        {
            try
            {
                List<PackageDetail> packageDetails
                    = (List<PackageDetail>)_context.Get<PackageDetail>().ToList();
                return packageDetails;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // get PackageDetails by id
        public PackageDetail GetById(Guid id)
        {
            try
            {
                return _context.Get<PackageDetail>().Where(o => o.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // add PackageDetails
        public void Add(PackageDetail packageDetail)
        {
            try
            {
                _context.Get<PackageDetail>().Add(packageDetail);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // update PackageDetails
        public void Update(PackageDetail packageDetail)
        {
            try
            {
                var PackageDetail = _context.Get<PackageDetail>().FirstOrDefault(x => x.Id == packageDetail.Id);
                if (PackageDetail == null)
                {
                    throw new NotFoundException();
                }
                PackageDetail.StartDate = DateTime.Now;
                PackageDetail.EndDate = DateTime.Now;
                PackageDetail.PackageID = packageDetail.PackageID;
                PackageDetail.UserAccountId = packageDetail.UserAccountId;
                PackageDetail.PaymentMethodID = packageDetail.PaymentMethodID;
                PackageDetail.LastModified = DateTime.Now;


                _context.Get<PackageDetail>().Update(PackageDetail);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // delete PackageDetails, isDelete = true
        public void Delete(Guid id)
        {
            try
            {
                var packageDetail = _context.Get<PackageDetail>().Where(o => o.Id == id).FirstOrDefault();
                packageDetail.IsDeleted = true;
                _context.Get<PackageDetail>().Update(packageDetail);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
