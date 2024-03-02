using AWS_BusinessObjects.Common;
using AWS_BusinessObjects.Enums;
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
        public PackageStatus? PackageStatus { get; set; }
        public virtual IList<PackageDetail>? PackageDetails { get; set; }
    }
}
