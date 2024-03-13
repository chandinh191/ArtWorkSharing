using AWS_BusinessObjects.Common.Interfaces;
using AWS_BusinessObjects.Entities;
using AWS_DAO.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO
{
    public class ReportDAO
    {
        private readonly IApplicationDbContext _context;
        public ReportDAO(IApplicationDbContext context)
        {
            _context = context;
        }

        public ReportDAO()
        {
        }

        // get all reports, validate and try catch
        public List<Report> GetAll()
        {
            try
            {
                List<Report> reports
                    = (List<Report>)_context.Get<Report>().ToList();
                return reports;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // get report by id, validate and try catch
        public Report GetById(Guid id)
        {
            try
            {
                return _context.Get<Report>().Where(o => o.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // add report, validate and try catch
        public void Add(Report report)
        {
            try
            {
                // check reportId, if found throw exception
                var checkId = GetById(report.Id);
                if (checkId != null)
                {
                    throw new Exception("Report already exists");
                }
                _context.Get<Report>().Add(report);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // update report, validate and try catch
        public void Update(Report report)
        {
            try
            {
                // check reportId, throw not found exception if not found
                var checkId = GetById(report.Id);
                if (checkId == null)
                {
                    throw new NotFoundException("Report not found");
                }
                _context.Get<Report>().Update(report);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // delete report, validate and try catch, isDelete = true   
        public void Delete(Report report)
        {
            try
            {
                // check reportId, throw not found exception if not found
                var checkId = GetById(report.Id);
                if (checkId == null)
                {
                    throw new NotFoundException("Report not found");
                }
                report.IsDeleted = true;
                _context.Get<Report>().Update(report);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
