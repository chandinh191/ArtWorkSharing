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
    public class AdminAccountRepository : IAdminAccountRepository
    {
        private AdminAccountDAO adminAccountDAO = null;
        public AdminAccountRepository()
        {
            adminAccountDAO = new AdminAccountDAO();
        }

        public void Add(AdminAccount adminAccount)
        => adminAccountDAO.Add(adminAccount);

        public void Delete(AdminAccount adminAccount)
        => adminAccountDAO.Delete(adminAccount);

        public List<AdminAccount> GetAll()
        => adminAccountDAO.GetAll();

        public AdminAccount GetById(Guid id)
        => adminAccountDAO.GetById(id);

        public void Update(AdminAccount adminAccount)
        => adminAccountDAO.Update(adminAccount);
    }
}
