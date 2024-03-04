using AWS_Repository.Identity;
using AWS_Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;




namespace ArtWorkSharingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtWorkController : ControllerBase
    {
        private IArtWorkService _artWorkService;

        public ArtWorkController(IArtWorkService artWorkService)
        {
            _artWorkService = artWorkService;
        }
        [HttpGet(Name = "GetAll")]
        [AllowAnonymous]
        public IActionResult GetAll()
        {
            var artWorks = _artWorkService.GetAll();
           
            return Ok(artWorks);
        }
    }
}
