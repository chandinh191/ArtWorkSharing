using AWS_DAO.Common.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.PaymentMethod.Queries
{
    public class PaymentMethodModel : IMapFrom<AWS_BusinessObjects.Entities.PaymentMethod>
    {
        public string Name { get; set; }
        public int Status { get; set; }
    }
}
