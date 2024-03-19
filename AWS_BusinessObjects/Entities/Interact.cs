using AWS_BusinessObjects.Common;
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
    public class Interact : BaseAuditableEntity
    {
        [Required]
        public Guid ArtWorkID { get; set; }

        // bị vòng
        /*public ApplicationUser ApplicationUser { get; set; }
        [ForeignKey("ApplicationUser")]
        public string UserAccountId { get; set; }*/
        [Required]
        public string Comment { get; set; }
        public bool IsLike { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
