﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Common.Models
{
    public class CategoryModel
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public List<ArtWorkModel> ArtWorks { get; set; }
    }
}
