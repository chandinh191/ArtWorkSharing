using AWS_BusinessObjects.Entities;
using AWS_DAO.Common.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO.Package.Queries
{
    public class PackageModel : IMapFrom<AWS_BusinessObjects.Entities.Package>  
    {
        public string? NamePacked { get; set; }
        public string? Description { get; set; }
        public int Status { get; set; }
/*        public virtual IList<PackageDetail>? PackageDetails { get; set; }*/
    }
}
