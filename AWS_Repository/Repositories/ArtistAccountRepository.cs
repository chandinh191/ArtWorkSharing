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
    public class ArtistAccountRepository : IArtistAccountRepository
    {
        private ArtistAccountDAO artistAccountDAO = null;
        public ArtistAccountRepository()
        {
            artistAccountDAO = new ArtistAccountDAO();
        }

        public void Add(ArtistAccount artistAccount)
        => artistAccountDAO.Add(artistAccount);

        public void Delete(ArtistAccount artistAccount)
        => artistAccountDAO.Delete(artistAccount);

        public List<ArtistAccount> GetAll()
        => artistAccountDAO.GetAll();

        public ArtistAccount GetById(Guid id)
        => artistAccountDAO.GetById(id);

        public void Update(ArtistAccount artistAccount)
        => artistAccountDAO.Update(artistAccount);
    }
}
