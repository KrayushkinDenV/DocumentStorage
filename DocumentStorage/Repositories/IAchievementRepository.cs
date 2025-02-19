//---Entities---//
using DocumentStorage.Data.Models;

namespace DocumentStorage.Repositories
{
	public interface IAchievementRepository
	{
		Task<Guid> CreateAsync(Achievement achievement);
		Task CreateNoResultAsync(Achievement achievement);
		IQueryable<Achievement> Read();
	}
}
