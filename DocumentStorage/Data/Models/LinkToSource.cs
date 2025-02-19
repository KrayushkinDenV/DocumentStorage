//---Packages---//
using System.ComponentModel.DataAnnotations;

namespace DocumentStorage.Data.Models
{
	public class LinkToSource
	{
		[Key]
		public Guid LinkToSourceID { get; set; }
		public string Name { get; set; }
		public string Href { get; set; }
		public virtual Achievement Achievement { get; set; }
	}
}
