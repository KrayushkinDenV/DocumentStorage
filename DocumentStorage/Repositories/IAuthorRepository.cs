//---Entities---//
using DocumentStorage.Data.Models;

namespace DocumentStorage.Repositories
{
	public interface IAuthorRepository
	{
		Task CreateAsync(Author author);
	}
}
