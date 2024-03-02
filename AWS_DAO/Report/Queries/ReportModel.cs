using AWS_BusinessObjects.Identity;
using AWS_DAO.Common.Mappings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.Report.Queries
{
    public class ReportModel : IMapFrom<AWS_BusinessObjects.Entities.Report>
    {
        public ApplicationUser applicationUser { get; set; }
        [ForeignKey("ApplicationUser")]
        public Guid UserAccountID { get; set; }
        [ForeignKey("ApplicationUser")]
        public Guid UserAccountIDReport { get; set; }
        public string? Description { get; set; }
    }
}
