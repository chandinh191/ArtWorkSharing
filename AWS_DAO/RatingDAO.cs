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
    public class RatingDAO
    {
        private readonly IApplicationDbContext _context;
        public RatingDAO(IApplicationDbContext context)
        {
            _context = context;
        }

        public RatingDAO()
        {
        }

        // get all Rating
        public List<Rating> GetAll()
        {
            try
            {
                List<Rating> ratings
                    = (List<Rating>)_context.Get<Rating>().ToList();
                return ratings;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // get Rating by id
        public Rating GetById(Guid id)
        {
            try
            {
                return _context.Get<Rating>().Where(o => o.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // add Rating
        public void Add(Rating rating)
        {
            try
            {
                // check ratingId, if found throw exception
                var checkId = GetById(rating.Id);
                if (checkId != null)
                {
                    throw new Exception("Rating already exists");
                }
                _context.Get<Rating>().Add(rating);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // update Rating
        public void Update(Rating rating)
        {
            try
            {
                // check ratingId, if not found throw exception
                var checkId = GetById(rating.Id);
                if (checkId == null)
                {
                    throw new NotFoundException("Rating not found");
                }
                _context.Get<Rating>().Update(rating);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // delete Rating, isDeleted = true
        public void Delete(Guid id)
        {
            try
            {
                // check ratingId, if not found throw exception
                var checkId = GetById(id);
                if (checkId == null)
                {
                    throw new NotFoundException("Rating not found");
                }
                var rating = _context.Get<Rating>().Where(o => o.Id == id).FirstOrDefault();
                rating.IsDeleted = true;
                _context.Get<Rating>().Update(rating);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
