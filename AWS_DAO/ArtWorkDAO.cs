using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AWS_BusinessObjects.Common.Interfaces;
using AWS_BusinessObjects.Entities;
using AWS_BusinessObjects.Persistence;
using AWS_DAO.Common.Exceptions;
using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace AWS_DAO
{
    public class ArtWorkDAO
    {
        private readonly IApplicationDbContext _context;
        public ArtWorkDAO(IApplicationDbContext context)
        {
            _context = context;
        }

        public ArtWorkDAO()
        {
            // lỗi nè
        }

        public AWS_BusinessObjects.Entities.ArtWork GetById(Guid id)
        {
            try
            {
                return _context.Get<ArtWork>().Where(o=>o.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<AWS_BusinessObjects.Entities.ArtWork> GetAll()
        {
            try
            {
                List<AWS_BusinessObjects.Entities.ArtWork> artWorks 
                    = (List<ArtWork>)_context.Get<ArtWork>().ToList();
                return artWorks;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Add(AWS_BusinessObjects.Entities.ArtWork artWorks)
        {
            try
            {
                _context.Get<ArtWork>().Add(artWorks);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(AWS_BusinessObjects.Entities.ArtWork artWorks)
        {
            try
            {      
                var ArtWork = _context.Get<ArtWork>().FirstOrDefault(x => x.Id == artWorks.Id);
                if(ArtWork != null)
                {
                    throw new NotFoundException();
                }
                ArtWork = artWorks;
                _context.Get<ArtWork>().Update(ArtWork);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Delete(AWS_BusinessObjects.Entities.ArtWork artWorks)
        {
            try
            {
                var ArtWork = _context.Get<ArtWork>().FirstOrDefault(x => x.Id == artWorks.Id);
                if (ArtWork != null)
                {
                    throw new NotFoundException();
                }
                ArtWork.IsDeleted = true;
                _context.Get<ArtWork>().Update(ArtWork);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
