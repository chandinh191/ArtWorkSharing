using AWS_BusinessObjects.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Entities
{
    public class Package : BaseAuditableEntity
    {
        public string NamePacked { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public virtual IList<PackageDetail>? PackageDetails { get; set; }
    }
}
