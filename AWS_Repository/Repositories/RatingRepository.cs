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
    public class RatingRepository : IRatingRepository
    {
        private RatingDAO ratingDAO = null;
        public RatingRepository(IApplicationDbContext context)
        {
            ratingDAO = new RatingDAO(context);
        }

        public void Add(Rating rating)
        => ratingDAO.Add(rating);

        public void Delete(Guid id)
        => ratingDAO.Delete(id);

        public List<Rating> GetAll()
        => ratingDAO.GetAll();

        public Rating GetById(Guid id)
        => ratingDAO.GetById(id);

        public void Update(Rating rating)
        => ratingDAO.Update(rating);
    }
}
