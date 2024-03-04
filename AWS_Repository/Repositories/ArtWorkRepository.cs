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
    public class ArtWorkRepository : IArtWorkRepository
    {
        private ArtWorkDAO artWorkDAO = null;
        public ArtWorkRepository()
        {
            artWorkDAO = new ArtWorkDAO();
        }
        public void Add(ArtWork artWork)
        {
            artWorkDAO.Add(artWork);
            throw new NotImplementedException();
        }

        public void Delete(ArtWork artWork)
        {
            artWorkDAO.Delete(artWork);
            throw new NotImplementedException();
        }

        public List<ArtWork> GetAll()
        {
            return artWorkDAO.GetAll();
            throw new NotImplementedException();
        }

        public ArtWork GetById(Guid id)
        {
            return artWorkDAO.GetById(id);
            throw new NotImplementedException();
        }

        public void Update(ArtWork artWork)
        {
            artWorkDAO.Update(artWork);
            throw new NotImplementedException();
        }
    }
}
