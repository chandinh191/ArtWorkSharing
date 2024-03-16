using AWS_BusinessObjects.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Entities
{
    public class PackageDetail : BaseAuditableEntity
    {
        [ForeignKey("Package")]
        public Guid PackageID { get; set; }
        [ForeignKey("ApplicationUser")]
        public string UserAccountId { get; set; }
        [ForeignKey("PaymentMethod")]
        public Guid PaymentMethodID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
