using AWS_BusinessObjects.Common;
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
        public int Status { get; set; }
    }
}
