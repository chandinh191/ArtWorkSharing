using AWS_BusinessObjects.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Entities
{
    public class PackageDetail : BaseAuditableEntity
    {
        public Guid PackageID { get; set; }
        public Guid UserAccountId { get; set; }
        public Guid PaymentMethodID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
