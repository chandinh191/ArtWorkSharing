using AWS_BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Repository.Interface
{
    public interface IReportRepository
    {
        public List<Report> GetAll();
        public Report GetById(Guid id);
        public void Add(Report report);
        public void Update(Report report);
        public void Delete(Report report);
    }
}
