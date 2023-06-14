using DocumentStorage.Data.Models.Enums;
using DocumentStorage.Data.Models;

namespace DocumentStorage.Models
{
	public class AchievementModel
	{
		public string Title { get; set; }
		public string FullTitle { get; set; }
		public string JournalName { get; set; }
		public string? Description { get; set; }
		public string? LinkToSource { get; set; }
		public AchievementType AchievementType { get; set; }
	}
}
