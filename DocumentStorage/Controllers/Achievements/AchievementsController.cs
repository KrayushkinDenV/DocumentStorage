//---Models---//
using AutoMapper.QueryableExtensions;
using DocumentStorage.Models;
//---Context---//
using DocumentStorage.Repositories;
//---Services---//
using DocumentStorage.Services;
//---Packages---//
using Microsoft.AspNetCore.Mvc;

namespace DocumentStorage.Controllers.Achievements
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class AchievementsController : ControllerBase
    {
        private IAchievementRepository achievementContext;
        public AchievementsController(IAchievementRepository achievementContext) =>
            this.achievementContext = achievementContext;

        [HttpGet("Index")]
        public async Task<IEnumerable<AchievementModel>> GetAchievementsAsync()
        {
            await Task.Yield();
            var achievements = achievementContext.Read();

            return achievements.ProjectTo<AchievementModel>(AutoMapperService.GetModelsMapping())
                               .ToArray();
        }

        [HttpPost("Create")]
        public async Task<Guid> CreateAchievement([FromForm] AchievementModel formData) =>
            await achievementContext.CreateAsync(formData.AutoMapService());

        [HttpPost("Upload")]
        public async Task UploadFile([FromForm] IFormFile file)
        {
            await FileService.SaveFileAsync(file);
		}
    }
}
