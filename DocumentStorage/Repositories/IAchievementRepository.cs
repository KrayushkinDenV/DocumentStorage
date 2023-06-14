//---Entities---//
using DocumentStorage.Data.Models;

namespace DocumentStorage.Repositories
{
	public interface IAchievementRepository
	{
		Task CreateAsync(Achievement achievement);
	}
}
