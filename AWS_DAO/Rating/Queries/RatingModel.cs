using AWS_DAO.Common.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.Rating.Queries
{
    public class RatingModel : IMapFrom<AWS_BusinessObjects.Entities.Rating>
    {
        public Guid OrderID { get; set; }
        public string? Description { get; set; }
        public float Point { get; set; }
    }
}
