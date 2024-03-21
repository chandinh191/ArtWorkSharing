using AWS_BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Services.Interface
{
    public interface IWishListService
    {
        public List<WishList> GetAll();
        public WishList GetById(Guid id);
        public void Add(WishList wishList);
        public void Update(WishList wishList);
        public void Delete(Guid id);
    }
}
