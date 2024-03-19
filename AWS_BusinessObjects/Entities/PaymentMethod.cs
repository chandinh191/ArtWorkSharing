using AWS_BusinessObjects.Common;
using AWS_BusinessObjects.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Entities
{
    public class PaymentMethod : BaseAuditableEntity
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        public string Name { get; set; }
        public PaymentMethodStatus PaymentMethodStatus { get; set; }
        public virtual IList<PackageDetail>? PackageDetails { get; set; }
    }
}
