using AWS_BusinessObjects.Common.Interfaces;
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
    public class WishListRepository : IWishListRepository
    {
        private WishListDAO wishListDAO = null;
        public WishListRepository(IApplicationDbContext context)
        {
            wishListDAO = new WishListDAO(context);
        }
        public void Add(WishList wishList) => wishListDAO.Add(wishList);

        public void Delete(Guid id) => wishListDAO.Delete(id);

        public List<WishList> GetAll() => wishListDAO.GetAll();

        public WishList GetById(Guid id) => wishListDAO.GetById(id);

        public void Update(WishList wishList) => wishListDAO.Update(wishList);
    }
}
