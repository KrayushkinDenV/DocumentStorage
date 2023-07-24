//---Models---//
using DocumentStorage.Data.Models.Enums;
//---Packages---//
using System.ComponentModel.DataAnnotations;

namespace DocumentStorage.Data.Models
{
    public class Achievement
    {
        public Achievement()
        {
            this.Authors = new HashSet<Author>();

			this.Documents = new List<Document>();
			this.Links = new List<LinkToSource>();
		}

        [Key]
        public Guid AchievementId { get; set; }
        public string Title { get; set; }
        public string FullTitle { get; set; }
        public string JournalName { get; set; }
        public string? Description { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public AchievementType AchievementType { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<LinkToSource> Links{ get; set; }
    }
}
