//---Context---//
using DocumentStorage.Data;
//---Models---//
using DocumentStorage.Data.Models;

namespace DocumentStorage.Repositories
{
	public class AuthorRepository : IAuthorRepository
	{
		private readonly DocumentsContext context;
		public AuthorRepository(DocumentsContext context) => this.context = context;
		public async Task CreateAsync(Author author)
		{
			author.AuthorId = Guid.NewGuid();

			context.Add(author);
			await context.SaveChangesAsync();
		}
	}
}
