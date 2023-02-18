using System.ComponentModel.DataAnnotations;

namespace DocumentStorage.Models
{
    public class Author
	{
		[Key]
		public string AuthorId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Patronymic { get; set; }
		public string? Email { get; set; }
		public ICollection<Achievement>? Achievements { get; set; }

	}
}
