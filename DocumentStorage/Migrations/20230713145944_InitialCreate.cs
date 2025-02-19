using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocumentStorage.Migrations
{
	/// <inheritdoc />
	public partial class InitialCreate : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Achievements",
				columns: table => new
				{
					AchievementId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
					FullTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
					JournalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
					ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
					AchievementType = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Achievements", x => x.AchievementId);
				});

			migrationBuilder.CreateTable(
				name: "Authors",
				columns: table => new
				{
					AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Authors", x => x.AuthorId);
				});

			migrationBuilder.CreateTable(
				name: "Documents",
				columns: table => new
				{
					DocumentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
					AchievementId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Documents", x => x.DocumentID);
					table.ForeignKey(
						name: "FK_Documents_Achievements_AchievementId",
						column: x => x.AchievementId,
						principalTable: "Achievements",
						principalColumn: "AchievementId",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "LinksToSources",
				columns: table => new
				{
					LinkToSourceID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Href = table.Column<string>(type: "nvarchar(max)", nullable: false),
					AchievementId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_LinksToSources", x => x.LinkToSourceID);
					table.ForeignKey(
						name: "FK_LinksToSources_Achievements_AchievementId",
						column: x => x.AchievementId,
						principalTable: "Achievements",
						principalColumn: "AchievementId",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "AchievementAuthor",
				columns: table => new
				{
					AchievementsAchievementId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					AuthorsAuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AchievementAuthor", x => new { x.AchievementsAchievementId, x.AuthorsAuthorId });
					table.ForeignKey(
						name: "FK_AchievementAuthor_Achievements_AchievementsAchievementId",
						column: x => x.AchievementsAchievementId,
						principalTable: "Achievements",
						principalColumn: "AchievementId",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_AchievementAuthor_Authors_AuthorsAuthorId",
						column: x => x.AuthorsAuthorId,
						principalTable: "Authors",
						principalColumn: "AuthorId",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateIndex(
				name: "IX_AchievementAuthor_AuthorsAuthorId",
				table: "AchievementAuthor",
				column: "AuthorsAuthorId");

			migrationBuilder.CreateIndex(
				name: "IX_Documents_AchievementId",
				table: "Documents",
				column: "AchievementId");

			migrationBuilder.CreateIndex(
				name: "IX_LinksToSources_AchievementId",
				table: "LinksToSources",
				column: "AchievementId");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "AchievementAuthor");

			migrationBuilder.DropTable(
				name: "Documents");

			migrationBuilder.DropTable(
				name: "LinksToSources");

			migrationBuilder.DropTable(
				name: "Authors");

			migrationBuilder.DropTable(
				name: "Achievements");
		}
	}
}
