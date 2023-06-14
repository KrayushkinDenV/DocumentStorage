//---Context---//
using DocumentStorage.Data;
//---Entites---//
using DocumentStorage.Data.Models;

namespace DocumentStorage.Repositories
{
	public class AchievementRepository : IAchievementRepository
	{
		private readonly DocumentsContext context;
		public AchievementRepository(DocumentsContext context) => this.context = context;
		public async Task CreateAsync(Achievement achievement)
		{
			achievement.AchievementId = Guid.NewGuid();

			context.Add(achievement);
			await context.SaveChangesAsync();
		}
	}
}
