//---Packages---//
using System.ComponentModel.DataAnnotations;

namespace DocumentStorage.Data.Models
{
	public class Document
	{
		[Key]
		public Guid DocumentID { get; set; }
		public string Name { get; set; }
		public string Path { get; set; }
		public virtual Achievement Achievement { get; set; }
	}
}
