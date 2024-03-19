using AWS_BusinessObjects.Common;
using AWS_BusinessObjects.Enums;
using AWS_BusinessObjects.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Entities
{
    public class Order : BaseAuditableEntity
    {
        [ForeignKey("ApplicationUser")]
        [Required(ErrorMessage = "Name is required")]
        public string UserAccountId { get; set; }
        [ForeignKey("ArtWord")]
        [Required(ErrorMessage = "Name is required")]
        public Guid ArtWordID { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [Range(1,9999999999, ErrorMessage = "Price must be between 1 and 9999999999")]
        public float Price { get; set; }
        public OrderStatus Status { get; set; }
        public bool isPreOrder { get; set; }    
        public virtual IList<Rating>? Rating { get; set; }
    }
}
