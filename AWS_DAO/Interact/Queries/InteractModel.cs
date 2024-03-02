using AWS_DAO.Common.Mappings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.Interact.Queries
{
    public class InteractModel : IMapFrom<AWS_BusinessObjects.Entities.Interact>
    {
        public Guid ArtWorkID { get; set; }
        [ForeignKey("ApplicationUser")]
        public Guid UserAccountId { get; set; }
        public string Comment { get; set; }
        public bool IsLike { get; set; }
        public DateTime Date { get; set; }
    }
}
