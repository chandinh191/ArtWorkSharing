using AWS_BusinessObjects.Entities;
using AWS_Repository.Identity;
using AWS_Repository.Interface;
using AWS_Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Services.Services
{
    public class ArtWorkService : IArtWorkService
    {
        private readonly IArtWorkRepository _artWorkRepository;
        public ArtWorkService(IArtWorkRepository artWorkRepository)
        {
            this._artWorkRepository = artWorkRepository;
        }
        public void Add(ArtWork artWork)
        {
            _artWorkRepository.Add(artWork);
            throw new NotImplementedException();
        }

        public void Delete(ArtWork artWork)
        {
            _artWorkRepository.Delete(artWork);
            throw new NotImplementedException();
        }

        public List<ArtWork> GetAll()
        {
            return _artWorkRepository.GetAll();
            throw new NotImplementedException();
        }

        public ArtWork GetById(Guid id)
        {
            return _artWorkRepository.GetById(id);
            throw new NotImplementedException();
        }

        public void Update(ArtWork artWork)
        {
            _artWorkRepository.Update(artWork);
            throw new NotImplementedException();
        }
    }
}
