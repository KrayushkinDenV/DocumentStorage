//---Context---//
using DocumentStorage.Data;
//---Entites---//
using DocumentStorage.Data.Models;
//---Packages---//

namespace DocumentStorage.Repositories
{
	public class AchievementRepository : IAchievementRepository
	{
		private readonly DocumentsContext context;
		public AchievementRepository(DocumentsContext context) => this.context = context;
		public async Task CreateNoResultAsync(Achievement achievement) => createBase(achievement);
		public async Task<Guid> CreateAsync(Achievement achievement) => await createBase(achievement);
		public IQueryable<Achievement> Read() => context.Achievements.AsQueryable();
		private async Task<Guid> createBase(Achievement achievement)
		{
			achievement.AchievementId = Guid.NewGuid();

			context.Add(achievement);
			await context.SaveChangesAsync();

			return achievement.AchievementId;
		}
	}
}
