using AWS_BusinessObjects.Common.Interfaces;
using AWS_BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO
{
    public class AudienceAccountDAO
    {
        private readonly IApplicationDbContext _context;
        public AudienceAccountDAO(IApplicationDbContext context)
        {
            _context = context;
        }

        // get all AudienceAccount
        public List<AudienceAccount> GetAll()
        {
            try
            {
                List<AudienceAccount> audienceAccounts
                    = (List<AudienceAccount>)_context.Get<AudienceAccount>().ToList();
                return audienceAccounts;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // get AudienceAccount by id
        public AudienceAccount GetById(Guid id)
        {
            try
            {
                return _context.Get<AudienceAccount>().Where(o => o.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // add AudienceAccount
        public void Add(AudienceAccount audienceAccount)
        {
            try
            {
                _context.Get<AudienceAccount>().Add(audienceAccount);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // update AudienceAccount
        public void Update(AudienceAccount audienceAccount)
        {
            try
            {
                _context.Get<AudienceAccount>().Update(audienceAccount);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // delete AudienceAccount
        public void Delete(AudienceAccount audienceAccount)
        {
            try
            {
                audienceAccount.IsDeleted = true;   
                _context.Get<AudienceAccount>().Update(audienceAccount);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
