using AWS_BusinessObjects.Common;
using Duende.IdentityServer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required(ErrorMessage = "UserAccountId is required")]
        public string UserAccountId { get; set; }
        [ForeignKey("PaymentMethod")]
        [Required(ErrorMessage = "PaymentMethodID is required")]
        public Guid PaymentMethodID { get; set; }
        [Required(ErrorMessage = "First date is required")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "End date is required")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
    }
}
