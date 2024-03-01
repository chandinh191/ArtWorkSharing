using AWS_BusinessObjects.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Entities
{
    public class Rating : BaseAuditableEntity
    {
        [ForeignKey("Order")]
        public Guid OrderID { get; set; }
        public string Description { get; set; } 
        public float Point { get; set; }
    }
}
