using AWS_BusinessObjects.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required(AllowEmptyStrings = true, ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description must be at most 500 characters")]
        public string Description { get; set; }
        [Range(0,5,ErrorMessage = "Range point between 0 -> 5")]        
        public float Point { get; set; }
    }
}
