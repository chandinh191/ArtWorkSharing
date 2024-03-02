using AWS_BusinessObjects.Entities;
using AWS_BusinessObjects.Identity;
using AWS_DAO.Common.Mappings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.AdminAccount.Queries
{
    public class AccountModel : IMapFrom<AWS_BusinessObjects.Entities.AdminAccount>
    {
        public Guid Id { get; set; }
        [ForeignKey("ApplicationUser")]
        public string UserAccountId { get; set; }
        public virtual ApplicationUser? ApplicationUser { get; set; }
    }
}
