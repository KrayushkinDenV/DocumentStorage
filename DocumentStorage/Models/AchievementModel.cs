using DocumentStorage.Data.Models.Enums;

namespace DocumentStorage.Models
{
	public class AchievementModel
	{
		public string Title { get; set; }
		public string FullTitle { get; set; }
		public string JournalName { get; set; }
		public string? Description { get; set; }
		public DateTime? ReleaseDate { get; set; }
		public AchievementType AchievementType { get; set; }
	}
}
