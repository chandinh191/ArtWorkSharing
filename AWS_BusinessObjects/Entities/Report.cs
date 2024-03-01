using AWS_BusinessObjects.Common;
using AWS_BusinessObjects.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Entities
{
    public class Report : BaseAuditableEntity
    {
        public ApplicationUser applicationUser { get; set; }
        [ForeignKey("ApplicationUser")]
        public Guid UserAccountID { get; set; }
        [ForeignKey("ApplicationUser")]
        public Guid UserAccountIDReport { get; set; }
        public string? Description { get; set; }
    }
}
                                                                                                                                                            