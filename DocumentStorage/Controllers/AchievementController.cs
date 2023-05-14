//---Models---//
using DocumentStorage.Controllers.Models;

//---Packages---//
using Microsoft.AspNetCore.Mvc;

namespace DocumentStorage.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class AchievementController : ControllerBase
	{
		[HttpGet("Index")]
		public IEnumerable<temporaryAchievementModel> GetAchievements()
		{
			var achievements = new List<temporaryAchievementModel>()
			{
				new temporaryAchievementModel(){Title="Title_1",FullTitle ="FullTitle_1", JournalName="JournalName_1", Description="Description_1", LinkToSource="LinkToSource_1"},
				new temporaryAchievementModel(){Title="Title_2",FullTitle ="FullTitle_2", JournalName="JournalName_2", Description="Description_2", LinkToSource="LinkToSource_2"},
				new temporaryAchievementModel(){Title="Title_3",FullTitle ="FullTitle_3", JournalName="JournalName_3", Description="Description_3", LinkToSource="LinkToSource_3"},
				new temporaryAchievementModel(){Title="Title_4",FullTitle ="FullTitle_4", JournalName="JournalName_4", Description="Description_4", LinkToSource="LinkToSource_4"}

			};
			return achievements;
			//IEnumerable<temporaryAchievementModel> model = Enumerable.Empty<temporaryAchievementModel>();

			//model.Append(new temporaryAchievementModel()
			//{
			//	Title = "Title_1",
			//	FullTitle = "FullTitle_1",
			//	JournalName = "JournalName_1",
			//	Description = "Description_1",
			//	LinkToSource = "LinkToSource_1"
			//});
			//return Enumerable.Empty<temporaryAchievementModel>();

			//return model;
		}

	}
}
