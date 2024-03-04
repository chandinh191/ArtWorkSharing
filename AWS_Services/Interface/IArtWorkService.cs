using AWS_BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Services.Interface
{
    public interface IArtWorkService
    {
        public List<ArtWork> GetAll();
        public ArtWork GetById(Guid id);
        public void Add(ArtWork artWork);
        public void Update(ArtWork artWork);
        public void Delete(ArtWork artWork);
    }
}
