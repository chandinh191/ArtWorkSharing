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
    public class AudienceAccountRepository : IAudienceAccountRepository
    {
        private AudienceAccountDAO AudienceAccountDAO = null;
        public AudienceAccountRepository()
        {
            AudienceAccountDAO = new AudienceAccountDAO();
        }

        public void Add(AudienceAccount audienceAccount)
        => AudienceAccountDAO.Add(audienceAccount);

        public void Delete(AudienceAccount audienceAccount)
        => AudienceAccountDAO.Delete(audienceAccount);

        public List<AudienceAccount> GetAll()
        => AudienceAccountDAO.GetAll();

        public AudienceAccount GetById(Guid id)
        => AudienceAccountDAO.GetById(id);

        public void Update(AudienceAccount audienceAccount)
        => AudienceAccountDAO.Update(audienceAccount);
    }
}
