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
    public class InteractDAO
    {
        private readonly IApplicationDbContext _context;
        public InteractDAO(IApplicationDbContext context)
        {
            _context = context;
        }

        // get all Interact, check isDeleted = false, sort by Created
        public List<Interact> GetAll()
        {
            try
            {
                List<Interact> interacts
                    = (List<Interact>)_context.Get<Interact>().Where(x => x.IsDeleted==false).OrderByDescending(x => x.Created) 
                    .ToList();
                return interacts;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // get Interact by id
        public Interact GetById(Guid id)
        {
            try
            {
                return _context.Get<Interact>().Where(o => o.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // add Interact
        public void Add(Interact interact)
        {
            try
            {
                _context.Get<Interact>().Add(interact);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // update Interact
        public void Update(Interact interact)
        {
            try
            {
                var Interact = _context.Get<Interact>().FirstOrDefault(x => x.Id == interact.Id);
                if (Interact == null)
                {
                    throw new NotFoundException();
                }
                Interact.Comment = interact.Comment;
                Interact.IsLike = interact.IsLike;
                Interact.LastModified = DateTime.Now;

                _context.Get<Interact>().Update(Interact);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // delete Interact, isDeleted = true
        public void Delete(Guid id)
        {
            try
            {
                var interact = _context.Get<Interact>().FirstOrDefault(x => x.Id == id);
                if (interact == null)
                {
                    throw new NotFoundException();
                }
                interact.IsDeleted = true;
                _context.Get<Interact>().Update(interact);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
