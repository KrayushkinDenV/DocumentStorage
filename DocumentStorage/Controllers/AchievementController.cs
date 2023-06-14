//---Models---//
using DocumentStorage.Models;
//---Context---//
using DocumentStorage.Repositories;
//---Services---//
using DocumentStorage.Services;
//---Packages---//
using Microsoft.AspNetCore.Mvc;

namespace DocumentStorage.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class AchievementController : ControllerBase
	{
		private IAchievementRepository achievementContext;
		public AchievementController(IAchievementRepository achievementContext) =>
			this.achievementContext = achievementContext;

		[HttpGet("Index")]
		public IEnumerable<object> GetAchievements()
		{
			var achievements = new[]
			{
				new {Title="Title_1",FullTitle ="FullTitle_1", JournalName="JournalName_1", Description="Description_1", LinkToSource="LinkToSource_1"},
				new {Title="Title_2",FullTitle ="FullTitle_2", JournalName="JournalName_2", Description="Description_2", LinkToSource="LinkToSource_2"},
				new {Title="Title_3",FullTitle ="FullTitle_3", JournalName="JournalName_3", Description="Description_3", LinkToSource="LinkToSource_3"},
				new {Title="Title_4",FullTitle ="FullTitle_4", JournalName="JournalName_4", Description="Description_4", LinkToSource="LinkToSource_4"}
			};
			return achievements;
		}

		[HttpPost("Create")]
		public async Task CreateAchievement([FromForm] AchievementModel formData)=>
			await achievementContext.CreateAsync(formData.AutoMapService());
	}
}
