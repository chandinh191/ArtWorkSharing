using AWS_BusinessObjects.Common.Interfaces;
using AWS_BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO
{
    public class AdminAccountDAO
    {
        private readonly IApplicationDbContext _context;
        public AdminAccountDAO(IApplicationDbContext context)
        {
            _context = context;
        }

        // get all AdminAccount
        public List<AdminAccount> GetAll()
        {
            try
            {
                List<AdminAccount> adminAccounts
                    = (List<AdminAccount>)_context.Get<AdminAccount>().ToList();
                return adminAccounts;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // get AdminAccount by id
        public AdminAccount GetById(Guid id)
        {
            try
            {
                return _context.Get<AdminAccount>().Where(o => o.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // add AdminAccount
        public void Add(AdminAccount adminAccount)
        {
            try
            {
                _context.Get<AdminAccount>().Add(adminAccount);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // update AdminAccount
        public void Update(AdminAccount adminAccount)
        {
            try
            {
                _context.Get<AdminAccount>().Update(adminAccount);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // delete AdminAccount
        public void Delete(AdminAccount adminAccount)
        {
            try
            {
                adminAccount.IsDeleted = true;
                _context.Get<AdminAccount>().Update(adminAccount);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
