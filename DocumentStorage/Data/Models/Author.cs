using System.ComponentModel.DataAnnotations;

namespace DocumentStorage.Data.Models
{
	public class Author
	{
		public Author()
		{
			this.Achievements = new HashSet<Achievement>();
		}

		[Key]
		public Guid AuthorId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Patronymic { get; set; }
		public string? Email { get; set; }
		public virtual ICollection<Achievement> Achievements { get; set; }

	}
}
