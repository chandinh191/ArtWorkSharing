using AWS_BusinessObjects.Entities;
using AWS_Repository.Interface;
using AWS_Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Services.Services
{
    public class RatingService : IRatingService
    {
        private readonly IRatingRepository ratingRepository;
        public RatingService(IRatingRepository ratingRepository)
        {
            this.ratingRepository = ratingRepository;
        }

        public void Add(Rating rating)
        => ratingRepository.Add(rating);

        public void Delete(Guid id)
        => ratingRepository.Delete(id);

        public List<Rating> GetAll()
        => ratingRepository.GetAll();

        public Rating GetById(Guid id)
        => ratingRepository.GetById(id);

        public void Update(Rating rating)
        => ratingRepository.Update(rating);
    }
}
