using AWS_DAO.Common.Mappings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.PackageDetail.Queries
{
    public class PackageDetailModel : IMapFrom<AWS_BusinessObjects.Entities.PackageDetail>
    {
        [ForeignKey("Package")]
        public Guid PackageID { get; set; }
        [ForeignKey("ApplicationUser")]
        public Guid UserAccountId { get; set; }
        [ForeignKey("PaymentMethod")]
        public Guid PaymentMethodID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
