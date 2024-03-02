using AWS_BusinessObjects.Common;
using AWS_BusinessObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Entities
{
    public class PaymentMethod : BaseAuditableEntity
    {
        public string Name { get; set; }
        public PaymentMethodStatus PaymentMethodStatus { get; set; }
        public virtual IList<PackageDetail>? PackageDetails { get; set; }
    }
}
