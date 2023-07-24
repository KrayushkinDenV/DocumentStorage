﻿// <auto-generated />
using System;
using DocumentStorage.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DocumentStorage.Migrations
{
    [DbContext(typeof(DocumentsContext))]
    partial class DocumentsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AchievementAuthor", b =>
                {
                    b.Property<Guid>("AchievementsAchievementId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorsAuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AchievementsAchievementId", "AuthorsAuthorId");

                    b.HasIndex("AuthorsAuthorId");

                    b.ToTable("AchievementAuthor", (string)null);
                });

            modelBuilder.Entity("DocumentStorage.Data.Models.Achievement", b =>
                {
                    b.Property<Guid>("AchievementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AchievementType")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JournalName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AchievementId");

                    b.ToTable("Achievements", (string)null);
                });

            modelBuilder.Entity("DocumentStorage.Data.Models.Author", b =>
                {
                    b.Property<Guid>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors", (string)null);
                });

            modelBuilder.Entity("DocumentStorage.Data.Models.Document", b =>
                {
                    b.Property<Guid>("DocumentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AchievementId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DocumentID");

                    b.HasIndex("AchievementId");

                    b.ToTable("Documents", (string)null);
                });

            modelBuilder.Entity("DocumentStorage.Data.Models.LinkToSource", b =>
                {
                    b.Property<Guid>("LinkToSourceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AchievementId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Href")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LinkToSourceID");

                    b.HasIndex("AchievementId");

                    b.ToTable("LinksToSources", (string)null);
                });

            modelBuilder.Entity("AchievementAuthor", b =>
                {
                    b.HasOne("DocumentStorage.Data.Models.Achievement", null)
                        .WithMany()
                        .HasForeignKey("AchievementsAchievementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DocumentStorage.Data.Models.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsAuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DocumentStorage.Data.Models.Document", b =>
                {
                    b.HasOne("DocumentStorage.Data.Models.Achievement", "Achievement")
                        .WithMany("Documents")
                        .HasForeignKey("AchievementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Achievement");
                });

            modelBuilder.Entity("DocumentStorage.Data.Models.LinkToSource", b =>
                {
                    b.HasOne("DocumentStorage.Data.Models.Achievement", "Achievement")
                        .WithMany("Links")
                        .HasForeignKey("AchievementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Achievement");
                });

            modelBuilder.Entity("DocumentStorage.Data.Models.Achievement", b =>
                {
                    b.Navigation("Documents");

                    b.Navigation("Links");
                });
#pragma warning restore 612, 618
        }
    }
}
