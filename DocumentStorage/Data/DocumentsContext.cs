//---Models---//
using DocumentStorage.Models;
//---NuGet---//
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DocumentStorage.Data
{
	public class DocumentsContext : DbContext
	{
		public DocumentsContext(DbContextOptions<DocumentsContext> options) : base(options)
		{

		}
		public DbSet<Author> Authors { get; set; }
		public DbSet<Achievement> Achievements { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			//var keysProperties = builder.Model.GetEntityTypes()                      // All entities
			//					 .Select(x => x.FindPrimaryKey())        // All primary keys in entities
			//					 .Where(key => key is { })               // Where key is ''
			//					 .SelectMany(x => x.Properties);

			//foreach (var property in keysProperties)
			//{
			//	property.ValueGenerated = ValueGenerated.OnAdd;
			//}
			modelBuilder.Entity<Author>().ToTable("Author");
			modelBuilder.Entity<Achievement>().ToTable("Achievement");
		}
	}
}
