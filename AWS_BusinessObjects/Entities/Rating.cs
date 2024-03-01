using AWS_BusinessObjects.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Entities
{
    public class Rating : BaseAuditableEntity
    {
        public Guid OrderID { get; set; }
        public string Description { get; set; } 
        public float Point { get; set; }
    }
}
