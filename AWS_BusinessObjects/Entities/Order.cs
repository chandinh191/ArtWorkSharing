using AWS_BusinessObjects.Common;
using AWS_BusinessObjects.Enums;
using AWS_BusinessObjects.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Entities
{
    public class Order : BaseAuditableEntity
    {
        [ForeignKey("ApplicationUser")]
        public Guid UserAccountId { get; set; }
        [ForeignKey("ArtWord")]
        public Guid ArtWordID { get; set; }
        public string Name { get; set; }
        public string imgURL { get; set; }
        public string Price { get; set; }
        public OrderStatus Status { get; set; }
        public bool isPreOrder { get; set; }    
        public virtual IList<Rating>? Rating { get; set; }
    }
}
