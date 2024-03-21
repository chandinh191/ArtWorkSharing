using AWS_BusinessObjects.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Entities
{
    public class WishList : BaseAuditableEntity
    {
        [ForeignKey("ApplicationUser")]
        [Required(ErrorMessage = "UserAccountId is required")]
        public string UserAccountId { get; set; }
        [ForeignKey("ArtWord")]
        [Required(ErrorMessage = "ArtWordID is required")]
        public Guid ArtWordID { get; set; }
        public virtual IList<ArtWork>? ArtWorks { get; set; }
    }
}
