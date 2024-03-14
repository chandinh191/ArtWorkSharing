using AWS_BusinessObjects.Entities;
using AWS_DAO;
using AWS_Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Repository.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private ReportDAO reportDAO = null;
        public ReportRepository()
        {
            reportDAO = new ReportDAO();
        }

        public void Add(Report report)
        => reportDAO.Add(report);

        public void Delete(Guid id)
        => reportDAO.Delete(id);

        public List<Report> GetAll()
        => reportDAO.GetAll();

        public Report GetById(Guid id)
        => reportDAO.GetById(id);

        public void Update(Report report)
        => reportDAO.Update(report);
    }
}
