//---Models---//
using DocumentStorage.Data.Models;
using Microsoft.AspNetCore.Identity;
//---NuGet---//
using Microsoft.EntityFrameworkCore;

namespace DocumentStorage.Data
{
    public class DocumentsContext : DbContext
	{
		public DocumentsContext(DbContextOptions<DocumentsContext> options) : base(options)
		{
			//Database.EnsureDeleted();
			//Database.EnsureCreated(); // Гарантия, что БД создалась 
		}
		public DbSet<Author> Authors { get; set; }
		public DbSet<Achievement> Achievements { get; set; }
		public DbSet<Document> Documents { get; set; }
		public DbSet<LinkToSource> LinksToSources { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
