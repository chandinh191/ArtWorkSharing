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
    public class ArtWorkRepository : IArtWorkRepository
    {
        private ArtWorkDAO artWorkDAO;
        public ArtWorkRepository(IApplicationDbContext context)
        {
            artWorkDAO = new ArtWorkDAO(context);
        }
        public void Add(ArtWork artWork)
        {
            artWorkDAO.Add(artWork);
            //throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            artWorkDAO.Delete(id);
            //throw new NotImplementedException();
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
            //throw new NotImplementedException();
        }
    }
}
