using AWS_BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Services.Interface
{
    public interface IRatingService
    {
        public List<Rating> GetAll();
        public Rating GetById(Guid id);
        public void Add(Rating rating);
        public void Update(Rating rating);
        public void Delete(Guid id);
    }
}
