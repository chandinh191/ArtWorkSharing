using AWS_BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Services.Interface
{
    public interface IReportService
    {
        public List<Report> GetAll();
        public Report GetById(Guid id);
        public void Add(Report report);
        public void Update(Report report);
        public void Delete(Guid id);
    }
}
