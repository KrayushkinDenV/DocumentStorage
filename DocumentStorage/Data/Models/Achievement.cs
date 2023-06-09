//---Models---//
using DocumentStorage.Data.Models.Enums;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace DocumentStorage.Data.Models
{
    public class Achievement
    {
        public Achievement()
        {
            this.Authors = new HashSet<Author>();
        }

        [Key]
        public Guid AchievementId { get; set; }
        public string Title { get; set; }
        public string FullTitle { get; set; }
        public string JournalName { get; set; }
        public string? Description { get; set; }
        public string? LinkToSource { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public AchievementType AchievementType { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
        public string? Documents { get; set; }
    }
}
