using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWorksAPI.Repositories;

namespace NZWorksAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WalkDifficultiesController : Controller
    {
        private readonly IWalkDifficultyRepository walkDifficultyRepository;
        private readonly IMapper mapper;

        public WalkDifficultiesController(IWalkDifficultyRepository walkDifficultyRepository, IMapper mapper)
        {
            this.walkDifficultyRepository = walkDifficultyRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllWalkDifficultiesAsync()
        {
            var walkdifficulties = await walkDifficultyRepository.GetAllAsync();

            var walkdifficultiesDTO = mapper.Map<List<Models.DTO.WalkDifficulty>>(walkdifficulties);

            return Ok(walkdifficultiesDTO);
        }

    }
}
