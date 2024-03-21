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
        private readonly RatingDAO _ratingDAO;
        public RatingRepository(RatingDAO ratingDAO)
        {
            _ratingDAO = ratingDAO;
        }

        public void Add(Rating rating)
        => _ratingDAO.Add(rating);

        public void Delete(Guid id)
        => _ratingDAO.Delete(id);

        public List<Rating> GetAll()
        => _ratingDAO.GetAll();

        public Rating GetById(Guid id)
        => _ratingDAO.GetById(id);

        public void Update(Rating rating)
        => _ratingDAO.Update(rating);
    }
}
