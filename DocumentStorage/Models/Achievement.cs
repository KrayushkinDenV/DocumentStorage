//---Models---//
using DocumentStorage.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace DocumentStorage.Models
{
    public class Achievement
    {
        [Key]
        public string AchievementId { get; set; }
        public string Title { get; set; }
		public string FullTitle { get; set; }
        public string JournalName { get; set; }
		public string? Description { get; set; }
        public string? LinkToSource { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public AchievementType AchievementType { get; set; }
        public ICollection<Author> Authors { get; set; } 
        public string? Documents { get; set; }
    }
}
