using AWS_BusinessObjects.Common.Interfaces;
using AWS_BusinessObjects.Entities;
using AWS_DAO.Common.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO
{
    public class WishListDAO
    {
        private readonly IApplicationDbContext _context;
        public WishListDAO(IApplicationDbContext context)
        {
            _context = context;
        }


        // get all Order
        public List<WishList> GetAll()
        {
            try
            {
                List<WishList> wishLists
                    = (List<WishList>)_context.Get<WishList>()
                    .Include(i => i.ArtWorks)
                    .ToList();
                return wishLists;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // get Order by id
        public WishList GetById(Guid id)
        {
            try
            {
                return _context.Get<WishList>().Where(o => o.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // add Order
        public void Add(WishList wishList)
        {
            try
            {
                _context.Get<WishList>().Add(wishList);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // update Order
        public void Update(WishList wishList)
        {
            try
            {
                var WishList = _context.Get<WishList>().FirstOrDefault(x => x.Id == wishList.Id);
                if (WishList == null)
                {
                    throw new NotFoundException();
                }
                WishList.ArtWordID = wishList.ArtWordID;
                WishList.LastModified = DateTime.Now;


                _context.Get<WishList>().Update(WishList);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // delete Order, isDeleted = true
        public void Delete(Guid id)
        {
            try
            {
                WishList wishList = GetById(id);
                wishList.IsDeleted = true;
                _context.Get<WishList>().Update(wishList);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
