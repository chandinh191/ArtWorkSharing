using AWS_BusinessObjects.Common;
using AWS_BusinessObjects.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Entities
{
    public class Order : BaseAuditableEntity
    {
        public ApplicationUser ApplicationUser { get; set; }
        public Guid UserAccountId { get; set; }
        public Guid ArtWordID { get; set; }
        public string Name { get; set; }
        public string imgURL { get; set; }
        public string Price { get; set; }
        public int Status { get; set; }
        public bool isPreOrder { get; set; }    
    }
}
